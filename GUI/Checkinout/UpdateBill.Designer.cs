namespace GUI.Checkinout
{
    partial class UpdateBill
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateBill));
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("");
            this.lb_phong = new System.Windows.Forms.Label();
            this.bt_save = new Guna.UI2.WinForms.Guna2Button();
            this.dtpk_np = new System.Windows.Forms.DateTimePicker();
            this.lb_ngaynhan = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lb_type = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.cbx_type = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txt_ttt = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txt_note = new Guna.UI2.WinForms.Guna2TextBox();
            this.lsv_mu = new System.Windows.Forms.ListView();
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lb_error = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.SuspendLayout();
            // 
            // lb_phong
            // 
            this.lb_phong.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_phong.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lb_phong.Image = ((System.Drawing.Image)(resources.GetObject("lb_phong.Image")));
            this.lb_phong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lb_phong.Location = new System.Drawing.Point(5, 0);
            this.lb_phong.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lb_phong.Name = "lb_phong";
            this.lb_phong.Size = new System.Drawing.Size(97, 51);
            this.lb_phong.TabIndex = 1;
            this.lb_phong.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            this.bt_save.FillColor = System.Drawing.Color.AliceBlue;
            this.bt_save.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_save.ForeColor = System.Drawing.Color.Green;
            this.bt_save.Image = ((System.Drawing.Image)(resources.GetObject("bt_save.Image")));
            this.bt_save.ImageSize = new System.Drawing.Size(40, 40);
            this.bt_save.Location = new System.Drawing.Point(230, 6);
            this.bt_save.Name = "bt_save";
            this.bt_save.Size = new System.Drawing.Size(101, 45);
            this.bt_save.TabIndex = 9;
            this.bt_save.Text = "Lưu";
            this.bt_save.UseTransparentBackground = true;
            this.bt_save.Click += new System.EventHandler(this.bt_save_Click);
            // 
            // dtpk_np
            // 
            this.dtpk_np.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(19)))), ((int)(((byte)(43)))));
            this.dtpk_np.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpk_np.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpk_np.Location = new System.Drawing.Point(9, 106);
            this.dtpk_np.Margin = new System.Windows.Forms.Padding(5);
            this.dtpk_np.Name = "dtpk_np";
            this.dtpk_np.Size = new System.Drawing.Size(313, 28);
            this.dtpk_np.TabIndex = 97;
            // 
            // lb_ngaynhan
            // 
            this.lb_ngaynhan.BackColor = System.Drawing.Color.Transparent;
            this.lb_ngaynhan.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ngaynhan.ForeColor = System.Drawing.SystemColors.Control;
            this.lb_ngaynhan.Location = new System.Drawing.Point(11, 89);
            this.lb_ngaynhan.Margin = new System.Windows.Forms.Padding(5);
            this.lb_ngaynhan.Name = "lb_ngaynhan";
            this.lb_ngaynhan.Size = new System.Drawing.Size(91, 18);
            this.lb_ngaynhan.TabIndex = 96;
            this.lb_ngaynhan.Text = "Thời gian nhận";
            // 
            // lb_type
            // 
            this.lb_type.BackColor = System.Drawing.Color.Transparent;
            this.lb_type.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_type.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lb_type.Location = new System.Drawing.Point(9, 143);
            this.lb_type.Margin = new System.Windows.Forms.Padding(5);
            this.lb_type.Name = "lb_type";
            this.lb_type.Size = new System.Drawing.Size(57, 18);
            this.lb_type.TabIndex = 100;
            this.lb_type.Text = "Kiểu thuê";
            // 
            // cbx_type
            // 
            this.cbx_type.BackColor = System.Drawing.Color.Transparent;
            this.cbx_type.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbx_type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_type.FillColor = System.Drawing.Color.AliceBlue;
            this.cbx_type.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbx_type.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbx_type.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbx_type.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cbx_type.ItemHeight = 30;
            this.cbx_type.Items.AddRange(new object[] {
            "Thuê theo giờ",
            "Thuê qua đêm",
            "Thuê theo ngày",
            "Thuê theo tháng"});
            this.cbx_type.Location = new System.Drawing.Point(11, 158);
            this.cbx_type.Name = "cbx_type";
            this.cbx_type.Size = new System.Drawing.Size(311, 36);
            this.cbx_type.TabIndex = 102;
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(11, 202);
            this.guna2HtmlLabel2.Margin = new System.Windows.Forms.Padding(5);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(80, 18);
            this.guna2HtmlLabel2.TabIndex = 104;
            this.guna2HtmlLabel2.Text = "Tiền trả trước";
            // 
            // txt_ttt
            // 
            this.txt_ttt.Animated = true;
            this.txt_ttt.BorderColor = System.Drawing.Color.RosyBrown;
            this.txt_ttt.BorderRadius = 8;
            this.txt_ttt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_ttt.DefaultText = "";
            this.txt_ttt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_ttt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_ttt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_ttt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_ttt.FillColor = System.Drawing.Color.AliceBlue;
            this.txt_ttt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_ttt.Font = new System.Drawing.Font("Times New Roman", 10.8F);
            this.txt_ttt.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_ttt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_ttt.Location = new System.Drawing.Point(9, 218);
            this.txt_ttt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_ttt.Name = "txt_ttt";
            this.txt_ttt.PasswordChar = '\0';
            this.txt_ttt.PlaceholderText = "";
            this.txt_ttt.SelectedText = "";
            this.txt_ttt.Size = new System.Drawing.Size(313, 37);
            this.txt_ttt.TabIndex = 103;
            this.txt_ttt.Tag = "0";
            this.txt_ttt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_ttt_KeyPress);
            // 
            // guna2HtmlLabel3
            // 
            this.guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.guna2HtmlLabel3.Location = new System.Drawing.Point(11, 256);
            this.guna2HtmlLabel3.Margin = new System.Windows.Forms.Padding(5);
            this.guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            this.guna2HtmlLabel3.Size = new System.Drawing.Size(124, 18);
            this.guna2HtmlLabel3.TabIndex = 106;
            this.guna2HtmlLabel3.Text = "Ghi chú(có thể trống)";
            // 
            // txt_note
            // 
            this.txt_note.Animated = true;
            this.txt_note.BorderColor = System.Drawing.Color.RosyBrown;
            this.txt_note.BorderRadius = 8;
            this.txt_note.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_note.DefaultText = "";
            this.txt_note.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_note.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_note.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_note.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_note.FillColor = System.Drawing.Color.AliceBlue;
            this.txt_note.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_note.Font = new System.Drawing.Font("Times New Roman", 10.8F);
            this.txt_note.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_note.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_note.Location = new System.Drawing.Point(9, 272);
            this.txt_note.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_note.Name = "txt_note";
            this.txt_note.PasswordChar = '\0';
            this.txt_note.PlaceholderText = "";
            this.txt_note.SelectedText = "";
            this.txt_note.Size = new System.Drawing.Size(313, 37);
            this.txt_note.TabIndex = 105;
            this.txt_note.Tag = "0";
            // 
            // lsv_mu
            // 
            this.lsv_mu.BackColor = System.Drawing.Color.AliceBlue;
            this.lsv_mu.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8});
            this.lsv_mu.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsv_mu.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lsv_mu.FullRowSelect = true;
            this.lsv_mu.GridLines = true;
            this.lsv_mu.HideSelection = false;
            this.lsv_mu.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.lsv_mu.Location = new System.Drawing.Point(3, 340);
            this.lsv_mu.Name = "lsv_mu";
            this.lsv_mu.Size = new System.Drawing.Size(322, 146);
            this.lsv_mu.TabIndex = 107;
            this.lsv_mu.UseCompatibleStateImageBehavior = false;
            this.lsv_mu.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Tên Menu";
            this.columnHeader6.Width = 111;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "sl";
            this.columnHeader7.Width = 34;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Ngày";
            this.columnHeader8.Width = 171;
            // 
            // lb_error
            // 
            this.lb_error.AutoSize = false;
            this.lb_error.BackColor = System.Drawing.Color.Transparent;
            this.lb_error.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_error.ForeColor = System.Drawing.Color.Red;
            this.lb_error.Location = new System.Drawing.Point(3, 54);
            this.lb_error.Name = "lb_error";
            this.lb_error.Size = new System.Drawing.Size(319, 22);
            this.lb_error.TabIndex = 108;
            this.lb_error.Text = "lb_error";
            // 
            // UpdateBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.Controls.Add(this.lb_error);
            this.Controls.Add(this.lsv_mu);
            this.Controls.Add(this.guna2HtmlLabel3);
            this.Controls.Add(this.txt_note);
            this.Controls.Add(this.guna2HtmlLabel2);
            this.Controls.Add(this.txt_ttt);
            this.Controls.Add(this.cbx_type);
            this.Controls.Add(this.lb_type);
            this.Controls.Add(this.dtpk_np);
            this.Controls.Add(this.lb_ngaynhan);
            this.Controls.Add(this.bt_save);
            this.Controls.Add(this.lb_phong);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "UpdateBill";
            this.Size = new System.Drawing.Size(334, 647);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_phong;
        private Guna.UI2.WinForms.Guna2Button bt_save;
        internal System.Windows.Forms.DateTimePicker dtpk_np;
        private Guna.UI2.WinForms.Guna2HtmlLabel lb_ngaynhan;
        private Guna.UI2.WinForms.Guna2HtmlLabel lb_type;
        private Guna.UI2.WinForms.Guna2ComboBox cbx_type;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2TextBox txt_ttt;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private Guna.UI2.WinForms.Guna2TextBox txt_note;
        private System.Windows.Forms.ListView lsv_mu;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private Guna.UI2.WinForms.Guna2HtmlLabel lb_error;
    }
}
