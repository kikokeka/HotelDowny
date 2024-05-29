using DTO;
using BLL;
using System.Windows.Forms;
using System;
using GUI.ManageSys;

namespace GUI
{
    public partial class Trangchu : Form
    {
        private static Trangchu instance;
        public static Trangchu Instance
        {
            get { if (instance == null) instance = new Trangchu(); return Trangchu.instance; }
            private set { Trangchu.instance = value; }
        }
        public Trangchu()
        {
            InitializeComponent();
            Loaddata();
        }
        void Loaddata()
        {
            DateTime date = DateTime.Now;
            DateTime[] arr_d = new DateTime[8];
            for (int i = 0; i < 8; i++)
            {
                arr_d[i] = date.AddDays(-7 + i);
            }
            for(int i = 0;i < 8;i++)
            {
                object count = Function.Instance.Luotthue(arr_d[i]);
                if (count != null)
                    chart1.Series["Lượt thuê"].Points.AddXY(arr_d[i], (int)count);
            }
            chart1.ChartAreas[0].AxisX.Title = "Ngày";
            chart1.ChartAreas[0].AxisY.Title = "Lượt thuê phòng";
            int luot = (int)Function.Instance.Luotdangthue();
            lb_ttn.Text = $"Thuê trong ngày\n{luot} lượt";
            int pc = (int)Function.Instance.StatusRoom("Trống");
            lb_pc.Text = $"Phòng chờ\n{pc} phòng";
            int pdt = (int)Function.Instance.StatusRoom("Đang thuê");
            lb_pdt.Text = $"Phòng đang thuê\n{pdt} phòng";
            int pcd = (int)Function.Instance.Phongcandon();
            lb_pcd.Text = $"Phòng cần dọn\n{pcd} phòng";
        }

        private void bt_refresh_Click(object sender, EventArgs e)
        {
            Loaddata();
        }

        private void bt_tp_Click(object sender, EventArgs e)
        {
            Main.Instance.bt_ttp_Click(sender, e);
        }

        private void bt_trap_Click(object sender, EventArgs e)
        {
            Main.Instance.bt_pdt_Click(sender, e);
        }

        private void bt_donp_Click(object sender, EventArgs e)
        {
            Main.Instance.bt_pcd_Click(sender, e);
        }
    }
}
