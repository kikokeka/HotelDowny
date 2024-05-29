using System.Data;

namespace DTO
{
    public class Menu
    {
        public string name { get; set; }
        public string loai { get; set; }
        public int gianhap { get; set; }
        public int giaban { get; set;}
        public string status { get; set; }
        public Menu() { }
        public Menu(DataRow row)
        {
            this.name = row["name"].ToString();
            this.loai = row["loai"].ToString();
            this.gianhap = int.Parse(row["gianhap"].ToString());
            this.giaban = int.Parse(row["giaban"].ToString());
            this.status = row["status"].ToString();
        }
    }
}
