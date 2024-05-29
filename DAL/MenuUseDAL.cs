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
    public class MenuUseDAL
    {
        private static MenuUseDAL instance;
        public static MenuUseDAL Instance
        {
            get { if (instance == null) instance = new MenuUseDAL(); return MenuUseDAL.instance; }
            private set { MenuUseDAL.instance = value; }
        }
        public string AddMenuUse(MenuUse mu)
        {
            string insert = "usp_insertmu @id, @ten, @sl, @ngay, @mabill";
            int result = Connect.Instance.excutenonquery(insert, out string error, new SqlParameter[]{
                new SqlParameter("@id",mu.id),
                new SqlParameter("@ten",mu.tenmenu),
                new SqlParameter("@sl",mu.soluong),
                new SqlParameter("@ngay",mu.ngay),
                new SqlParameter("@mabill",mu.mabill) });
            if (error == null & result > 0) return "Thêm dịch vụ thành công";
            else return error;
        }
        public string FixMenuUse(int soluong, int id)
        {
            string update = "usp_insertmu @sl, @id";
            int result = Connect.Instance.excutenonquery(update, out string error, new SqlParameter[]{
                new SqlParameter("@sl",soluong),
                new SqlParameter("@id",id)});
            if (error == null & result > 0) return "Sửa dịch vụ thành công";
            else return error;
        }
        public string DelMenuUse(List<string> lst_id)
        {
            string id = $"'{lst_id[0]}',";
            if (lst_id.Count > 1)
            {
                for(int i=0;i< lst_id.Count; i++)
                {
                    id += $"{lst_id[i]},";
                }
            }
            string iddel = "("+id.Remove(id.Length-1)+")";
            string delete = $"delete menuuse where id in {iddel}";
            int result = Connect.Instance.excutenonquery(delete, out string error);
            if (error == null & result > 0) return "Xóa dịch vụ thành công";
            else return error;
        }
        public object TotalMenu(string day)
        {
            string query = "usp_totalmenu @day";
            object count = Connect.Instance.excutescalar(query, out string error, new System.Data.SqlClient.SqlParameter("@day", day));
            if (error != null) return error;
            return count;
        }
        public List<MenuUse> GetDetails(string mabill)
        {
            List<MenuUse> lst = new List<MenuUse>();
            DataTable roomtype = Connect.Instance.taobang("usp_getmenuusedetail @mabill",new SqlParameter("@mabill",mabill));
            foreach (DataRow row in roomtype.Rows)
            {
                MenuUse m = new MenuUse(row);
                lst.Add(m);
            }
            return lst;
        }
        public DataTable GetService(string mabill)
        {
            DataTable dt = Connect.Instance.taobang("usp_getmenuuse @mabill",new SqlParameter("@mabill", mabill));
            return dt;
        }
        public DataTable ReportMenu(string mabill)
        {
            return Connect.Instance.taobang("usp_reportmenu @mabill", new SqlParameter("@mabill", mabill));
        }
        public string GetMUID()
        {
            List<string> lstmabill = Connect.Instance.excuteReader("select id from menuuse", out string error);
            List<int> ints = new List<int>();
            foreach (string s in lstmabill)
            {
                string so = new string(s.Where(char.IsDigit).ToArray());
                int mabill = int.Parse(so);
                ints.Add(mabill);
            }
            Random random = new Random();
            int number;
            do
            {
                number = random.Next(100000, 1000000);
            }
            while (ints.Contains(number));
            string bill = $"MU{number}";
            return bill;
        }
    }
}
