using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ClientBLL
    {
        private static ClientBLL instance;
        public static ClientBLL Instance
        {
            get { if (instance == null) instance = new ClientBLL(); return ClientBLL.instance; }
            set => ClientBLL.instance = value;
        }
        public DataTable GetClientIn4()
        {
            return ClientDAL.Instance.GetClientIn4();
        }
    }
}
