using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class MenuDAL
    {
        private static MenuDAL instance;
        public static MenuDAL Instance
        {
            get { if (instance == null) instance = new MenuDAL(); return MenuDAL.instance; }
            set => MenuDAL.instance = value;
        }
        public string AddMenu(Menu m)
        {
            string insert = "usp_insertmenu @name, @loai, @gianhap, @giaban";
            int result = Connect.Instance.excutenonquery(insert, out string error, new SqlParameter[] {
                new SqlParameter("@name",m.name),
                new SqlParameter("@loai",m.loai),
                new SqlParameter("@gianhap",m.gianhap),
                new SqlParameter("@giaban",m.giaban)});
            if (error == null && result > 0) return "Thêm thành công";
            else return error;
        }
        public string FixMenu(Menu m)
        {
            string update = "usp_updatemenu @name, @loai, @gianhap, @giaban, @status";
            int result = Connect.Instance.excutenonquery(update, out string error, new SqlParameter[] {
                new SqlParameter("@name",m.name),
                new SqlParameter("@loai",m.loai),
                new SqlParameter("@gianhap",m.gianhap),
                new SqlParameter("@giaban",m.giaban),
                new SqlParameter("@status",m.status)
                });
            if (error == null && result > 0) return "Sửa thành công";
            else return error;
        }
        public string DelMenu(string name)
        {
            string delete = $"usp_delmenu @name";
            int result = Connect.Instance.excutenonquery(delete, out string error, new SqlParameter("@name", name));
            if (error == null && result > 0) return "Xóa thành công";
            else return error;
        }
        public void DelAll()
        {
            string delall = $"delete menu where name != ' '";
            Connect.Instance.excutenonquery(delall, out string error);
        }
        public List<Menu> GetMenu(string query)
        {
            List<Menu> menu = new List<Menu>();
            DataTable data = Connect.Instance.taobang(query);
            foreach (DataRow row in data.Rows)
            {
                Menu mn = new Menu(row);
                if (mn.name != " ") menu.Add(mn);
            }
            return menu;
        }
    }
}
