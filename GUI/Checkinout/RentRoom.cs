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
    public partial class RentRoom : Form
    {
        public static DTO.Checkinout cko;
        private static RentRoom instance;
        public static RentRoom Instance
        {
            get { if (instance == null) instance = new RentRoom(); return RentRoom.instance; }
            private set { RentRoom.instance = value; }
        }
        List<FlowLayoutPanel> lstpn = new List<FlowLayoutPanel>();
        List<Guna2Button> lstbtn = new List<Guna2Button>();
        string mabill;
        int giosom, giomuon;
        Guna2Button currentbutton;
        public RentRoom()
        {
            InitializeComponent();
            lb_error.Text = "";
            txt_downprice.Text = "0"
;            dtpk_np.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            dtpk_trap.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            dtpk_trap.MaxDate = DateTime.Now.Date.AddHours(24);
            pn_note.Visible = false;
            pn_np.Visible = false;
            pn_doip.Visible= false;
            lb_message.TextAlign = ContentAlignment.MiddleRight;
            LoadRooms();
        }
        void LoadRooms()
        {
            pn_show.BringToFront();
            List<RoomType> lst_r = RoomTypeBLL.Instance.GetRoomType("usp_getroomtype");
            foreach (RoomType rt in lst_r)
            {
                Guna2Button bt = new Guna2Button()
                {
                    BorderRadius = 8,
                    Height = 60,
                    AutoSize = false,
                    Text = rt.Ten,
                    FillColor = Color.WhiteSmoke,
                    Animated = true,
                    UseTransparentBackground = true,
                    TextAlign = (HorizontalAlignment)Left,
                    Dock = DockStyle.Top,
                    ForeColor = Color.Black
                };
                pn_show.Controls.Add(bt);
                bt.BringToFront();
                bt.Click += Bt_Click;
                FlowLayoutPanel pn = new FlowLayoutPanel()
                {
                    AutoSize = true,
                    Tag = rt.Ten,
                    AutoScroll = true,
                    Dock = DockStyle.Top
                };
                pn_show.Controls.Add(pn);
                pn.BringToFront();
                List<Room> room = RoomBLL.Instance.GetRoom($"select * from room where status = N'Đang thuê' and loai = N'{rt.Ten}' and tenp != ' '");
                foreach (Room ro in room)
                {
                    Guna2Button roombt = new Guna2Button()
                    {
                        BorderRadius = 8,
                        Width = 185,
                        Height = 127,
                        Animated = true,
                        UseTransparentBackground = true,
                        Text = ro.tenp + Environment.NewLine + ro.dondep,
                        ImageAlign = HorizontalAlignment.Right,
                        ImageOffset = new Point(0, -40),
                        ImageSize = new Size(40, 40),
                        FillColor = Color.FromArgb(240, 248, 255)
                    };
                    DTO.Checkinout cko = CheckinoutBLL.Instance.GetBill(ro.tenp);
                    roombt.Tag = cko.mabill.Trim();
                    roombt.Click += Roombt_Click;
                    pn.Controls.Add(roombt);
                    lstbtn.Add(roombt);
                    switch (ro.dondep)
                    {
                        case "Đã dọn":
                            roombt.ForeColor = Color.Black;
                            break;
                        case "Chưa dọn":
                            roombt.ForeColor = Color.Sienna;
                            break;
                    }
                    switch (cko.type)
                    {
                        case "Thuê theo tháng":
                            roombt.Image = Resource.Baby_Calendar;
                            break;
                        case "Thuê theo ngày":
                            roombt.Image = Resource.Smiling_Sun;
                            break;
                        case "Thuê theo giờ":
                            roombt.Image = Resource.Clock;
                            break;
                        case "Thuê qua đêm":
                            roombt.Image = Resource.Night;
                            break;
                    }
                }
                lstpn.Add(pn);
            }
        }
        string TGthue(DateTime a, DateTime b)
        {
            TimeSpan tgthue = b - a;
            int days = tgthue.Days;
            int hours = tgthue.Hours;
            int minutes = tgthue.Minutes;
            string result = $"{Math.Abs(days)} ngày {Math.Abs(hours)} giờ {Math.Abs(minutes)} phút";
            if (days < 0 || hours < 0 || minutes < 0)
            {
                result = "-" + result;
            }
            return result;
        }
        void CheckTime(DateTime a, DateTime b, string type)
        {
            TimeSpan nhansom, tramuon;
            switch (type)
            {
                case "Thuê qua đêm":
                    nhansom = a.Hour < 21 ? a.Date.AddHours(21) - a : TimeSpan.Zero;
                    tramuon = b.Date > a.Date ? b - a.Date.AddDays(1).AddHours(9) : TimeSpan.Zero;
                    lb_nhansom.Text = $"Nhận sớm {nhansom.Hours} giờ {nhansom.Minutes} phút";
                    lb_tramuon.Text = $"Trả muộn: {(int)Math.Floor(tramuon.TotalHours)} giờ {tramuon.Minutes} phút";
                    break;
                case "Thuê theo ngày":
                    nhansom = a.Hour < 12 ? a.Date.AddHours(12) - a : TimeSpan.Zero;
                    tramuon = b.Hour >= 12 ? b - b.Date.AddHours(12) : TimeSpan.Zero;
                    lb_nhansom.Text = $"Nhận sớm {nhansom.Hours} giờ {nhansom.Minutes} phút";
                    lb_tramuon.Text = $"Trả muộn: {tramuon.Hours} giờ {tramuon.Minutes} phút";
                    break;
                //case "Thuê theo tháng":
                    
                    //break;
                default:
                    nhansom = tramuon = TimeSpan.Zero;
                    break;
            }
            if (b.Date == a.Date)
                nhansom = tramuon = TimeSpan.Zero;
            giosom = (int)Math.Round(nhansom.TotalHours);
            giomuon = (int)Math.Round(tramuon.TotalHours);
        }
        void LoadBill()
        {
            if (pn_np.Visible)
            {
                int tiensom,tienmuon;
                DateTime a = dtpk_np.Value;
                DateTime b = dtpk_trap.Value;
                lb_tgthue.Text = TGthue(a, b);
                RoomType rt = RoomTypeBLL.Instance.GetRoom(lb_message.Text);
                switch(cbx_type.Text)
                {
                    case "Thuê theo giờ":
                        int hours = (int)Math.Round((b - a).TotalHours);
                        hours = hours > rt.blockdau ? hours : rt.blockdau;
                        lb_nhansom.Text = "";
                        lb_tramuon.Text = "";
                        lb_tientg.Text = $"Tiền phòng {hours} giờ";
                        txt_tienp.Text = $"{rt.giablockdau + (hours - rt.blockdau) * rt.giagiosau}";
                        break;
                    case "Thuê qua đêm":
                        CheckTime(a, b, "Thuê qua đêm");
                        tiensom = giosom * rt.giagiosau;
                        tienmuon = giomuon * rt.giagiosau;
                        lb_tientg.Text = "Tiền phòng 1 đêm";
                        txt_tienp.Text = (rt.giaquadem + tiensom + tienmuon).ToString();
                        break;
                    case "Thuê theo ngày":
                        CheckTime(a, b, cbx_type.Text);
                        tiensom = giosom * rt.giagiosau;
                        tienmuon = giomuon * rt.giagiosau;
                        double ngay = (double)Math.Round((b - a).TotalDays);
                        if (ngay == 0) ngay = 1;
                        lb_tientg.Text = $"Tiền phòng {ngay} ngày";
                        txt_tienp.Text = (tiensom + tienmuon + rt.giangay * ngay).ToString();
                        break;
                    case "Thuê theo tháng":

                        break;
                }
            }
        }
        private void Roombt_Click(object sender, EventArgs e)
        {
            ctxmenu.Show(MousePosition);
            currentbutton = sender as Guna2Button;
            cko = CheckinoutBLL.Instance.GetBill((sender as Guna2Button).Text.Split(new string[] { Environment.NewLine }, StringSplitOptions.None)[0]);
        }

        private void Bt_Click(object sender, EventArgs e)
        {
            Guna2Button button = (Guna2Button)sender;
            foreach (FlowLayoutPanel item in lstpn)
            {
                if (item.Tag.ToString() == button.Text)
                    item.Visible = !item.Visible;
            }
        }

        private void ctx_swap_Click(object sender, EventArgs e)
        {
            pn_doip.Visible = true;
            pn_doip.BringToFront();
            Swaproom sw = new Swaproom();
            pn_doip.Controls.Add(sw);
            sw.Disposed += Sw_Disposed;
        }

        private void Sw_Disposed(object sender, EventArgs e)
        {
            pn_doip.Visible = false;
        }

        private void ctx_xem_Click(object sender, EventArgs e)
        {
            pn_note.Visible = true;
            pn_doip.Visible = false;
            pn_np.Visible = false;
            foreach(Control c  in pn_note.Controls)
            {
                if(c is UserControl) c.Dispose();
            }
            UpdateBill update = new UpdateBill();
            pn_note.Controls.Add(update);
            update.Dock = DockStyle.Fill;
            pn_note.BringToFront();
        }

        private void ctx_clear_Click(object sender, EventArgs e)
        {
            DialogResult result = CusMessage.Show($"Yêu cầu dọn phòng {cko.phong}", "Xác nhận", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                string message = RoomBLL.Instance.Clear(cko.phong);
                if (message == "Yêu cầu thành công")
                {
                    foreach (Guna2Button c in lstbtn)
                    {
                        if (c.Text == currentbutton.Text)
                        {
                            c.ForeColor = Color.Yellow;
                            c.Text = cko.phong + Environment.NewLine + "Chưa dọn";
                            CusMessage.Show("Yêu cầu thành công");
                        }
                    }
                }
                else
                    CusMessage.Show(message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ctx_del_Click(object sender, EventArgs e)
        {

        }

        private void ctx_menu_Click(object sender, EventArgs e)
        {
            UseMenu menu = new UseMenu();
            menu.ShowDialog();
        }

        private void ctx_checkout_Click(object sender, EventArgs e)
        {
            pn_doip.Visible = false;
            pn_note.Visible = true;
            pn_np.Visible = true;
            lb_message.Text = cko.phong;
            txt_ttt.Text = Function.Instance.Getttt(cko.mabill).ToString();
            cbx_type.Text = cko.type;
            dtpk_np.Value = cko.daycheckin;
            dtpk_trap.Value = DateTime.Now;
            dtgrv_mu.DataSource = MenuUseBLL.Instance.GetService(cko.mabill);
            if (dtgrv_mu.Rows.Count > 1)
            {
                double sum = 0;
                for(int i = 0;i<dtgrv_mu.Rows.Count;i++)
                {
                    if (dtgrv_mu.Rows[i].Cells[2].Value!=null)
                    {
                        string menu = dtgrv_mu.Rows[i].Cells[2].Value.ToString();
                        sum += int.Parse(menu);
                    }
                }
                txt_tienmenu.Text = sum.ToString();
                DataTable dataTable = (DataTable)dtgrv_mu.DataSource;
                DataRow newRow = dataTable.NewRow();
                newRow["Tên"] = "Tổng tiền";
                newRow["Thành tiền"] = txt_tienmenu.Text;
                dataTable.Rows.Add(newRow);
            }
            else
            {
                txt_tienmenu.Text = "0";
            }
            LoadBill();
            txt_tong.Text = (int.Parse(txt_tienp.Text) + int.Parse(txt_tienmenu.Text) - int.Parse(txt_ttt.Text)).ToString();
        }

        private void txt_ttt_TextChanged(object sender, EventArgs e)
        {
            if (txt_tienp.Text != "" && txt_tienmenu.Text != "" && txt_ttt.Text != "")
                txt_tong.Text = (int.Parse(txt_tienp.Text) + int.Parse(txt_tienmenu.Text) - int.Parse(txt_ttt.Text)).ToString();
        }

        private void cbx_type_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadBill();
        }

        private void dtpk_np_ValueChanged(object sender, EventArgs e)
        {
            LoadBill();
        }

        private void dtpk_trap_ValueChanged(object sender, EventArgs e)
        {
            LoadBill();
        }

        private void txt_tienmenu_TextChanged(object sender, EventArgs e)
        {
            if (txt_tienp.Text != "" && txt_tienmenu.Text != "" && txt_ttt.Text != "")
                txt_tong.Text = (int.Parse(txt_tienp.Text) + int.Parse(txt_tienmenu.Text) - int.Parse(txt_ttt.Text) - int.Parse(txt_downprice.Text)).ToString();
        }

        private void bt_save_Click(object sender, EventArgs e)
        {
            DialogResult result = CusMessage.Show("Xác nhận trả phòng?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                DTO.Checkinout checkinout = new DTO.Checkinout();
                checkinout.mabill = currentbutton.Tag.ToString().Trim();
                checkinout.daycheckin = dtpk_np.Value;
                checkinout.daycheckout = dtpk_trap.Value;
                checkinout.phong = cko.phong;
                checkinout.type = cbx_type.Text;
                checkinout.status = "1";
                checkinout.menuprice = int.Parse(txt_tienmenu.Text);
                checkinout.roomprice = int.Parse(txt_tienp.Text);
                checkinout.totalprice = int.Parse(txt_tong.Text) + int.Parse(txt_ttt.Text);
                checkinout.downprice = int.Parse(txt_downprice.Text);
                checkinout.ghichu = txt_note.Text;
                checkinout.tknhan = cko.tknhan;
                checkinout.tktra = Account.logged.Tk;
                string message = CheckinoutBLL.Instance.Checkout(checkinout);
                if(message =="Trả phòng thành công")
                {
                    
                    foreach (Guna2Button btn in lstbtn)
                    {
                        if (btn.Tag.ToString().Trim() == currentbutton.Tag.ToString().Trim())
                        {
                            btn.Dispose();
                            break;
                        }
                    }
                    pn_np.Visible = false;
                    CusMessage.Show("Trả phòng thành công");
                    return;
                }
                CusMessage.Show(message, "Thông báp", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txt_ttt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(int.TryParse(txt_ttt.Text,out _))
            {
                e.Handled = false;
            }
        }

        private void txt_downprice_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_downprice.Text))
            {
                // Đặt giá trị TextBox thành "0"
                txt_downprice.Text = "0";
                // Đặt con trỏ chuột vào cuối văn bản
                txt_downprice.SelectionStart = txt_downprice.Text.Length;
            }
            if (txt_tienp.Text != "" && txt_tienmenu.Text != "" && txt_ttt.Text != "")
                txt_tong.Text = (int.Parse(txt_tienp.Text) + int.Parse(txt_tienmenu.Text) - int.Parse(txt_ttt.Text) - int.Parse(txt_downprice.Text)).ToString();
        }

        private void txt_downprice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsDigit(e.KeyChar))
            {
                if (txt_downprice.Text == "0")
                {
                    // Thay thế giá trị "0" bằng ký tự số mới
                    txt_downprice.Text = e.KeyChar.ToString();
                    // Ngăn không cho ký tự mới được thêm vào sau số hiện tại
                    e.Handled = true;
                    // Đặt con trỏ chuột vào cuối văn bản
                    txt_downprice.SelectionStart = txt_downprice.Text.Length;
                }
                else
                {
                    e.Handled = false; // Cho phép chữ số
                }
            }
            else if (e.KeyChar == '-') e.Handled = false;
            else e.Handled = true;
        }

        private void bt_print_Click(object sender, EventArgs e)
        {
            cko.mabill = currentbutton.Tag.ToString().Trim();
            cko.daycheckin = dtpk_np.Value;
            cko.daycheckout = dtpk_trap.Value;
            cko.type = cbx_type.Text;
            cko.menuprice = int.Parse(txt_tienmenu.Text);
            cko.roomprice = int.Parse(txt_tienp.Text);
            cko.totalprice = int.Parse(txt_tong.Text) + int.Parse(txt_ttt.Text);
            cko.downprice = int.Parse(txt_downprice.Text);
            cko.tktra = Account.logged.Tk;
            new ReportBill("Chưa trả phòng",cko.mabill).Show();
        }

        private void txt_downprice_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back && txt_downprice.Text.Length == 1)
            {
                // Đặt giá trị TextBox thành "0"
                txt_downprice.Text = "0";
                // Ngăn không cho thực hiện hành động Backspace
                e.SuppressKeyPress = true;
            }
        }

        private void txt_tienp_TextChanged(object sender, EventArgs e)
        {
            if (txt_tienp.Text != "" && txt_tienmenu.Text != "" && txt_ttt.Text != "")
                txt_tong.Text = (int.Parse(txt_tienp.Text) + int.Parse(txt_tienmenu.Text) - int.Parse(txt_ttt.Text) - int.Parse(txt_downprice.Text)).ToString();
        }
    }
}
