using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class RevExp
    {
        public int mathuchi {  get; set; }
        public DateTime ngay { get; set; }
        public string loai {  get; set; }
        public int gia { get; set; }
        public string noidung { get; set; }
        public string tk { get; set; }
        public RevExp() { }
        public RevExp(int mathuchi, DateTime ngay, string loai, int gia, string noidung, string tk)
        {
            this.mathuchi = mathuchi;
            this.ngay = ngay;
            this.loai = loai;
            this.gia = gia;
            this.noidung = noidung;
            this.tk = tk;
        }
        public RevExp(DataRow row)
        {
            this.mathuchi = (int)row["mathuchi"];
            this.ngay = (DateTime)row["ngay"];
            this.loai = row["loai"].ToString();
            this.gia = (int)row["gia"];
            this.noidung = row["noidung"].ToString();
            this.tk = row["tk"].ToString();
        }
    }
}
