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
using static System.Net.Mime.MediaTypeNames;

namespace GUI.ManageSys
{
    public partial class Setup : Form
    {
        public Setup()
        {
            InitializeComponent();
            lb_name.Visible = false;
            lb_loca.Visible = false;
            lb_sdt.Visible = false;
            Loaddata();
        }
        string[] arr_plahoder;
        void Loaddata()
        {
            arr_plahoder = new string[3] { txt_name.PlaceholderText, txt_location.PlaceholderText, txt_phone.PlaceholderText };
            DTO.Setup in4 = SetupBLL.Instance.Getdata();
            txt_name.Text = in4.name;
            txt_location.Text = in4.location;
            txt_phone.Text = in4.sdt;
        }
        private void bt_save_Click(object sender, EventArgs e)
        {
            DTO.Setup in4 = new DTO.Setup();
            in4.name = txt_name.Text;
            in4.location = txt_location.Text;
            in4.sdt = txt_phone.Text;
            string message = SetupBLL.Instance.Fix(in4);
            if(message == "Cập nhật thông tin thành công")
            {
                CusMessage.Show(message);
            }
            else CusMessage.Show(message,"Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Error);
        }

        private void txt_name_Click(object sender, EventArgs e)
        {
            lb_name.Visible = true;
            txt_name.PlaceholderText = "";
        }

        private void txt_name_Leave(object sender, EventArgs e)
        {
            if (txt_name.Text == "")
            {
                lb_name.Visible = false;
                txt_name.PlaceholderText = arr_plahoder[0];
            }
            else lb_name.Visible = true;
        }

        private void txt_location_Click(object sender, EventArgs e)
        {
            lb_loca.Visible = true;
            txt_location.PlaceholderText = "";
        }

        private void txt_location_Leave(object sender, EventArgs e)
        {
            if (txt_location.Text == "")
            {
                lb_loca.Visible = false;
                txt_location.PlaceholderText = arr_plahoder[1];
            }
            else lb_loca.Visible = true;
        }

        private void txt_phone_Leave(object sender, EventArgs e)
        {
            if (txt_phone.Text == "")
            {
                lb_sdt.Visible = false;
                txt_phone.PlaceholderText = arr_plahoder[2];
            }
            else lb_sdt.Visible = true;
        }

        private void txt_phone_Click(object sender, EventArgs e)
        {
            lb_sdt.Visible = true;
            txt_phone.PlaceholderText = "";
        }

        private void txt_name_TextChanged(object sender, EventArgs e)
        {
            if(txt_name.Text=="") lb_name.Visible = false;
            else lb_name.Visible = true;
        }

        private void txt_location_TextChanged(object sender, EventArgs e)
        {
            if (txt_location.Text == "") lb_loca.Visible = false;
            else lb_loca.Visible = true;
        }

        private void txt_phone_TextChanged(object sender, EventArgs e)
        {
            if (txt_phone.Text == "") lb_sdt.Visible = false;
            else lb_sdt.Visible = true;
        }
    }
}
