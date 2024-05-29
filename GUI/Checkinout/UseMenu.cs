using BLL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using DTO;
using Menu = DTO.Menu;
using GUI.Properties;

namespace GUI.Checkinout
{
    public partial class UseMenu : Form
    {
        List<Menu> lst_mn = new List<DTO.Menu>();
        List<Menu> lst_add = new List<Menu>();
        List<MenuUse> lst_sell = new List<MenuUse>();
        List<NumericUpDown> lst_slmenu = new List<NumericUpDown>();
        List<Label> lst_label = new List<Label>();
        List<Panel> lstpnmn = new List<Panel>();
        List<Panel> lstpnadd = new List<Panel>();
        List<Panel> lstpnselled = new List<Panel>();
        List<string> lstidremove = new List<string>();
        public UseMenu()
        {
            InitializeComponent();
            txt_tenp.Text ="Thêm dịch vụ phòng" + RentRoom.cko.phong;
            cbx_type.SelectedIndex = 0;
            LoadMenu();
        }
        void LoadMenu()
        {
            lst_mn.Clear();
            lst_slmenu.Clear();
            lst_add.Clear();
            foreach (Label lbl in lst_label)
            {
                lbl.Dispose();
            }
            foreach (Panel p in lstpnmn)
            {
                p.Dispose();
            }
            foreach (Panel p in lstpnadd)
            {
                p.Dispose();
            }
            foreach (Control c in flp_menu.Controls)
            {
                if (c.Tag.ToString() != "column")
                    c.Dispose();
            }
            foreach (Control c in flp_added.Controls)
            {
                if (c.Tag.ToString() != "column")
                    c.Dispose();
            }
            lst_mn = MenuBLL.Instance.GetMenu("usp_getmenu");
            
            foreach (Menu mn in lst_mn)
            {
                Panel pn = new Panel()
                {
                    Dock = DockStyle.Top,
                    Size = pn_column.Size,
                    BorderStyle = BorderStyle.FixedSingle,
                    Tag = mn.name
                };
                lstpnmn.Add(pn);    

                Label lbloai = new Label()
                { 
                    Text = mn.loai,
                    Size = lb_lmn.Size,
                    TextAlign = ContentAlignment.MiddleCenter,
                    Dock = DockStyle.Left
                };
                pn.Controls.Add(lbloai);
                lbloai.BringToFront();
                Label lbten = new Label() 
                { 
                    Text = mn.name,
                    Size = lb_nmn.Size,
                    TextAlign = ContentAlignment.MiddleCenter,
                    Dock = DockStyle.Left
                };
                pn.Controls.Add(lbten);
                lbten.BringToFront();
                Label lbgia = new Label() 
                {
                    Text = mn.giaban.ToString(),
                    Size = lb_giab.Size,
                    TextAlign = ContentAlignment.MiddleCenter,
                    Dock = DockStyle.Left
                };
                pn.Controls.Add(lbgia);
                lbgia.BringToFront();
                Button bt_add = new Button() 
                {
                    Image = Resource.Add,
                    Size = lb_bt.Size,
                    Dock = DockStyle.Left,
                    Tag = mn.name 
                };
                pn.Controls.Add(bt_add);
                bt_add.BringToFront();
                flp_menu.Controls.Add(pn);
                bt_add.Click += Bt_add_Click;
            }
            lst_sell = MenuUseBLL.Instance.GetDetails(RentRoom.cko.mabill);
            foreach(MenuUse mu in lst_sell)
            {
                Panel pn = new Panel()
                {
                    Dock = DockStyle.Top,
                    Size = pn_columnadded.Size,
                    BorderStyle = BorderStyle.FixedSingle,
                    Tag = mu.id
                };
                lstpnselled.Add(pn);
                Label lbmn = new Label()
                {
                    Text = mu.tenmenu,
                    Size = lb_mnsell.Size,
                    TextAlign = ContentAlignment.MiddleCenter,
                    Dock = DockStyle.Left
                };
                pn.Controls.Add(lbmn);
                lbmn.BringToFront() ;
                Label lbngay = new Label()
                {
                    Text = mu.ngay.ToString(),
                    Size = lb_ngay.Size,
                    TextAlign = ContentAlignment.MiddleCenter,
                    Dock = DockStyle.Left
                };
                pn.Controls.Add(lbngay);
                lbngay.BringToFront();
                Label lbsl = new Label()
                {
                    Text = mu.soluong.ToString(),
                    Size = lb_sl.Size,
                    TextAlign = ContentAlignment.MiddleCenter,
                    Dock = DockStyle.Left
                };
                pn.Controls.Add(lbsl);
                lbsl.BringToFront();
                Label lbgia = new Label()
                {
                    Text = mu.thanhtien.ToString(),
                    Size = lb_price.Size,
                    TextAlign = ContentAlignment.MiddleCenter,
                    Dock = DockStyle.Left
                };
                pn.Controls.Add(lbgia);
                lbgia.BringToFront();
                Button bt_del = new Button()
                {
                    Image = Resource.Cancel,
                    Size = lb_btx.Size,
                    Dock = DockStyle.Left,
                    Tag = mu.id
                };
                pn.Controls.Add(bt_del);
                bt_del.BringToFront();
                bt_del.Click += Bt_del_Click;
                flp_added.Controls.Add(pn);
            }
        }

