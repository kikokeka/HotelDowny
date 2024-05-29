using DTO;
using BLL;
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
    public partial class RevandExp : Form
    {
        int index;
        int id;
        private static RevandExp instance;
        public static RevandExp Instance
        {
            get { if (instance == null) instance = new RevandExp(); return RevandExp.instance; }
            private set { RevandExp.instance = value; }
        }
        public RevandExp()
        {
            InitializeComponent();
            cbx_type.SelectedIndex = 0;
            dtpk_ngay.CustomFormat = "dd/MM/yyyy hh:mm";
            dtpk_start.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            dtpk_end.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 29);
            Loaddata();
        }
        void Loaddata()
        {
            pn_update.Visible = false;
            lsv_thuchi.Items.Clear();
            List<RevExp> re = RevExpBLL.Instance.GetRE($"usp_getre '{dtpk_start.Value}','{dtpk_end.Value}'");
            foreach (RevExp exp in re)
            {
                ListViewItem listViewItem = new ListViewItem(exp.ngay.ToString());
                listViewItem.SubItems.Add(exp.loai);
                listViewItem.SubItems.Add(exp.gia.ToString());
                listViewItem.SubItems.Add(exp.noidung);
                listViewItem.SubItems.Add(exp.tk);
                listViewItem.SubItems.Add(exp.mathuchi.ToString());
                lsv_thuchi.Items.Add(listViewItem);
            }
        }
        private void bt_add_Click(object sender, EventArgs e)
        {
            bt_xoa.Visible = false;
            bt_save.Tag = "Thêm";
            pn_update.Visible = true;
            lb_message.Text = "Thêm mới";
            txt_gia.Text = txt_nd.Text = "";
        }

        private void bt_save_Click(object sender, EventArgs e)
        {
            string error = RevExpBLL.Instance.CheckValid(txt_gia.Text, txt_nd.Text);
            if (error != "")
            {
                lb_error.Text = error;
                return;
            }
            RevExp re = new RevExp();
            re.ngay = dtpk_ngay.Value;
            re.loai = cbx_type.Text;
            re.gia = int.Parse(txt_gia.Text);
            re.noidung = txt_nd.Text;
            re.tk = Account.logged.Tk;
            if (bt_save.Tag == "Thêm")
            {
                string message = RevExpBLL.Instance.Add(re);
                if (message == "Thêm thành công")
                {
                    Loaddata();
                    txt_nd.Clear();
                    txt_gia.Clear();
                    CusMessage.Show(message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else CusMessage.Show(message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                re.mathuchi = id;
                string message = RevExpBLL.Instance.Fix(re);
                if(message=="Sửa thành công")
                {
                    Loaddata();
                    CusMessage.Show("Cập nhật thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else CusMessage.Show(message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lsv_thuchi_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsv_thuchi.SelectedItems.Count > 0)
            {
                pn_update.Visible = true;
                lb_message.Text = "Chỉnh sửa";
                bt_save.Tag = "Sửa";
                bt_xoa.Visible = true;
                ListViewItem selectedItem = lsv_thuchi.SelectedItems[0];
                index = selectedItem.Index;
                string id = selectedItem.SubItems[5].Text;
                this.id = int.Parse(id);
                dtpk_ngay.Value = DateTime.Parse(selectedItem.SubItems[0].Text);
                cbx_type.Text = selectedItem.SubItems[1].Text;
                txt_gia.Text = selectedItem.SubItems[2].Text;
                txt_nd.Text = selectedItem.SubItems[3].Text;
            }

        }

        private void bt_xoa_Click(object sender, EventArgs e)
        {
            DialogResult result = CusMessage.Show("Bạn có chắc chắn xóa?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                string message = RevExpBLL.Instance.Del(id);
                if (message=="Xóa thành công")
                {
                    lsv_thuchi.Items.RemoveAt(index);
                    pn_update.Visible = false;
                    CusMessage.Show("Xóa thành công");
                }
                else CusMessage.Show(message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
