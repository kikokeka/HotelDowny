namespace GUI.Inventory
{
    partial class Status
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Status));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pn_update = new System.Windows.Forms.Panel();
            this.flp_dsmenu = new System.Windows.Forms.FlowLayoutPanel();
            this.pn_col = new System.Windows.Forms.Panel();
            this.lb_sl = new System.Windows.Forms.Label();
            this.lb_nmn = new System.Windows.Forms.Label();
            this.dtpk_ngay = new System.Windows.Forms.DateTimePicker();
            this.pn_logo = new System.Windows.Forms.Panel();
            this.bt_xoa = new Guna.UI2.WinForms.Guna2Button();
            this.lb_mess = new System.Windows.Forms.Label();
            this.bt_save = new Guna.UI2.WinForms.Guna2Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.State = new System.Windows.Forms.TabPage();
            this.dtgrv_kho = new Guna.UI2.WinForms.Guna2DataGridView();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_find = new Guna.UI2.WinForms.Guna2TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.bt_add = new Guna.UI2.WinForms.Guna2Button();
            this.dtgrv_nhapkho = new Guna.UI2.WinForms.Guna2DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpk_start = new System.Windows.Forms.DateTimePicker();
            this.dtpk_end = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bt_find = new Guna.UI2.WinForms.Guna2Button();
            this.pn_update.SuspendLayout();
            this.flp_dsmenu.SuspendLayout();
            this.pn_col.SuspendLayout();
            this.pn_logo.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.State.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrv_kho)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrv_nhapkho)).BeginInit();
            this.SuspendLayout();
            // 
            // pn_update
            // 
            this.pn_update.BackColor = System.Drawing.Color.AliceBlue;
            this.pn_update.Controls.Add(this.flp_dsmenu);
            this.pn_update.Controls.Add(this.dtpk_ngay);
            this.pn_update.Controls.Add(this.pn_logo);
            this.pn_update.Dock = System.Windows.Forms.DockStyle.Right;
            this.pn_update.Location = new System.Drawing.Point(944, 0);
            this.pn_update.Name = "pn_update";
            this.pn_update.Size = new System.Drawing.Size(352, 647);
            this.pn_update.TabIndex = 0;
            // 
            // flp_dsmenu
            // 
            this.flp_dsmenu.AutoScroll = true;
            this.flp_dsmenu.Controls.Add(this.pn_col);
            this.flp_dsmenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flp_dsmenu.ForeColor = System.Drawing.SystemColors.ControlText;
            this.flp_dsmenu.Location = new System.Drawing.Point(6, 156);
            this.flp_dsmenu.Name = "flp_dsmenu";
            this.flp_dsmenu.Size = new System.Drawing.Size(343, 236);
            this.flp_dsmenu.TabIndex = 103;
            // 
            // pn_col
            // 
            this.pn_col.Controls.Add(this.lb_sl);
            this.pn_col.Controls.Add(this.lb_nmn);
            this.pn_col.Dock = System.Windows.Forms.DockStyle.Top;
            this.pn_col.Location = new System.Drawing.Point(3, 3);
            this.pn_col.Name = "pn_col";
            this.pn_col.Size = new System.Drawing.Size(325, 30);
            this.pn_col.TabIndex = 0;
            this.pn_col.Tag = "Column";
            // 
            // lb_sl
            // 
            this.lb_sl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_sl.Location = new System.Drawing.Point(209, 0);
            this.lb_sl.Name = "lb_sl";
            this.lb_sl.Size = new System.Drawing.Size(116, 30);
            this.lb_sl.TabIndex = 1;
            this.lb_sl.Tag = "Column";
            this.lb_sl.Text = " Số lượng";
            this.lb_sl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lb_nmn
            // 
            this.lb_nmn.Dock = System.Windows.Forms.DockStyle.Left;
            this.lb_nmn.Location = new System.Drawing.Point(0, 0);
            this.lb_nmn.Name = "lb_nmn";
            this.lb_nmn.Size = new System.Drawing.Size(209, 30);
            this.lb_nmn.TabIndex = 0;
            this.lb_nmn.Tag = "Column";
            this.lb_nmn.Text = "Tên Menu";
            this.lb_nmn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dtpk_ngay
            // 
            this.dtpk_ngay.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpk_ngay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpk_ngay.Location = new System.Drawing.Point(5, 101);
            this.dtpk_ngay.Margin = new System.Windows.Forms.Padding(5);
            this.dtpk_ngay.Name = "dtpk_ngay";
            this.dtpk_ngay.Size = new System.Drawing.Size(331, 28);
            this.dtpk_ngay.TabIndex = 101;
            this.dtpk_ngay.Value = new System.DateTime(2024, 5, 12, 13, 46, 26, 0);
            // 
            // pn_logo
            // 
            this.pn_logo.BackColor = System.Drawing.Color.AliceBlue;
            this.pn_logo.Controls.Add(this.bt_xoa);
            this.pn_logo.Controls.Add(this.lb_mess);
            this.pn_logo.Controls.Add(this.bt_save);
            this.pn_logo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pn_logo.Location = new System.Drawing.Point(0, 0);
            this.pn_logo.Name = "pn_logo";
            this.pn_logo.Size = new System.Drawing.Size(352, 45);
            this.pn_logo.TabIndex = 1;
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
            this.bt_xoa.FillColor = System.Drawing.Color.AliceBlue;
            this.bt_xoa.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_xoa.ForeColor = System.Drawing.Color.Red;
            this.bt_xoa.Image = ((System.Drawing.Image)(resources.GetObject("bt_xoa.Image")));
            this.bt_xoa.ImageSize = new System.Drawing.Size(30, 30);
            this.bt_xoa.Location = new System.Drawing.Point(187, 0);
            this.bt_xoa.Name = "bt_xoa";
            this.bt_xoa.Size = new System.Drawing.Size(71, 45);
            this.bt_xoa.TabIndex = 9;
            this.bt_xoa.Text = "Xóa";
            this.bt_xoa.UseTransparentBackground = true;
            this.bt_xoa.Click += new System.EventHandler(this.bt_xoa_Click);
            // 
            // lb_mess
            // 
            this.lb_mess.Dock = System.Windows.Forms.DockStyle.Left;
            this.lb_mess.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_mess.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lb_mess.Location = new System.Drawing.Point(0, 0);
            this.lb_mess.Name = "lb_mess";
            this.lb_mess.Size = new System.Drawing.Size(100, 45);
            this.lb_mess.TabIndex = 0;
            this.lb_mess.Text = "label1";
            this.lb_mess.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.bt_save.ImageSize = new System.Drawing.Size(30, 30);
            this.bt_save.Location = new System.Drawing.Point(277, 0);
            this.bt_save.Name = "bt_save";
            this.bt_save.Size = new System.Drawing.Size(75, 45);
            this.bt_save.TabIndex = 8;
            this.bt_save.Text = "Lưu";
            this.bt_save.UseTransparentBackground = true;
            this.bt_save.Click += new System.EventHandler(this.bt_save_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 780;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.State);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(944, 647);
            this.tabControl1.TabIndex = 1;
            // 
            // State
            // 
            this.State.BackColor = System.Drawing.Color.AliceBlue;
            this.State.Controls.Add(this.dtgrv_kho);
            this.State.Controls.Add(this.txt_find);
            this.State.ForeColor = System.Drawing.SystemColors.ControlText;
            this.State.Location = new System.Drawing.Point(4, 29);
            this.State.Name = "State";
            this.State.Padding = new System.Windows.Forms.Padding(3);
            this.State.Size = new System.Drawing.Size(936, 614);
            this.State.TabIndex = 0;
            this.State.Text = "Tình trạng kho";
            // 
            // dtgrv_kho
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(224)))), ((int)(((byte)(244)))));
            this.dtgrv_kho.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgrv_kho.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(220)))), ((int)(((byte)(242)))));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgrv_kho.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgrv_kho.ColumnHeadersHeight = 22;
            this.dtgrv_kho.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dtgrv_kho.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(220)))), ((int)(((byte)(242)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(186)))), ((int)(((byte)(231)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgrv_kho.DefaultCellStyle = dataGridViewCellStyle3;
            this.dtgrv_kho.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(220)))), ((int)(((byte)(242)))));
            this.dtgrv_kho.Location = new System.Drawing.Point(8, 130);
            this.dtgrv_kho.Name = "dtgrv_kho";
            this.dtgrv_kho.ReadOnly = true;
            this.dtgrv_kho.RowHeadersVisible = false;
            this.dtgrv_kho.RowHeadersWidth = 51;
            this.dtgrv_kho.RowTemplate.Height = 24;
            this.dtgrv_kho.Size = new System.Drawing.Size(912, 289);
            this.dtgrv_kho.TabIndex = 127;
            this.dtgrv_kho.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.FeterRiver;
            this.dtgrv_kho.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(224)))), ((int)(((byte)(244)))));
            this.dtgrv_kho.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dtgrv_kho.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dtgrv_kho.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dtgrv_kho.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dtgrv_kho.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(220)))), ((int)(((byte)(242)))));
            this.dtgrv_kho.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(220)))), ((int)(((byte)(242)))));
            this.dtgrv_kho.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.dtgrv_kho.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dtgrv_kho.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtgrv_kho.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.Black;
            this.dtgrv_kho.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dtgrv_kho.ThemeStyle.HeaderStyle.Height = 22;
            this.dtgrv_kho.ThemeStyle.ReadOnly = true;
            this.dtgrv_kho.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(220)))), ((int)(((byte)(242)))));
            this.dtgrv_kho.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtgrv_kho.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtgrv_kho.ThemeStyle.RowsStyle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.dtgrv_kho.ThemeStyle.RowsStyle.Height = 24;
            this.dtgrv_kho.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(186)))), ((int)(((byte)(231)))));
            this.dtgrv_kho.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "tenmenu";
            this.dataGridViewTextBoxColumn3.FillWeight = 121.5506F;
            this.dataGridViewTextBoxColumn3.HeaderText = "Tên Menu";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "soluong";
            this.dataGridViewTextBoxColumn4.FillWeight = 66.14996F;
            this.dataGridViewTextBoxColumn4.HeaderText = "Số lượng";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
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
            this.txt_find.FillColor = System.Drawing.Color.AliceBlue;
            this.txt_find.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_find.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.txt_find.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_find.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_find.Location = new System.Drawing.Point(8, 68);
            this.txt_find.Name = "txt_find";
            this.txt_find.PasswordChar = '\0';
            this.txt_find.PlaceholderForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_find.PlaceholderText = "Tìm kiếm";
            this.txt_find.SelectedText = "";
            this.txt_find.Size = new System.Drawing.Size(912, 41);
            this.txt_find.TabIndex = 8;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.AliceBlue;
            this.tabPage2.Controls.Add(this.bt_add);
            this.tabPage2.Controls.Add(this.dtgrv_nhapkho);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.dtpk_start);
            this.tabPage2.Controls.Add(this.dtpk_end);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.bt_find);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(936, 614);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Nhập kho";
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
            this.bt_add.Location = new System.Drawing.Point(531, 39);
            this.bt_add.Name = "bt_add";
            this.bt_add.Size = new System.Drawing.Size(132, 45);
            this.bt_add.TabIndex = 103;
            this.bt_add.Text = "Thêm mới";
            this.bt_add.UseTransparentBackground = true;
            this.bt_add.Click += new System.EventHandler(this.bt_add_Click);
            // 
            // dtgrv_nhapkho
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(224)))), ((int)(((byte)(244)))));
            this.dtgrv_nhapkho.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dtgrv_nhapkho.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(220)))), ((int)(((byte)(242)))));
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgrv_nhapkho.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dtgrv_nhapkho.ColumnHeadersHeight = 27;
            this.dtgrv_nhapkho.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dtgrv_nhapkho.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.Column3});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(234)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(186)))), ((int)(((byte)(231)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgrv_nhapkho.DefaultCellStyle = dataGridViewCellStyle6;
            this.dtgrv_nhapkho.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(220)))), ((int)(((byte)(242)))));
            this.dtgrv_nhapkho.Location = new System.Drawing.Point(13, 102);
            this.dtgrv_nhapkho.Name = "dtgrv_nhapkho";
            this.dtgrv_nhapkho.ReadOnly = true;
            this.dtgrv_nhapkho.RowHeadersVisible = false;
            this.dtgrv_nhapkho.RowHeadersWidth = 51;
            this.dtgrv_nhapkho.RowTemplate.Height = 24;
            this.dtgrv_nhapkho.Size = new System.Drawing.Size(914, 287);
            this.dtgrv_nhapkho.TabIndex = 102;
            this.dtgrv_nhapkho.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.FeterRiver;
            this.dtgrv_nhapkho.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(224)))), ((int)(((byte)(244)))));
            this.dtgrv_nhapkho.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dtgrv_nhapkho.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dtgrv_nhapkho.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dtgrv_nhapkho.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dtgrv_nhapkho.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(220)))), ((int)(((byte)(242)))));
            this.dtgrv_nhapkho.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(220)))), ((int)(((byte)(242)))));
            this.dtgrv_nhapkho.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.dtgrv_nhapkho.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dtgrv_nhapkho.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtgrv_nhapkho.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dtgrv_nhapkho.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dtgrv_nhapkho.ThemeStyle.HeaderStyle.Height = 27;
            this.dtgrv_nhapkho.ThemeStyle.ReadOnly = true;
            this.dtgrv_nhapkho.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(234)))), ((int)(((byte)(247)))));
            this.dtgrv_nhapkho.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtgrv_nhapkho.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtgrv_nhapkho.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dtgrv_nhapkho.ThemeStyle.RowsStyle.Height = 24;
            this.dtgrv_nhapkho.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(186)))), ((int)(((byte)(231)))));
            this.dtgrv_nhapkho.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dtgrv_nhapkho.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgrv_nhapkho_CellClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Thời gian nhập kho";
            this.dataGridViewTextBoxColumn1.FillWeight = 139.0374F;
            this.dataGridViewTextBoxColumn1.HeaderText = "Thời gian nhập kho";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Tổng số lượng";
            this.dataGridViewTextBoxColumn2.FillWeight = 60.96257F;
            this.dataGridViewTextBoxColumn2.HeaderText = "Tổng số lượng";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Tổng giá";
            this.Column3.HeaderText = "Tổng giá";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(227, 31);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 16);
            this.label3.TabIndex = 101;
            this.label3.Text = "Đến ngày";
            // 
            // dtpk_start
            // 
            this.dtpk_start.Checked = false;
            this.dtpk_start.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpk_start.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpk_start.Location = new System.Drawing.Point(14, 47);
            this.dtpk_start.Margin = new System.Windows.Forms.Padding(5);
            this.dtpk_start.Name = "dtpk_start";
            this.dtpk_start.Size = new System.Drawing.Size(203, 28);
            this.dtpk_start.TabIndex = 100;
            // 
            // dtpk_end
            // 
            this.dtpk_end.Checked = false;
            this.dtpk_end.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpk_end.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpk_end.Location = new System.Drawing.Point(227, 47);
            this.dtpk_end.Margin = new System.Windows.Forms.Padding(5);
            this.dtpk_end.Name = "dtpk_end";
            this.dtpk_end.Size = new System.Drawing.Size(204, 28);
            this.dtpk_end.TabIndex = 96;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(320, 19);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 36);
            this.label2.TabIndex = 97;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(10, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 16);
            this.label1.TabIndex = 99;
            this.label1.Text = "Từ ngày";
            // 
            // bt_find
            // 
            this.bt_find.Animated = true;
            this.bt_find.BackColor = System.Drawing.Color.Transparent;
            this.bt_find.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.bt_find.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.bt_find.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.bt_find.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.bt_find.FillColor = System.Drawing.Color.AliceBlue;
            this.bt_find.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bt_find.ForeColor = System.Drawing.Color.White;
            this.bt_find.Image = ((System.Drawing.Image)(resources.GetObject("bt_find.Image")));
            this.bt_find.ImageSize = new System.Drawing.Size(50, 50);
            this.bt_find.Location = new System.Drawing.Point(429, 39);
            this.bt_find.Margin = new System.Windows.Forms.Padding(5);
            this.bt_find.Name = "bt_find";
            this.bt_find.Size = new System.Drawing.Size(84, 36);
            this.bt_find.TabIndex = 98;
            this.bt_find.UseTransparentBackground = true;
            // 
            // Status
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(1296, 647);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.pn_update);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Status";
            this.Text = "Status";
            this.pn_update.ResumeLayout(false);
            this.flp_dsmenu.ResumeLayout(false);
            this.pn_col.ResumeLayout(false);
            this.pn_logo.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.State.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgrv_kho)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrv_nhapkho)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pn_update;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage State;
        private Guna.UI2.WinForms.Guna2TextBox txt_find;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DateTimePicker dtpk_end;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button bt_find;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpk_start;
        private Guna.UI2.WinForms.Guna2DataGridView dtgrv_nhapkho;
        private System.Windows.Forms.FlowLayoutPanel flp_dsmenu;
        private System.Windows.Forms.Panel pn_col;
        private System.Windows.Forms.Label lb_sl;
        private System.Windows.Forms.Label lb_nmn;
        private System.Windows.Forms.DateTimePicker dtpk_ngay;
        private System.Windows.Forms.Panel pn_logo;
        private Guna.UI2.WinForms.Guna2Button bt_xoa;
        private System.Windows.Forms.Label lb_mess;
        private Guna.UI2.WinForms.Guna2Button bt_save;
        private Guna.UI2.WinForms.Guna2Button bt_add;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private Guna.UI2.WinForms.Guna2DataGridView dtgrv_kho;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    }
}