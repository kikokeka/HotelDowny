using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class RoomBLL
    {
        private static RoomBLL instance;
        public static RoomBLL Instance
        {
            get { if (instance == null) instance = new RoomBLL(); return RoomBLL.instance; }
            set => RoomBLL.instance = value;
        }
        public string checkvalid(string name, string type, string[] arr_id, string id)
        {
            if (name == "" || type == "") return "Vui lòng nhập đủ thông tin";
            if (arr_id.Contains(id))
            {
                return "Tên phòng đã tồn tại!";
            }
            if (id.Length > 10) return "Tên phòng không được quả 10 kí tự";
            return "";
        }
        public List<Room> GetRoom(string query)
        {
            List<Room> list = RoomDAL.Instance.GetRoom(query);
            return list;
        }
        public string Add(Room r)
        {
            string check = RoomDAL.Instance.AddRoom(r);
            return check;
        }
        public string Fix(string name, Room r)
        {
            string check = RoomDAL.Instance.FixRoom(name, r);
            return check;
        }
        public string Clear(string name)
        {
            return RoomDAL.Instance.ClearRoom(name);
        }
        public string Cleared(string name)
        {
            return RoomDAL.Instance.ClearedRoom(name);
        }
        public string Remove(string name)
        {
            string check = RoomDAL.Instance.DelRoom(name);
            return check;
        }
        public string RemoveAll()
        {
            return RoomDAL.Instance.DelAll();
        }
        public string LastCheckout(string name)
        {
            return RoomDAL.Instance.LastCheckout(name);
        }
        public DataTable RevRoom(string a, string b)
        {
            return RoomDAL.Instance.RevRoom(a, b);
        }
        public object Gettienp(string a, string b)
        {
            return RoomDAL.Instance.Gettienp(a, b);
        }
    }
}
