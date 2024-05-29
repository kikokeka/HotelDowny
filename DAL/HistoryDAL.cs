using System;
using System.Collections.Generic;
using System.Data;
using DTO;

namespace DAL
{
    public class HistoryDAL
    {
        private static HistoryDAL instance;

        public static HistoryDAL Instance
        {
            get { if (instance == null) instance = new HistoryDAL(); return HistoryDAL.instance; }
            set => HistoryDAL.instance = value;
        }
        public string AddHistory(Account acc)
        {
            string check;
            Account login = AccountDAL.Instance.Login(acc);
            check = login.Tk;
            if(check !="Tài khoản không tồn tại"&&check!="Sai mật khẩu")
            {
                Account.logged = login;
                string insert = $"insert into history(tk,checkin) values ('{check}','{DateTime.Now}')";
                Connect.Instance.excutenonquery(insert, out string error);
            }
            return check;
        }
        public void UpdateHistory()
        {
            string update = $"update history set checkout = '{DateTime.Now}' where tk = '{Account.logged.Tk}' and checkout is null";
            Connect.Instance.excutenonquery(update, out string error);
        }
        public List<History> GetHistory(string query)
        {
            List<History> list = new List<History>();
            DataTable data = Connect.Instance.taobang(query);
            foreach(DataRow row in data.Rows)
            {
                History h = new History(row);
                list.Add(h);
            }
            return list;
        }
    }
}
