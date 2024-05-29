using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Client
    {
        public string CCCD { get; set; }
        public string namekh { get; set; }
        public string sdt { get; set; }
        public string phong {  get; set; }
        public DateTime ngayra { get; set; }
        public int total_rent {  get; set; }
        public int totalprice {  get; set; }
        public string note { get; set; }
        public Client() { }
        public Client(string CCCD, string namekh, string sdt, string phong, DateTime ngayra,int total_rent, int totalprice, string note)
        {
            this.CCCD = CCCD;
            this.namekh = namekh;
            this.sdt = sdt;
            this.note = note;
            this.ngayra = ngayra;
            this.total_rent = total_rent;
            this.totalprice = totalprice;
            this.note = note;
        }
        public Client(DataRow row)
        {
            this.CCCD = row["CCCD"].ToString();
            this.namekh = row["Họ tên"].ToString();
            this.sdt = row["SĐT"].ToString();
            this.phong = row["Phòng"].ToString();
            this.ngayra = (DateTime)row["Ngày ra"];
            this.total_rent = (int)row["Tổng lượt thuê"];
            this.totalprice = (int)row["Tổng tiền sử dụng"];
            this.note = row["Ghi chú"].ToString();
        }
    }
}
