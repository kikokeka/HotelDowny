using BLL;
using DTO;
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
    public partial class Swaproom : UserControl
    {
        public Swaproom()
        {
            InitializeComponent();
            lb_message.Text = $"ĐỔi phòng {RentRoom.cko.phong}";
            List<RoomType> lst_rt = RoomTypeBLL.Instance.GetRoomType("usp_getroomtype");
            foreach (RoomType r in lst_rt)
            {
                cbx_type.Items.Add(r.Ten);
            }
            cbx_type.SelectedIndex = 0;
            cbx_dsp.SelectedIndex = 0;
        }

        private void bt_thoatdoip_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void cbx_type_SelectedIndexChanged(object sender, EventArgs e)
        {
            string query = "select * from room where status = N'Trống'";
            if (cbx_type.Text == "Tất cả")
            {
                if (!string.IsNullOrEmpty(txt_name.Text))
                {
                    query += $" and tenp like N'%{txt_name.Text}%'";
                }
            }
            else
            {
                if (!string.IsNullOrEmpty(txt_name.Text))
                {
                    query += $" and loai = N'{cbx_type.Text}' and tenp like N'%{txt_name.Text}%'";
                }
                else
                {
                    query += $" and Loai = N'{cbx_type.Text}'";
                }
            }
            List<Room> lst_r = RoomBLL.Instance.GetRoom(query);
            List<String> name = new List<String>();
            foreach (Room r in lst_r)
            {
                name.Add(r.tenp);
            }
            cbx_dsp.DataSource = name;
        }

        private void txt_name_TextChanged(object sender, EventArgs e)
        {
            cbx_type_SelectedIndexChanged(sender, e);
        }

        private void bt_doiphong_Click(object sender, EventArgs e)
        {
            string tenp = RentRoom.cko.phong;
            string swap = cbx_dsp.Text;
            DialogResult result = CusMessage.Show($"Xác nhận đổi phòng {tenp} sang phòng {swap}?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                string mabill = RentRoom.cko.mabill;
                string message = CheckinoutBLL.Instance.Swaproom(mabill, tenp, swap);
                if (message == "Đổi phòng thành công")
                {
                    CusMessage.Show(message);
                    this.Dispose();
                }
                else CusMessage.Show(message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
