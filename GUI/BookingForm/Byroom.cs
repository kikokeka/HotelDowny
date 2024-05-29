using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using DTO;
using BLL;
using GUI.BookingForm;

namespace GUI.Booking
{
    public partial class Byroom : Form
    {
        private static Byroom instance;
        public static Byroom Instance
        {
            get { if (instance == null) instance = new Byroom(); return Byroom.instance; }
            private set { Byroom.instance = value; }
        }
        public static string mabill;
        int row, column;
        public Byroom()
        {
            InitializeComponent();
            dtpk_start.Value = DateTime.Now;
            dtpk_end.Value = DateTime.Now.AddDays(14);
            LoadColumn();
            LoadRows("usp_getroom");
            foreach (RoomType r in RoomTypeBLL.Instance.GetRoomType("usp_getroomtype"))
            {
                cbx_roomtype.Items.Add(r.Ten);
            }
            dtgrv_info.Name = "Phòng";
            cbx_roomtype.Text = cbx_roomtype.Items[0].ToString();
            cbx_type.Text = cbx_type.Items[0].ToString();
            Loaddata();
        }
        void LoadRows(string query)
        {
            DataGridViewRow r = new DataGridViewRow();
            r.CreateCells(dtgrv_info);
            r.HeaderCell.Value = "Phòng";
            dtgrv_info.Rows.Add(r);
            List<Room> roomtypeclean = RoomBLL.Instance.GetRoom(query);
            foreach (Room ro in roomtypeclean)
            {
                DataGridViewRow newRow = new DataGridViewRow();
                newRow.CreateCells(dtgrv_info);
                newRow.HeaderCell.Value = ro.tenp;
                dtgrv_info.Rows.Add(newRow);
            }
        }
        void ReloadRows()
        {
            dtgrv_info.Rows.Clear();
        }
        void LoadColumn()
        {
            DataGridViewTextBoxColumn cl = new DataGridViewTextBoxColumn();
            cl.HeaderText = "Lịch";
            dtgrv_info.Columns.Add(cl);
            DateTime start = dtpk_start.Value;
            DateTime end = dtpk_end.Value;
            while (start <= end)
            {
                DataGridViewTextBoxColumn column = new DataGridViewTextBoxColumn();
                column.HeaderText = start.ToString("yyyy-MM-dd");
                dtgrv_info.Columns.Add(column);
                start = start.AddDays(1);
            }
            dtgrv_info.Rows[0].DefaultCellStyle.BackColor = Color.White;
        }
        void ReloadColumns()
        {
            List<DataGridViewColumn> columnsToKeep = new List<DataGridViewColumn>();
            foreach (DataGridViewColumn cl in dtgrv_info.Columns)
            {
                if (cl.Name != "Phòng")
                {
                    columnsToKeep.Add(cl);
                }
            }
            foreach (DataGridViewColumn cl in columnsToKeep)
            {
                dtgrv_info.Columns.Remove(cl);
            }
        }
        void Loaddata()
        {
            pn_np.Visible = false;
            pn_insert.Visible = false;
            foreach (DataGridViewColumn column in dtgrv_info.Columns)
            {
                if (column.HeaderText != "Lịch")
                {
                    foreach (DataGridViewRow row in dtgrv_info.Rows)
                    {
                        DataGridViewCell cell = row.Cells[column.Index];
                        if (cell != null)
                        {
                            object b = BookingBLL.Instance.Getdata(row.HeaderCell.Value?.ToString(), column.HeaderText);
                            if (b != null)
                            {
                                DTO.Booking dp = (DTO.Booking)b;
                                string hoten = dp.namekh;
                                string status = dp.status;
                                switch (status)
                                {
                                    case "Đã nhận phòng":
                                        cell.Style.BackColor = Color.Pink;
                                        break;
                                    case "Chưa nhận phòng":
                                        cell.Style.BackColor = Color.Blue;
                                        break;
                                    case "Đã trả phòng":
                                        cell.Style.BackColor = Color.Yellow;
                                        break;

                                }
                                cell.Value = hoten;
                                cell.Tag = dp.mabill;
                            }
                        }
                    }
                }
            }
        }

        private void bt_find_Click(object sender, EventArgs e)
        {
            ReloadColumns();
            ReloadRows();
            string query = "select * from room";
            if (cbx_roomtype.Text == "Tất cả")
            {
                if (!string.IsNullOrEmpty(txt_name.Text))
                {
                    query += $" where tenp like N'%{txt_name.Text}%'";
                }
            }
            else
            {
                if (!string.IsNullOrEmpty(txt_name.Text))
                {
                    query += $" where loai = N'{cbx_roomtype.Text}' and tenp like N'%{txt_name.Text}%'";
                }
                else
                {
                    query += $" where Loai = N'{cbx_roomtype.Text}'";
                }
            }
            LoadColumn();
            LoadRows(query);
            Loaddata();
        }

