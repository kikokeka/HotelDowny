using DTO;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class RevExpDAL
    {
        private static RevExpDAL instance;
        public static RevExpDAL Instance
        {
            get { if (instance == null) instance = new RevExpDAL(); return RevExpDAL.instance; }
            set => RevExpDAL.instance = value;
        }
        public string Add(RevExp re)
        {
            string insert = "usp_insertRE @ngay, @loai, @gia, @noidung ,@tk";
            int result = Connect.Instance.excutenonquery(insert, out string error, new SqlParameter[] {
                new SqlParameter("@ngay",re.ngay),
                new SqlParameter("@loai",re.loai),
                new SqlParameter("@gia",re.gia),
                new SqlParameter("@noidung",re.noidung),
                new SqlParameter("@tk",re.tk)
                });
            if (error == null && result > 0) return "Thêm thành công";
            else return error;
        }
        public string Fix(RevExp re)
        {
            string update = "usp_updateRE @mathuchi, @ngay, @loai, @gia, @noidung ,@tk";
            int result = Connect.Instance.excutenonquery(update, out string error, new SqlParameter[] {
                new SqlParameter("@mathuchi",re.mathuchi),
                new SqlParameter("@ngay",re.ngay),
                new SqlParameter("@loai",re.loai),
                new SqlParameter("@gia",re.gia),
                new SqlParameter("@noidung",re.noidung),
                new SqlParameter("@tk",re.tk)
                });
            if (error == null && result > 0) return "Sửa thành công";
            else return error;
        }
        public string Del(int id)
        {
            string delete = $"usp_delRE {id}";
            int result = Connect.Instance.excutenonquery(delete, out string error);
            if (error == null && result > 0) return "Xóa thành công";
            else return error;
        }
        public List<RevExp> GetRE(string query)
        {
            List<RevExp> RE = new List<RevExp>();
            DataTable data = Connect.Instance.taobang(query);
            foreach (DataRow row in data.Rows)
            {
                RevExp re = new RevExp(row);
                RE.Add(re);
            }
            return RE;
        }
        public object RevExp(string type, DateTime a, DateTime b)
        {
            string query = $"usp_in4thuchi '{type}','{a}','{b}'";
            object count = Connect.Instance.excutescalar(query, out string error);
            if (error != null) return error;
            return count;
        }
        public DataTable Revenue(string a, string b)
        {
            string query = "usp_thuchi @start , @end";
            DataTable data = Connect.Instance.taobang(query, new SqlParameter[]{
                new SqlParameter("@start",a),
                new SqlParameter("@end",b) });
            return data;
        }
    }
}
