using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DAL
{
    public class SetupDAL
    {
        private static SetupDAL instance;
        public static SetupDAL Instance
        {
            get { if (instance == null) instance = new SetupDAL(); return SetupDAL.instance; }
            set => SetupDAL.instance = value;
        }
        public string Fix(Setup in4)
        {
            string update = $"update setup set name = @name, location = @location, sdt = @sdt";
            int result = Connect.Instance.excutenonquery(update, out string error, new SqlParameter[] {
                new SqlParameter("@name",in4.name),
                new SqlParameter("@location",in4.location),
                new SqlParameter("@sdt",in4.sdt)});
            if (error == null && result > 0) return "Cập nhật thông tin thành công";
            return error;
        }
        public Setup Getdata()
        {
            Setup in4 = null;
            string query = "select * from setup";
            DataTable dt = Connect.Instance.taobang(query);
            foreach(DataRow row in dt.Rows)
            {
                in4 = new Setup(row);
            }
            return in4;
        }
        public DataTable Report()
        {
            return Connect.Instance.taobang("select * from setup");
        }
    }
}
