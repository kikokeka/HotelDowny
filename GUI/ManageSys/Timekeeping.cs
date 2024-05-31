using BLL;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Excel = Microsoft.Office.Interop.Excel;

namespace GUI.ManageSys
{
    public partial class Timekeeping : Form
    {
        private static Timekeeping instance;
        public static Timekeeping Instance
        {
            get { if (instance == null) instance = new Timekeeping(); return Timekeeping.instance; }
            set => Timekeeping.instance = value;
        }
        public Timekeeping()
        {
            InitializeComponent();
            dtpk_ngay.CustomFormat = "MM/yyyy";
            Loaddata();
        }
        void Loaddata()
        {
            lsv_time.Items.Clear();
            DataTable dt = AccountBLL.Instance.ManageAcc($"usp_timework {dtpk_ngay.Value.Month},{dtpk_ngay.Value.Year}");
            foreach(DataRow r in dt.Rows)
            {
                ListViewItem item = new ListViewItem(r["tk"].ToString());
                string quyen = ((int)r["cap"] == 1) ? "Quản lý" : "Nhân viên";
                item.SubItems.Add(quyen);
                item.SubItems.Add(r["ToTalLoginTime"].ToString());
                lsv_time.Items.Add(item);
            }
        }

        private void dtpk_ngay_ValueChanged(object sender, EventArgs e)
        {
            Loaddata();
        }

        private void bt_export_Click(object sender, EventArgs e)
        {
            lsv_time.Tag = $"Chấm công tháng {dtpk_ngay.Value.ToString("MM-yyyy")}";
            Program.ExportListView(lsv_time);
        }

        private void bt_out_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
