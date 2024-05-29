using BLL;
using System;
using DTO;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using System.Linq;
using System.Collections.Generic;
using System.Management.Instrumentation;

namespace GUI.ManageSys
{
    public partial class RoomTypeForm : Form
    {
        private static RoomTypeForm instance;
        public static RoomTypeForm Instance
        {
            get { if (instance == null) instance = new RoomTypeForm(); return RoomTypeForm.instance; }
            private set { RoomTypeForm.instance = value; }
        }
        string name;
        string[] id;
        public RoomTypeForm()
        {
            InitializeComponent();
            pn_in4.Visible = false;
            bt_save.Visible = false;
            bt_xoa.Visible = false;
            Loaddata();
        }
        bool iswaiting;
        void Loaddata()
        {
            lsv_roomtype.Items.Clear();
            lb_message.Visible = pn_in4.Visible;
            foreach (Control c in pn_in4.Controls)
            {
                if (c is Guna2TextBox tb) tb.Clear();
            }
            List<RoomType> lst_r = RoomTypeBLL.Instance.GetRoomType("usp_getroomtype");
            foreach (RoomType r in lst_r)
            {
                ListViewItem listViewItem = new ListViewItem(r.Ten);
                listViewItem.SubItems.Add(r.blockdau.ToString());
                listViewItem.SubItems.Add(r.giablockdau.ToString());
                listViewItem.SubItems.Add(r.giagiosau.ToString());
                listViewItem.SubItems.Add(r.giaquadem.ToString());
                listViewItem.SubItems.Add(r.giangay.ToString());
                listViewItem.SubItems.Add(r.giathang.ToString());
                listViewItem.SubItems.Add(r.mota.ToString());
                lsv_roomtype.Items.Add(listViewItem);
            }
            id = new string[lst_r.Count];
            for (int i = 0; i < lst_r.Count; i++)
            {
                id[i] = lsv_roomtype.Items[i].SubItems[0].Text.Trim();
            }
        }
        bool CheckValid()
        {
            List<string> lst = new List<string>();
            List<Guna2TextBox> lst_txt = new List<Guna2TextBox>();
            foreach (Control c in pn_in4.Controls)
            {
                if (c is Guna2TextBox tb)
                {
                    if (tb.Text == "" && tb.Tag.ToString() != "7")
                    {
                        CusMessage.Show($"Vui lòng nhập đủ thông tin","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Error);
                        return false;
                    }
                    lst_txt.Add(tb);
                    lst.Add(tb.Text); 
                }
            }
            string checkvalid = RoomTypeBLL.Instance.CheckValid(id,bt_save.Tag.ToString(),lst);
            if (checkvalid != "")
            {
                CusMessage.Show(checkvalid, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
        private void bt_add_Click(object sender, EventArgs e)
        {
            txt_name.Enabled = true;
            foreach (Control c in pn_in4.Controls)
            {
                if(c is Guna2TextBox tb) tb.Clear();
            }
            pn_in4.Visible = true;
            bt_save.Visible = true;
            bt_xoa.Visible = false;
            lb_message.Visible = true;
            lb_message.Text = "Thêm mới";
            bt_save.Tag = "Thêm";
        }

        private void bt_xoa_Click(object sender, EventArgs e)
        {
            DialogResult result =
                CusMessage.Show("Chắc chắn xóa?","Thông báo",MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                string message = RoomTypeBLL.Instance.Remove(name);
                if (message == "Xóa thành công")
                {
                    Loaddata();
                    pn_in4.Visible=false;
                    bt_save.Visible=false;
                    bt_xoa.Visible=false;
                    lb_message.Text = "";
                    CusMessage.Show(message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    CusMessage.Show(message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else return;
        }

        private void bt_save_Click(object sender, EventArgs e)
        {
            if (CheckValid() == false) return;
            RoomType r = new RoomType();
            r.Ten = txt_name.Text;
            r.blockdau = int.Parse(txt_bldau.Text);
            r.giablockdau = int.Parse (txt_giabldau.Text);
            r.giagiosau = int.Parse(txt_giagiosau.Text);
            r.giaquadem = int.Parse(txt_giaqd.Text);
            r.giangay = int.Parse(txt_giangay.Text);
            r.giathang = int.Parse(txt_giathang.Text);
            r.mota = txt_mota.Text;
            if(bt_save.Tag == "Sửa")
            {
                string message = RoomTypeBLL.Instance.Fix(r);
                if (message == "Sửa thành công")
                {
                    Loaddata();
                    CusMessage.Show(message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    CusMessage.Show(message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string message = RoomTypeBLL.Instance.Add(r);
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

        private void bt_xoaall_Click(object sender, EventArgs e)
        {
            DialogResult result = CusMessage.Show("Xóa toàn bộ dữ liệu của loại phòng sẽ xóa hết dữ liệu của phòng", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(result == DialogResult.Yes)
            {
                string mess = RoomTypeBLL.Instance.RemoveAll();
                if (mess == "Xóa dữ liệu thành công")
                {
                    Loaddata();
                    pn_in4.Visible = false;
                    bt_save.Visible = false;
                    bt_xoa.Visible = false;
                    lb_message.Text = "";
                    CusMessage.Show("Xóa dữ liệu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    CusMessage.Show(mess, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }
        }


        private void txt_find_TextChanged(object sender, EventArgs e)
        {
            if(iswaiting) return;
            timer1.Start();
            iswaiting = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            lsv_roomtype.Items.Clear();
            List<RoomType> lst_r;
            if (txt_find.Text == "")
                lst_r = RoomTypeBLL.Instance.GetRoomType($"usp_getroomtype");
            else
                lst_r = RoomTypeBLL.Instance.GetRoomType($"usp_findtype '{txt_find.Text}'");
            foreach (RoomType r in lst_r)
            {
                ListViewItem listViewItem = new ListViewItem(r.Ten);
                listViewItem.SubItems.Add(r.blockdau.ToString());
                listViewItem.SubItems.Add(r.giablockdau.ToString());
                listViewItem.SubItems.Add(r.giagiosau.ToString());
                listViewItem.SubItems.Add(r.giaquadem.ToString());
                listViewItem.SubItems.Add(r.giangay.ToString());
                listViewItem.SubItems.Add(r.giathang.ToString());
                listViewItem.SubItems.Add(r.mota.ToString());
                lsv_roomtype.Items.Add(listViewItem);
            }
            iswaiting = false;
        }

        private void lsv_roomtype_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsv_roomtype.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = lsv_roomtype.SelectedItems[0];
                pn_in4.Visible = true;
                txt_name.Enabled = false;
                lb_message.Text = "Chỉnh sửa";
                name = selectedItem.SubItems[0].Text.Trim();
                txt_name.Text = name;
                txt_bldau.Text = selectedItem.SubItems[1].Text.Trim();
                txt_giabldau.Text = selectedItem.SubItems[2].Text.Trim();
                txt_giagiosau.Text = selectedItem.SubItems[3].Text.Trim();
                txt_giaqd.Text = selectedItem.SubItems[4].Text.Trim();
                txt_giangay.Text = selectedItem.SubItems[5].Text.Trim();
                txt_giathang.Text = selectedItem.SubItems[6].Text.Trim();
                txt_mota.Text = selectedItem.SubItems[7].Text.Trim();
                bt_save.Tag = "Sửa";
                bt_save.Visible = true;
                bt_xoa.Visible = true;
            }
        }
    }
}
