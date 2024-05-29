using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class CheckinoutBLL
    {
        private static CheckinoutBLL instance;
        public static CheckinoutBLL Instance
        {
            get { if (instance == null) instance = new CheckinoutBLL(); return CheckinoutBLL.instance; }
            private set { CheckinoutBLL.instance = value; }
        }
        private CheckinoutBLL() { }
        public string Checkin(Checkinout cko)
        {
            return CheckinoutDAL.Instance.Checkin(cko);
        }
        public string Checkinonsite(Booking booking)
        {
            return CheckinoutDAL.Instance.Checkinonsite(booking);
        }
        public string Fix(string mabill, DateTime daycheckin, string type, int tientratruoc, string note, string tk)
        {
            return CheckinoutDAL.Instance.Fix(mabill, daycheckin, type, tientratruoc, note, tk);
        }
        public string Checkout(Checkinout cko)
        {
            return CheckinoutDAL.Instance.Checkout(cko);
        }
        public Checkinout GetByid(string id)
        {
            Checkinout ck = null;
            DataTable data = Connect.Instance.taobang($"select * from checkinout where mabill =N'{id}'");
            foreach (DataRow item in data.Rows)
            {
                ck = new Checkinout(item);
            }
            return ck;
        }
        public Checkinout GetBill(string tenp)
        {
            Checkinout ck = null;
            DataTable data = Connect.Instance.taobang($"select * from checkinout where phong = N'{tenp}' and status = 0 ");
            foreach (DataRow item in data.Rows)
            {
                ck = new Checkinout(item);
            }
            return ck;
        }
        public string Swaproom(string mabill, string tenp, string swap)
        {
            string swaproom = "usp_swaproom @mabill, @tenp, @swap";
            int result = Connect.Instance.excutenonquery(swaproom, out string error, new SqlParameter[] {
                new SqlParameter("@mabill",mabill),
                new SqlParameter("@tenp",tenp),
                new SqlParameter("@swap",swap)
                });
            if (error == null && result > 0) return "Đổi phòng thành công";
            return error;
        }
        public object RevBill(string a, string b)
        {
            string query = $"select coalesce(Sum([Tổng tiền]),0) from bill (@start, @end)";
            object count = Connect.Instance.excutescalar(query, out string error, new SqlParameter[]{
                new SqlParameter("@start",a),
                new SqlParameter("@end",b)});
            if (error != null) return error;
            return count;
        }
        public List<Checkinout> History()
        {
            List<Checkinout> bills = new List<Checkinout>();
            DataTable data = Connect.Instance.taobang("select * from checkinout where status = 1");
            foreach (DataRow row in data.Rows)
            {
                Checkinout nhanphong = new Checkinout(row);
                bills.Add(nhanphong);
            }
            return bills;
        }
        public DataTable ReportBill(string id)
        {
            return Connect.Instance.taobang("select * from ReportBill (@id)", new SqlParameter("@id", id));
        }
        public DataTable Bill(string a, string b)
        {
            DataTable data = Connect.Instance.taobang($"usp_gethiscko @start, @end", new SqlParameter[]{
                new SqlParameter("@start",a),
                new SqlParameter("@end",b)});
            return data;
        }
    }
}
