using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Management.Instrumentation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DTO;
using GUI.Properties;
using Guna.UI2.WinForms;


namespace GUI.Booking
{
    public partial class Byday : Form
    {
        private static Byday instance;
        public static Byday Instance
        {
            get { if (instance == null) instance = new Byday(); return Byday.instance; }
            private set { Byday.instance = value; }
        }
        Guna2Button currentbutton = new Guna2Button();
        string mabill;
        public Byday()
        {
            InitializeComponent();
            cbx_type.SelectedIndex = 0;
            pn_logo.Visible = false;
            pn_np.Visible = false;
            Loaddata();
        }
        void Loaddata()
        {
            flp_in4.Controls.Clear();
            DateTime btday = dtpk_day.Value;
            int i = 1;
            string query = $"usp_byday N'{btday}'";
            List<DTO.Booking> lst_bk = BookingBLL.Instance.GetByday(query);
            if (lst_bk.Count == 0)
            {
                Guna2HtmlLabel lb = new Guna2HtmlLabel()
                {
                    Text = "Không có đơn đặt phòng trong ngày này",
                    Font = new Font(Font.FontFamily, 15f),
                    AutoSize = false,
                    Size = new Size(250, 250),
                    TextAlignment = ContentAlignment.MiddleCenter,
                    Cursor = Cursors.Hand
                };
                flp_in4.Controls.Add(lb);
            }
            foreach (DTO.Booking book in lst_bk)
            {
                Panel pn = new Panel()
                {
                    Size = new Size(260, 210),
                    Tag = book.mabill,
                    BorderStyle = BorderStyle.FixedSingle,
                };
                Panel sup = new Panel()
                {
                    Size = new Size(260, 35),
                    Dock = DockStyle.Top,
                    BorderStyle = BorderStyle.FixedSingle
                };
                pn.Controls.Add(sup);
                sup.BringToFront();
                Guna2Button btn = new Guna2Button()
                {
                    Name = book.mabill,
                    Dock = DockStyle.Right,
                    FillColor = Color.FromArgb(240, 248, 255),
                    Size = new Size(45, 35),
                    Image = Resource.Menu_Vertical,
                    ImageSize = new Size(30,30),
                    Cursor = Cursors.Hand,
                    Tag = book.status,
                };
                btn.Click += Btn_Click;
                sup.Controls.Add(btn);
                Label lb = new Label()
                {
                    TextAlign = ContentAlignment.MiddleLeft,
                    Text = $" #{i}",
                    Dock = DockStyle.Fill,
                    ForeColor = Color.Red
                };
                sup.Controls.Add(lb);
                Label lb1 = new Label()
                {
                    Dock = DockStyle.Top,
                    Size = new Size(260, 35),
                    TextAlign = ContentAlignment.MiddleCenter,
                    Text = book.namekh,
                    BorderStyle = BorderStyle.FixedSingle,
                    Image = Resource.User,
                    ImageAlign = ContentAlignment.MiddleLeft
                };
                pn.Controls.Add(lb1);
                lb1.BringToFront();
                Label lb2 = new Label()
                {
                    Dock = DockStyle.Top,
                    Size = new Size(260, 35),
                    TextAlign = ContentAlignment.MiddleCenter,
                    Text = book.status,
                    BorderStyle = BorderStyle.FixedSingle,
                    Image = Resource.Sorting_Arrows_Horizontal1,
                    ImageAlign = ContentAlignment.MiddleLeft
                };
                if (lb2.Text == "Đã hủy phòng") lb2.ForeColor = Color.Red;
                else if (lb2.Text == "Đã nhận phòng") lb2.ForeColor = Color.Green;
                else if(lb2.Text =="Đã trả phòng") lb2.ForeColor = Color.YellowGreen;
                else lb2.ForeColor = Color.Black;
                pn.Controls.Add(lb2);
                lb2.BringToFront();
                Label lb3 = new Label()
                {
                    Dock = DockStyle.Top,
                    Size = new Size(260, 35),
                    TextAlign = ContentAlignment.MiddleCenter,
                    Text = $"{book.ngaynhan.ToString("dd/MM")} - {book.ngaytra?.ToString("dd/MM")}",
                    BorderStyle = BorderStyle.FixedSingle,
                    Image = Resource.Clock,
                    ImageAlign = ContentAlignment.MiddleLeft
                };
                pn.Controls.Add(lb3);
                lb3.BringToFront();
                Label lb4 = new Label()
                {
                    Dock = DockStyle.Top,
                    Size = new Size(260, 35),
                    TextAlign = ContentAlignment.MiddleCenter,
                    Text = book.sdt,
                    BorderStyle = BorderStyle.FixedSingle,
                    Image = Resource.Phone,
                    ImageAlign = ContentAlignment.MiddleLeft
                };
                pn.Controls.Add(lb4);
                lb4.BringToFront();
                Label lb5 = new Label()
                {
                    Dock = DockStyle.Top,
                    Size = new Size(260, 35),
                    TextAlign = ContentAlignment.MiddleCenter,
                    Text = book.phong,
                    BorderStyle = BorderStyle.FixedSingle,
                    Image = Resource.Empty_Bed,
                    ImageAlign = ContentAlignment.MiddleLeft
                };
                pn.Controls.Add(lb5);
                lb5.BringToFront();
                flp_in4.Controls.Add(pn);
                i++;
            }
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            ctx_menu.Show(MousePosition);
            currentbutton = sender as Guna2Button;
            mabill = currentbutton.Name;
            string status = currentbutton.Tag.ToString();
            switch (status)
            {
                case "Đã nhận phòng":
                    ctx_menu.Items[0].Enabled = false;
                    ctx_menu.Items[1].Enabled = false;
                    ctx_menu.Items[2].Enabled = false;
                    break;
                case "Đã hủy phòng":
                    ctx_menu.Items[0].Enabled = false;
                    ctx_menu.Items[1].Enabled = false;
                    ctx_menu.Items[2].Enabled = true;
                    break;
                case "Chưa nhận phòng":
                    ctx_menu.Items[0].Enabled = true;
                    ctx_menu.Items[1].Enabled = true;
                    ctx_menu.Items[2].Enabled = true;
                    break;
            }
        }

