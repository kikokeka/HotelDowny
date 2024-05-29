using BLL;
using DTO;
using GUI.Properties;
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
    public partial class Lichsu : Form
    {
        public Lichsu()
        {
            InitializeComponent();
            dtpk_start.CustomFormat = "yyyy-MM-dd hh:mm";
            dtpk_end.CustomFormat = "yyyy-MM-dd hh:mm";
            pn_in4.Visible = false;

            Loaddata();
        }
        internal static string mabill;
        void Loaddata()
        {
            List<DTO.Checkinout> lst = CheckinoutBLL.Instance.History();
            foreach(DTO.Checkinout bill in lst)
            {
                TimeSpan songay = DateTime.Now - bill.daycheckout.Value;
                int totalprice = bill.totalprice;
                Panel pn = new Panel()
                {
                    Size = new Size(260, 165),
                    Tag = bill.mabill,
                    BorderStyle = BorderStyle.FixedSingle,
                };
                Panel sup = new Panel()
                {
                    Size = new Size(260, 55),
                    Dock = DockStyle.Top,
                    BorderStyle = BorderStyle.FixedSingle,
                };
                pn.Controls.Add(sup);
                sup.BringToFront();
                Guna2Button btn = new Guna2Button()
                {
                    FillColor = Color.Azure,
                    ImageSize = new Size(30, 30),
                    Dock = DockStyle.Right,
                    Size = new Size(45, 55),
                    Image = Resource.Menu_Vertical,
                    Cursor = Cursors.Hand,
                    Tag = bill.mabill,
                };
                btn.Click += Btn_Click;
                sup.Controls.Add(btn);
                Label lb = new Label()
                {
                    TextAlign = ContentAlignment.MiddleLeft,
                    Text = $" {bill.phong}",
                    Dock = DockStyle.Fill,
                    ForeColor = Color.Red
                };
                sup.Controls.Add(lb);
                Label lbngay = new Label()
                {
                    Dock = DockStyle.Top,
                    AutoSize = false,
                    Size = new Size(260, 55),
                    TextAlign = ContentAlignment.MiddleCenter,
                    Text = $"{Math.Round(songay.TotalDays)} ngày trước",
                    Image = Resource.Calendar,
                    ImageAlign = ContentAlignment.MiddleLeft,
                    ForeColor = Color.Black
                };
                pn.Controls.Add(lbngay);
                lbngay.BringToFront();
                Label lb2 = new Label()
                {
                    Dock = DockStyle.Top,
                    Size = new Size(260, 55),
                    TextAlign = ContentAlignment.MiddleCenter,
                    Text = $"{totalprice} VNĐ",
                    Image = Resource.Cash,
                    ImageAlign = ContentAlignment.MiddleLeft,
                    ForeColor = Color.Black
                };
                pn.Controls.Add(lb2);
                lb2.BringToFront();
                flp_his.Controls.Add(pn);
            }
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            ctx_menu.Show(MousePosition);
            mabill = (sender as Guna2Button).Tag.ToString().Trim();
        }

        private void ctx_xem_Click(object sender, EventArgs e)
        {
            double total = 0;
            pn_in4.Visible = true;
            DTO.Checkinout bill = CheckinoutBLL.Instance.GetByid(mabill);
            object ttt = Function.Instance.Getttt(mabill);
            lb_tenp.Text = bill.phong;
            dtpk_start.Value = bill.daycheckin;
            dtpk_end.Value = (DateTime)bill.daycheckout;
            txt_tienp.Text = $"{bill.roomprice} VNĐ";
            txt_tienmenu.Text = $"{bill.menuprice} VNĐ";
            txt_ttt.Text = $"{ttt} VNĐ";
            txt_downprice.Text = $"{bill.downprice} VNĐ";
            int pay = bill.totalprice - (int)ttt;
            txt_pay.Text = $"{pay} VNĐ";
            txt_tong.Text = $"{bill.totalprice} VNĐ";
            txt_tkn.Text = bill.tknhan;
            txt_tktra.Text = bill.tktra;
            dtgrv_mu.DataSource = MenuUseBLL.Instance.GetService(mabill);
            if (dtgrv_mu.Rows.Count > 1)
            {
                
                for (int i = 0; i < dtgrv_mu.Rows.Count; i++)
                {
                    if (dtgrv_mu.Rows[i].Cells[2].Value != null)
                    {
                        string menu = dtgrv_mu.Rows[i].Cells[2].Value.ToString();
                        total += int.Parse(menu);
                    }
                }
            }
            DataTable dataTable = (DataTable)dtgrv_mu.DataSource;
            DataRow newRow = dataTable.NewRow();
            newRow["Tên"] = "Tổng tiền";
            newRow["Thành tiền"] = total.ToString();
            dataTable.Rows.Add(newRow);
        }

        private void ctx_print_Click(object sender, EventArgs e)
        {
            new ReportBill("Đã trả phòng",mabill).Show();
        }

        private void bt_print_Click(object sender, EventArgs e)
        {
            new ReportBill("Đã trả phòng",mabill).Show();
        }
    }
}
