using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL;
using System.Windows.Forms;
using Guna.UI2.WinForms;

namespace GUI.Checkinout
{
    public partial class ClearRoom : Form
    {
        private static ClearRoom instance;
        public static ClearRoom Instance
        {
            get { if (instance == null) instance = new ClearRoom(); return ClearRoom.instance; }
            private set { ClearRoom.instance = value; }
        }
        Guna2Button currentbutton;
        List<Panel> lstpn = new List<Panel>();
        List<Guna2Button> lstbtn = new List<Guna2Button>();
        public ClearRoom()
        {
            InitializeComponent();
            LoadRooms();
        }
        void LoadRooms()
        {
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
                List<Room> roomtypeclean = RoomBLL.Instance.GetRoom($"select * from room where dondep = 1 and loai = N'{rt.Ten}'");
                foreach (Room ro in roomtypeclean)
                {
                    Guna2Button roombtn = new Guna2Button() 
                    {
                        Width = 185,
                        Height = 127,
                        Tag = "Chưa dọn",
                        BorderRadius = 8,
                        Animated = true,
                        UseTransparentBackground = true,
                        FillColor = Color.Azure
                    };
                    roombtn.Text = ro.tenp + Environment.NewLine + ro.status + Environment.NewLine + ro.loai;
                    switch (ro.status)
                    {
                        case "Trống":
                            roombtn.ForeColor = Color.FromArgb(0, 150, 136);
                            //roombtn.Tag = "Phòng chờ";
                            break;
                        case "Đang thuê":
                            roombtn.ForeColor = Color.Sienna;
                            //roombtn.Tag = "Đang thuê";
                            break;
                    }
                    roombtn.Click += Roombtn_Click;
                    pn.Controls.Add(roombtn);
                    lstbtn.Add(roombtn);
                }
                lstpn.Add(pn);
            }
        }

        private void Bt_Click(object sender, EventArgs e)
        {
            Guna2Button button = (Guna2Button)sender;
            foreach (Panel item in lstpn)
            {
                if (item.Tag.ToString() == button.Text)
                    item.Visible = !item.Visible;
            }
        }

        private void Roombtn_Click(object sender, EventArgs e)
        {
            ctxmenu.Show(MousePosition);
            currentbutton = sender as Guna2Button;
        }

        private void ctx_cleared_Click(object sender, EventArgs e)
        {
            string tenp = currentbutton.Text.Split(new string[] { Environment.NewLine }, StringSplitOptions.None)[0];
            DialogResult result = CusMessage.Show($"Phòng {tenp} đã được dọn?", "Xác nhận", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                string message = RoomBLL.Instance.Cleared(tenp);
                if (message == $"Phòng {tenp} đã được dọn") 
                {
                    foreach (Guna2Button c in lstbtn)
                    {
                        if (c.Text == currentbutton.Text) c.Dispose();
                    }
                    CusMessage.Show(message);
                }
                else CusMessage.Show(message,"Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
    }
}
