using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Booking
    {
        public string mabill {  get; set; }
        public string cccd {  get; set; }
        public string phong {  get; set; }
        public string type {  get; set; }
        public string status {  get; set; }
        public DateTime ngaynhan { get; set; }
        public DateTime? ngaytra { get; set; }
        public int tientratruoc { get; set; }
        public string ghichu {  get; set; }
        public string tk { get; set; }
        public string namekh {  get; set; }
        public string sdt {  get; set; }
        public Booking() { }
        public Booking(string mabill, string cccd, string phong, string type, string status, DateTime ngaynhan, DateTime? ngaytra, int tientratruoc,string ghichu, string tk,string namekh, string sdt)
        {
            this.mabill = mabill;
            this.cccd = cccd;
            this.phong = phong;
            this.type = type;
            this.status = status;
            this.ngaynhan = ngaynhan;
            this.ngaytra = ngaytra;
            this.tientratruoc = tientratruoc;
            this.ghichu = ghichu;
            this.tk = tk;
            this.namekh = namekh;
            this.sdt = sdt;
        }

        public Booking(DataRow row)
        {
            this.mabill = row["mabill"].ToString();
            this.cccd = row["cccd"].ToString();
            this.phong = row["phong"].ToString();
            this.type = row["type"].ToString();
            this.status = row["status"].ToString();
            this.ngaynhan = DateTime.Parse(row["ngaynhan"].ToString());
            var ngaytra = row["ngaytra"];
            if (ngaytra.ToString() != "")
                this.ngaytra = (DateTime?)row["ngaytra"];
            this.tientratruoc = (int)row["tientratruoc"];
            this.ghichu = row["ghichu"].ToString();
            this.tk = row["tk"].ToString();
            this.namekh = row["namekh"].ToString();
            this.sdt = row["sdt"].ToString();
        }
    }
}
