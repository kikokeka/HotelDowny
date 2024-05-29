using System;
using DAL;
using DTO;

namespace BLL
{
    public class LoginBLL
    {
        private static LoginBLL instance;
        public static LoginBLL Instance
        {
            get { if (instance == null) instance = new LoginBLL(); return LoginBLL.instance; }
            set => LoginBLL.instance = value;
        }
        public string CheckLogin(Account acc)
        {
            if (acc.Tk == "")
                return "Vui lòng nhập tài khoản";
            if (acc.Mk == "")
                return "Vui lòng nhập mật khẩu";
            else
            {
                string info = HistoryDAL.Instance.AddHistory(acc);
                return info;
            }
        }
        public void Logout()
        {
            HistoryDAL.Instance.UpdateHistory();
        }
    }
}
