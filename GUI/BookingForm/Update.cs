using BLL;
using DTO;
using GUI.Booking;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.BookingForm
{
    public partial class Update : UserControl
    {
        DTO.Booking b;
        public static bool status = false;
        public Update()
        {
            InitializeComponent();
            dtpk_ngaynhan.CustomFormat = "dd/MM/yyyy HH:mm:ss";
            dtpk_ngaytra.CustomFormat = "dd/MM/yyyy HH:mm:ss";
            Loaddata();
        }
        #region Methods
        void Loaddata()
        {
            b = BookingBLL.Instance.GetBill("usp_byid @mabill",Byroom.mabill);
            txt_cccd.Text = b.cccd;
            txt_namekh.Text = b.namekh;
            txt_sdt.Text = b.sdt;
            txt_tus.Text = b.status;
            dtpk_ngaynhan.Value = b.ngaynhan;
            if (b.ngaytra != null)
            {
                dtpk_ngaytra.Value = b.ngaytra.Value;
            }
            txt_ttt.Text = b.tientratruoc.ToString();
            txt_note.Text = b.ghichu;
            RoomButton bt = new RoomButton();
            bt.selectroom(b.phong);
            button();
        }
        void button()
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
        bool CheckValid()
        {
            List<string> lst = new List<string>();
            lst.Add(txt_cccd.Text);
            if (txt_ttt.Text == "") txt_ttt.Text = "0";
            lst.Add(txt_ttt.Text);
            lst.Add(txt_namekh.Text);
            lst.Add(txt_sdt.Text);
            string checkvalid = BookingBLL.Instance.CheckValid(lst);
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
            return true;
        }
        #endregion
        #region Events
        private void bt_addroom_Click(object sender, EventArgs e)
        {
            RoomButton form = new RoomButton();
            form.Show();
            RoomButton.tenphong = null;
            form.FormClosed += Form_FormClosed;
        }

        private void Form_FormClosed(object sender, FormClosedEventArgs e)
        {
            button();
        }
        private void Btn_Click(object sender, EventArgs e)
        {
            bt_addroom.Enabled = true;
            (sender as Button).Dispose();
            RoomButton.tenphong = null;
            flp_phong.Tag = null;
        }

        private void bt_dp_Click(object sender, EventArgs e)
        {
            if (!CheckValid()) return;
            if (dtpk_ngaynhan.Value.AddHours(2) > dtpk_ngaytra.Value)
            {
                CusMessage.Show("Ngày trả phải sau ngày nhận ít nhất 2 giờ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if(RoomButton.tenphong == null)
            {
                CusMessage.Show("Vui lòng thêm phòng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DialogResult result = CusMessage.Show("Xác nhận sửa thông tin ?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                b.cccd = txt_cccd.Text;
                b.phong = flp_phong.Tag.ToString().Trim();
                b.ngaynhan = dtpk_ngaynhan.Value;
                b.ngaytra = dtpk_ngaytra.Value;
                b.tientratruoc = int.Parse(txt_ttt.Text);
                b.ghichu = txt_note.Text;
                b.tk = Account.logged.Tk;
                b.namekh = txt_namekh.Text;
                b.sdt = txt_sdt.Text;
                string message = BookingBLL.Instance.Fix(b);
                if (message == "Sửa đặt phòng thành công")
                {
                    CusMessage.Show(message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    status = true;
                    this.Dispose();
                }
                else
                    CusMessage.Show(message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion
    }
}
