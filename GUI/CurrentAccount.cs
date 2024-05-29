using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class CurrentAccount : Form
    {
        public CurrentAccount()
        {
            InitializeComponent();
            Loaddata();
        }
        void Loaddata()
        {
            Account acc = Account.logged;
            lb_last.Text = AccountBLL.Instance.Lastlog(acc.Tk);
            lb_user.Text = acc.Tk.ToString();
            string quyen = (acc.Cap == 1) ? "Quản lý" : "Nhân viên";
            lb_type.Text = quyen;
            if (lb_type.Text == "Nhân viên")
            {
                checkBox2.Checked = false;
                checkBox3.Checked = false;
                checkBox7.Checked = false;
                checkBox8.Checked = false;
            }
            else
            {
                checkBox2.Checked = true;
                checkBox3.Checked = true;
                checkBox7.Checked = true;
                checkBox8.Checked = true;
            }
        }

        private void bt_save_Click(object sender, EventArgs e)
        {

        }
    }
}
