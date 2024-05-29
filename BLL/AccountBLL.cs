using DTO;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace BLL
{
    public class AccountBLL
    {
        private static AccountBLL instance;
        public static AccountBLL Instance
        {
            get { if (instance == null) instance = new AccountBLL(); return AccountBLL.instance; }
            set => AccountBLL.instance = value;
        }
        public string Checkvalid(List<string>id, string type, List<string>in4)
        {
            if(type == "Thêm")
            {
                if (id.Contains(in4[0]))
                {
                    return "Tên tài khoản đã tồn tại!";
                }
            }
            foreach(string s in in4)
            {
                if(string.IsNullOrEmpty(s))
                {
                    return "Vui lòng nhập đủ thông tin";
                }
            }
            if (in4[1] != in4[2])
                return "Xác nhận lại mật khẩu";
            return "";
        }
        public string AddAcc(Account account)
        {
            return AccountDAL.Instance.Addacc(account);
        }
        public string ChangMk(string tk, string mk)
        {
            return AccountDAL.Instance.ChangePass(tk, mk);
        }
        public string DelAcc(string tk)
        {
            return AccountDAL.Instance.RemoveAcc(tk);
        }
        public List<Account> GetAcc(string query)
        {
            return AccountDAL.Instance.GetAcc(query);
        }
        public DataTable ManageAcc(string query)
        {
            return AccountDAL.Instance.ManageAcc(query);
        }
        public string Lastlog(string tk)
        {
            return AccountDAL.Instance.LastLog(tk);
        }
    }
}
