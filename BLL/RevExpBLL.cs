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
    public class RevExpBLL
    {
        private static RevExpBLL _instance;
        public static RevExpBLL Instance
        {
            get
            {
                if (_instance == null) _instance = new RevExpBLL();
                return _instance;
            }
        }
        public string CheckValid(string gia, string noidung)
        {
            if (string.IsNullOrEmpty(gia))
                return "Bạn cần nhập vào giá tiền";
            if (!int.TryParse(gia, out _))
                return "Giá tiền phải là 1 số";
            if (string.IsNullOrEmpty(noidung))
                return "Bạn cần nhập vào nội dung";
            return "";
        }
        public string Add(RevExp re)
        {
            return RevExpDAL.Instance.Add(re);
        }
        public string Fix(RevExp re)
        {
            return RevExpDAL.Instance.Fix(re);
        }
        public string Del(int id)
        {
            return RevExpDAL.Instance.Del(id);
        }
        public List<RevExp> GetRE(string query)
        {
            return RevExpDAL.Instance.GetRE(query);
        }
        public object RevExp(string type, DateTime a, DateTime b)
        {
            return RevExpDAL.Instance.RevExp(type, a, b);
        }
        public DataTable Revenue(string a, string b)
        {
            return RevExpDAL.Instance.Revenue(a, b);
        }
    }
}
