using BLL;
using DTO;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Menu = DTO.Menu;

namespace GUI.ManageSys
{
    public partial class MenuForm : Form
    {
        private static MenuForm instance;
        public static MenuForm Instance
        {
            get { if (instance == null) instance = new MenuForm(); return MenuForm.instance; }
            private set { MenuForm.instance = value; }
        }
        string name;
        string[] arr_id;
        bool iswaiting;
        public MenuForm()
        {
            InitializeComponent();
            Loaddata();
            pn_in4.Visible = false;
            pn_logo.Visible = false;
        }
        void Loaddata()
        {
            lsv_menu.Items.Clear();
            cbx_type.Text = "";
            txt_name.Text = txt_giaban.Text = txt_gianhap.Text = "";
            cbx_type.SelectedItem = null;
            List<Menu> lst_mn = MenuBLL.Instance.GetMenu("usp_getmenu");
            foreach (Menu m in lst_mn)
            {
                ListViewItem listViewItem = new ListViewItem(m.name);
                listViewItem.SubItems.Add(m.loai);
                listViewItem.SubItems.Add(m.giaban.ToString());
                listViewItem.SubItems.Add(m.gianhap.ToString());
                lsv_menu.Items.Add(listViewItem);
            }
            arr_id = new string[lst_mn.Count];
            for (int i = 0; i < lst_mn.Count; i++)
            {
                arr_id[i] = lsv_menu.Items[i].SubItems[0].Text.Trim();
            }
        }
        bool checkvalid()
        {
            if (txt_name.Text == "" || cbx_type.Text == "" || txt_giaban.Text == "" || txt_gianhap.Text == "")
            {
                CusMessage.Show("Vui lòng nhập đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            string id = txt_name.Text;
            List<string> lst = new List<string>() { id, cbx_type.Text,txt_gianhap.Text,txt_giaban.Text };
            string checkvalid = MenuBLL.Instance.checkvalid(bt_save.Tag.ToString(), lst, arr_id);
            if (checkvalid != "")
            {
                CusMessage.Show(checkvalid, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
        private void lsv_menu_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsv_menu.SelectedItems.Count > 0)
            {
                pn_in4.Visible = true;
                pn_logo.Visible = true;
                lb_message.Text = "Chỉnh sửa";
                bt_save.Tag = "Sửa";
                bt_save.Visible = true;
                bt_xoa.Visible = true;
                ListViewItem selectedItem = lsv_menu.SelectedItems[0];
                name = selectedItem.SubItems[0].Text.Trim();
                txt_name.Text = name;
                cbx_type.Text = selectedItem.SubItems[1].Text.Trim();
                txt_giaban.Text = selectedItem.SubItems[2].Text.Trim();
                txt_gianhap.Text = selectedItem.SubItems[3].Text.Trim();
                txt_name.Enabled = false;
            }
        }

        private void bt_add_Click(object sender, EventArgs e)
        {
            txt_name.Enabled = true;
            cbx_type.SelectedItem = null;
            txt_name.Text = txt_giaban.Text = txt_gianhap.Text;
            pn_in4.Visible = true;
            pn_logo.Visible = true;
            bt_save.Visible = true;
            bt_xoa.Visible = false;
            lb_message.Visible = true;
            lb_message.Text = "Thêm mới";
            bt_save.Tag = "Thêm";
        }

        private void bt_xoaall_Click(object sender, EventArgs e)
        {
            DialogResult result = CusMessage.Show("Xác nhận xóa toàn bộ dữ liệu của menu?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                MenuBLL.Instance.RemoveAll();
                Loaddata();
                pn_in4.Visible = false;
                bt_save.Visible = false;
                bt_xoa.Visible = false;
                lb_message.Text = "";
                CusMessage.Show("Xóa dữ liệu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else return;
        }

        private void bt_save_Click(object sender, EventArgs e)
        {
            if (checkvalid() == false) return;
            Menu m = new Menu();
            m.name = txt_name.Text;
            m.loai = cbx_type.Text;
            m.gianhap = int.Parse(txt_gianhap.Text);
            m.giaban = int.Parse(txt_giaban.Text);
            if (bt_save.Tag == "Sửa")
            {
                string message = MenuBLL.Instance.Fix(m);
                if (message == "Sửa thành công")
                {
                    Loaddata();
                    pn_in4.Visible = false;
                    bt_save.Visible = false;
                    bt_xoa.Visible = false;
                    CusMessage.Show(message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    CusMessage.Show(message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string message = MenuBLL.Instance.Add(m);
                if (message == "Thêm thành công")
                {
                    Loaddata();
                    pn_in4.Visible = false;
                    bt_save.Visible = false;
                    bt_xoa.Visible = false;
                    CusMessage.Show(message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    CusMessage.Show(message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bt_xoa_Click(object sender, EventArgs e)
        {
            DialogResult result =
                CusMessage.Show("Chắc chắn xóa?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                string message = MenuBLL.Instance.Remove(name);
                if (message == "Xóa thành công")
                {
                    Loaddata();
                    pn_in4.Visible = false;
                    bt_save.Visible = false;
                    bt_xoa.Visible = false;
                    lb_message.Text = "";
                    CusMessage.Show(message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    CusMessage.Show(message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else return;
        }

        private void txt_find_TextChanged(object sender, EventArgs e)
        {
            if (iswaiting) return;
            timer1.Start();
            iswaiting = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            lsv_menu.Items.Clear();
            List<Menu> lst_mn;
            if(txt_find.Text == "")
                lst_mn = MenuBLL.Instance.GetMenu("usp_getmenu");
            else
                lst_mn = MenuBLL.Instance.GetMenu($"usp_findmenu '{txt_find.Text}'");
            foreach (Menu m in lst_mn)
            {
                ListViewItem listViewItem = new ListViewItem(m.name);
                listViewItem.SubItems.Add(m.loai);
                listViewItem.SubItems.Add(m.giaban.ToString());
                listViewItem.SubItems.Add(m.gianhap.ToString());
                lsv_menu.Items.Add(listViewItem);
            }
            iswaiting = false;
        }
    }
}
