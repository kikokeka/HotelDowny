using System;
using System.Windows.Forms;

namespace GUI.ManageSys
{
    public partial class SysMainForm : Form
    {
        private static SysMainForm instance;
        public static SysMainForm Instance
        {
            get { if (instance == null) instance = new SysMainForm(); return SysMainForm.instance; }
            private set { SysMainForm.instance = value; }
        }
        public SysMainForm()
        {
            InitializeComponent();
            ChangeName();
        }
        void ChangeName()
        {
            bt_roomtype.Text += "\n\nLoại phòng";
            bt_room.Text += "\n\nPhòng";
            bt_tkp.Text += "\n\nTài khoản phụ";
            bt_menu.Text += "\n\nMenu";
            bt_history.Text += "\n\nLịch sử";
            bt_customer.Text += "\n\nKhách hàng";
            bt_report.Text += "\n\nThống kê";
            bt_tlk.Text += "\n\nThiết lập khác";
        }

        private void bt_roomtype_Click(object sender, EventArgs e)
        {
            Main.Instance.lb_main.Text = "Quản lý loại phòng";
            Main.Instance.bt_back.Tag = "back";
            Main.Instance.openform(new RoomTypeForm());
        }

        private void bt_room_Click(object sender, EventArgs e)
        {
            Main.Instance.lb_main.Text = "Quản lý phòng";
            Main.Instance.bt_back.Tag = "back";
            Main.Instance.openform(new RoomForm());
        }

        private void bt_menu_Click(object sender, EventArgs e)
        {
            Main.Instance.lb_main.Text = "Quản lý menu";
            Main.Instance.bt_back.Tag = "back";
            Main.Instance.openform(new MenuForm());
        }

        private void bt_customer_Click(object sender, EventArgs e)
        {
            Main.Instance.lb_main.Text = "Quản lý khách hàng";
            Main.Instance.bt_back.Tag = "back";
            Main.Instance.openform(new CustomerForm());
        }

        private void bt_tkp_Click(object sender, EventArgs e)
        {
            Main.Instance.lb_main.Text = "Quản lý tài khoản";
            Main.Instance.bt_back.Tag = "back";
            Main.Instance.openform(new AccForm());
        }

        private void bt_report_Click(object sender, EventArgs e)
        {
            Main.Instance.lb_main.Text = "Thống kê";
            Main.Instance.bt_back.Tag = "back";
            Main.Instance.openform(new ReportForm());
        }

        private void bt_history_Click(object sender, EventArgs e)
        {
            Main.Instance.lb_main.Text = "Lịch sử";
            Main.Instance.bt_back.Tag = "back";
            Main.Instance.openform(new HistorySys());
        }

        private void bt_tlk_Click(object sender, EventArgs e)
        {
            Main.Instance.lb_main.Text = "Thiết lập khác";
            Main.Instance.bt_back.Tag = "back";
            Main.Instance.openform(new Setup());
        }
    }
}
