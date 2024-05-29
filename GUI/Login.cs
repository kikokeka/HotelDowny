using System.Windows.Forms;
using DTO;
using BLL;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Threading.Tasks;
using System;

namespace GUI
{
    public partial class Login : Form
    {
        private static Login instance;
        public static Login Instance
        {
            get { if (instance == null) instance = new Login(); return Login.instance; }
            private set { Login.instance = value; }
        }
        public Login()
        {
            InitializeComponent();
            guna2ProgressBar1.Visible = false;
            //checkBox1.Checked = false;
            txt_mk.PasswordChar = '*';
        }

        private void txt_tk_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                bt_login_Click(sender, e);
        }

        private void txt_mk_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                bt_login_Click(sender, e);
        }

        private void bt_login_Click(object sender, System.EventArgs e)
        {
            Account acc = new Account();
            string enteruser = txt_tk.Text;
            acc.Tk = txt_tk.Text;
            acc.Mk = txt_mk.Text;
            string currentacc = LoginBLL.Instance.CheckLogin(acc);
            if (enteruser != currentacc)
            {
                CusMessage.Show(currentacc,"Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            else
            {
                guna2ProgressBar1.Visible = true;
                //progressBar1.Visible = true;
                timer1.Start();
            }
        }

        private void guna2ControlBox1_Click(object sender, System.EventArgs e)
        {
            Application.Exit();
        }

        private void timer1_Tick(object sender, System.EventArgs e)
        {
            guna2ProgressBar1.Value += 2;
            if (guna2ProgressBar1.Value >= guna2ProgressBar1.Maximum)
            {
                txt_tk.Clear();
                txt_mk.Clear();
                guna2ProgressBar1.Value = 0;
                guna2ProgressBar1.Visible = false;
                Main.Instance.Visible = true;
                timer1.Stop();
                this.Hide();
            }
        }

        private void checkBox1_CheckedChanged(object sender, System.EventArgs e)
        {
            if (checkBox1.Checked)
            {
                txt_mk.PasswordChar = '\0'; // Hiển thị mật khẩu
            }
            else
            {
                txt_mk.PasswordChar = '*'; // Ẩn mật khẩu
            }
        }
    }
}
