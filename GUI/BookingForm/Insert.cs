using BLL;
using DTO;
using GUI.Booking;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.BookingForm
{
    public partial class Insert : UserControl
    {
        public static bool status = false;
        public Insert()
        {
            InitializeComponent();
            dtpk_ngaynhan.MinDate = DateTime.Now;
            dtpk_ngaytra.MinDate = DateTime.Now.AddHours(2);
            dtpk_ngaynhan.CustomFormat = "dd/MM/yyyy HH:mm:ss";
            dtpk_ngaytra.CustomFormat = "dd/MM/yyyy HH:mm:ss";
        }
        bool CheckValid()
        {
            List<string> lst = new List<string>();
            lst.Add(txt_cccd.Text);
            if (txt_ttt.Text == "") txt_ttt.Text = "0";
            lst.Add(txt_ttt.Text);
            lst.Add(txt_namekh.Text);
            lst.Add(txt_sdt.Text);
            string checkvalid = BookingBLL.Instance.checkvalid(lst);
            if (checkvalid != "")
            {
                CusMessage.Show(checkvalid, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (flp_phong.Tag == null)
            {
                CusMessage.Show("Vui lòng thêm phòng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (dtpk_ngaynhan.Value >= dtpk_ngaytra.Value.AddHours(2))
            {
                CusMessage.Show("Thời gian nhận phải cách thời gian trả ít nhất 2 giờ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void bt_addroom_Click(object sender, EventArgs e)
        {
            RoomButton form = new RoomButton();
            form.Show();
            form.FormClosed += Form_FormClosed;
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

        private void Btn_Click(object sender, EventArgs e)
        {
            (sender as Button).Dispose();
            bt_addroom.Enabled = true;
        }

        private void bt_dp_Click(object sender, EventArgs e)
        {
            if (!CheckValid()) return;
            DialogResult result = CusMessage.Show("Xác nhận dặt phòng ?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                DTO.Booking b = new DTO.Booking();
                b.mabill = BookingBLL.Instance.GetBillID();
                b.cccd = txt_cccd.Text;
                b.phong = flp_phong.Tag.ToString().Trim();
                b.type = "0";
                b.ngaynhan = dtpk_ngaynhan.Value;
                b.ngaytra = dtpk_ngaytra.Value;
                b.tientratruoc = int.Parse(txt_ttt.Text);
                b.ghichu = txt_note.Text;
                b.tk = Account.logged.Tk;
                b.namekh = txt_namekh.Text;
                b.sdt = txt_sdt.Text;
                string message = BookingBLL.Instance.Add(b);
                if (message == "Đặt phòng thành công")
                {
                    CusMessage.Show(message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    status = true;
                    this.Dispose();
                }
                else
                    CusMessage.Show(message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}
