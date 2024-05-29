using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace BLL
{
    public class BookingBLL
    {
        private static readonly Lazy<BookingBLL> instance = new Lazy<BookingBLL>(() => new BookingBLL());

        public static BookingBLL Instance => instance.Value;

        private BookingBLL() { }

        public string CheckValid(List<string> lst)
        {
            string[] fields = new string[4] { "CCCD", "tiền trả trước", "tên khách hàng", "sđt" };
            StringBuilder checkField = new StringBuilder();

            for (int i = 0; i < lst.Count; i++)
            {
                if (string.IsNullOrEmpty(lst[i]))
                {
                    return "Vui lòng nhập đủ thông tin";
                }
            }

            if (!IsValidCCCD(lst[0]))
                checkField.Append($"{fields[0]}, ");

            if (!int.TryParse(lst[1], out _))
                checkField.Append($"{fields[1]}, ");

            if (!IsValidPhoneNumber(lst[3]))
                checkField.Append($"{fields[3]}, ");

            if (checkField.Length > 0)
                return $"Giá trị {checkField.ToString().TrimEnd(',', ' ')} không đúng định dạng";

            return string.Empty;
        }

        private bool IsValidCCCD(string cccd)
        {
            Regex rgcccd = new Regex(@"^0+([0-9]{11})$");
            return rgcccd.IsMatch(cccd);
        }

        private bool IsValidPhoneNumber(string phoneNumber)
        {
            Regex rgsdt = new Regex(@"^(03|05|07|08|09)+([0-9]{8})$");
            return rgsdt.IsMatch(phoneNumber);
        }
        public string Add(Booking b)
        {
            return BookingDAL.Instance.AddBooking(b);
        }
        public string Fix(Booking b)
        {
            return BookingDAL.Instance.FixBooking(b);
        }
        public string Remove(string mabill)
        {
            return BookingDAL.Instance.DelBooking(mabill);
        }
        public string Cancel(string mabill)
        {
            return BookingDAL.Instance.CancelBooking(mabill);
        }
        public Booking Getdata(string phong, string ngaynhan)
        {
            Booking b = BookingDAL.Instance.Getdata(phong,ngaynhan);
            return b;
        }
        public Booking GetBill(string query,string mabill)
        {
            return BookingDAL.Instance.GetBill(query,mabill);
        }
        public List<Booking> GetByday(string query)
        {
            return BookingDAL.Instance.GetByday(query);
        }
        public string GetBillID()
        {
            return BookingDAL.Instance.GetBillID();
        }
    }
}