        private void bt_add_Click(object sender, EventArgs e)
        {
            DialogResult result = CusMessage.Show("Xác nhận nhận phòng ?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                if (RoomButton.tenphong == null)
                {
                    CusMessage.Show("Vui lòng thêm phòng","Thông báo",MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                DTO.Checkinout cko = new DTO.Checkinout();
                cko.mabill = mabill;
                cko.daycheckin = DateTime.Now;
                cko.phong = RoomButton.tenphong.Text;
                cko.type = cbx_type.Text;
                cko.tknhan = Account.logged.Tk;
                string message = CheckinoutBLL.Instance.Checkin(cko);
                if (message == "Nhận phòng thành công")
                {
                    Loaddata();
                    CusMessage.Show(message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else CusMessage.Show(message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bt_down_Click(object sender, EventArgs e)
        {
            dtpk_day.Value = dtpk_day.Value.AddDays(-1);
        }

        private void bt_up_Click(object sender, EventArgs e)
        {
            dtpk_day.Value = dtpk_day.Value.AddDays(1);
        }

        private void ctx_np_Click(object sender, EventArgs e)
        {
            pn_logo.Visible = pn_np.Visible = true;
        }

        private void bt_addroom_Click(object sender, EventArgs e)
        {
            RoomButton form = new RoomButton();
            form.Show();
            RoomButton.tenphong = null;
            form.FormClosed += Form_FormClosed;
        }

        private void Form_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (RoomButton.tenphong != null)
            {
                bt_addroom.Enabled = false;
                Button btn = RoomButton.tenphong;
                btn.Size = new Size(78, 40);
                btn.Click += Btn_Click1;
                flp_phong.Controls.Add(btn);
                flp_phong.Tag = btn.Text;
            }
        }

        private void Btn_Click1(object sender, EventArgs e)
        {
            (sender as Button).Dispose();
            bt_addroom.Enabled = true;
        }

        private void dtpk_day_ValueChanged(object sender, EventArgs e)
        {
            Loaddata();
        }

        private void ctx_cancel_Click(object sender, EventArgs e)
        {
            DialogResult result = CusMessage.Show("Hủy đặt phòng ?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                string message = BookingBLL.Instance.Cancel(mabill);
                if (message == "Hủy đặt phòng thành công")
                {
                    Loaddata();
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
                    Loaddata();
                    CusMessage.Show(message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else CusMessage.Show(message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
