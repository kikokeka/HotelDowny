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
    public partial class UpdateBill : UserControl
    {
        DTO.Checkinout cko = RentRoom.cko;
        public UpdateBill()
        {
            InitializeComponent();
            lb_error.Text = "";
            dtpk_np.CustomFormat = "yyyy/MM/dd HH:mm";
            dtpk_np.MaxDate = DateTime.Now;
            Loaddata();
        }
        void Loaddata()
        {
            cbx_type.Text = cko.type;
            lb_phong.Text = cko.phong;
            dtpk_np.Value = cko.daycheckin;
            txt_ttt.Text = Function.Instance.Getttt(cko.mabill).ToString();
            txt_note.Text = cko.ghichu;
            List<MenuUse> lst = MenuUseBLL.Instance.GetDetails(cko.mabill);
            foreach(MenuUse item in lst)
            {
                ListViewItem listViewItem = new ListViewItem(item.tenmenu);
                listViewItem.SubItems.Add(item.soluong.ToString());
                listViewItem.SubItems.Add(item.ngay.ToString());
                listViewItem.SubItems.Add(item.id.ToString());
                lsv_mu.Items.Add(listViewItem);
            }
        }
        private void bt_save_Click(object sender, EventArgs e)
        {
            string tk = Account.logged.Tk;
            string message = CheckinoutBLL.Instance.Fix(cko.mabill, dtpk_np.Value,cbx_type.Text, int.Parse(txt_ttt.Text), txt_note.Text, tk);
            if(message=="Cập nhật thành công") CusMessage.Show(message);
            else lb_error.Text = message; return;
        }

        private void txt_ttt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
