using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace DAL
{
    public class BookingDAL
    {
        private static BookingDAL instance;
        public static BookingDAL Instance
        {
            get { if (instance == null) instance = new BookingDAL(); return BookingDAL.instance; }
            private set { BookingDAL.instance = value; }
        }
        private BookingDAL() { }
        public string AddBooking(Booking b)
        {
            string insert = "usp_insertbooking @mabill, @cccd, @phong, @type, @ngaynhan, @ngaytra, @tientratruoc, @ghichu, @tk, @namekh, @sdt";
            int result = Connect.Instance.excutenonquery(insert, out string error, new SqlParameter[] {
                new SqlParameter("mabill", b.mabill),
                new SqlParameter("cccd", b.cccd),
                new SqlParameter("phong", b.phong),
                new SqlParameter("type", b.type),
                new SqlParameter("ngaynhan", b.ngaynhan),
                new SqlParameter("ngaytra", b.ngaytra),
                new SqlParameter("tientratruoc", b.tientratruoc),
                new SqlParameter("ghichu", b.ghichu),
                new SqlParameter("tk", b.tk),
                new SqlParameter("namekh",b.namekh),
                new SqlParameter("sdt",b.sdt)
                });
            if (error == null && result > 0) return "Đặt phòng thành công";
            return error;

        }
        public string FixBooking(Booking b)
        {
            string update = "usp_updatebooking @mabill, @cccd, @phong, @type, @ngaynhan, @ngaytra, @tientratruoc, @ghichu, @tk, @namekh, @sdt";
            int result = Connect.Instance.excutenonquery(update,out string error, new SqlParameter[] {
                new SqlParameter("mabill", b.mabill),
                new SqlParameter("cccd", b.cccd),
                new SqlParameter("phong", b.phong),
                new SqlParameter("type", b.type),
                new SqlParameter("ngaynhan", b.ngaynhan),
                new SqlParameter("ngaytra", b.ngaytra),
                new SqlParameter("tientratruoc", b.tientratruoc),
                new SqlParameter("ghichu", b.ghichu),
                new SqlParameter("tk", b.tk),
                new SqlParameter("namekh", b.namekh),
                new SqlParameter("@sdt",b.sdt)
                });
            if (error == null && result > 0) return "Sửa đặt phòng thành công";
            return error;
        }
        public string DelBooking(string mabill)
        {
            string delete = "usp_deletebooking @mabill";
            int result = Connect.Instance.excutenonquery(delete, out string error, new SqlParameter[] {new SqlParameter("mabill", mabill)});
            if (error == null && result > 0) return "Xóa đặt phòng thành công";
            return error;
        }
        public string CancelBooking(string mabill)
        {
            string update = $"update booking set status = N'Đã hủy phòng' where mabill = N'{mabill}'";
            int result = Connect.Instance.excutenonquery(update, out string error);
            if (error == null && result > 0) return "Hủy đặt phòng thành công";
            return error;
        }
        public Booking Getdata(string phong, string ngaynhan)
        {
            Booking datphong = null;
            string query = $"usp_getdp N'{phong}' , N'{ngaynhan}'";
            DataTable data = Connect.Instance.taobang(query);
            foreach (DataRow row in data.Rows)
            {
                datphong = new Booking(row);
            }
            return datphong;
        }
        public Booking GetBill(string query,string mabill)
        {
            Booking datphong = null;
            //string query = $"select * from booking where mabill = @mabill";
            DataTable data = Connect.Instance.taobang(query,new SqlParameter("@mabill",mabill));
            foreach (DataRow row in data.Rows)
            {
                datphong = new Booking(row);
            }
            return datphong;
        }
        public List<Booking> GetByday(string query)
        {
            List<Booking> dp = new List<Booking>();
            DataTable data = Connect.Instance.taobang(query);
            foreach (DataRow row in data.Rows)
            {
                Booking datphong = new Booking(row);
                dp.Add(datphong);
            }
            return dp;
        }
        public string GetBillID()
        {
            List<string> lstmabill = Connect.Instance.excuteReader("select mabill from booking",out string error);
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
            string bill = $"DN{number}";
            return bill;
        }
        
    }
}
