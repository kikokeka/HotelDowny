using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using DTO;

namespace DAL
{
    public class RoomTypeDAL
    {
        private static RoomTypeDAL instance;
        public static RoomTypeDAL Instance
        {
            get { if (instance == null) instance = new RoomTypeDAL(); return RoomTypeDAL.instance; }
            set => RoomTypeDAL.instance = value;
        }
        public RoomType GetRoom(string tenp)
        {
            RoomType rt = null;
            DataTable dt = Connect.Instance.taobang("usp_gettypebyroom @tenp",new SqlParameter ("@tenp",tenp ));
            foreach(DataRow r in dt.Rows)
            {
                rt = new RoomType(r);
            }
            return rt;
        }
        public List<RoomType> GetRoomType(string query)
        {
            List<RoomType> lst = new List<RoomType>();
            DataTable roomtype = Connect.Instance.taobang(query);
            foreach (DataRow row in roomtype.Rows)
            {
                RoomType r = new RoomType(row);
                if (r.Ten != " ") lst.Add(r);
            }
            return lst;
        }
        public string AddRoomType(RoomType r)
        {
            string query = $"usp_inserttype @ten, @bldau, @gbldau, @ggiosau, @giaqd, @giangay, @giathang, @mota";
            int result = Connect.Instance.excutenonquery(query, out string error, new SqlParameter[] {
                    new SqlParameter("@ten", r.Ten),
                    new SqlParameter("@bldau", r.blockdau),
                    new SqlParameter("@gbldau", r.giablockdau),
                    new SqlParameter("@ggiosau", r.giagiosau),
                    new SqlParameter("@giaqd", r.giaquadem),
                    new SqlParameter("@giangay", r.giangay),
                    new SqlParameter("@giathang", r.giathang),
                    new SqlParameter("@mota", r.mota)
                    });
            if (error == null && result > 0) return "Thêm thành công";
            else return error;
        }
        public string FixRoomType(RoomType r2)
        {
            string query = "usp_updatetype @ten, @blockdau, @giablockdau, @giagiosau, @giaquadem, @giangay, @giathang, @mota";
            int result = Connect.Instance.excutenonquery(query, out string error, new SqlParameter[] {
                    new SqlParameter("@ten", r2.Ten),
                    new SqlParameter("@blockdau", r2.blockdau),
                    new SqlParameter("@giablockdau", r2.giablockdau),
                    new SqlParameter("@giagiosau", r2.giagiosau),
                    new SqlParameter("@giaquadem", r2.giaquadem),
                    new SqlParameter("@giangay", r2.giangay),
                    new SqlParameter("@giathang", r2.giathang),
                    new SqlParameter("@mota", r2.mota)
                    });
            if (error == null && result > 0) return "Sửa thành công";
            else return error;
        }
        public string DelRoomType(string name)
        {
            string check = $"select count(*) from room where loai = @ten";
            int ktra = (int)Connect.Instance.excutescalar(check,out string error,new SqlParameter[] {new SqlParameter("@ten",name)});
            if (error != null) return error;
            if (ktra > 0) return "Có phòng thuộc loại phòng này";
            else
            {
                string delete = $"usp_deltype @ten";
                if (Connect.Instance.excutenonquery(delete, out string errors, new SqlParameter[] {new SqlParameter(@"ten",name)}) > 0 && errors==null) return "Xóa thành công";
                else return errors;
            }
        }
        public string DelAll()
        {
            string mess = RoomDAL.Instance.DelAll();
            if(mess == "Xóa dữ liệu thành công")
            {
                string deltypeall = $"delete roomtype where Ten != ' '";
                Connect.Instance.excutenonquery(deltypeall, out string error);
                if (error != null) return error;
                return "Xóa dữ liệu thành công";
            }
            return mess;
        }
    }
}
