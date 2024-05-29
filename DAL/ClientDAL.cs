using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ClientDAL
    {
        private static ClientDAL instance;
        public static ClientDAL Instance
        {
            get { if (instance == null) instance = new ClientDAL(); return ClientDAL.instance; }
            set => ClientDAL.instance = value;
        }
        public DataTable GetClientIn4()
        {
            return Connect.Instance.taobang("usp_clientin4");
        }
        public List<Client> GetClient()
        {
            List<Client> cl = new List<Client>();
            return cl;
        }
    }
}
