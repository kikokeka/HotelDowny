using BLL;
using DTO;
using GUI.Checkinout;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.ManageSys
{
    public partial class HistorySys : Form
    {
        private static HistorySys instance;
        public static HistorySys Instance
        {
            get { if (instance == null) instance = new HistorySys(); return HistorySys.instance; }
            private set { HistorySys.instance = value; }
        }
        DataTable data;
        int currentPage = 1;
        string mabill;
        public HistorySys()
        {
            InitializeComponent();
            pn_in4.Visible = false;
            dtpk_start.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            dtpk_end.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 29);
            Loaddata();
            cbx_size.Text = "10";
            Loadrecord();
        }
        void Loaddata()
        {
            string a = dtpk_start.Value.ToString();
            string b = dtpk_end.Value.ToString();
            data = CheckinoutBLL.Instance.Bill(a,b);
        }
        void Loadrecord()
        {
            var pageData = data.AsEnumerable().Skip((currentPage - 1) * int.Parse(cbx_size.Text)).Take(int.Parse(cbx_size.Text));
            DataTable currentPageTable;
            if (pageData.Any())
            {
                currentPageTable = pageData.CopyToDataTable();
            }
            else
            {
                currentPageTable = data.Clone(); // Tạo DataTable rỗng với cùng cấu trúc
            }
            dtgrv_history.DataSource = currentPageTable;
            bt_previous.Enabled = currentPage > 1;
            bt_next.Enabled = currentPage < (data.Rows.Count + int.Parse(cbx_size.Text) - 1) / int.Parse(cbx_size.Text);
        }

        private void bt_previous_Click(object sender, EventArgs e)
        {
            if (currentPage > 1)
            {
                currentPage--;
                Loadrecord();
            }
        }

        private void bt_next_Click(object sender, EventArgs e)
        {
            if (currentPage < (data.Rows.Count + int.Parse(cbx_size.Text) - 1) / int.Parse(cbx_size.Text))
            {
                currentPage++;
                Loadrecord();
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Loaddata();
            Loadrecord();
        }

        private void cbx_size_SelectedIndexChanged(object sender, EventArgs e)
        {
            Loadrecord();
        }

        private void dtgrv_history_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                pn_in4.Visible = true;
                mabill = dtgrv_history.Rows[e.RowIndex].Cells["dataGridViewTextBoxColumn1"].Value.ToString();
                
                DTO.Checkinout cko = CheckinoutBLL.Instance.GetByid(mabill);
                lb_message.Text = cko.phong;
                txt_downprice.Text = cko.downprice.ToString();
                dtpk_np.Value = cko.daycheckin;
                dtpk_trap.Value = (DateTime)cko.daycheckout;
                cbx_type.Text = cko.type;
                txt_tienmenu.Text = cko.menuprice.ToString();
                txt_tienp.Text = cko.roomprice.ToString();
                txt_note.Text = cko.ghichu;
                txt_tong.Text = cko.totalprice.ToString();
                txt_ttt.Text = Function.Instance.Getttt(mabill).ToString();
                txt_tknhan.Text = cko.tknhan;
                txt_tktra.Text = cko.tktra;
                dtgrv_mu.DataSource = MenuUseBLL.Instance.GetService(mabill);
                if (dtgrv_mu.Rows.Count > 1)
                {
                    double sum = 0;
                    for (int i = 0; i < dtgrv_mu.Rows.Count; i++)
                    {
                        if (dtgrv_mu.Rows[i].Cells[2].Value != null)
                        {
                            string menu = dtgrv_mu.Rows[i].Cells[2].Value.ToString();
                            sum += int.Parse(menu);
                        }
                    }
                    DataTable dataTable = (DataTable)dtgrv_mu.DataSource;
                    DataRow newRow = dataTable.NewRow();
                    newRow["Tên"] = "Tổng tiền";
                    newRow["Thành tiền"] = sum;
                    dataTable.Rows.Add(newRow);
                }
            }
        }
        private void txt_find_TextChanged(object sender, EventArgs e)
        {
            DataView dataView = new DataView(data);
            string[] searchColumns = { "mabill", "phong", };
            List<string> conditions = new List<string>();
            foreach (string column in searchColumns)
            {
                conditions.Add($"{column} LIKE '%{txt_find}%'");
            }
            string filterCondition = string.Join(" OR ", conditions);
            dataView.RowFilter = filterCondition;
            dtgrv_history.DataSource = dataView;
        }

        private void bt_print_Click(object sender, EventArgs e)
        {
            new ReportBill("Đã trả phòng",mabill).Show();
        }
    }
}
