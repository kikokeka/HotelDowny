namespace GUI.Checkinout
{
    partial class UseMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UseMenu));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pn_added = new System.Windows.Forms.Panel();
            this.flp_added = new System.Windows.Forms.FlowLayoutPanel();
            this.pn_columnadded = new System.Windows.Forms.Panel();
            this.lb_btx = new System.Windows.Forms.Label();
            this.lb_price = new System.Windows.Forms.Label();
            this.lb_sl = new System.Windows.Forms.Label();
            this.lb_ngay = new System.Windows.Forms.Label();
            this.lb_mnsell = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pn_dsmenu = new System.Windows.Forms.Panel();
            this.flp_menu = new System.Windows.Forms.FlowLayoutPanel();
            this.pn_column = new System.Windows.Forms.Panel();
            this.lb_lmn = new System.Windows.Forms.Label();
            this.lb_bt = new System.Windows.Forms.Label();
            this.lb_giab = new System.Windows.Forms.Label();
            this.lb_nmn = new System.Windows.Forms.Label();
            this.txt_timmenu = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.cbx_type = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lb_dsmn = new System.Windows.Forms.Label();
            this.bt_exit = new Guna.UI2.WinForms.Guna2Button();
            this.bt_save = new Guna.UI2.WinForms.Guna2Button();
            this.txt_tenp = new Guna.UI2.WinForms.Guna2TextBox();
            this.bt_f5 = new Guna.UI2.WinForms.Guna2Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.pn_added.SuspendLayout();
            this.flp_added.SuspendLayout();
            this.pn_columnadded.SuspendLayout();
            this.pn_dsmenu.SuspendLayout();
            this.flp_menu.SuspendLayout();
            this.pn_column.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Silver;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 42F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 58F));
            this.tableLayoutPanel1.Controls.Add(this.pn_added, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.pn_dsmenu, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(1, 48);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1160, 405);
            this.tableLayoutPanel1.TabIndex = 117;
            // 
            // pn_added
            // 
            this.pn_added.Controls.Add(this.flp_added);
            this.pn_added.Controls.Add(this.label4);
            this.pn_added.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pn_added.Location = new System.Drawing.Point(490, 3);
            this.pn_added.Name = "pn_added";
            this.pn_added.Size = new System.Drawing.Size(667, 379);
            this.pn_added.TabIndex = 2;
            // 
            // flp_added
            // 
            this.flp_added.AutoScroll = true;
            this.flp_added.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flp_added.Controls.Add(this.pn_columnadded);
            this.flp_added.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flp_added.Location = new System.Drawing.Point(5, 121);
            this.flp_added.Name = "flp_added";
            this.flp_added.Size = new System.Drawing.Size(659, 275);
            this.flp_added.TabIndex = 6;
            // 
            // pn_columnadded
            // 
            this.pn_columnadded.BackColor = System.Drawing.Color.Silver;
            this.pn_columnadded.Controls.Add(this.lb_btx);
            this.pn_columnadded.Controls.Add(this.lb_price);
            this.pn_columnadded.Controls.Add(this.lb_sl);
            this.pn_columnadded.Controls.Add(this.lb_ngay);
            this.pn_columnadded.Controls.Add(this.lb_mnsell);
            this.pn_columnadded.Location = new System.Drawing.Point(3, 3);
            this.pn_columnadded.Name = "pn_columnadded";
            this.pn_columnadded.Size = new System.Drawing.Size(634, 35);
            this.pn_columnadded.TabIndex = 0;
            this.pn_columnadded.Tag = "column";
            // 
            // lb_btx
            // 
            this.lb_btx.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lb_btx.Dock = System.Windows.Forms.DockStyle.Left;
            this.lb_btx.Location = new System.Drawing.Point(572, 0);
            this.lb_btx.Name = "lb_btx";
            this.lb_btx.Size = new System.Drawing.Size(61, 35);
            this.lb_btx.TabIndex = 3;
            this.lb_btx.Text = "Xóa";
            this.lb_btx.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_price
            // 
            this.lb_price.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lb_price.Dock = System.Windows.Forms.DockStyle.Left;
            this.lb_price.Location = new System.Drawing.Point(474, 0);
            this.lb_price.Name = "lb_price";
            this.lb_price.Size = new System.Drawing.Size(98, 35);
            this.lb_price.TabIndex = 2;
            this.lb_price.Text = "Thành tiền";
            this.lb_price.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_sl
            // 
            this.lb_sl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lb_sl.Dock = System.Windows.Forms.DockStyle.Left;
            this.lb_sl.Location = new System.Drawing.Point(408, 0);
            this.lb_sl.Name = "lb_sl";
            this.lb_sl.Size = new System.Drawing.Size(66, 35);
            this.lb_sl.TabIndex = 1;
            this.lb_sl.Text = "Số lượng";
            this.lb_sl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_ngay
            // 
            this.lb_ngay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lb_ngay.Dock = System.Windows.Forms.DockStyle.Left;
            this.lb_ngay.Location = new System.Drawing.Point(232, 0);
            this.lb_ngay.Name = "lb_ngay";
            this.lb_ngay.Size = new System.Drawing.Size(176, 35);
            this.lb_ngay.TabIndex = 4;
            this.lb_ngay.Text = "Ngày";
            this.lb_ngay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_mnsell
            // 
            this.lb_mnsell.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lb_mnsell.Dock = System.Windows.Forms.DockStyle.Left;
            this.lb_mnsell.Location = new System.Drawing.Point(0, 0);
            this.lb_mnsell.Name = "lb_mnsell";
            this.lb_mnsell.Size = new System.Drawing.Size(232, 35);
            this.lb_mnsell.TabIndex = 0;
            this.lb_mnsell.Text = "Menu";
            this.lb_mnsell.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Dock = System.Windows.Forms.DockStyle.Top;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(175)))), ((int)(((byte)(243)))));
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(667, 29);
            this.label4.TabIndex = 1;
            this.label4.Text = "Menu đã chọn";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pn_dsmenu
            // 
            this.pn_dsmenu.Controls.Add(this.flp_menu);
            this.pn_dsmenu.Controls.Add(this.txt_timmenu);
            this.pn_dsmenu.Controls.Add(this.guna2HtmlLabel1);
            this.pn_dsmenu.Controls.Add(this.cbx_type);
            this.pn_dsmenu.Controls.Add(this.lb_dsmn);
            this.pn_dsmenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pn_dsmenu.Location = new System.Drawing.Point(3, 3);
            this.pn_dsmenu.Name = "pn_dsmenu";
            this.pn_dsmenu.Size = new System.Drawing.Size(481, 379);
            this.pn_dsmenu.TabIndex = 1;
            // 
            // flp_menu
            // 
            this.flp_menu.AutoScroll = true;
            this.flp_menu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flp_menu.Controls.Add(this.pn_column);
            this.flp_menu.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flp_menu.Location = new System.Drawing.Point(3, 121);
            this.flp_menu.Name = "flp_menu";
            this.flp_menu.Size = new System.Drawing.Size(475, 275);
            this.flp_menu.TabIndex = 106;
            // 
            // pn_column
            // 
            this.pn_column.BackColor = System.Drawing.Color.Silver;
            this.pn_column.Controls.Add(this.lb_lmn);
            this.pn_column.Controls.Add(this.lb_bt);
            this.pn_column.Controls.Add(this.lb_giab);
            this.pn_column.Controls.Add(this.lb_nmn);
            this.pn_column.Dock = System.Windows.Forms.DockStyle.Top;
            this.pn_column.Location = new System.Drawing.Point(3, 3);
            this.pn_column.Name = "pn_column";
            this.pn_column.Size = new System.Drawing.Size(455, 35);
            this.pn_column.TabIndex = 0;
            this.pn_column.Tag = "column";
            // 
            // lb_lmn
            // 
            this.lb_lmn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lb_lmn.Dock = System.Windows.Forms.DockStyle.Left;
            this.lb_lmn.Location = new System.Drawing.Point(0, 0);
            this.lb_lmn.Name = "lb_lmn";
            this.lb_lmn.Size = new System.Drawing.Size(67, 35);
            this.lb_lmn.TabIndex = 0;
            this.lb_lmn.Text = "Loại MN";
            this.lb_lmn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_bt
            // 
            this.lb_bt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lb_bt.Location = new System.Drawing.Point(393, 0);
            this.lb_bt.Name = "lb_bt";
            this.lb_bt.Size = new System.Drawing.Size(61, 35);
            this.lb_bt.TabIndex = 3;
            this.lb_bt.Text = "Thêm";
            this.lb_bt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_giab
            // 
            this.lb_giab.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lb_giab.Location = new System.Drawing.Point(295, 0);
            this.lb_giab.Name = "lb_giab";
            this.lb_giab.Size = new System.Drawing.Size(98, 35);
            this.lb_giab.TabIndex = 2;
            this.lb_giab.Text = "Giá";
            this.lb_giab.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_nmn
            // 
            this.lb_nmn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lb_nmn.Location = new System.Drawing.Point(64, 0);
            this.lb_nmn.Name = "lb_nmn";
            this.lb_nmn.Size = new System.Drawing.Size(232, 35);
            this.lb_nmn.TabIndex = 1;
            this.lb_nmn.Text = "Tên";
            this.lb_nmn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_timmenu
            // 
            this.txt_timmenu.Animated = true;
            this.txt_timmenu.BorderColor = System.Drawing.Color.DimGray;
            this.txt_timmenu.BorderRadius = 8;
            this.txt_timmenu.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_timmenu.DefaultText = "";
            this.txt_timmenu.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_timmenu.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_timmenu.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_timmenu.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_timmenu.FillColor = System.Drawing.Color.DarkGray;
            this.txt_timmenu.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_timmenu.Font = new System.Drawing.Font("Times New Roman", 10.8F);
            this.txt_timmenu.ForeColor = System.Drawing.Color.White;
            this.txt_timmenu.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_timmenu.IconLeft = ((System.Drawing.Image)(resources.GetObject("txt_timmenu.IconLeft")));
            this.txt_timmenu.IconLeftSize = new System.Drawing.Size(40, 40);
            this.txt_timmenu.Location = new System.Drawing.Point(212, 53);
            this.txt_timmenu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_timmenu.Name = "txt_timmenu";
            this.txt_timmenu.PasswordChar = '\0';
            this.txt_timmenu.PlaceholderForeColor = System.Drawing.Color.SteelBlue;
            this.txt_timmenu.PlaceholderText = "Tìm menu";
            this.txt_timmenu.SelectedText = "";
            this.txt_timmenu.Size = new System.Drawing.Size(243, 37);
            this.txt_timmenu.TabIndex = 105;
            this.txt_timmenu.Tag = "0";
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(5, 32);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(65, 18);
            this.guna2HtmlLabel1.TabIndex = 4;
            this.guna2HtmlLabel1.Text = "Loại menu";
            // 
            // cbx_type
            // 
            this.cbx_type.BackColor = System.Drawing.Color.Transparent;
            this.cbx_type.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbx_type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_type.FillColor = System.Drawing.Color.DarkGray;
            this.cbx_type.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbx_type.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbx_type.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbx_type.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbx_type.ItemHeight = 30;
            this.cbx_type.Items.AddRange(new object[] {
            "Tất cả",
            "Đồ ăn",
            "Đồ uống",
            "Loại khác"});
            this.cbx_type.Location = new System.Drawing.Point(5, 53);
            this.cbx_type.Name = "cbx_type";
            this.cbx_type.Size = new System.Drawing.Size(186, 36);
            this.cbx_type.TabIndex = 3;
            // 
            // lb_dsmn
            // 
            this.lb_dsmn.Dock = System.Windows.Forms.DockStyle.Top;
            this.lb_dsmn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_dsmn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(175)))), ((int)(((byte)(243)))));
            this.lb_dsmn.Location = new System.Drawing.Point(0, 0);
            this.lb_dsmn.Name = "lb_dsmn";
            this.lb_dsmn.Size = new System.Drawing.Size(481, 29);
            this.lb_dsmn.TabIndex = 2;
            this.lb_dsmn.Text = "Danh sách Menu";
            this.lb_dsmn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bt_exit
            // 
            this.bt_exit.Animated = true;
            this.bt_exit.BackColor = System.Drawing.Color.Transparent;
            this.bt_exit.BorderRadius = 8;
            this.bt_exit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.bt_exit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.bt_exit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.bt_exit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.bt_exit.FillColor = System.Drawing.Color.Gray;
            this.bt_exit.Font = new System.Drawing.Font("Times New Roman", 13.8F);
            this.bt_exit.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.bt_exit.Image = ((System.Drawing.Image)(resources.GetObject("bt_exit.Image")));
            this.bt_exit.ImageSize = new System.Drawing.Size(40, 40);
            this.bt_exit.Location = new System.Drawing.Point(1057, 456);
            this.bt_exit.Name = "bt_exit";
            this.bt_exit.Size = new System.Drawing.Size(101, 45);
            this.bt_exit.TabIndex = 113;
            this.bt_exit.Text = "Thoát";
            this.bt_exit.UseTransparentBackground = true;
            this.bt_exit.Click += new System.EventHandler(this.bt_exit_Click);
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
            this.bt_save.FillColor = System.Drawing.Color.SlateGray;
            this.bt_save.Font = new System.Drawing.Font("Times New Roman", 13.8F);
            this.bt_save.ForeColor = System.Drawing.Color.GreenYellow;
            this.bt_save.Image = ((System.Drawing.Image)(resources.GetObject("bt_save.Image")));
            this.bt_save.ImageSize = new System.Drawing.Size(40, 40);
            this.bt_save.Location = new System.Drawing.Point(853, 456);
            this.bt_save.Name = "bt_save";
            this.bt_save.Size = new System.Drawing.Size(101, 45);
            this.bt_save.TabIndex = 116;
            this.bt_save.Text = "Lưu";
            this.bt_save.UseTransparentBackground = true;
            this.bt_save.Click += new System.EventHandler(this.bt_save_Click);
            // 
            // txt_tenp
            // 
            this.txt_tenp.Animated = true;
            this.txt_tenp.BorderColor = System.Drawing.Color.DimGray;
            this.txt_tenp.BorderRadius = 8;
            this.txt_tenp.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_tenp.DefaultText = "";
            this.txt_tenp.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_tenp.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_tenp.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_tenp.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_tenp.FillColor = System.Drawing.Color.DimGray;
            this.txt_tenp.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_tenp.Font = new System.Drawing.Font("Times New Roman", 10.8F);
            this.txt_tenp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(175)))), ((int)(((byte)(243)))));
            this.txt_tenp.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_tenp.IconLeft = ((System.Drawing.Image)(resources.GetObject("txt_tenp.IconLeft")));
            this.txt_tenp.IconLeftSize = new System.Drawing.Size(40, 40);
            this.txt_tenp.Location = new System.Drawing.Point(329, 4);
            this.txt_tenp.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_tenp.Name = "txt_tenp";
            this.txt_tenp.PasswordChar = '\0';
            this.txt_tenp.PlaceholderText = "";
            this.txt_tenp.ReadOnly = true;
            this.txt_tenp.SelectedText = "";
            this.txt_tenp.Size = new System.Drawing.Size(381, 37);
            this.txt_tenp.TabIndex = 114;
            this.txt_tenp.Tag = "0";
            this.txt_tenp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // bt_f5
            // 
            this.bt_f5.Animated = true;
            this.bt_f5.BackColor = System.Drawing.Color.Transparent;
            this.bt_f5.BorderRadius = 8;
            this.bt_f5.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.bt_f5.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.bt_f5.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.bt_f5.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.bt_f5.FillColor = System.Drawing.Color.RosyBrown;
            this.bt_f5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_f5.ForeColor = System.Drawing.Color.Pink;
            this.bt_f5.Image = ((System.Drawing.Image)(resources.GetObject("bt_f5.Image")));
            this.bt_f5.ImageSize = new System.Drawing.Size(40, 40);
            this.bt_f5.Location = new System.Drawing.Point(594, 455);
            this.bt_f5.Margin = new System.Windows.Forms.Padding(5);
            this.bt_f5.Name = "bt_f5";
            this.bt_f5.Size = new System.Drawing.Size(162, 46);
            this.bt_f5.TabIndex = 19;
            this.bt_f5.Text = "Làm mới";
            this.bt_f5.UseTransparentBackground = true;
            this.bt_f5.Click += new System.EventHandler(this.bt_f5_Click);
            // 
            // UseMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(1161, 503);
            this.Controls.Add(this.bt_f5);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.bt_exit);
            this.Controls.Add(this.bt_save);
            this.Controls.Add(this.txt_tenp);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "UseMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UseMenu";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.pn_added.ResumeLayout(false);
            this.flp_added.ResumeLayout(false);
            this.pn_columnadded.ResumeLayout(false);
            this.pn_dsmenu.ResumeLayout(false);
            this.pn_dsmenu.PerformLayout();
            this.flp_menu.ResumeLayout(false);
            this.pn_column.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button bt_exit;
        private Guna.UI2.WinForms.Guna2Button bt_save;
        private Guna.UI2.WinForms.Guna2TextBox txt_tenp;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel pn_dsmenu;
        private System.Windows.Forms.FlowLayoutPanel flp_menu;
        private System.Windows.Forms.Panel pn_column;
        private System.Windows.Forms.Label lb_lmn;
        private System.Windows.Forms.Label lb_bt;
        private System.Windows.Forms.Label lb_giab;
        private System.Windows.Forms.Label lb_nmn;
        private Guna.UI2.WinForms.Guna2TextBox txt_timmenu;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2ComboBox cbx_type;
        private System.Windows.Forms.Label lb_dsmn;
        private System.Windows.Forms.Panel pn_added;
        private System.Windows.Forms.FlowLayoutPanel flp_added;
        private System.Windows.Forms.Panel pn_columnadded;
        private System.Windows.Forms.Label lb_mnsell;
        private System.Windows.Forms.Label lb_ngay;
        private System.Windows.Forms.Label lb_sl;
        private System.Windows.Forms.Label lb_btx;
        private System.Windows.Forms.Label lb_price;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2Button bt_f5;
    }
}