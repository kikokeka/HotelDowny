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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GUI.ManageSys
{
    public partial class AccForm : Form
    {
        List<string> id = new List<string>();
        public AccForm()
        {
            InitializeComponent();
            Main.Instance.lb_main.Text = "Quản lý tài khoản";
            pn_insert.Visible = false;
            Loaddata();
        }
        void Loaddata()
        {
            lsv_acc.Items.Clear();
            DataTable dt = AccountBLL.Instance.ManageAcc("usp_hislog");
            foreach (DataRow r in dt.Rows)
            {
                string tk = r["tk"].ToString();
                ListViewItem item = new ListViewItem(tk);
                id.Add(tk);
                string quyen = ((int)r["cap"] == 1) ? "Quản lý" : "Nhân viên";
                item.SubItems.Add(quyen);
                item.SubItems.Add(r["lastlog"].ToString());
                lsv_acc.Items.Add(item);
            }

        }
        private void bt_add_Click(object sender, EventArgs e)
        {
            pn_insert.Visible = true;
            bt_save.Tag = "Thêm";
            txt_tk.ReadOnly = false;
            lb_message.Text = "Thêm tài khoản";
            txt_tk.Clear();
            txt_mk.Clear();
            txt_xnmk.Clear();
        }

        private void bt_save_Click(object sender, EventArgs e)
        {
            Account a = new Account();
            a.Tk = txt_tk.Text;
            a.Mk = txt_mk.Text;
            string xnmk = txt_xnmk.Text;
            List<string> list = new List<string>() { a.Tk, a.Mk, xnmk };
            string error = AccountBLL.Instance.Checkvalid(id, bt_save.Tag.ToString(), list);
            lb_error.Text = error;
            if (error != "") return;
            if (bt_save.Tag == "Thêm")
            {
                a.Cap = 2;
                string message = AccountBLL.Instance.AddAcc(a);
                if(message=="Thêm thành công")
                {
                    ListViewItem item = new ListViewItem(a.Tk);
                    item.SubItems.Add("Nhân viên");
                    lsv_acc.Items.Add(item);
                    CusMessage.Show("Thêm tài khoản thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else CusMessage.Show(message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string message = AccountBLL.Instance.ChangMk(a.Tk, a.Mk);
                if(message=="Đổi mk thành công")
                    CusMessage.Show(message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else CusMessage.Show(message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            txt_tk.Clear();
            txt_mk.Clear();
            txt_xnmk.Clear();
            pn_insert.Visible = false;
        }

        private void lsv_acc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsv_acc.SelectedItems.Count > 0)
            {
                pn_insert.Visible = true;
                lb_message.Text = "Đổi mật khẩu";
                bt_save.Tag = "Sửa";
                txt_tk.ReadOnly = true;
                ListViewItem item = lsv_acc.SelectedItems[0];
                txt_tk.Text = item.SubItems[0].Text;
            }
        }

        private void bt_wage_Click(object sender, EventArgs e)
        {
            new Timekeeping().Show();
        }
    }
}
