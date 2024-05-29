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
    public class SetupBLL
    {
        private static SetupBLL instance;
        public static SetupBLL Instance
        {
            get { if (instance == null) instance = new SetupBLL(); return SetupBLL.instance; }
            set => SetupBLL.instance = value;
        }
        public Setup Getdata()
        {
            return SetupDAL.Instance.Getdata();
        }
        public string Fix(Setup setup)
        {
            return SetupDAL.Instance.Fix(setup);
        }
        public DataTable Report()
        {
            return SetupDAL.Instance.Report();
        }
    }
}
