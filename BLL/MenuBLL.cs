using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class MenuBLL
    {
        private static MenuBLL instance;
        public static MenuBLL Instance
        {
            get { if (instance == null) instance = new MenuBLL(); return MenuBLL.instance; }
            set => MenuBLL.instance = value;
        }
        public string checkvalid(string type, List<string> m, string[] id)
        {
            string[] field = new string[2] { "giá nhập", "giá bán" };
            string checkfield = "";
            if (type == "Thêm")
            {
                if (id.Contains(m[0]))
                {
                    return "Menu đã tồn tại!";
                }
            }
            for (int i = 2; i < m.Count; i++)
            {
                if (!int.TryParse(m[i], out _))
                {
                    checkfield += $"{field[i - 2]}, ";
                }
            }
            if (checkfield != "") return $"Giá trị {checkfield.Substring(0, checkfield.Length - 2)} phải là kiểu nguyên";
            if (int.Parse(m[2]) >= int.Parse(m[3])) return "Giá bán phải lớn hơn giá nhập";
            return "";
        }
        public List<Menu> GetMenu(string query)
        {
            List<Menu> list = MenuDAL.Instance.GetMenu(query);
            return list;
        }
        public string Add(Menu m)
        {
            string check = MenuDAL.Instance.AddMenu(m);
            return check;
        }
        public string Fix(Menu m)
        {
            string check = MenuDAL.Instance.FixMenu(m);
            return check;
        }
        public string Remove(string name)
        {
            string check = MenuDAL.Instance.DelMenu(name);
            return check;
        }
        public void RemoveAll()
        {
            MenuDAL.Instance.DelAll();
        }
    }
}
