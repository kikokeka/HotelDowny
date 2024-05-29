using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class InventoryDAL
    {
        private static InventoryDAL instance;
        public static InventoryDAL Instance
        {
            get { if (instance == null) instance = new InventoryDAL(); return InventoryDAL.instance; }
            set => InventoryDAL.instance = value;
        }
        public string Add(string[] arr_name, int[] arr_value,string id, DateTime ngay)
        {
            string insertnk = $"insert into nhapkho values ('{id}','{DateTime.Now}','{Account.logged.Tk}')";
            int result;
            result = Connect.Instance.excutenonquery(insertnk, out string error);
            if (error != null || result <= 0) return error;
            for (int i= 0;i < arr_name.Length; i++)
            {
                string insertctnk = $"insert into chitietnhapkho values ('{id}',N'{arr_name[i]}',{arr_value[i]})";
                result = Connect.Instance.excutenonquery(insertctnk,out string errordetail);
                if(result <= 0 || errordetail!=null) return errordetail;
            }
            return "Nhập kho thành công";
        }
        public DataTable GetKho(string query)
        {
            return Connect.Instance.taobang(query);
        }
        public List<Inventory> GetNhapKho(string query)
        {
            List<Inventory> dp = new List<Inventory>();
            DataTable data = Connect.Instance.taobang(query);
            foreach (DataRow row in data.Rows)
            {
                Inventory inv = new Inventory(row);
                dp.Add(inv);
            }
            return dp;
        }
        public string GetInvenID()
        {
            List<string> lstmabill = Connect.Instance.excuteReader("select id from nhapkho",out string error);
            if (error != null) return error ;
            List<int> ints = new List<int>();
            foreach (string s in lstmabill)
            {
                string so = new string(s.Where(char.IsDigit).ToArray());
                int mabill = int.Parse(so);
                ints.Add(mabill);
            }
            Random random = new Random();
            int number;
            do
            {
                number = random.Next(100000, 1000000);
            }
            while (ints.Contains(number));
            string id = $"NK{number}";
            return id;
        }
    }
}
