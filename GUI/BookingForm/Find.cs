using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BLL;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GUI.Booking
{
    public partial class Find : Form
    {
        private static Find instance;
        public static Find Instance
        {
            get { if (instance == null) instance = new Find(); return Find.instance; }
            private set { Find.instance = value; }
        }
        List<DTO.Booking> booking;
        DataTable dt = new DataTable();
        bool iswaiting;
        public Find()
        {
            InitializeComponent();
            Loaddata();
        }
        void Loaddata()
        {
            lsv_booking.Items.Clear();
            booking = BookingBLL.Instance.GetByday($"usp_findbooking '{dtpk_start.Value}' , '{dtpk_end.Value}'");
             foreach (DTO.Booking b in booking)
            {
                ListViewItem listViewItem = new ListViewItem(b.namekh);
                listViewItem.SubItems.Add(b.cccd.ToString());
                listViewItem.SubItems.Add(b.sdt.ToString());
                listViewItem.SubItems.Add(b.phong.ToString());
                listViewItem.SubItems.Add(b.type.ToString());
                listViewItem.SubItems.Add(b.status.ToString());
                listViewItem.SubItems.Add(b.ngaynhan.ToString());
                listViewItem.SubItems.Add(b.ngaytra.ToString());
                listViewItem.SubItems.Add(b.tientratruoc.ToString());
                listViewItem.SubItems.Add(b.tk.ToString());
                lsv_booking.Items.Add(listViewItem);
            }
        }
        bool Special(string text)
        {
            return text.Any(c => char.IsPunctuation(c));
        }
        void Search(string text)
        {
            int sl = lsv_booking.Items.Count;
            List<DTO.Booking> bk = new List<DTO.Booking>();
            foreach(DTO.Booking b in booking)
            {
                string namekh = b.namekh;
                string cccd = b.cccd;
                string sdt = b.sdt;
                string phong = b.phong;
                string status = b.status;
                if (namekh.Contains(text) || cccd.Contains(text) || phong.Contains(text) || sdt.Contains(text) || status.Contains(text))
                {
                    bk.Add(b);
                }

            }
            if (sl != bk.Count)
            {
                lsv_booking.Items.Clear();
                foreach (DTO.Booking b in bk)
                {
                    ListViewItem listViewItem = new ListViewItem(b.namekh);
                    listViewItem.SubItems.Add(b.cccd.ToString());
                    listViewItem.SubItems.Add(b.sdt.ToString());
                    listViewItem.SubItems.Add(b.phong.ToString());
                    listViewItem.SubItems.Add(b.type.ToString());
                    listViewItem.SubItems.Add(b.status.ToString());
                    listViewItem.SubItems.Add(b.ngaynhan.ToString());
                    listViewItem.SubItems.Add(b.ngaytra.ToString());
                    listViewItem.SubItems.Add(b.tientratruoc.ToString());
                    listViewItem.SubItems.Add(b.tk.ToString());
                    lsv_booking.Items.Add(listViewItem);
                }
            }
            else return;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
           if (Special(txt_tim.Text))
            {
                CusMessage.Show("Không được nhập kí tự đặc biệt", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Search(txt_tim.Text);
            iswaiting = false;
        }

        private void txt_tim_TextChanged(object sender, EventArgs e)
        {
            if (iswaiting) return;
            timer1.Start();
            iswaiting = true;
        }

        private void bt_find_Click(object sender, EventArgs e)
        {
            Loaddata();
        }
    }
}
