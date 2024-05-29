using BLL;
using DTO;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace GUI.ManageSys
{
    public partial class RoomForm : Form
    {
        private static RoomForm instance;
        public static RoomForm Instance
        {
            get { if (instance == null) instance = new RoomForm(); return RoomForm.instance; }
            private set { RoomForm.instance = value; }
        }
        Room r;
        string[] arr_id;
        bool iswaiting;
        public RoomForm()
        {
            InitializeComponent();
            pn_in4.Visible = false;
            pn_logo.Visible = false;
            Loaddata();
            if (cbx_type.Items.Count <= 0)
            {
                foreach (RoomType r in RoomTypeBLL.Instance.GetRoomType("usp_getroomtype"))
                {
                    cbx_type.Items.Add(r.Ten);
                }
            }
            cbx_type.SelectedIndex = 0;
        }
        void Loaddata()
        {
            lsv_room.Items.Clear();
            List<Room> lst_r = RoomBLL.Instance.GetRoom("usp_getroom");
            foreach(Room r in lst_r)
            {
                ListViewItem listViewItem = new ListViewItem(r.tenp);
                listViewItem.SubItems.Add(r.loai);
                listViewItem.SubItems.Add(r.mota);
                listViewItem.Tag = r;
                lsv_room.Items.Add(listViewItem);
            }
            arr_id = new string[lst_r.Count];
            for (int i = 0; i < lst_r.Count; i++)
            {
                arr_id[i] = lsv_room.Items[i].SubItems[0].Text.Trim();
            }
        }
        bool CheckValid()
        {
            string id = txt_name.Text;
            if (bt_save.Tag == "Thêm")
            {
                string checkvalid = RoomBLL.Instance.checkvalid(id, cbx_type.Text, arr_id, id);
                if (checkvalid != "")
                {
                    CusMessage.Show(checkvalid, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            return true;
        }
        private void bt_xoaall_Click(object sender, EventArgs e)
        {
            DialogResult result = CusMessage.Show("Xác nhận xóa toàn bộ dữ liệu?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                string mess = RoomBLL.Instance.RemoveAll();
                if (mess == "Xóa dữ liệu thành công")
                {
                    Loaddata();
                    CusMessage.Show(mess, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else CusMessage.Show(mess, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bt_add_Click(object sender, EventArgs e)
        {
            foreach (Control c in pn_in4.Controls)
            {
                if (c is Guna2TextBox tb) tb.Clear();
            }
            txt_name.Enabled = true;
            pn_in4.Visible = true;
            pn_logo.Visible = true;
            bt_xoa.Visible = false;
            bt_save.Tag = "Thêm";
            lb_message.Text = "Thêm mới";
        }

        private void bt_save_Click(object sender, EventArgs e)
        {
            if (!CheckValid()) return;
            Room ro = new Room();
            ro.tenp = txt_name.Text;
            ro.loai = cbx_type.Text;
            ro.mota = txt_mota.Text;
            if (bt_save.Tag == "Sửa")
            {
                string message = RoomBLL.Instance.Fix(r.tenp, ro);

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
                
                string message = RoomBLL.Instance.Add(ro);
                if (message == "Thêm thành công")
                {
                    Loaddata();
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
                string message = RoomBLL.Instance.Remove(r.tenp);
                if (message == "Xóa thành công")
                {
                    Loaddata(); CusMessage.Show(message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            lsv_room.Items.Clear();
            List<Room> lst_r;
            if (txt_find.Text == "")
                lst_r = RoomBLL.Instance.GetRoom("usp_getroom");
            else
                lst_r = RoomBLL.Instance.GetRoom($"usp_findroom '{txt_find.Text}'");
            foreach (Room r in lst_r)
            {
                ListViewItem listViewItem = new ListViewItem(r.tenp);
                listViewItem.SubItems.Add(r.loai);
                listViewItem.SubItems.Add(r.mota);
                lsv_room.Items.Add(listViewItem);
            }
            iswaiting = false;
        }

        private void lsv_room_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsv_room.SelectedItems.Count > 0)
            {
                pn_in4.Visible = true;
                pn_logo.Visible = true;
                lb_message.Text = "Chỉnh sửa";
                bt_save.Tag = "Sửa";
                bt_save.Visible = true;
                bt_xoa.Visible = true;
                ListViewItem selectedItem = lsv_room.SelectedItems[0];
                r = selectedItem.Tag as Room;
                txt_name.Text = r.tenp;
                cbx_type.Text = selectedItem.SubItems[1].Text.Trim();
                txt_mota.Text = selectedItem.SubItems[2].Text.Trim();
                txt_name.Enabled = false;
            }
        }
    }
}
