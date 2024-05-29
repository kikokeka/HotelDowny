namespace GUI.Booking
{
    partial class Byroom
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Byroom));
            this.tbly_byroom = new System.Windows.Forms.TableLayoutPanel();
            this.pn_in4 = new System.Windows.Forms.Panel();
            this.dtgrv_info = new System.Windows.Forms.DataGridView();
            this.pn_note = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bt_find = new Guna.UI2.WinForms.Guna2Button();
            this.txt_name = new Guna.UI2.WinForms.Guna2TextBox();
            this.cbx_roomtype = new System.Windows.Forms.ComboBox();
            this.dtpk_end = new System.Windows.Forms.DateTimePicker();
            this.dtpk_start = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.pn_button = new System.Windows.Forms.Panel();
            this.bt_refresh = new Guna.UI2.WinForms.Guna2Button();
            this.bt_add = new Guna.UI2.WinForms.Guna2Button();
            this.pn_insert = new System.Windows.Forms.Panel();
            this.pn_np = new System.Windows.Forms.Panel();
            this.flp_phong = new System.Windows.Forms.FlowLayoutPanel();
            this.bt_addroom = new Guna.UI2.WinForms.Guna2Button();
            this.cbx_type = new System.Windows.Forms.ComboBox();
            this.lb_type = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txt_namekh = new Guna.UI2.WinForms.Guna2TextBox();
            this.lb_error = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.pn_logo = new System.Windows.Forms.Panel();
            this.bt_np = new Guna.UI2.WinForms.Guna2Button();
            this.lb_message = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.ctx_menu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ctx_update = new System.Windows.Forms.ToolStripMenuItem();
            this.ctx_np = new System.Windows.Forms.ToolStripMenuItem();
            this.ctx_cancel = new System.Windows.Forms.ToolStripMenuItem();
            this.ctx_del = new System.Windows.Forms.ToolStripMenuItem();
            this.tbly_byroom.SuspendLayout();
            this.pn_in4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrv_info)).BeginInit();
            this.pn_note.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pn_button.SuspendLayout();
            this.pn_insert.SuspendLayout();
            this.pn_np.SuspendLayout();
            this.pn_logo.SuspendLayout();
            this.ctx_menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbly_byroom
            // 
            this.tbly_byroom.BackColor = System.Drawing.Color.AliceBlue;
            this.tbly_byroom.ColumnCount = 2;
            this.tbly_byroom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75.17675F));
            this.tbly_byroom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.82325F));
            this.tbly_byroom.Controls.Add(this.pn_in4, 0, 0);
            this.tbly_byroom.Controls.Add(this.pn_insert, 1, 0);
            this.tbly_byroom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbly_byroom.Location = new System.Drawing.Point(0, 0);
            this.tbly_byroom.Margin = new System.Windows.Forms.Padding(5);
            this.tbly_byroom.Name = "tbly_byroom";
            this.tbly_byroom.RowCount = 1;
            this.tbly_byroom.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tbly_byroom.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 647F));
            this.tbly_byroom.Size = new System.Drawing.Size(1296, 647);
            this.tbly_byroom.TabIndex = 0;
            // 
            // pn_in4
            // 
            this.pn_in4.BackColor = System.Drawing.Color.AliceBlue;
            this.pn_in4.Controls.Add(this.dtgrv_info);
            this.pn_in4.Controls.Add(this.pn_note);
            this.pn_in4.Controls.Add(this.panel1);
            this.pn_in4.Controls.Add(this.label2);
            this.pn_in4.Controls.Add(this.pn_button);
            this.pn_in4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pn_in4.Location = new System.Drawing.Point(5, 5);
            this.pn_in4.Margin = new System.Windows.Forms.Padding(5);
            this.pn_in4.Name = "pn_in4";
            this.pn_in4.Size = new System.Drawing.Size(964, 637);
            this.pn_in4.TabIndex = 10;
            // 
            // dtgrv_info
            // 
            this.dtgrv_info.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dtgrv_info.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            this.dtgrv_info.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dtgrv_info.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dtgrv_info.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgrv_info.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtgrv_info.Dock = System.Windows.Forms.DockStyle.Top;
            this.dtgrv_info.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dtgrv_info.Location = new System.Drawing.Point(0, 118);
            this.dtgrv_info.Margin = new System.Windows.Forms.Padding(5);
            this.dtgrv_info.Name = "dtgrv_info";
            this.dtgrv_info.ReadOnly = true;
            this.dtgrv_info.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dtgrv_info.RowTemplate.Height = 24;
            this.dtgrv_info.Size = new System.Drawing.Size(964, 408);
            this.dtgrv_info.TabIndex = 18;
            this.dtgrv_info.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgrv_info_CellClick);
            // 
            // pn_note
            // 
            this.pn_note.Controls.Add(this.label4);
            this.pn_note.Controls.Add(this.label5);
            this.pn_note.Controls.Add(this.label6);
            this.pn_note.Controls.Add(this.label7);
            this.pn_note.Controls.Add(this.label8);
            this.pn_note.Controls.Add(this.label3);
            this.pn_note.Dock = System.Windows.Forms.DockStyle.Top;
            this.pn_note.Location = new System.Drawing.Point(0, 90);
            this.pn_note.Margin = new System.Windows.Forms.Padding(5);
            this.pn_note.Name = "pn_note";
            this.pn_note.Size = new System.Drawing.Size(964, 28);
            this.pn_note.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.Dock = System.Windows.Forms.DockStyle.Left;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(352, 0);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 28);
            this.label4.TabIndex = 25;
            this.label4.Text = "Đã trả phòng";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Yellow;
            this.label5.Dock = System.Windows.Forms.DockStyle.Left;
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(322, 0);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 28);
            this.label5.TabIndex = 28;
            // 
            // label6
            // 
            this.label6.Dock = System.Windows.Forms.DockStyle.Left;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label6.Location = new System.Drawing.Point(183, 0);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(139, 28);
            this.label6.TabIndex = 26;
            this.label6.Text = "Chưa nhận phòng";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Blue;
            this.label7.Dock = System.Windows.Forms.DockStyle.Left;
            this.label7.ForeColor = System.Drawing.SystemColors.Control;
            this.label7.Location = new System.Drawing.Point(153, 0);
            this.label7.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(30, 28);
            this.label7.TabIndex = 29;
            // 
            // label8
            // 
            this.label8.Dock = System.Windows.Forms.DockStyle.Left;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label8.Location = new System.Drawing.Point(30, 0);
            this.label8.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(123, 28);
            this.label8.TabIndex = 27;
            this.label8.Text = "Đã nhận phòng";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Pink;
            this.label3.Dock = System.Windows.Forms.DockStyle.Left;
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 28);
            this.label3.TabIndex = 24;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.bt_find);
            this.panel1.Controls.Add(this.txt_name);
            this.panel1.Controls.Add(this.cbx_roomtype);
            this.panel1.Controls.Add(this.dtpk_end);
            this.panel1.Controls.Add(this.dtpk_start);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 63);
            this.panel1.Margin = new System.Windows.Forms.Padding(5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(964, 27);
            this.panel1.TabIndex = 13;
            // 
            // bt_find
            // 
            this.bt_find.Animated = true;
            this.bt_find.BackColor = System.Drawing.Color.Transparent;
            this.bt_find.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.bt_find.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.bt_find.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.bt_find.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.bt_find.Dock = System.Windows.Forms.DockStyle.Left;
            this.bt_find.FillColor = System.Drawing.Color.AliceBlue;
            this.bt_find.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bt_find.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bt_find.Image = ((System.Drawing.Image)(resources.GetObject("bt_find.Image")));
            this.bt_find.ImageSize = new System.Drawing.Size(50, 50);
            this.bt_find.Location = new System.Drawing.Point(709, 0);
            this.bt_find.Margin = new System.Windows.Forms.Padding(5);
            this.bt_find.Name = "bt_find";
            this.bt_find.Size = new System.Drawing.Size(66, 27);
            this.bt_find.TabIndex = 15;
            this.bt_find.UseTransparentBackground = true;
            this.bt_find.Click += new System.EventHandler(this.bt_find_Click);
            // 
            // txt_name
            // 
            this.txt_name.Animated = true;
            this.txt_name.BackColor = System.Drawing.Color.AliceBlue;
            this.txt_name.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_name.DefaultText = "";
            this.txt_name.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_name.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_name.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_name.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_name.Dock = System.Windows.Forms.DockStyle.Left;
            this.txt_name.FillColor = System.Drawing.Color.AliceBlue;
            this.txt_name.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.txt_name.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_name.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_name.Location = new System.Drawing.Point(555, 0);
            this.txt_name.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.txt_name.Name = "txt_name";
            this.txt_name.PasswordChar = '\0';
            this.txt_name.PlaceholderText = "";
            this.txt_name.SelectedText = "";
            this.txt_name.Size = new System.Drawing.Size(154, 27);
            this.txt_name.TabIndex = 12;
            // 
            // cbx_roomtype
            // 
            this.cbx_roomtype.BackColor = System.Drawing.Color.AliceBlue;
            this.cbx_roomtype.Dock = System.Windows.Forms.DockStyle.Left;
            this.cbx_roomtype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_roomtype.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbx_roomtype.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_roomtype.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cbx_roomtype.FormattingEnabled = true;
            this.cbx_roomtype.Items.AddRange(new object[] {
            "Tất cả"});
            this.cbx_roomtype.Location = new System.Drawing.Point(380, 0);
            this.cbx_roomtype.Margin = new System.Windows.Forms.Padding(5);
            this.cbx_roomtype.Name = "cbx_roomtype";
            this.cbx_roomtype.Size = new System.Drawing.Size(175, 28);
            this.cbx_roomtype.TabIndex = 11;
            // 
            // dtpk_end
            // 
            this.dtpk_end.Dock = System.Windows.Forms.DockStyle.Left;
            this.dtpk_end.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpk_end.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpk_end.Location = new System.Drawing.Point(181, 0);
            this.dtpk_end.Margin = new System.Windows.Forms.Padding(5);
            this.dtpk_end.Name = "dtpk_end";
            this.dtpk_end.Size = new System.Drawing.Size(199, 28);
            this.dtpk_end.TabIndex = 10;
            this.dtpk_end.Value = new System.DateTime(2024, 1, 3, 0, 0, 0, 0);
            // 
            // dtpk_start
            // 
            this.dtpk_start.Dock = System.Windows.Forms.DockStyle.Left;
            this.dtpk_start.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpk_start.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpk_start.Location = new System.Drawing.Point(0, 0);
            this.dtpk_start.Margin = new System.Windows.Forms.Padding(5);
            this.dtpk_start.Name = "dtpk_start";
            this.dtpk_start.Size = new System.Drawing.Size(181, 28);
            this.dtpk_start.TabIndex = 9;
            this.dtpk_start.Value = new System.DateTime(2024, 1, 3, 0, 0, 0, 0);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(0, 43);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(748, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "Từ ngày                                  Đến ngày                                " +
    " Loại phòng                       Tên phòng\r\n";
            // 
            // pn_button
            // 
            this.pn_button.Controls.Add(this.bt_refresh);
            this.pn_button.Controls.Add(this.bt_add);
            this.pn_button.Dock = System.Windows.Forms.DockStyle.Top;
            this.pn_button.Location = new System.Drawing.Point(0, 0);
            this.pn_button.Margin = new System.Windows.Forms.Padding(5);
            this.pn_button.Name = "pn_button";
            this.pn_button.Size = new System.Drawing.Size(964, 43);
            this.pn_button.TabIndex = 17;
            // 
            // bt_refresh
            // 
            this.bt_refresh.Animated = true;
            this.bt_refresh.BackColor = System.Drawing.Color.Transparent;
            this.bt_refresh.BorderRadius = 8;
            this.bt_refresh.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.bt_refresh.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.bt_refresh.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.bt_refresh.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.bt_refresh.Dock = System.Windows.Forms.DockStyle.Left;
            this.bt_refresh.FillColor = System.Drawing.Color.AliceBlue;
            this.bt_refresh.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_refresh.ForeColor = System.Drawing.Color.Pink;
            this.bt_refresh.Image = ((System.Drawing.Image)(resources.GetObject("bt_refresh.Image")));
            this.bt_refresh.ImageSize = new System.Drawing.Size(40, 40);
            this.bt_refresh.Location = new System.Drawing.Point(162, 0);
            this.bt_refresh.Margin = new System.Windows.Forms.Padding(5);
            this.bt_refresh.Name = "bt_refresh";
            this.bt_refresh.Size = new System.Drawing.Size(162, 43);
            this.bt_refresh.TabIndex = 18;
            this.bt_refresh.Text = "Làm mới";
            this.bt_refresh.UseTransparentBackground = true;
            this.bt_refresh.Click += new System.EventHandler(this.bt_refresh_Click);
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
            this.bt_add.Dock = System.Windows.Forms.DockStyle.Left;
            this.bt_add.FillColor = System.Drawing.Color.AliceBlue;
            this.bt_add.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_add.ForeColor = System.Drawing.Color.Green;
            this.bt_add.Image = ((System.Drawing.Image)(resources.GetObject("bt_add.Image")));
            this.bt_add.ImageSize = new System.Drawing.Size(40, 40);
            this.bt_add.Location = new System.Drawing.Point(0, 0);
            this.bt_add.Margin = new System.Windows.Forms.Padding(5);
            this.bt_add.Name = "bt_add";
            this.bt_add.Size = new System.Drawing.Size(162, 43);
            this.bt_add.TabIndex = 17;
            this.bt_add.Text = "Thêm mới";
            this.bt_add.UseTransparentBackground = true;
            this.bt_add.Click += new System.EventHandler(this.bt_add_Click);
            // 
            // pn_insert
            // 
            this.pn_insert.Controls.Add(this.pn_np);
            this.pn_insert.Dock = System.Windows.Forms.DockStyle.Right;
            this.pn_insert.Location = new System.Drawing.Point(979, 5);
            this.pn_insert.Margin = new System.Windows.Forms.Padding(5);
            this.pn_insert.Name = "pn_insert";
            this.pn_insert.Size = new System.Drawing.Size(312, 637);
            this.pn_insert.TabIndex = 11;
            // 
            // pn_np
            // 
            this.pn_np.BackColor = System.Drawing.Color.AliceBlue;
            this.pn_np.Controls.Add(this.flp_phong);
            this.pn_np.Controls.Add(this.bt_addroom);
            this.pn_np.Controls.Add(this.cbx_type);
            this.pn_np.Controls.Add(this.lb_type);
            this.pn_np.Controls.Add(this.txt_namekh);
            this.pn_np.Controls.Add(this.lb_error);
            this.pn_np.Controls.Add(this.pn_logo);
            this.pn_np.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pn_np.Location = new System.Drawing.Point(0, 0);
            this.pn_np.Margin = new System.Windows.Forms.Padding(5);
            this.pn_np.Name = "pn_np";
            this.pn_np.Size = new System.Drawing.Size(312, 637);
            this.pn_np.TabIndex = 12;
            // 
            // flp_phong
            // 
            this.flp_phong.BackColor = System.Drawing.Color.AliceBlue;
            this.flp_phong.Dock = System.Windows.Forms.DockStyle.Top;
            this.flp_phong.Location = new System.Drawing.Point(0, 253);
            this.flp_phong.Margin = new System.Windows.Forms.Padding(5);
            this.flp_phong.Name = "flp_phong";
            this.flp_phong.Size = new System.Drawing.Size(312, 53);
            this.flp_phong.TabIndex = 90;
            // 
            // bt_addroom
            // 
            this.bt_addroom.Animated = true;
            this.bt_addroom.BackColor = System.Drawing.Color.Transparent;
            this.bt_addroom.BorderRadius = 8;
            this.bt_addroom.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.bt_addroom.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.bt_addroom.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.bt_addroom.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.bt_addroom.Dock = System.Windows.Forms.DockStyle.Top;
            this.bt_addroom.FillColor = System.Drawing.Color.AliceBlue;
            this.bt_addroom.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.bt_addroom.ForeColor = System.Drawing.Color.Green;
            this.bt_addroom.Image = ((System.Drawing.Image)(resources.GetObject("bt_addroom.Image")));
            this.bt_addroom.ImageSize = new System.Drawing.Size(40, 40);
            this.bt_addroom.Location = new System.Drawing.Point(0, 192);
            this.bt_addroom.Margin = new System.Windows.Forms.Padding(5);
            this.bt_addroom.Name = "bt_addroom";
            this.bt_addroom.Size = new System.Drawing.Size(312, 61);
            this.bt_addroom.TabIndex = 89;
            this.bt_addroom.Text = "Chọn phòng";
            this.bt_addroom.UseTransparentBackground = true;
            this.bt_addroom.Click += new System.EventHandler(this.bt_addroom_Click);
            // 
            // cbx_type
            // 
            this.cbx_type.BackColor = System.Drawing.Color.AliceBlue;
            this.cbx_type.Dock = System.Windows.Forms.DockStyle.Top;
            this.cbx_type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_type.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbx_type.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_type.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cbx_type.FormattingEnabled = true;
            this.cbx_type.Items.AddRange(new object[] {
            "Thuê theo giờ",
            "Thuê qua đêm",
            "Thuê theo ngày",
            "Thuê theo tháng"});
            this.cbx_type.Location = new System.Drawing.Point(0, 158);
            this.cbx_type.Margin = new System.Windows.Forms.Padding(5);
            this.cbx_type.Name = "cbx_type";
            this.cbx_type.Size = new System.Drawing.Size(312, 34);
            this.cbx_type.TabIndex = 12;
            // 
            // lb_type
            // 
            this.lb_type.BackColor = System.Drawing.Color.AliceBlue;
            this.lb_type.Dock = System.Windows.Forms.DockStyle.Top;
            this.lb_type.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_type.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lb_type.Location = new System.Drawing.Point(0, 134);
            this.lb_type.Margin = new System.Windows.Forms.Padding(5);
            this.lb_type.Name = "lb_type";
            this.lb_type.Size = new System.Drawing.Size(312, 24);
            this.lb_type.TabIndex = 1;
            this.lb_type.Text = "Kiểu thuê";
            // 
            // txt_namekh
            // 
            this.txt_namekh.Animated = true;
            this.txt_namekh.BackColor = System.Drawing.Color.AliceBlue;
            this.txt_namekh.BorderColor = System.Drawing.Color.RosyBrown;
            this.txt_namekh.BorderRadius = 8;
            this.txt_namekh.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_namekh.DefaultText = "";
            this.txt_namekh.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_namekh.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_namekh.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_namekh.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_namekh.Dock = System.Windows.Forms.DockStyle.Top;
            this.txt_namekh.FillColor = System.Drawing.Color.AliceBlue;
            this.txt_namekh.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_namekh.Font = new System.Drawing.Font("Times New Roman", 10.8F);
            this.txt_namekh.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_namekh.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_namekh.Location = new System.Drawing.Point(0, 79);
            this.txt_namekh.Margin = new System.Windows.Forms.Padding(7);
            this.txt_namekh.Name = "txt_namekh";
            this.txt_namekh.PasswordChar = '\0';
            this.txt_namekh.PlaceholderForeColor = System.Drawing.SystemColors.GrayText;
            this.txt_namekh.PlaceholderText = "Họ tên khách hàng";
            this.txt_namekh.ReadOnly = true;
            this.txt_namekh.SelectedText = "";
            this.txt_namekh.Size = new System.Drawing.Size(312, 55);
            this.txt_namekh.TabIndex = 91;
            this.txt_namekh.Tag = "0";
            // 
            // lb_error
            // 
            this.lb_error.AutoSize = false;
            this.lb_error.BackColor = System.Drawing.Color.Transparent;
            this.lb_error.Dock = System.Windows.Forms.DockStyle.Top;
            this.lb_error.ForeColor = System.Drawing.Color.Red;
            this.lb_error.Location = new System.Drawing.Point(0, 43);
            this.lb_error.Margin = new System.Windows.Forms.Padding(5);
            this.lb_error.Name = "lb_error";
            this.lb_error.Size = new System.Drawing.Size(312, 36);
            this.lb_error.TabIndex = 2;
            this.lb_error.Text = null;
            // 
            // pn_logo
            // 
            this.pn_logo.Controls.Add(this.bt_np);
            this.pn_logo.Controls.Add(this.lb_message);
            this.pn_logo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pn_logo.Location = new System.Drawing.Point(0, 0);
            this.pn_logo.Margin = new System.Windows.Forms.Padding(5);
            this.pn_logo.Name = "pn_logo";
            this.pn_logo.Size = new System.Drawing.Size(312, 43);
            this.pn_logo.TabIndex = 0;
            // 
            // bt_np
            // 
            this.bt_np.Animated = true;
            this.bt_np.BackColor = System.Drawing.Color.Transparent;
            this.bt_np.BorderRadius = 8;
            this.bt_np.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.bt_np.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.bt_np.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.bt_np.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.bt_np.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bt_np.FillColor = System.Drawing.Color.AliceBlue;
            this.bt_np.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.bt_np.ForeColor = System.Drawing.Color.Green;
            this.bt_np.Image = ((System.Drawing.Image)(resources.GetObject("bt_np.Image")));
            this.bt_np.ImageSize = new System.Drawing.Size(40, 40);
            this.bt_np.Location = new System.Drawing.Point(171, 0);
            this.bt_np.Margin = new System.Windows.Forms.Padding(5);
            this.bt_np.Name = "bt_np";
            this.bt_np.Size = new System.Drawing.Size(141, 43);
            this.bt_np.TabIndex = 18;
            this.bt_np.Text = "Nhận phòng";
            this.bt_np.UseTransparentBackground = true;
            this.bt_np.Click += new System.EventHandler(this.bt_np_Click);
            // 
            // lb_message
            // 
            this.lb_message.AutoSize = false;
            this.lb_message.BackColor = System.Drawing.Color.Transparent;
            this.lb_message.Dock = System.Windows.Forms.DockStyle.Left;
            this.lb_message.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_message.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lb_message.Location = new System.Drawing.Point(0, 0);
            this.lb_message.Margin = new System.Windows.Forms.Padding(5);
            this.lb_message.Name = "lb_message";
            this.lb_message.Size = new System.Drawing.Size(171, 43);
            this.lb_message.TabIndex = 0;
            this.lb_message.Text = "Chọn phòng";
            this.lb_message.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ctx_menu
            // 
            this.ctx_menu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ctx_menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ctx_update,
            this.ctx_np,
            this.ctx_cancel,
            this.ctx_del});
            this.ctx_menu.Name = "ctx_menu";
            this.ctx_menu.Size = new System.Drawing.Size(182, 108);
            // 
            // ctx_update
            // 
            this.ctx_update.Image = ((System.Drawing.Image)(resources.GetObject("ctx_update.Image")));
            this.ctx_update.Name = "ctx_update";
            this.ctx_update.Size = new System.Drawing.Size(181, 26);
            this.ctx_update.Text = "Chỉnh sửa";
            this.ctx_update.Click += new System.EventHandler(this.ctx_update_Click);
            // 
            // ctx_np
            // 
            this.ctx_np.Image = ((System.Drawing.Image)(resources.GetObject("ctx_np.Image")));
            this.ctx_np.Name = "ctx_np";
            this.ctx_np.Size = new System.Drawing.Size(181, 26);
            this.ctx_np.Text = "Nhận phòng";
            this.ctx_np.Click += new System.EventHandler(this.ctx_np_Click);
            // 
            // ctx_cancel
            // 
            this.ctx_cancel.Image = ((System.Drawing.Image)(resources.GetObject("ctx_cancel.Image")));
            this.ctx_cancel.Name = "ctx_cancel";
            this.ctx_cancel.Size = new System.Drawing.Size(181, 26);
            this.ctx_cancel.Text = "Hủy đặt phòng";
            this.ctx_cancel.Click += new System.EventHandler(this.ctx_cancel_Click);
            // 
            // ctx_del
            // 
            this.ctx_del.Image = ((System.Drawing.Image)(resources.GetObject("ctx_del.Image")));
            this.ctx_del.Name = "ctx_del";
            this.ctx_del.Size = new System.Drawing.Size(181, 26);
            this.ctx_del.Text = "Xóa";
            this.ctx_del.Click += new System.EventHandler(this.ctx_del_Click);
            // 
            // Byroom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(1296, 647);
            this.Controls.Add(this.tbly_byroom);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Byroom";
            this.Text = "Byroom";
            this.tbly_byroom.ResumeLayout(false);
            this.pn_in4.ResumeLayout(false);
            this.pn_in4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrv_info)).EndInit();
            this.pn_note.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.pn_button.ResumeLayout(false);
            this.pn_insert.ResumeLayout(false);
            this.pn_np.ResumeLayout(false);
            this.pn_np.PerformLayout();
            this.pn_logo.ResumeLayout(false);
            this.ctx_menu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tbly_byroom;
        private System.Windows.Forms.Panel pn_in4;
        private System.Windows.Forms.ComboBox cbx_roomtype;
        private System.Windows.Forms.DateTimePicker dtpk_end;
        private System.Windows.Forms.DateTimePicker dtpk_start;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2TextBox txt_name;
        private Guna.UI2.WinForms.Guna2Button bt_find;
        private System.Windows.Forms.Panel pn_note;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ContextMenuStrip ctx_menu;
        private System.Windows.Forms.ToolStripMenuItem ctx_np;
        private System.Windows.Forms.ToolStripMenuItem ctx_cancel;
        private System.Windows.Forms.ToolStripMenuItem ctx_del;
        private System.Windows.Forms.Panel pn_button;
        private Guna.UI2.WinForms.Guna2Button bt_add;
        private System.Windows.Forms.Panel pn_np;
        private System.Windows.Forms.ComboBox cbx_type;
        private Guna.UI2.WinForms.Guna2HtmlLabel lb_type;
        private Guna.UI2.WinForms.Guna2HtmlLabel lb_error;
        private Guna.UI2.WinForms.Guna2Button bt_np;
        private Guna.UI2.WinForms.Guna2HtmlLabel lb_message;
        internal Guna.UI2.WinForms.Guna2Button bt_addroom;
        internal System.Windows.Forms.FlowLayoutPanel flp_phong;
        internal Guna.UI2.WinForms.Guna2TextBox txt_namekh;
        private System.Windows.Forms.DataGridView dtgrv_info;
        private System.Windows.Forms.ToolStripMenuItem ctx_update;
        private System.Windows.Forms.Panel pn_insert;
        private System.Windows.Forms.Panel pn_logo;
        private Guna.UI2.WinForms.Guna2Button bt_refresh;
    }
}