using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BLL
{
    public class RoomTypeBLL
    {
        private static RoomTypeBLL instance;
        public static RoomTypeBLL Instance
        {
            get { if (instance == null) instance = new RoomTypeBLL(); return RoomTypeBLL.instance; }
            set => RoomTypeBLL.instance = value;
        }
        public string CheckValid(string[] id, string type, List<string> lst)
        {
            lst.Reverse();
            string[] field = new string[6] { "block đầu", "giá blockdau", "giá giờ sau", "giá qua đêm", "giá ngày", "giá tháng" };
            string checkfield = "";
            if (type == "Thêm")
            {
                if (id.Contains(lst[0]))
                {
                    return "Tên loại phòng đã tồn tại!";
                }
            }
            for (int i = 1; i < lst.Count - 1; i++)
            {
                if (!int.TryParse(lst[i], out _))
                {
                    checkfield += $"{field[i-1]}, ";
                }
            }
            if (checkfield != "") return $"Giá trị {checkfield.Substring(0,checkfield.Length-2)} phải là kiểu nguyên";
            return "";
        }
        public string Add(RoomType type)
        {
            string check = RoomTypeDAL.Instance.AddRoomType(type);
            return check;
        }
        public string Fix(RoomType r)
        {
            string check = RoomTypeDAL.Instance.FixRoomType(r);
            return check;
        }
        public string Remove(string name)
        {
            string check = RoomTypeDAL.Instance.DelRoomType(name);
            return check;
        }
        public string RemoveAll()
        {
            return RoomTypeDAL.Instance.DelAll();
        }
        public RoomType GetRoom(string tenp)
        {
            return RoomTypeDAL.Instance.GetRoom(tenp);
        }
        public List<RoomType> GetRoomType(string query)
        {
            List<RoomType> list = RoomTypeDAL.Instance.GetRoomType(query);
            return list;
        }
    }
}
