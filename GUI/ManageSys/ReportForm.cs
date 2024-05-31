using BLL;
using GUI.Checkinout;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace GUI.ManageSys
{
    public partial class ReportForm : Form
    {
        private static ReportForm instance;
        public static ReportForm Instance
        {
            get { if (instance == null) instance = new ReportForm(); return ReportForm.instance; }
            private set { ReportForm.instance = value; }
        }
        string startmenu, endmenu, startroom, endroom, startother, endother;
        public ReportForm()
        {
            InitializeComponent();
            dtpk_startmenu.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            dtpk_endmenu.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 29);
            dtpk_startroom.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            dtpk_endroom.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 29);
            dtpk_startother.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            dtpk_endother.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 29);
            Chart();
            Loadmenurevenue();
            Loadroomrevenue();
            Loadother();
            Loadloinhuan();
        }

        void Chart()
        {
            DateTime date = DateTime.Now;
            for (int i = 0; i < 8; i++)
            {
                DateTime day = date.AddDays(-7 + i);
                string ngay = day.ToString("d");
                object countmenu = MenuUseBLL.Instance.TotalMenu(ngay);
                if (countmenu != null)
                {
                    int totalmoney = countmenu.ToString() == "" ? 0 : (int)countmenu;
                    chart_menu.Series["Doanh thu Menu"].Points.AddXY(day, totalmoney);
                }
                object nhapkho = Function.Instance.Nhapkho(ngay, ngay);
                if (nhapkho != null)
                {
                    int totalmoney = nhapkho.ToString() == "" ? 0 : (int)nhapkho;
                    chart_menu.Series["Nhập Menu"].Points.AddXY(day, totalmoney);
                }
                DataTable countroom = RoomBLL.Instance.RevRoom(ngay, ngay);
                int moneyroom = countroom.Rows.Count <= 1 ? 0 : (int)countroom.Rows[0]["Tổng tiền"];
                chart_room.Series["Doanh thu phòng"].Points.AddXY(day, moneyroom);
                object tongthu = RevExpBLL.Instance.RevExp("Thu", day, day);
                if (tongthu != null)
                {
                    int totalmoney = tongthu.ToString() == "" ? 0 : (int)tongthu;
                    chart_other.Series["Thu"].Points.AddXY(day, totalmoney);
                }
                object tongchi = RevExpBLL.Instance.RevExp("Chi", day, day);
                if (tongchi != null)
                {
                    int totalmoney = tongchi.ToString() == "" ? 0 : (int)tongchi;
                    chart_other.Series["Chi"].Points.AddXY(day, totalmoney);
                }
            }
        }
        void Loadmenurevenue()
        {
            lsv_dtmenu.Items.Clear();
            double total = 0;
            startmenu = dtpk_startmenu.Value.ToString("yyyy-MM-dd");
            endmenu = dtpk_endmenu.Value.ToString("yyyy-MM-dd");
            DataTable data = Function.Instance.RevMenu(startmenu, endmenu);
            foreach (DataRow row in data.Rows)
            {
                ListViewItem item = new ListViewItem(row.ItemArray[0].ToString());
                for (int i = 1; i < row.ItemArray.Length; i++)
                {
                    item.SubItems.Add(row.ItemArray[i].ToString());
                }
                lsv_dtmenu.Items.Add(item);
            }
            foreach (ListViewItem item in lsv_dtmenu.Items)
            {
                string tien = item.SubItems[item.SubItems.Count - 1].Text;
                if (double.TryParse(tien, out double value))
                {
                    total += value;
                }
            }
            ListViewItem tong = new ListViewItem("Tổng doanh thu");
            tong.SubItems.Add("");
            tong.SubItems.Add(total.ToString());
            lsv_dtmenu.Items.Add(tong);
            lsv_dtmenu.Tag = $"Doanhthu menu từ {dtpk_startmenu.Value.ToString("dd-MM")} đến {dtpk_endmenu.Value.ToString("dd-MM")}";
        }
        void Loadroomrevenue()
        {
            double total = 0;
            lsv_dtp.Items.Clear();
            startroom = dtpk_startroom.Value.ToString("yyyy-MM-dd");
            endroom = dtpk_endroom.Value.ToString("yyyy-MM-dd");
            DataTable data = RoomBLL.Instance.RevRoom(startroom, endroom);
            foreach (DataRow row in data.Rows)
            {
                ListViewItem item = new ListViewItem(row.ItemArray[0].ToString());
                for (int i = 1; i < row.ItemArray.Length; i++)
                {
                    item.SubItems.Add(row.ItemArray[i].ToString());
                }
                lsv_dtp.Items.Add(item);
            }
            foreach (ListViewItem item in lsv_dtp.Items)
            {
                string tien = item.SubItems[item.SubItems.Count - 1].Text;
                if (double.TryParse(tien, out double value))
                {
                    total += value;
                }
            }
            ListViewItem tong = new ListViewItem("Tổng doanh thu");
            tong.SubItems.Add("");
            tong.SubItems.Add(total.ToString());
            lsv_dtp.Items.Add(tong);
            lsv_dtp.Tag = $"Doanhthu phóng từ {dtpk_startroom.Value.ToString("dd-MM")} đến {dtpk_endroom.Value.ToString("dd-MM")}";
        }


        void Loadother()
        {
            double total = 0;
            lsv_thuchi.Items.Clear();
            startother = dtpk_startother.Value.ToString("yyyy-MM-dd");
            endother = dtpk_endother.Value.ToString("yyyy-MM-dd");
            DataTable data = RevExpBLL.Instance.Revenue(startother, endother);
            foreach (DataRow row in data.Rows)
            {
                ListViewItem item = new ListViewItem(row.ItemArray[0].ToString());
                for (int i = 1; i < row.ItemArray.Length; i++)
                {
                    item.SubItems.Add(row.ItemArray[i].ToString());
                }
                lsv_thuchi.Items.Add(item);
            }
            foreach (ListViewItem item in lsv_thuchi.Items)
            {
                string tien = item.SubItems[item.SubItems.Count - 2].Text;
                if (double.TryParse(tien, out double value))
                {
                    total += value;
                }
            }
            ListViewItem tong = new ListViewItem("Tổng thu");
            tong.SubItems.Add("");
            tong.SubItems.Add(total.ToString());
            lsv_thuchi.Items.Add(tong);
            lsv_thuchi.Tag = $"Các khoản thu từ {dtpk_startother.Value.ToString("dd-MM")} đến {dtpk_endother.Value.ToString("dd-MM")}";
        }
        int GetTotalPrice(object obj)
        {
            return obj != null && int.TryParse(obj.ToString(), out int result) ? result : 0;
        }
        void AddChartPoints(Series series, Dictionary<string, int> points)
        {
            foreach (var point in points)
            {
                series.Points.AddXY(point.Key, point.Value);
            }
        }
        void Loadloinhuan()
        {
            chart_thu.Series["Thu"].Points.Clear();
            chart_chi.Series["Chi"].Points.Clear();
            dtpk_loinhuan.CustomFormat = "MM/yyyy";
            dtpk_loinhuan.ShowUpDown = true;

            int month = dtpk_loinhuan.Value.Month;
            int year = dtpk_loinhuan.Value.Year;
            string startmonth = $"{year}-{month}-01";
            string lastmonth = new DateTime(year, month, DateTime.DaysInMonth(year, month)).ToString("yyyy-MM-dd");

            int priceroom = GetTotalPrice(RoomBLL.Instance.Gettienp(startmonth, lastmonth));
            int totalprice = GetTotalPrice(CheckinoutBLL.Instance.RevBill(startmonth, lastmonth));
            int pricemenu = totalprice - priceroom;

            int totalthuother = GetTotalPrice(RevExpBLL.Instance.RevExp("Thu", DateTime.Parse(startmonth), DateTime.Parse(lastmonth)));

            AddChartPoints(chart_thu.Series["Thu"], new Dictionary<string, int>{
                { "Thu từ Phòng", priceroom },
                { "Thu từ Menu", pricemenu },
                { "Thu Khác", totalthuother }});

            lb_thu.Text = $"Tổng thu: {totalprice + totalthuother} VNĐ";

            int nhapmenu = GetTotalPrice(Function.Instance.ChiMenu(startmonth, lastmonth));
            int chikhac = GetTotalPrice(RevExpBLL.Instance.RevExp("Chi", DateTime.Parse(startmonth), DateTime.Parse(lastmonth)));

            AddChartPoints(chart_chi.Series["Chi"], new Dictionary<string, int>{
                { "Chi phí nhập Menu", nhapmenu },
                { "Chi phí Khác", chikhac }});

            lb_chi.Text = $"Tổng chi: {nhapmenu + chikhac} VNĐ";
            lb_loinhuan.Text = $"Lợi nhuận: {totalprice + totalthuother - nhapmenu - chikhac} VNĐ";
        }


        private void dtpk_startmenu_ValueChanged(object sender, EventArgs e)
        {
            startmenu = dtpk_startmenu.Value.ToString("yyyy-MM-dd");
            Loadmenurevenue();
        }

        private void dtpk_endmenu_ValueChanged(object sender, EventArgs e)
        {
            endmenu = dtpk_endmenu.Value.ToString("yyyy-MM-dd");
            Loadmenurevenue();
        }

        private void bt_exmenu_Click(object sender, EventArgs e)
        {
            Program.ExportListView(lsv_dtmenu, true);
        }

        private void bt_exroom_Click(object sender, EventArgs e)
        {
            Program.ExportListView(lsv_dtp, true);
        }

        private void bt_exother_Click(object sender, EventArgs e)
        {
            Program.ExportListView(lsv_thuchi, true);

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void dtpk_loinhuan_ValueChanged(object sender, EventArgs e)
        {
            Loadloinhuan();
        }
        private void dtpk_startroom_ValueChanged(object sender, EventArgs e)
        {
            startroom = dtpk_startroom.Value.ToString("yyyy-MM-dd");
            Loadroomrevenue();
        }

        private void dtpk_endroom_ValueChanged(object sender, EventArgs e)
        {
            endroom = dtpk_endroom.Value.ToString("yyyy-MM-dd");
            Loadroomrevenue();
        }

        private void dtpk_endother_ValueChanged(object sender, EventArgs e)
        {
            endother = dtpk_endother.Value.ToString("yyyy-MM-dd");
            Loadother();
        }

        private void dtpk_startother_ValueChanged(object sender, EventArgs e)
        {
            startother = dtpk_startother.Value.ToString("yyyy-MM-dd");
            Loadother();
        }
    }
}
