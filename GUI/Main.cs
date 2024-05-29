using System;
using System.Windows.Forms;
using DTO;
using BLL;
using System.Diagnostics;
using GUI.Properties;
using GUI.ManageSys;
using GUI.Booking;
using GUI.Checkinout;
using GUI.Inventory;
using Guna.UI2.WinForms;
using System.Drawing;

namespace GUI
{
    public partial class Main : Form
    {
        private static Main instance;
        public static Main Instance
        {
            get { if (instance == null) instance = new Main(); return Main.instance; }
            private set { Main.instance = value; }
        }
        Form currentFormChild = null;
        string animation;
        public Main()
        {
            InitializeComponent();
            customsize();
            Log();
            bt_back.Tag = "menu";
            openform(new Trangchu());
        }
        #region Methods
        void Log()
        {
            int cap = Account.logged.Cap;
            if (cap > 1) bt_sys.Visible = false;
            if(cap==1) bt_sys.Visible = true;
        }
        internal void openform(Form childform)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Dispose();
            }
            currentFormChild = childform;
            childform.TopLevel = false;
            childform.FormBorderStyle = FormBorderStyle.None;
            childform.Dock = DockStyle.Fill;
            pn_body.Controls.Add(childform);
            pn_body.Tag = childform;
            childform.BringToFront();
            childform.Show();
            Check();
        }

        void customsize()
        {
            pn_supdp.Visible = false;
            pn_supttp.Visible = false;
        }

        void hidemenu()
        {
            pn_supdp.Visible = pn_supdp.Visible ? true : false;
            pn_supttp.Visible = pn_supttp.Visible ? true : false;
        }

        void Unload()
        {
            foreach(Control control in pn_body.Controls) { control.Dispose(); }
        }

        void showmenu(Panel pn)
        {
            if (animation == "Đặt phòng")
            {
                if (pn.Visible == false)
                {
                    hidemenu();
                    pn.Visible = true;
                }
                else
                {
                    pn.Visible = false;
                }
            }
            if (animation == "Thuê trả phòng")
            {
                if (pn.Visible == false)
                {
                    hidemenu();
                    pn.Visible = true;
                }
                else
                {
                    pn.Visible = false;
                }
            }
        }
        void Check()
        {
            if (bt_back.Tag == "back")
                bt_back.Image = Resource.Go_Back;
            else if (bt_back.Tag == "menu")
                bt_back.Image = Resource.Menu;
        }
        #endregion
        #region Events

        private void Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            LoginBLL.Instance.Logout();
            Application.Exit();
        }

        private void bt_booking_Click(object sender, EventArgs e)
        {
            animation = "Đặt phòng";
            showmenu(pn_supdp);
        }

        public void bt_ttp_Click(object sender, EventArgs e)
        {
            animation = "Thuê trả phòng";
            showmenu(pn_supttp);
        }

        private void bt_byroom_Click(object sender, EventArgs e)
        {
            bt_back.Tag = "menu";
            lb_main.Text = "Đặt phòng";
            openform(new Byroom());
        }

        private void bt_byday_Click(object sender, EventArgs e)
        {
            bt_back.Tag = "menu";
            lb_main.Text = "Đặt phòng";
            openform(new Byday());
        }

        private void bt_pc_Click(object sender, EventArgs e)
        {
            bt_back.Tag = "menu";
            lb_main.Text = "Phòng chờ";
            openform(new EmtyRoom());
        }

        private void bt_trangchu_Click(object sender, EventArgs e)
        {
            Unload();
            lb_main.Tag = "Trang chính";
            bt_back.Tag = "menu";
            openform(new Trangchu());
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            string link = @"https://www.facebook.com/duyd01";
            Process.Start(link);
        }

        private void bt_find_Click(object sender, EventArgs e)
        {
            bt_back.Tag = "menu";
            lb_main.Text = "Đặt phòng";
            openform(new Find());
        }

        public void bt_pdt_Click(object sender, EventArgs e)
        {
            bt_back.Tag = "menu";
            lb_main.Text = "Phòng đang thuê";
            openform(new RentRoom());
        }

        public void bt_pcd_Click(object sender, EventArgs e)
        {
            bt_back.Tag = "menu";
            lb_main.Text = "Phòng cần dọn";
            openform(new ClearRoom());
        }

        private void bt_lsu_Click(object sender, EventArgs e)
        {
            bt_back.Tag = "menu";
            lb_main.Text = "Lịch sử";
            openform(new Lichsu());
        }

        private void bt_qlk_Click(object sender, EventArgs e)
        {
            bt_back.Tag = "menu";
            lb_main.Text = "Quản lý kho";
            openform(new Status());
        }

        private void bt_qltc_Click(object sender, EventArgs e)
        {
            bt_back.Tag = "menu";
            lb_main.Text = "Quản lý thu chi khác";
            openform(new RevandExp());
        }

        private void bt_sys_Click(object sender, EventArgs e)
        {
            bt_back.Tag = "menu";
            lb_main.Text = "Quản lý hệ thống";
            openform(new SysMainForm());
        }

        private void bt_acc_Click(object sender, EventArgs e)
        {
            bt_back.Tag = "menu";
            lb_main.Text = "Tài khoản";
            openform(new CurrentAccount());
        }

        private void bt_back_Click(object sender, EventArgs e)
        {
            if (bt_back.Tag.ToString() == "back")
            {
                bt_back.Tag = "menu";
                openform(new SysMainForm());
                
            }
            else if (bt_back.Tag == "menu")
                pn_menu.Visible = !pn_menu.Visible ? true : false;
        }
        private void bt_logout_Click(object sender, EventArgs e)
        {
            LoginBLL.Instance.Logout();
            Login.Instance.Visible = true;
            this.Visible = false;
        }

        private void Main_VisibleChanged(object sender, EventArgs e)
        {
            lb_main.Text = "Quản lý khách sạn Downy";
            Log();
            openform(new Trangchu());
            customsize();
        }

        #endregion

        private void bt_qlk_MouseEnter(object sender, EventArgs e)
        {
            ((Guna2Button)sender).FillColor = Color.Plum;
        }

        private void bt_qlk_MouseLeave(object sender, EventArgs e)
        {
            ((Guna2Button)sender).FillColor = Color.DeepSkyBlue;
        }

        private void bt_byroom_MouseEnter(object sender, EventArgs e)
        {
            ((Button)sender).BackColor = Color.Yellow;
        }

        private void bt_byroom_MouseLeave(object sender, EventArgs e)
        {
            ((Button)sender).BackColor = Color.FromArgb(192, 255, 255);
        }
    }
}
