using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Room
    {

        public string tenp { get; set; }
        public string loai { get; set; }
        public string status { get; set; }
        public string dondep { get; set; }
        public string mota { get; set; }
        public Room() { }
        public Room(DataRow row)
        {
            this.tenp = row["tenp"].ToString();
            this.loai = row["loai"].ToString();
            this.status = row["status"].ToString();
            this.dondep = ((bool)row["dondep"] == true) ? "Chưa dọn" : "Đã dọn";
            this.mota = row["mota"].ToString();

        }
    }
}
