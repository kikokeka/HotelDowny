using BLL;
using DTO;
using Guna.UI2.WinForms;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Menu = DTO.Menu;

namespace GUI.Inventory
{
    public partial class Status : Form
    {
        bool iswaiting;
        List<Guna2NumericUpDown> lst_nmr = new List<Guna2NumericUpDown>();
        string id;
        public Status()
        {
            InitializeComponent();
            dtpk_start.CustomFormat = "dd/MM/yyyy hh:mm";
            dtpk_end.CustomFormat = "dd/MM/yyyy hh:mm";
            pn_update.Visible = false;
            LoadKho("select * from inventory");
            LoadNhapkho();
        }
        void LoadKho(string query)
        {
            DataTable dt = InventoryBLL.Instance.GetKho(query);
            dtgrv_kho.DataSource = InventoryBLL.Instance.GetKho(query);
        }
        void LoadNhapkho()
        {
            DataTable data = InventoryBLL.Instance.GetKho($"select * from dbo.CalculateTotalInfo('{dtpk_start.Value}','{dtpk_end.Value}')");
            foreach (DataRow row in data.Rows)
            {
                int rowIndex = dtgrv_nhapkho.Rows.Add(row["Thời gian nhập kho"], row["Tổng số lượng"], row["Tổng giá"]);
                DataGridViewRow dataGridViewRow = dtgrv_nhapkho.Rows[rowIndex];
                for (int i = 0; i < dataGridViewRow.Cells.Count; i++)
                {
                    dataGridViewRow.Cells[i].Tag = row["id"];
                }
            }
        }
        void LoadMenu()
        {
            foreach(Control c in flp_dsmenu.Controls)
            {
                if(c.Tag.ToString()!="Column") c.Dispose();
            }
            List<Menu> lst_mn = MenuBLL.Instance.GetMenu("select * from menu");
            foreach (Menu mn in lst_mn)
            {
                Panel pn = new Panel()
                {
                    Size = new Size(310,30),
                    Dock = DockStyle.Top,
                    Tag = mn.name,
                };
                flp_dsmenu.Controls.Add(pn);
                Label lb = new Label()
                {
                    FlatStyle = FlatStyle.Flat,
                    Text = mn.name,
                    AutoSize = false,
                    Size = new Size(200,30),
                    TextAlign = ContentAlignment.MiddleLeft,
                    Dock = DockStyle.Left,
                    Tag = mn.name,
                };
                pn.Controls.Add(lb);
                Guna2NumericUpDown nmr = new Guna2NumericUpDown()
                {
                    Dock = DockStyle.Right,
                    FillColor = Color.FromArgb(128, 255, 255),
                    Size = new Size(100,30),
                    TextOffset = new Point(25,0),
                    Tag = mn.name,
                    ForeColor = Color.Black,
                    Value = 0
                };
                pn.Controls.Add(nmr);
                lst_nmr.Add(nmr);
            }
        }
        private void txt_find_TextChanged(object sender, EventArgs e)
        {
            if (iswaiting) return;
            timer1.Start();
            iswaiting = true;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            if (txt_find.Text == "")
                LoadKho("select * from inventory");
            else
                LoadKho($"usp_findinventory '{txt_find.Text}'");
            iswaiting = false;
        }

        private void bt_add_Click(object sender, EventArgs e)
        {
            bt_xoa.Visible = false;
            bt_save.Tag = "Thêm";
            pn_update.Visible = true;
            lb_mess.Text = "Thêm mới";
            dtpk_ngay.Value = DateTime.Now;
            LoadMenu();
        }

        private void bt_save_Click(object sender, EventArgs e)
        {
            bool check = false;
            if (bt_save.Tag.ToString() == "Thêm")
            {
                foreach (Guna2NumericUpDown nmr in lst_nmr)
                {
                    if (nmr.Value != 0)
                    {
                        check = true;
                        break;
                    }
                    else
                        continue;
                }
                if (check == false)
                {
                    CusMessage.Show("Vui lòng thêm menu");
                    return;
                }
                string id = InventoryBLL.Instance.GetId();
                string[] arr_name = new string[lst_nmr.Count];
                int[] arr_value = new int[lst_nmr.Count];
                for (int i = 0; i < lst_nmr.Count; i++)
                {
                    arr_name[i] = lst_nmr[i].Tag.ToString();
                    arr_value[i] = (int)lst_nmr[i].Value;
                }
                string message = InventoryBLL.Instance.Add(arr_name, arr_value, id, DateTime.Now);
                if (message == "Nhập kho thành công")
                {
                    LoadNhapkho();
                    CusMessage.Show("Nhập kho thành công");
                }
                else CusMessage.Show(message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bt_xoa_Click(object sender, EventArgs e)
        {

        }

        private void dtgrv_nhapkho_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                if (dtgrv_nhapkho.Rows[e.RowIndex].Cells[e.ColumnIndex].Tag == null)
                {
                    return;
                }
                lb_mess.Text = "Chỉnh sửa";
                bt_save.Tag = "Sửa";
                pn_update.Visible = true;
                string id = dtgrv_nhapkho.Rows[e.RowIndex].Cells[e.ColumnIndex].Tag.ToString();
                LoadMenu();
                List<DTO.Inventory> inv = InventoryBLL.Instance.GetNhapKho($"usp_getnhapkho '{id}'");
                // Tạo một danh sách để lưu trữ các tags đã được cập nhật
                HashSet<string> updatedTags = new HashSet<string>();

                foreach (DTO.Inventory item in inv)
                {
                    dtpk_ngay.Value = item.ngaynhap;

                    foreach (Guna2NumericUpDown nmr in lst_nmr)
                    {
                        if (nmr.Tag.ToString() == item.tenmenu)
                        {
                            nmr.Value = item.soluong;
                            updatedTags.Add(nmr.Tag.ToString());
                        }
                    }
                }

                // Đặt giá trị về 0 cho các Guna2NumericUpDown không có trong inv
                foreach (Guna2NumericUpDown nmr in lst_nmr)
                {
                    if (!updatedTags.Contains(nmr.Tag.ToString()))
                    {
                        nmr.Value = 0;
                    }
                }
            }
        }
    }
}
