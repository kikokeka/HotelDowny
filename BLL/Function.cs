using DAL;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Function
    {
        private static Function instance;
        public static Function Instance
        {
            get { if (instance == null) return instance = new Function(); return Function.instance; }
            set { Function.instance = value; }
        }
        public object Luotthue(DateTime checkin)
        {
            string luotthue = $"select count(*) from checkinout where convert(date,daycheckin) = convert(date,'{checkin}')";
            object count = Connect.Instance.excutescalar(luotthue,out string error);
            if(error != null) return error;
            return count;
        }
        public object Luotdangthue()
        {
            string query = $"select count(*) from checkinout where convert(date,daycheckin) = convert(date,'{DateTime.Now}') and status = 0";
            object luotthue = Connect.Instance.excutescalar(query, out string error);
            if (error != null) return error;
            return luotthue;
        }
        public object StatusRoom(string status)
        {
            string query = $"select count(*) from room where status = N'{status}'";
            object count = Connect.Instance.excutescalar(query, out string error);
            if (error != null) return error;
            return count;
        }
        public object Phongcandon()
        {
            string query = $"select count(*) from room where dondep = 1";
            object count = Connect.Instance.excutescalar(query, out string error);
            if (error != null) return error;
            return count;
        }
        public object Getttt(string mabill)
        {
            string query = $"select tientratruoc from booking where mabill = @mabill";
            object count = Connect.Instance.excutescalar(query , out string error,new System.Data.SqlClient.SqlParameter("@mabill",mabill));
            if (error != null) return error;
            return count;
        }
        public object Nhapkho(string a, string b)
        {
            string query = $"select SUM([Tổng giá]) from dbo.CalculateTotalInfo ('{a}' , '{b}')";
            object count = Connect.Instance.excutescalar(query, out string error);
            if (error != null) return error;
            return count;
        }
        public object ChiMenu(string a, string b)
        {
            string query = $"select coalesce(SUM([Tổng giá]),0) from dbo.CalculateTotalInfo ('{a}', '{b}')";
            object count = Connect.Instance.excutescalar(query, out string error);
            if (error != null) return error;
            return count;
        }
        public DataTable RevMenu(string a, string b)
        {
            string query = "usp_dtmenu @start , @end";
            DataTable data = Connect.Instance.taobang(query,new SqlParameter[]{
                new SqlParameter("@start",a),
                new SqlParameter("@end",b) });
            return data;
        }
    }
}
