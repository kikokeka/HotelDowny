using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Inventory
    {
        public string id {  get; set; }
        public string tenmenu {  get; set; }
        public int soluong {  get; set; }
        public DateTime ngaynhap {  get; set; }
        public string tk {  get; set; }
        public Inventory() { }
        public Inventory(DataRow row)
        {
            this.id = (string)row["id"];
            this.tenmenu = row["tenmenu"].ToString();
            this.soluong = (int)row["soluong"];
            this.ngaynhap = (DateTime)row["ngaynhap"];
            this.tk = row["tk"].ToString();
        }
    }
}
