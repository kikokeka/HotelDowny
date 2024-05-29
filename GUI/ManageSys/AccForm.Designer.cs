namespace GUI.ManageSys
{
    partial class AccForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AccForm));
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("");
            this.bt_add = new Guna.UI2.WinForms.Guna2Button();
            this.lsv_acc = new System.Windows.Forms.ListView();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pn_insert = new System.Windows.Forms.Panel();
            this.txt_xnmk = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_mk = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_tk = new Guna.UI2.WinForms.Guna2TextBox();
            this.lb_error = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.pn_logo = new System.Windows.Forms.Panel();
            this.bt_save = new Guna.UI2.WinForms.Guna2Button();
            this.lb_message = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txt_tim = new Guna.UI2.WinForms.Guna2TextBox();
            this.bt_wage = new Guna.UI2.WinForms.Guna2Button();
            this.pn_insert.SuspendLayout();
            this.pn_logo.SuspendLayout();
            this.SuspendLayout();
            // 
            // bt_add
            // 
            this.bt_add.Animated = true;
            this.bt_add.BackColor = System.Drawing.Color.Transparent;
            this.bt_add.BorderRadius = 8;
            this.bt_add.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.bt_add.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.bt_add.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.bt_add.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.bt_add.FillColor = System.Drawing.Color.AliceBlue;
            this.bt_add.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_add.ForeColor = System.Drawing.Color.Green;
            this.bt_add.Image = ((System.Drawing.Image)(resources.GetObject("bt_add.Image")));
            this.bt_add.ImageSize = new System.Drawing.Size(40, 40);
            this.bt_add.Location = new System.Drawing.Point(4, 2);
            this.bt_add.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.bt_add.Name = "bt_add";
            this.bt_add.Size = new System.Drawing.Size(162, 44);
            this.bt_add.TabIndex = 19;
            this.bt_add.Text = "Thêm mới";
            this.bt_add.UseTransparentBackground = true;
            this.bt_add.Click += new System.EventHandler(this.bt_add_Click);
            // 
            // lsv_acc
            // 
            this.lsv_acc.BackColor = System.Drawing.Color.AliceBlue;
            this.lsv_acc.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lsv_acc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsv_acc.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lsv_acc.FullRowSelect = true;
            this.lsv_acc.GridLines = true;
            this.lsv_acc.HideSelection = false;
            this.lsv_acc.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.lsv_acc.Location = new System.Drawing.Point(12, 174);
            this.lsv_acc.Name = "lsv_acc";
            this.lsv_acc.Size = new System.Drawing.Size(587, 242);
            this.lsv_acc.TabIndex = 95;
            this.lsv_acc.UseCompatibleStateImageBehavior = false;
            this.lsv_acc.View = System.Windows.Forms.View.Details;
            this.lsv_acc.SelectedIndexChanged += new System.EventHandler(this.lsv_acc_SelectedIndexChanged);
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Tài khoản";
            this.columnHeader2.Width = 121;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Chức vụ";
            this.columnHeader3.Width = 157;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Lần đăng nhập gần nhất";
            this.columnHeader4.Width = 303;
            // 
            // pn_insert
            // 
            this.pn_insert.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pn_insert.Controls.Add(this.txt_xnmk);
            this.pn_insert.Controls.Add(this.txt_mk);
            this.pn_insert.Controls.Add(this.txt_tk);
            this.pn_insert.Controls.Add(this.lb_error);
            this.pn_insert.Controls.Add(this.pn_logo);
            this.pn_insert.Dock = System.Windows.Forms.DockStyle.Right;
            this.pn_insert.Location = new System.Drawing.Point(965, 0);
            this.pn_insert.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.pn_insert.Name = "pn_insert";
            this.pn_insert.Size = new System.Drawing.Size(331, 647);
            this.pn_insert.TabIndex = 96;
            // 
            // txt_xnmk
            // 
            this.txt_xnmk.Animated = true;
            this.txt_xnmk.BorderColor = System.Drawing.Color.RosyBrown;
            this.txt_xnmk.BorderRadius = 8;
            this.txt_xnmk.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_xnmk.DefaultText = "";
            this.txt_xnmk.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_xnmk.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_xnmk.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_xnmk.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_xnmk.FillColor = System.Drawing.Color.AliceBlue;
            this.txt_xnmk.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_xnmk.Font = new System.Drawing.Font("Times New Roman", 10.8F);
            this.txt_xnmk.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_xnmk.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_xnmk.Location = new System.Drawing.Point(13, 243);
            this.txt_xnmk.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_xnmk.Name = "txt_xnmk";
            this.txt_xnmk.PasswordChar = '\0';
            this.txt_xnmk.PlaceholderForeColor = System.Drawing.SystemColors.GrayText;
            this.txt_xnmk.PlaceholderText = "Xác nhận mật khẩu";
            this.txt_xnmk.SelectedText = "";
            this.txt_xnmk.Size = new System.Drawing.Size(312, 36);
            this.txt_xnmk.TabIndex = 29;
            this.txt_xnmk.Tag = "1";
            // 
            // txt_mk
            // 
            this.txt_mk.Animated = true;
            this.txt_mk.BorderColor = System.Drawing.Color.RosyBrown;
            this.txt_mk.BorderRadius = 8;
            this.txt_mk.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_mk.DefaultText = "";
            this.txt_mk.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_mk.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_mk.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_mk.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_mk.FillColor = System.Drawing.Color.AliceBlue;
            this.txt_mk.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_mk.Font = new System.Drawing.Font("Times New Roman", 10.8F);
            this.txt_mk.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_mk.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_mk.Location = new System.Drawing.Point(13, 173);
            this.txt_mk.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_mk.Name = "txt_mk";
            this.txt_mk.PasswordChar = '\0';
            this.txt_mk.PlaceholderForeColor = System.Drawing.SystemColors.GrayText;
            this.txt_mk.PlaceholderText = "Mật khẩu";
            this.txt_mk.SelectedText = "";
            this.txt_mk.Size = new System.Drawing.Size(312, 40);
            this.txt_mk.TabIndex = 28;
            this.txt_mk.Tag = "1";
            // 
            // txt_tk
            // 
            this.txt_tk.Animated = true;
            this.txt_tk.BorderColor = System.Drawing.Color.RosyBrown;
            this.txt_tk.BorderRadius = 8;
            this.txt_tk.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_tk.DefaultText = "";
            this.txt_tk.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_tk.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_tk.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_tk.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_tk.FillColor = System.Drawing.Color.AliceBlue;
            this.txt_tk.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_tk.Font = new System.Drawing.Font("Times New Roman", 10.8F);
            this.txt_tk.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_tk.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_tk.Location = new System.Drawing.Point(13, 100);
            this.txt_tk.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_tk.Name = "txt_tk";
            this.txt_tk.PasswordChar = '\0';
            this.txt_tk.PlaceholderForeColor = System.Drawing.SystemColors.GrayText;
            this.txt_tk.PlaceholderText = "Tài khoản";
            this.txt_tk.SelectedText = "";
            this.txt_tk.Size = new System.Drawing.Size(312, 36);
            this.txt_tk.TabIndex = 27;
            this.txt_tk.Tag = "1";
            // 
            // lb_error
            // 
            this.lb_error.AutoSize = false;
            this.lb_error.BackColor = System.Drawing.Color.Transparent;
            this.lb_error.Dock = System.Windows.Forms.DockStyle.Top;
            this.lb_error.ForeColor = System.Drawing.Color.Red;
            this.lb_error.Location = new System.Drawing.Point(0, 55);
            this.lb_error.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.lb_error.Name = "lb_error";
            this.lb_error.Size = new System.Drawing.Size(329, 36);
            this.lb_error.TabIndex = 2;
            this.lb_error.Text = null;
            // 
            // pn_logo
            // 
            this.pn_logo.Controls.Add(this.bt_save);
            this.pn_logo.Controls.Add(this.lb_message);
            this.pn_logo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pn_logo.Location = new System.Drawing.Point(0, 0);
            this.pn_logo.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.pn_logo.Name = "pn_logo";
            this.pn_logo.Size = new System.Drawing.Size(329, 55);
            this.pn_logo.TabIndex = 0;
            // 
            // bt_save
            // 
            this.bt_save.Animated = true;
            this.bt_save.BackColor = System.Drawing.Color.Transparent;
            this.bt_save.BorderRadius = 8;
            this.bt_save.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.bt_save.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.bt_save.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.bt_save.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.bt_save.Dock = System.Windows.Forms.DockStyle.Right;
            this.bt_save.FillColor = System.Drawing.Color.AliceBlue;
            this.bt_save.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_save.ForeColor = System.Drawing.Color.Green;
            this.bt_save.Image = ((System.Drawing.Image)(resources.GetObject("bt_save.Image")));
            this.bt_save.ImageSize = new System.Drawing.Size(30, 30);
            this.bt_save.Location = new System.Drawing.Point(223, 0);
            this.bt_save.Name = "bt_save";
            this.bt_save.Size = new System.Drawing.Size(106, 55);
            this.bt_save.TabIndex = 10;
            this.bt_save.Text = "Lưu";
            this.bt_save.UseTransparentBackground = true;
            this.bt_save.Click += new System.EventHandler(this.bt_save_Click);
            // 
            // lb_message
            // 
            this.lb_message.AutoSize = false;
            this.lb_message.BackColor = System.Drawing.Color.Transparent;
            this.lb_message.Dock = System.Windows.Forms.DockStyle.Left;
            this.lb_message.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_message.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lb_message.Location = new System.Drawing.Point(0, 0);
            this.lb_message.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.lb_message.Name = "lb_message";
            this.lb_message.Size = new System.Drawing.Size(171, 55);
            this.lb_message.TabIndex = 0;
            this.lb_message.Text = "Thêm tài khoản";
            this.lb_message.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_tim
            // 
            this.txt_tim.Animated = true;
            this.txt_tim.BorderColor = System.Drawing.Color.RosyBrown;
            this.txt_tim.BorderRadius = 8;
            this.txt_tim.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_tim.DefaultText = "";
            this.txt_tim.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_tim.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_tim.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_tim.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_tim.FillColor = System.Drawing.Color.AliceBlue;
            this.txt_tim.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_tim.Font = new System.Drawing.Font("Times New Roman", 10.8F);
            this.txt_tim.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_tim.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_tim.Location = new System.Drawing.Point(12, 78);
            this.txt_tim.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_tim.Name = "txt_tim";
            this.txt_tim.PasswordChar = '\0';
            this.txt_tim.PlaceholderForeColor = System.Drawing.SystemColors.GrayText;
            this.txt_tim.PlaceholderText = "Tìm kiếm";
            this.txt_tim.SelectedText = "";
            this.txt_tim.Size = new System.Drawing.Size(383, 36);
            this.txt_tim.TabIndex = 97;
            this.txt_tim.Tag = "1";
            // 
            // bt_wage
            // 
            this.bt_wage.Animated = true;
            this.bt_wage.BackColor = System.Drawing.Color.Transparent;
            this.bt_wage.BorderRadius = 8;
            this.bt_wage.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.bt_wage.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.bt_wage.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.bt_wage.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.bt_wage.FillColor = System.Drawing.Color.AliceBlue;
            this.bt_wage.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.bt_wage.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.bt_wage.Image = ((System.Drawing.Image)(resources.GetObject("bt_wage.Image")));
            this.bt_wage.ImageSize = new System.Drawing.Size(40, 40);
            this.bt_wage.Location = new System.Drawing.Point(437, 70);
            this.bt_wage.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.bt_wage.Name = "bt_wage";
            this.bt_wage.Size = new System.Drawing.Size(162, 44);
            this.bt_wage.TabIndex = 98;
            this.bt_wage.Text = "Chấm công";
            this.bt_wage.UseTransparentBackground = true;
            this.bt_wage.Click += new System.EventHandler(this.bt_wage_Click);
            // 
            // AccForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(1296, 647);
            this.Controls.Add(this.pn_insert);
            this.Controls.Add(this.bt_wage);
            this.Controls.Add(this.txt_tim);
            this.Controls.Add(this.lsv_acc);
            this.Controls.Add(this.bt_add);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "AccForm";
            this.Text = "AccForm";
            this.pn_insert.ResumeLayout(false);
            this.pn_logo.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button bt_add;
        private System.Windows.Forms.ListView lsv_acc;
        private System.Windows.Forms.Panel pn_insert;
        private Guna.UI2.WinForms.Guna2TextBox txt_mk;
        private Guna.UI2.WinForms.Guna2TextBox txt_tk;
        private Guna.UI2.WinForms.Guna2HtmlLabel lb_error;
        private System.Windows.Forms.Panel pn_logo;
        private Guna.UI2.WinForms.Guna2Button bt_save;
        private Guna.UI2.WinForms.Guna2HtmlLabel lb_message;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private Guna.UI2.WinForms.Guna2TextBox txt_xnmk;
        private Guna.UI2.WinForms.Guna2TextBox txt_tim;
        private Guna.UI2.WinForms.Guna2Button bt_wage;
    }
}