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
    public class InventoryBLL
    {
        private static InventoryBLL instance;
        public static InventoryBLL Instance
        {
            get { if (instance == null) instance = new InventoryBLL(); return InventoryBLL.instance; }
            set => InventoryBLL.instance = value;
        }
        public string Add(string[] arr_name, int[] arr_value, string id, DateTime ngay)
        {
            return InventoryDAL.Instance.Add(arr_name, arr_value, id, ngay);
        }
        public DataTable GetKho(string query)
        {
            return InventoryDAL.Instance.GetKho(query);
        }
        public List<Inventory> GetNhapKho(string query)
        {
            return InventoryDAL.Instance.GetNhapKho(query);
        }
        public string GetId()
        {
            return InventoryDAL.Instance.GetInvenID();
        }
    }
}
