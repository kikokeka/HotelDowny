using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI;

namespace DAL
{
    public class RoomDAL
    {
        private static RoomDAL instance;
        public static RoomDAL Instance
        {
            get { if (instance == null) instance = new RoomDAL(); return RoomDAL.instance; }
            set => RoomDAL.instance = value;
        }

        public string AddRoom(Room r)
        {
            string insert = "usp_insertroom @tenp, @loai, @mota";
            int result = Connect.Instance.excutenonquery(insert, out string error, new SqlParameter[] {
                new SqlParameter("@tenp",r.tenp),
                new SqlParameter("@loai",r.loai),
                new SqlParameter("@mota",r.mota)
                });
            if (error == null && result > 0) return "Thêm thành công";
            else return error;
        }
        public string FixRoom(string name, Room r)
        {
            string update = "usp_updateroom @tenp, @loai, @mota";
            int result = Connect.Instance.excutenonquery(update, out string error, new SqlParameter[] {
                new SqlParameter("@tenp",name),
                new SqlParameter("@loai",r.loai),
                new SqlParameter("@mota",r.mota)
                });
            if (error == null && result > 0) return "Sửa thành công";
            else return error;
        }
        public string ClearRoom(string name)
        {
            string update = $"update room set dondep= 1 where tenp = @tenp";
            int result = Connect.Instance.excutenonquery(update, out string error, new SqlParameter[] { new SqlParameter("@tenp", name)});
            if (error == null && result > 0) return "Yêu cầu thành công";
            else return error;
        }
        public string ClearedRoom(string name)
        {
            string update = $"update room set dondep= 0 where tenp = @tenp";
            int result = Connect.Instance.excutenonquery(update, out string error, new SqlParameter[] { new SqlParameter("@tenp", name) });
            if (error == null && result > 0) return $"Phòng {name} đã được dọn";
            else return error;
        }
        public string DelRoom(string name)
        {
            string delete = $"usp_delroom @tenp";
            int result = Connect.Instance.excutenonquery(delete, out string error, new SqlParameter[] { new SqlParameter("@tenp", name) });
            if (error == null && result > 0) return "Xóa thành công";
            else return error;
        }
        public string DelAll()
        {
            string delall = $"delete room where tenp != ' '";
            Connect.Instance.excutenonquery(delall, out string error);
            if (error == null) return "Xóa dữ liệu thành công";
            return error;
        }
        public string LastCheckout(string name)
        {
            string reader = "usp_lastcheckout @name";
            object time = Connect.Instance.excutescalar(reader,out string error,new SqlParameter("@name",name));
            if (error == null)
            {
                if (time.ToString() == "") return "Chưa sử dụng";
                return time.ToString();
            }
            return error;
        }
        public DataTable RevRoom(string a, string b)
        {
            string query = "select * from revroom ( @start , @end )";
            DataTable data = Connect.Instance.taobang(query, new SqlParameter[]{
                new SqlParameter("@start",a),
                new SqlParameter("@end",b) });
            return data;
        }
        public List<Room> GetRoom(string query)
        {
            List<Room> room = new List<Room>();
            DataTable data = Connect.Instance.taobang(query);
            foreach (DataRow row in data.Rows)
            {
                Room a = new Room(row);
                if (a.tenp != " ") room.Add(a);
            }
            return room;
        }
        public object Gettienp(string a, string b)
        {
            string select = $"select coalesce(Sum([Tổng tiền]),0) from revroom (@start, @end)";
            object tienp = Connect.Instance.excutescalar(select,out string error,new SqlParameter[]{
                new SqlParameter("@start",a),
                new SqlParameter("@end",b) });
            if (error != null) return error;
            return tienp;
        }
    }
}