        private void bt_add_Click(object sender, EventArgs e)
        {
            foreach (Control c in pn_insert.Controls)
            {
                if (c is UserControl) c.Dispose();
            }
            pn_np.Visible = false;
            pn_insert.Visible = true;
            Insert insert = new Insert();
            pn_insert.Controls.Add(insert);
            insert.Dock = DockStyle.Fill;
            insert.Disposed += Insert_Disposed;
        }

        private void Insert_Disposed(object sender, EventArgs e)
        {
            if (Insert.status == true) Loaddata();
        }
        private void ctx_update_Click(object sender, EventArgs e)
        {
            pn_logo.Visible = false;
            pn_np.Visible = false;
            pn_insert.Visible = true;
            foreach (Control c in pn_insert.Controls)
            {
                if (c is UserControl) c.Dispose();
            }
            Update update = new Update();
            pn_insert.Controls.Add(update);
            update.Dock = DockStyle.Fill;
            update.Disposed += Update_Disposed;
        }

        private void Update_Disposed(object sender, EventArgs e)
        {
            if (GUI.BookingForm.Update.status == true) Loaddata();
        }

        private void Form_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (RoomButton.tenphong != null)
            {
                bt_addroom.Enabled = false;
                Button btn = RoomButton.tenphong;
                btn.Size = new Size(78, 40);
                btn.Click += Btn_Click;
                flp_phong.Controls.Add(btn);
                flp_phong.Tag = btn.Text;
            }
        }
        private void bt_addroom_Click(object sender, EventArgs e)
        {
            RoomButton form = new RoomButton();
            form.Show();
            RoomButton.tenphong = null;
            form.FormClosed += Form_FormClosed;
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            bt_addroom.Enabled = true;
            (sender as Button).Dispose();
            RoomButton.tenphong = null;
        }

        private void ctx_np_Click(object sender, EventArgs e)
        {
            pn_insert.Visible = true;
            pn_logo.Visible = true;
            pn_np.Visible = true;
        }

        private void ctx_cancel_Click(object sender, EventArgs e)
        {
            DialogResult result = CusMessage.Show("Hủy đặt phòng ?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                string message = BookingBLL.Instance.Cancel(mabill);
                if (message == "Hủy đặt phòng thành công")
                {
                    DataGridViewCell cell = dtgrv_info.Rows[row].Cells[column];
                    cell.Value = null;
                    cell.Style.BackColor = Color.FromArgb(7, 19, 43);
                    cell.Tag = null;
                    CusMessage.Show(message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    CusMessage.Show(message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ctx_del_Click(object sender, EventArgs e)
        {
            DialogResult result = CusMessage.Show("Xóa đặt phòng ?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                string message = BookingBLL.Instance.Remove(mabill);
                if (message == "Xóa đặt phòng thành công")
                {
                    DataGridViewCell cell = dtgrv_info.Rows[row].Cells[column];
                    cell.Value = null;
                    cell.Style.BackColor = Color.FromArgb(7, 19, 43);
                    cell.Tag = null;
                    CusMessage.Show(message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else CusMessage.Show(message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bt_np_Click(object sender, EventArgs e)
        {
            DialogResult result = CusMessage.Show("Xác nhận nhận phòng ?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                if (RoomButton.tenphong == null) { lb_error.Text = "Vui lòng thêm phòng"; return; }
                DTO.Checkinout cko = new DTO.Checkinout();
                cko.mabill = mabill;
                cko.daycheckin = DateTime.Now;
                cko.phong = RoomButton.tenphong.Text;
                cko.type = cbx_type.Text;
                cko.tknhan = Account.logged.Tk;
                string message = CheckinoutBLL.Instance.Checkin(cko);
                if (message == "Nhận phòng thành công")
                {
                    DataGridViewCell cell = dtgrv_info.Rows[row].Cells[column];
                    cell.Style.BackColor = Color.Pink;
                    CusMessage.Show(message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else CusMessage.Show(message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void bt_refresh_Click(object sender, EventArgs e)
        {
            Loaddata();
        }

        private void dtgrv_info_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                row = e.RowIndex;
                column = e.ColumnIndex;
                DataGridViewCell selectedCell = dtgrv_info.Rows[e.RowIndex].Cells[e.ColumnIndex];
                if (selectedCell.Value != null && !string.IsNullOrEmpty(selectedCell.Value.ToString()))
                {
                    ctx_menu.Show(MousePosition);
                    if (selectedCell.Style.BackColor != Color.Blue)
                    {
                        ctx_menu.Items[0].Enabled = false;
                        ctx_menu.Items[1].Enabled = false;
                        ctx_menu.Items[2].Enabled = false;
                        ctx_menu.Items[3].Enabled = false;
                    }
                    else
                    {
                        ctx_menu.Items[0].Enabled = true;
                        ctx_menu.Items[1].Enabled = true;
                        ctx_menu.Items[2].Enabled = true;
                        ctx_menu.Items[3].Enabled = true;
                    }
                    mabill = selectedCell.Tag.ToString();
                    txt_namekh.Text = selectedCell.Value.ToString().Trim();
                }
                else
                {
                    bt_add_Click(sender, e);
                }
            }
        }
    }
}
