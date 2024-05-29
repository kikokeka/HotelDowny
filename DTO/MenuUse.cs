using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class MenuUse
    {
        public string id {  get; set; }
        public string tenmenu {  get; set; }
        public int soluong { get; set; }
        public DateTime ngay { get; set; }
        public string mabill { get; set; }
        public int thanhtien {  get; set; }
        public MenuUse() { }
        public MenuUse(string id, string tenmenu,int soluong,DateTime ngay, string mabill,int thanhtien) 
        {
            this.id = id;
            this.tenmenu = tenmenu;
            this.soluong = soluong; this.ngay = ngay; this.mabill = mabill;
        }
        public MenuUse(DataRow row)
        {
            this.id = row["id"].ToString();
            this.tenmenu = row["tenmenu"].ToString();
            this.soluong = (int)row["soluong"];
            this.ngay = (DateTime)row["ngay"];
            this.mabill = row["mabill"].ToString();
            string thanhtien = row["Thành tiền"].ToString();
            if (!string.IsNullOrEmpty(thanhtien)) this.thanhtien= int.Parse(thanhtien);
        }
    }
}
