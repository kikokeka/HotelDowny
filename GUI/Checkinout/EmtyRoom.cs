using BLL;
using DTO;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.Checkinout
{
    public partial class EmtyRoom : Form
    {
        private static EmtyRoom instance;
        public static EmtyRoom Instance
        {
            get { if (instance == null) instance = new EmtyRoom(); return EmtyRoom.instance; }
            private set { EmtyRoom.instance = value; }
        }
        Guna2Button currentbutton;
        List<FlowLayoutPanel> lstpn = new List<FlowLayoutPanel>();
        List<Guna2Button> lstbtn = new List<Guna2Button>();
        string tenp;
        public EmtyRoom()
        {
            InitializeComponent();
            LoadRooms();
            pn_nhanp.Visible = false;
            dtpk_ngaynhan.Enabled = false;
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
            return true;
        }
        void LoadRooms()
        {
            pn_show.BringToFront();
            List<RoomType> lst_rt = RoomTypeBLL.Instance.GetRoomType("usp_getroomtype");
            foreach (RoomType rt in lst_rt)
            {
                Guna2Button bt = new Guna2Button()
                {
                    BorderRadius = 8,
                    Height = 60,
                    AutoSize = false,
                    Text = rt.Ten,
                    FillColor = Color.WhiteSmoke,
                    ForeColor = Color.Black,
                    Animated = true,
                    UseTransparentBackground = true,
                    TextAlign = (HorizontalAlignment)Left,
                    Dock = DockStyle.Top
                };
                pn_show.Controls.Add(bt);
                bt.BringToFront();
                bt.Click += Bt_Click;
                FlowLayoutPanel pn = new FlowLayoutPanel()
                {
                    AutoSize = true,
                    Tag = rt.Ten,
                    AutoScroll = true,
                    Dock = DockStyle.Top
                };
                pn_show.Controls.Add(pn);
                pn.BringToFront();
                List<Room> room = RoomBLL.Instance.GetRoom($"select * from room where status = N'Trống' and loai = N'{rt.Ten}' and tenp != ' '");
                foreach (Room ro in room)
                {
                    Guna2Button roombt = new Guna2Button()
                    {
                        BorderRadius = 8,
                        Width = 185,
                        Height = 127,
                        Animated = true,
                        UseTransparentBackground = true,
                        Tag = ro.loai,
                        FillColor = Color.Azure,
                    };
                    string time = RoomBLL.Instance.LastCheckout(ro.tenp);
                    if (time != "Chưa sử dụng") time += "ngày trước";
                    roombt.Text = ro.tenp + Environment.NewLine + time + Environment.NewLine + ro.dondep;
                    roombt.Click += Roombt_Click;
                    pn.Controls.Add(roombt);
                    lstbtn.Add(roombt);
                    switch (ro.dondep)
                    {
                        case "Đã dọn":
                            roombt.ForeColor = Color.Black;
                            break;
                        case "Chưa dọn":
                            roombt.ForeColor = Color.Sienna;
                            break;
                    }
                }
                lstpn.Add(pn);
            }
        }
        
        private void Roombt_Click(object sender, EventArgs e)
        {
            ctxmenu.Show(MousePosition);
            currentbutton = sender as Guna2Button;
            tenp = currentbutton.Text.Split(new string[] { Environment.NewLine }, StringSplitOptions.None)[0];
            if (currentbutton.Tag == "Chưa dọn")
                ctxmenu.Items[1].Enabled = false;
            else
                ctxmenu.Items[1].Enabled = true;
        }
        private void Bt_Click(object sender, EventArgs e)
        {
            Guna2Button button = (Guna2Button)sender;
            foreach (FlowLayoutPanel item in lstpn)
            {
                if (item.Tag.ToString() == button.Text)
                    item.Visible = !item.Visible;
            }
        }
        private void ctx_np_Click(object sender, EventArgs e)
        {
            DialogResult result = CusMessage.Show($"Thực hiện nhận phòng {tenp}", "Xác nhận", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                pn_nhanp.Visible = true;
                lb_message.Text = tenp;
                dtpk_ngaynhan.Value = DateTime.Now;
            }
        }

        private void ctx_dp_Click(object sender, EventArgs e)
        {
            DialogResult result = CusMessage.Show($"Yêu cầu dọn phòng {tenp}", "Xác nhận", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                string message = RoomBLL.Instance.Clear(tenp);
                if (message == "Yêu cầu thành công") 
                {
                    foreach (Guna2Button c in lstbtn)
                    {
                        if (c.Text == currentbutton.Text)
                        {
                            c.ForeColor = Color.Yellow;
                            c.Text = tenp + Environment.NewLine + currentbutton.Tag.ToString().Trim() + Environment.NewLine + "Chưa dọn";
                            CusMessage.Show("Yêu cầu thành công");
                        }
                    }
                }
                else
                    CusMessage.Show(message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bt_save_Click(object sender, EventArgs e)
        {
            if (!CheckValid()) return;
            DTO.Booking b = new DTO.Booking();
            b.mabill = BookingBLL.Instance.GetBillID();
            b.cccd = txt_cccd.Text;
            b.phong = lb_message.Text;
            b.type = "1";
            b.ngaynhan = dtpk_ngaynhan.Value;
            b.tientratruoc = int.Parse(txt_ttt.Text);
            b.tk = Account.logged.Tk;
            b.namekh = txt_namekh.Text;
            b.sdt = txt_sdt.Text;
            DialogResult result = CusMessage.Show("Xác nhận dặt phòng ?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                string message = CheckinoutBLL.Instance.Checkinonsite(b);
                if (message == "Nhận phòng thành công")
                {
                    txt_namekh.Clear();
                    txt_sdt.Clear();
                    txt_cccd.Clear();
                    txt_ttt.Clear();
                    lb_message.Text = "";
                    pn_nhanp.Visible = false;
                    foreach (Guna2Button c in lstbtn)
                    {
                        if (c.Text == currentbutton.Text) c.Dispose();
                    }
                    CusMessage.Show(message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    CusMessage.Show(message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}
