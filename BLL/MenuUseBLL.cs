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
    public class MenuUseBLL
    {
        private static MenuUseBLL instance;
        public static MenuUseBLL Instance
        {
            get { if (instance == null) instance = new MenuUseBLL(); return MenuUseBLL.instance; }
            private set { MenuUseBLL.instance = value; }
        }
        public string Add(MenuUse mu)
        {
            return MenuUseDAL.Instance.AddMenuUse(mu);
        }
        public string Fix(int soluong, int id)
        {
            return MenuUseDAL.Instance.FixMenuUse(soluong,id);
        }
        public string Del(List<string> id)
        {
            return MenuUseDAL.Instance.DelMenuUse(id);
        }
        public object TotalMenu(string day)
        {
            return MenuUseDAL.Instance.TotalMenu(day);
        }
        public List<MenuUse> GetDetails(string mabill)
        {
            return MenuUseDAL.Instance.GetDetails(mabill);
        }
        public DataTable GetService(string mabill)
        {
            return MenuUseDAL.Instance.GetService(mabill);
        }
        public DataTable ReportMenu(string mabill)
        {
            return MenuUseDAL.Instance.ReportMenu(mabill);
        }
        public string GetMuId()
        {
            return MenuUseDAL.Instance.GetMUID();
        }
    }
}