        private void Bt_del_Click(object sender, EventArgs e)
        {
            foreach(Panel pn in lstpnselled)
            {
                if (pn.Tag == (sender as Button).Tag) 
                {
                    lstidremove.Add(pn.Tag.ToString().Trim());
                    lstpnselled.Remove(pn);
                    pn.Dispose();
                    return;
                }
            }
        }

        private void Bt_add_Click(object sender, EventArgs e)
        {
            Menu mn = null;
            string tenmenu = (sender as Button).Tag.ToString();
            foreach (Menu m in lst_mn)
            {
                if (m.name == tenmenu)
                {
                    mn = m;
                    lst_add.Add(mn);
                }
            }
            foreach (Panel p in lstpnmn)
            {
                if (p.Tag.ToString() == tenmenu)
                    p.Visible = false;
            }
            Panel pn = new Panel()
            {
                Dock = DockStyle.Top,
                Size = pn_columnadded.Size,
                BorderStyle = BorderStyle.FixedSingle,
                Tag = mn.name
            };
            Label lbten = new Label()
            {
                Text = tenmenu,
                Size = lb_mnsell.Size,
                TextAlign = ContentAlignment.MiddleCenter,
                Dock = DockStyle.Left,
            };
            pn.Controls.Add(lbten);
            lbten.BringToFront();
            Label lbngay = new Label()
            {
                Text = DateTime.Now.ToString(),
                Size = lb_ngay.Size,
                TextAlign = ContentAlignment.MiddleCenter,
                Dock = DockStyle.Left,
            };
            pn.Controls.Add(lbngay);
            lbngay.BringToFront();
            NumericUpDown nmr = new NumericUpDown()
            {
                Font = new Font("Microsoft Sans Serif", 10, FontStyle.Regular),
                Minimum = 1,
                Maximum = 100,
                Size = lb_sl.Size,
                Dock = DockStyle.Left,
                Tag = tenmenu
            };
            pn.Controls.Add(nmr);
            nmr.ValueChanged += Nmr_ValueChanged;
            nmr.BringToFront();
            lst_slmenu.Add(nmr);
            Label lbprice = new Label()
            {
                Text = (mn.giaban * nmr.Value).ToString(),
                Size = lb_price.Size,
                TextAlign = ContentAlignment.MiddleCenter,
                Dock = DockStyle.Left,
                Tag = tenmenu
            };
            pn.Controls.Add(lbprice);
            lbprice.BringToFront();
            lst_label.Add(lbprice);
            Button bt_remove = new Button()
            {
                Image = Resource.Cancel,
                Size = lb_btx.Size,
                Dock = DockStyle.Left,
                Tag = tenmenu,
            };
            pn.Controls.Add(bt_remove);
            bt_remove.BringToFront();
            flp_added.Controls.Add(pn);
            lstpnadd.Add(pn);
            bt_remove.Click += Bt_remove_Click;
        }

        private void Bt_remove_Click(object sender, EventArgs e)
        {
            foreach (Panel p in lstpnmn)
            {
                if (p.Tag == (sender as Button).Tag)
                {
                    p.Visible = true;
                }
            }
            foreach (Panel p in lstpnadd)
            {
                if (p.Tag == (sender as Button).Tag)
                {
                    p.Visible = false;
                }
            }
            foreach (Menu mn in lst_add)
            {
                if (mn.name == (sender as Button).Tag.ToString())
                {
                    lst_add.Remove(mn);
                    break;
                }
            }
            foreach (NumericUpDown nmr in lst_slmenu)
            {
                if (nmr.Tag == (sender as Button).Tag)
                {
                    lst_slmenu.Remove(nmr); break;
                }
            }
        }

        private void Nmr_ValueChanged(object sender, EventArgs e)
        {
            int gia = 0;
            foreach (Menu mn in lst_mn)
            {
                if (mn.name == (sender as NumericUpDown).Tag.ToString())
                {
                    gia = mn.giaban;
                    break;
                }
            }
            foreach (Label lb in lst_label)
            {
                if (lb.Tag == (sender as NumericUpDown).Tag)
                {
                    lb.Text = (gia * (sender as NumericUpDown).Value).ToString();
                    //break;
                }
            }
        }

        private void bt_exit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void bt_save_Click(object sender, EventArgs e)
        {
            DialogResult result = 
                CusMessage.Show("Xác nhận cập nhật thông tin ?","Thông báo",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                if (lstidremove.Count > 0)
                {
                    string message = MenuUseBLL.Instance.Del(lstidremove);
                    if (message != "Xóa dịch vụ thành công")
                    {
                        CusMessage.Show(message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                foreach (NumericUpDown nmr in lst_slmenu)
                {
                    MenuUse mu = new MenuUse();
                    mu.id = MenuUseBLL.Instance.GetMuId();
                    mu.tenmenu = nmr.Tag.ToString().Trim();
                    mu.soluong = (int)nmr.Value;
                    mu.ngay = DateTime.Now;
                    mu.mabill = RentRoom.cko.mabill;
                    string message = MenuUseBLL.Instance.Add(mu);
                    if (message != "Thêm dịch vụ thành công")
                    {
                        CusMessage.Show(message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                CusMessage.Show("Cập nhật thành công","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
                this.Dispose();
            }

        }

        private void bt_f5_Click(object sender, EventArgs e)
        {
            LoadMenu();
        }
    }
}
