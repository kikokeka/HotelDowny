using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Checkinout
    {
        public string mabill { get; set; }
        public DateTime daycheckin { get; set; }
        public DateTime? daycheckout { get; set;}
        public string phong {  get; set;}
        public string type {  get; set;}
        public string status {  get; set;}
        public int menuprice {  get; set;}
        public int roomprice {  get; set;}
        public int totalprice {  get; set;}
        public string tknhan {  get; set;}
        public string tktra {  get; set;}
        public string ghichu { get; set;}
        public int downprice {  get; set;}
        public Checkinout(string mabill, DateTime daycheckin, DateTime? daycheckout, string phong, string type, string status, int menuprice, int roomprice, int totalprice, string tknhan, string tktra, string ghichu,int downprice)
        {
            this.mabill = mabill;
            this.daycheckin = daycheckin;
            this.daycheckout = daycheckout;
            this.phong = phong;
            this.type = type;
            this.status = status;
            this.menuprice = menuprice;
            this.roomprice = roomprice;
            this.totalprice = totalprice;
            this.tknhan = tknhan;
            this.tktra = tktra;
            this.ghichu = ghichu;
            this.downprice = downprice;
        }
        public Checkinout() { }
        public Checkinout(DataRow row)
        {
            this.mabill = row["mabill"].ToString();
            this.daycheckin = DateTime.Parse(row["daycheckin"].ToString());
            var ngaytra = row["daycheckout"];
            if(ngaytra.ToString()!="")
                this.daycheckout = (DateTime?)ngaytra;
            this.phong = row["phong"].ToString();
            this.type = row["type"].ToString();
            if ((bool)row["status"] == false) this.status = "Chưa thanh toán";
            else this.status = "Đã thanh toán";
            this.menuprice = int.Parse(row["menuprice"].ToString());
            this.roomprice = int.Parse(row["roomprice"].ToString());
            this.totalprice = int.Parse(row["totalprice"].ToString());
            this.tknhan = row["tknhan"].ToString();
            this.tktra = row["tktra"].ToString();
            this.ghichu = row["ghichu"].ToString();
            this.downprice = (int)row["downprice"];
        }
    }
}
