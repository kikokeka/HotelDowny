using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class RoomType
    {
        private string ten, Mota;
        private int Blockdau, Giablockdau, Giagiosau, Giaquadem, Giangay,Giathang;
        public string Ten { get => ten; set => ten = value; }
        public int blockdau { get => Blockdau; set => Blockdau = value; }
        public int giablockdau { get => Giablockdau; set => Giablockdau = value; }
        public int giagiosau { get => Giagiosau; set => Giagiosau = value; }
        public int giaquadem { get => Giaquadem; set => Giaquadem = value; }
        public int giangay { get => Giangay; set => Giangay = value; }
        public int giathang { get => Giathang; set => Giathang = value; }
        public string mota { get => Mota; set => Mota = value; }
        public RoomType() { }
        public RoomType(string ten, string mota, int blockdau, int giablockdau, int giagiosau, int giaquadem, int giangay, int giathang)
        {
            Ten = ten;
            this.mota = mota;
            this.blockdau = blockdau;
            this.giablockdau = giablockdau;
            this.giagiosau = giagiosau;
            this.giaquadem = giaquadem;
            this.giangay = giangay;
            this.giathang = giathang;
        }

        public RoomType(DataRow row)
        {
            this.Ten = row["Tên loại"].ToString();
            this.blockdau = (int)row["Block đầu"];
            this.giablockdau = (int)row["Giá block đầu"];
            this.giagiosau = (int)row["Giá giờ sau"];
            this.giaquadem = (int)row["Giá qua đêm"];
            this.giangay = (int)row["Giá ngày"];
            this.giathang = (int)row["Giá tháng"];
            this.mota = row["Mô tả"].ToString();
        }
    }
}
