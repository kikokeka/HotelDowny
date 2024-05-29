namespace GUI.ManageSys
{
    partial class RoomForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RoomForm));
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("");
            this.tbly_roomtype = new System.Windows.Forms.TableLayoutPanel();
            this.pn_in4 = new System.Windows.Forms.Panel();
            this.txt_mota = new Guna.UI2.WinForms.Guna2TextBox();
            this.cbx_type = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lb_type = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txt_name = new Guna.UI2.WinForms.Guna2TextBox();
            this.pn_logo = new System.Windows.Forms.Panel();
            this.lb_message = new System.Windows.Forms.Label();
            this.bt_save = new Guna.UI2.WinForms.Guna2Button();
            this.bt_xoa = new Guna.UI2.WinForms.Guna2Button();
            this.pn_control = new Guna.UI2.WinForms.Guna2Panel();
            this.bt_xoaall = new Guna.UI2.WinForms.Guna2Button();
            this.bt_add = new Guna.UI2.WinForms.Guna2Button();
            this.tbly_data = new System.Windows.Forms.TableLayoutPanel();
            this.txt_find = new Guna.UI2.WinForms.Guna2TextBox();
            this.pn_data = new System.Windows.Forms.Panel();
            this.lsv_room = new System.Windows.Forms.ListView();
            this.ten = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Type = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.note = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lb_seperate = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tbly_roomtype.SuspendLayout();
            this.pn_in4.SuspendLayout();
            this.pn_logo.SuspendLayout();
            this.pn_control.SuspendLayout();
            this.tbly_data.SuspendLayout();
            this.pn_data.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbly_roomtype
            // 
            this.tbly_roomtype.BackColor = System.Drawing.Color.AliceBlue;
            this.tbly_roomtype.ColumnCount = 2;
            this.tbly_roomtype.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tbly_roomtype.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tbly_roomtype.Controls.Add(this.pn_in4, 1, 1);
            this.tbly_roomtype.Controls.Add(this.pn_logo, 1, 0);
            this.tbly_roomtype.Controls.Add(this.pn_control, 0, 0);
            this.tbly_roomtype.Controls.Add(this.tbly_data, 0, 1);
            this.tbly_roomtype.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbly_roomtype.Location = new System.Drawing.Point(0, 0);
            this.tbly_roomtype.Margin = new System.Windows.Forms.Padding(5);
            this.tbly_roomtype.Name = "tbly_roomtype";
            this.tbly_roomtype.RowCount = 2;
            this.tbly_roomtype.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.tbly_roomtype.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 92F));
            this.tbly_roomtype.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tbly_roomtype.Size = new System.Drawing.Size(1273, 647);
            this.tbly_roomtype.TabIndex = 2;
            // 
            // pn_in4
            // 
            this.pn_in4.Controls.Add(this.txt_mota);
            this.pn_in4.Controls.Add(this.cbx_type);
            this.pn_in4.Controls.Add(this.lb_type);
            this.pn_in4.Controls.Add(this.txt_name);
            this.pn_in4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pn_in4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pn_in4.Location = new System.Drawing.Point(959, 56);
            this.pn_in4.Margin = new System.Windows.Forms.Padding(5);
            this.pn_in4.Name = "pn_in4";
            this.pn_in4.Size = new System.Drawing.Size(309, 586);
            this.pn_in4.TabIndex = 1;
            // 
            // txt_mota
            // 
            this.txt_mota.Animated = true;
            this.txt_mota.BorderColor = System.Drawing.Color.RosyBrown;
            this.txt_mota.BorderRadius = 8;
            this.txt_mota.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_mota.DefaultText = "";
            this.txt_mota.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_mota.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_mota.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_mota.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_mota.FillColor = System.Drawing.Color.AliceBlue;
            this.txt_mota.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_mota.Font = new System.Drawing.Font("Times New Roman", 10.8F);
            this.txt_mota.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_mota.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_mota.Location = new System.Drawing.Point(2, 175);
            this.txt_mota.Margin = new System.Windows.Forms.Padding(7);
            this.txt_mota.Name = "txt_mota";
            this.txt_mota.PasswordChar = '\0';
            this.txt_mota.PlaceholderForeColor = System.Drawing.SystemColors.GrayText;
            this.txt_mota.PlaceholderText = "Mô tả(có thể trống)";
            this.txt_mota.SelectedText = "";
            this.txt_mota.Size = new System.Drawing.Size(307, 41);
            this.txt_mota.TabIndex = 17;
            this.txt_mota.Tag = "0";
            // 
            // cbx_type
            // 
            this.cbx_type.BackColor = System.Drawing.Color.Transparent;
            this.cbx_type.BorderColor = System.Drawing.Color.RosyBrown;
            this.cbx_type.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbx_type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_type.FillColor = System.Drawing.Color.AliceBlue;
            this.cbx_type.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbx_type.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbx_type.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_type.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cbx_type.ItemHeight = 30;
            this.cbx_type.Location = new System.Drawing.Point(2, 114);
            this.cbx_type.Margin = new System.Windows.Forms.Padding(5);
            this.cbx_type.Name = "cbx_type";
            this.cbx_type.Size = new System.Drawing.Size(307, 36);
            this.cbx_type.TabIndex = 15;
            // 
            // lb_type
            // 
            this.lb_type.BackColor = System.Drawing.Color.AliceBlue;
            this.lb_type.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_type.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lb_type.Location = new System.Drawing.Point(0, 97);
            this.lb_type.Margin = new System.Windows.Forms.Padding(5);
            this.lb_type.Name = "lb_type";
            this.lb_type.Size = new System.Drawing.Size(76, 20);
            this.lb_type.TabIndex = 16;
            this.lb_type.Text = "Loại phòng";
            // 
            // txt_name
            // 
            this.txt_name.Animated = true;
            this.txt_name.BorderColor = System.Drawing.Color.RosyBrown;
            this.txt_name.BorderRadius = 8;
            this.txt_name.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_name.DefaultText = "";
            this.txt_name.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_name.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_name.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_name.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_name.FillColor = System.Drawing.Color.AliceBlue;
            this.txt_name.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_name.Font = new System.Drawing.Font("Times New Roman", 10.8F);
            this.txt_name.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_name.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_name.Location = new System.Drawing.Point(2, 41);
            this.txt_name.Margin = new System.Windows.Forms.Padding(7);
            this.txt_name.Name = "txt_name";
            this.txt_name.PasswordChar = '\0';
            this.txt_name.PlaceholderForeColor = System.Drawing.SystemColors.GrayText;
            this.txt_name.PlaceholderText = "Tên phòng";
            this.txt_name.SelectedText = "";
            this.txt_name.Size = new System.Drawing.Size(307, 41);
            this.txt_name.TabIndex = 6;
            this.txt_name.Tag = "0";
            // 
            // pn_logo
            // 
            this.pn_logo.BackColor = System.Drawing.Color.AliceBlue;
            this.pn_logo.Controls.Add(this.lb_message);
            this.pn_logo.Controls.Add(this.bt_save);
            this.pn_logo.Controls.Add(this.bt_xoa);
            this.pn_logo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pn_logo.Location = new System.Drawing.Point(959, 5);
            this.pn_logo.Margin = new System.Windows.Forms.Padding(5);
            this.pn_logo.Name = "pn_logo";
            this.pn_logo.Size = new System.Drawing.Size(309, 41);
            this.pn_logo.TabIndex = 0;
            // 
            // lb_message
            // 
            this.lb_message.BackColor = System.Drawing.Color.AliceBlue;
            this.lb_message.Dock = System.Windows.Forms.DockStyle.Left;
            this.lb_message.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_message.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lb_message.Location = new System.Drawing.Point(0, 0);
            this.lb_message.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lb_message.Name = "lb_message";
            this.lb_message.Size = new System.Drawing.Size(120, 41);
            this.lb_message.TabIndex = 0;
            this.lb_message.Text = "label1";
            this.lb_message.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.bt_save.Location = new System.Drawing.Point(145, 0);
            this.bt_save.Margin = new System.Windows.Forms.Padding(5);
            this.bt_save.Name = "bt_save";
            this.bt_save.Size = new System.Drawing.Size(76, 41);
            this.bt_save.TabIndex = 8;
            this.bt_save.Text = "Lưu";
            this.bt_save.UseTransparentBackground = true;
            this.bt_save.Click += new System.EventHandler(this.bt_save_Click);
            // 
            // bt_xoa
            // 
            this.bt_xoa.Animated = true;
            this.bt_xoa.BackColor = System.Drawing.Color.Transparent;
            this.bt_xoa.BorderRadius = 8;
            this.bt_xoa.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.bt_xoa.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.bt_xoa.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.bt_xoa.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.bt_xoa.Dock = System.Windows.Forms.DockStyle.Right;
            this.bt_xoa.FillColor = System.Drawing.Color.AliceBlue;
            this.bt_xoa.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_xoa.ForeColor = System.Drawing.Color.Red;
            this.bt_xoa.Image = ((System.Drawing.Image)(resources.GetObject("bt_xoa.Image")));
            this.bt_xoa.ImageSize = new System.Drawing.Size(30, 30);
            this.bt_xoa.Location = new System.Drawing.Point(221, 0);
            this.bt_xoa.Margin = new System.Windows.Forms.Padding(5);
            this.bt_xoa.Name = "bt_xoa";
            this.bt_xoa.Size = new System.Drawing.Size(88, 41);
            this.bt_xoa.TabIndex = 9;
            this.bt_xoa.Text = "Xóa";
            this.bt_xoa.UseTransparentBackground = true;
            this.bt_xoa.Click += new System.EventHandler(this.bt_xoa_Click);
            // 
            // pn_control
            // 
            this.pn_control.Controls.Add(this.bt_xoaall);
            this.pn_control.Controls.Add(this.bt_add);
            this.pn_control.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pn_control.Location = new System.Drawing.Point(5, 5);
            this.pn_control.Margin = new System.Windows.Forms.Padding(5);
            this.pn_control.Name = "pn_control";
            this.pn_control.Size = new System.Drawing.Size(944, 41);
            this.pn_control.TabIndex = 9;
            // 
            // bt_xoaall
            // 
            this.bt_xoaall.Animated = true;
            this.bt_xoaall.BackColor = System.Drawing.Color.Transparent;
            this.bt_xoaall.BorderRadius = 8;
            this.bt_xoaall.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.bt_xoaall.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.bt_xoaall.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.bt_xoaall.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.bt_xoaall.Dock = System.Windows.Forms.DockStyle.Left;
            this.bt_xoaall.FillColor = System.Drawing.Color.AliceBlue;
            this.bt_xoaall.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_xoaall.ForeColor = System.Drawing.Color.Red;
            this.bt_xoaall.Image = ((System.Drawing.Image)(resources.GetObject("bt_xoaall.Image")));
            this.bt_xoaall.ImageSize = new System.Drawing.Size(40, 40);
            this.bt_xoaall.Location = new System.Drawing.Point(146, 0);
            this.bt_xoaall.Margin = new System.Windows.Forms.Padding(5);
            this.bt_xoaall.Name = "bt_xoaall";
            this.bt_xoaall.Size = new System.Drawing.Size(166, 41);
            this.bt_xoaall.TabIndex = 8;
            this.bt_xoaall.Text = "Xóa toàn bộ";
            this.bt_xoaall.UseTransparentBackground = true;
            this.bt_xoaall.Click += new System.EventHandler(this.bt_xoaall_Click);
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
            this.bt_add.Size = new System.Drawing.Size(146, 41);
            this.bt_add.TabIndex = 7;
            this.bt_add.Text = "Thêm mới";
            this.bt_add.UseTransparentBackground = true;
            this.bt_add.Click += new System.EventHandler(this.bt_add_Click);
            // 
            // tbly_data
            // 
            this.tbly_data.ColumnCount = 1;
            this.tbly_data.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tbly_data.Controls.Add(this.txt_find, 0, 0);
            this.tbly_data.Controls.Add(this.pn_data, 0, 1);
            this.tbly_data.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbly_data.Location = new System.Drawing.Point(5, 56);
            this.tbly_data.Margin = new System.Windows.Forms.Padding(5);
            this.tbly_data.Name = "tbly_data";
            this.tbly_data.RowCount = 2;
            this.tbly_data.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.tbly_data.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 92F));
            this.tbly_data.Size = new System.Drawing.Size(944, 586);
            this.tbly_data.TabIndex = 10;
            // 
            // txt_find
            // 
            this.txt_find.Animated = true;
            this.txt_find.BorderColor = System.Drawing.Color.RosyBrown;
            this.txt_find.BorderRadius = 8;
            this.txt_find.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_find.DefaultText = "";
            this.txt_find.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_find.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_find.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_find.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_find.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_find.FillColor = System.Drawing.Color.AliceBlue;
            this.txt_find.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_find.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.txt_find.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_find.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_find.Location = new System.Drawing.Point(5, 5);
            this.txt_find.Margin = new System.Windows.Forms.Padding(5);
            this.txt_find.Name = "txt_find";
            this.txt_find.PasswordChar = '\0';
            this.txt_find.PlaceholderForeColor = System.Drawing.SystemColors.GrayText;
            this.txt_find.PlaceholderText = "Tìm kiếm";
            this.txt_find.SelectedText = "";
            this.txt_find.Size = new System.Drawing.Size(934, 36);
            this.txt_find.TabIndex = 5;
            this.txt_find.TextChanged += new System.EventHandler(this.txt_find_TextChanged);
            // 
            // pn_data
            // 
            this.pn_data.BackColor = System.Drawing.Color.AliceBlue;
            this.pn_data.Controls.Add(this.lsv_room);
            this.pn_data.Controls.Add(this.lb_seperate);
            this.pn_data.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pn_data.Location = new System.Drawing.Point(5, 51);
            this.pn_data.Margin = new System.Windows.Forms.Padding(5);
            this.pn_data.Name = "pn_data";
            this.pn_data.Size = new System.Drawing.Size(934, 530);
            this.pn_data.TabIndex = 0;
            // 
            // lsv_room
            // 
            this.lsv_room.BackColor = System.Drawing.Color.AliceBlue;
            this.lsv_room.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ten,
            this.Type,
            this.note});
            this.lsv_room.Dock = System.Windows.Forms.DockStyle.Top;
            this.lsv_room.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsv_room.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lsv_room.FullRowSelect = true;
            this.lsv_room.GridLines = true;
            this.lsv_room.HideSelection = false;
            this.lsv_room.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.lsv_room.Location = new System.Drawing.Point(0, 31);
            this.lsv_room.Margin = new System.Windows.Forms.Padding(5);
            this.lsv_room.Name = "lsv_room";
            this.lsv_room.Size = new System.Drawing.Size(934, 271);
            this.lsv_room.TabIndex = 92;
            this.lsv_room.UseCompatibleStateImageBehavior = false;
            this.lsv_room.View = System.Windows.Forms.View.Details;
            this.lsv_room.SelectedIndexChanged += new System.EventHandler(this.lsv_room_SelectedIndexChanged);
            // 
            // ten
            // 
            this.ten.Text = "Tên phòng";
            this.ten.Width = 150;
            // 
            // Type
            // 
            this.Type.Text = "Loại phòng";
            this.Type.Width = 155;
            // 
            // note
            // 
            this.note.Text = "Mô tả";
            this.note.Width = 594;
            // 
            // lb_seperate
            // 
            this.lb_seperate.Dock = System.Windows.Forms.DockStyle.Top;
            this.lb_seperate.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lb_seperate.Location = new System.Drawing.Point(0, 0);
            this.lb_seperate.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lb_seperate.Name = "lb_seperate";
            this.lb_seperate.Size = new System.Drawing.Size(934, 31);
            this.lb_seperate.TabIndex = 10;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // RoomForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1273, 647);
            this.Controls.Add(this.tbly_roomtype);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "RoomForm";
            this.Text = "RoomForm";
            this.tbly_roomtype.ResumeLayout(false);
            this.pn_in4.ResumeLayout(false);
            this.pn_in4.PerformLayout();
            this.pn_logo.ResumeLayout(false);
            this.pn_control.ResumeLayout(false);
            this.tbly_data.ResumeLayout(false);
            this.pn_data.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tbly_roomtype;
        private System.Windows.Forms.Panel pn_in4;
        private Guna.UI2.WinForms.Guna2TextBox txt_name;
        private System.Windows.Forms.Panel pn_logo;
        private System.Windows.Forms.Label lb_message;
        private Guna.UI2.WinForms.Guna2Button bt_save;
        private Guna.UI2.WinForms.Guna2Button bt_xoa;
        private Guna.UI2.WinForms.Guna2Panel pn_control;
        private Guna.UI2.WinForms.Guna2Button bt_xoaall;
        private Guna.UI2.WinForms.Guna2Button bt_add;
        private System.Windows.Forms.TableLayoutPanel tbly_data;
        private Guna.UI2.WinForms.Guna2TextBox txt_find;
        private System.Windows.Forms.Panel pn_data;
        private System.Windows.Forms.Label lb_seperate;
        private Guna.UI2.WinForms.Guna2ComboBox cbx_type;
        private Guna.UI2.WinForms.Guna2HtmlLabel lb_type;
        private Guna.UI2.WinForms.Guna2TextBox txt_mota;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ListView lsv_room;
        private System.Windows.Forms.ColumnHeader ten;
        private System.Windows.Forms.ColumnHeader Type;
        private System.Windows.Forms.ColumnHeader note;
    }
}