using BLL;
using DTO;
using GUI.ManageSys;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Security;
using System.Windows.Forms;

namespace GUI
{
    public partial class RoomButton : Form
    {
        private static RoomButton instance;
        public static RoomButton Instance
        {
            get { if (instance == null) instance = new RoomButton(); return RoomButton.instance; }
            private set { RoomButton.instance = value; }
        }
        public static Button tenphong;
        public static bool check = true;
        List<Button> roomallbtn = new List<Button>();
        List<Button> roombtn = new List<Button>();
        public RoomButton()
        {
            InitializeComponent();
            Addcontrol();
        }
        void Addcontrol()
        {
            List<RoomType> lst_rt = RoomTypeBLL.Instance.GetRoomType("usp_getroomtype");
            List<Room> lst_r = RoomBLL.Instance.GetRoom("usp_getroom");
            foreach (Room ro in lst_r)
            {
                Button bt = new Button()
                {
                    Width = 78,
                    Height = 78,
                    Text = ro.tenp,
                    Tag = ro.loai,
                    BackColor = Color.FromArgb(55, 71, 159),
                    ForeColor = Color.White
                };
                if (ro.status == "Chưa dọn") bt.BackColor = Color.Yellow;
                bt.Click += Bt_Click;
                flp_all.Controls.Add(bt);
                roombtn.Add(bt);
                roomallbtn.Add(bt);
            }
            foreach (RoomType rt in lst_rt)
            {
                TabPage tab = new TabPage(rt.Ten);
                tabControl.TabPages.Add(tab);
                FlowLayoutPanel flp = new FlowLayoutPanel();
                tab.Controls.Add(flp);
                flp.Dock = DockStyle.Fill;
                flp.BackColor = Color.LightSkyBlue;
                foreach (Button btn in roombtn)
                {
                    if (btn.Tag.ToString() == rt.Ten)
                    {
                        Button newbutton = new Button()
                        {
                            Width = 78,
                            Height = 78,
                            Text = btn.Text,
                            Tag = btn.Tag,
                            BackColor = btn.BackColor,
                            ForeColor = Color.White
                        };
                        
                        newbutton.Click += Newbutton_Click;
                        flp.Controls.Add(newbutton);
                        //roomallbtn.Add(newbutton);
                    }
                }
            }
        }
        public void selectroom(string tenp)
        {
            foreach(Button bt in roomallbtn)
            {
                if(bt.Text == tenp)
                {
                    tenphong = bt;
                    return;
                }
            }
        }

        private void Newbutton_Click(object sender, EventArgs e)
        {
            tenphong = sender as Button;
            this.Close();
        }

        private void Bt_Click(object sender, EventArgs e)
        {
            tenphong = sender as Button;
            this.Close();
        }
    }
}
