using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Web.UI.WebControls;
using DTO;

namespace DAL
{
    public class AccountDAL
    {
        private static AccountDAL instance;
        public static AccountDAL Instance
        {
            get { if (instance == null) instance = new AccountDAL(); return AccountDAL.instance; }
            set => AccountDAL.instance = value;
        }
        public Account Login(Account acc)
        {
            string check = $"select count(*) from account where tk = @tk";
            int count = (int)Connect.Instance.excutescalar(check,out string error ,new SqlParameter[] { new SqlParameter("@tk", acc.Tk) });
            if (error == null)
            {
                if (count > 0)
                {
                    string query = $"usp_log @tk , @mk";
                    DataTable dt = Connect.Instance.taobang(query, new SqlParameter[] { new SqlParameter("@tk", acc.Tk), new SqlParameter("@mk", acc.Mk) });
                    if (dt.Rows.Count < 1)
                        acc.Tk = "Sai mật khẩu";
                    else
                    {
                        foreach (DataRow row in dt.Rows)
                        {
                            acc = new Account(row);
                        }
                    }
                }
                else acc.Tk = "Tài khoản không tồn tại";
                return acc;
            }
            else
            {
                acc.Tk = error; return acc;
            }
        }
        public List<Account> GetAcc(string query)
        {
            List<Account> acc = new List<Account>();
            DataTable data = Connect.Instance.taobang(query);
            foreach (DataRow row in data.Rows)
            {
                Account a = new Account(row);
                acc.Add(a);
            }
            return acc;
        }
        public DataTable ManageAcc(string query)
        {
            return Connect.Instance.taobang(query);
        }
        public string Addacc(Account acc)
        {
            string insert = "usp_insertacc @tk, @mk, @cap";
            int result = Connect.Instance.excutenonquery(insert, out string error, new SqlParameter[] {
                new SqlParameter("@tk",acc.Tk),
                new SqlParameter("@mk",acc.Mk),
                new SqlParameter("@cap",acc.Cap)});
            if (result > 0 && error==null) return "Thêm thành công";
            else return error;
        }
        public string ChangePass(string tk, string mk)
        {
            string update = $"usp_changepass @tk, @mk";
            int result = Connect.Instance.excutenonquery(update, out string error, new SqlParameter[] {
                new SqlParameter("@tk",tk),
                new SqlParameter("@mk",mk) });
            if(result > 0 && error == null) return "Đổi mk thành công";
            else return error;
        }
        public string RemoveAcc(string tk)
        {
            string delete = $"usp_delacc @tk";
            int result = Connect.Instance.excutenonquery(delete, out string error, new SqlParameter("@tk", tk));
            if (result > 0 && error == null) return "Xóa thành công";
            else return error;
        }
        public string LastLog(string tk)
        {
            string select = $"select top 1 checkin from history where tk= @tk order by checkin desc ";
            return Connect.Instance.excutescalar(select, out string error, new SqlParameter("@tk", tk)).ToString();
        }
    }
}
