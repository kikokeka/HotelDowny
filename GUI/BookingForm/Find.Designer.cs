namespace GUI.Booking
{
    partial class Find
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Find));
            this.tbly_byroom = new System.Windows.Forms.TableLayoutPanel();
            this.pn_in4 = new System.Windows.Forms.Panel();
            this.lsv_booking = new System.Windows.Forms.ListView();
            this.ten = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Type = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.note = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txt_tim = new Guna.UI2.WinForms.Guna2TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bt_find = new Guna.UI2.WinForms.Guna2Button();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpk_end = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpk_start = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tbly_byroom.SuspendLayout();
            this.pn_in4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbly_byroom
            // 
            this.tbly_byroom.BackColor = System.Drawing.Color.AliceBlue;
            this.tbly_byroom.ColumnCount = 1;
            this.tbly_byroom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tbly_byroom.Controls.Add(this.pn_in4, 0, 0);
            this.tbly_byroom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbly_byroom.Location = new System.Drawing.Point(0, 0);
            this.tbly_byroom.Margin = new System.Windows.Forms.Padding(5);
            this.tbly_byroom.Name = "tbly_byroom";
            this.tbly_byroom.RowCount = 1;
            this.tbly_byroom.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tbly_byroom.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 1173F));
            this.tbly_byroom.Size = new System.Drawing.Size(1296, 647);
            this.tbly_byroom.TabIndex = 1;
            // 
            // pn_in4
            // 
            this.pn_in4.Controls.Add(this.lsv_booking);
            this.pn_in4.Controls.Add(this.txt_tim);
            this.pn_in4.Controls.Add(this.panel1);
            this.pn_in4.Controls.Add(this.label1);
            this.pn_in4.Controls.Add(this.guna2HtmlLabel1);
            this.pn_in4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pn_in4.Location = new System.Drawing.Point(5, 5);
            this.pn_in4.Margin = new System.Windows.Forms.Padding(5);
            this.pn_in4.Name = "pn_in4";
            this.pn_in4.Size = new System.Drawing.Size(1286, 637);
            this.pn_in4.TabIndex = 10;
            // 
            // lsv_booking
            // 
            this.lsv_booking.BackColor = System.Drawing.Color.AliceBlue;
            this.lsv_booking.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ten,
            this.Type,
            this.note,
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7});
            this.lsv_booking.Dock = System.Windows.Forms.DockStyle.Top;
            this.lsv_booking.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsv_booking.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lsv_booking.FullRowSelect = true;
            this.lsv_booking.GridLines = true;
            this.lsv_booking.HideSelection = false;
            this.lsv_booking.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.lsv_booking.Location = new System.Drawing.Point(0, 130);
            this.lsv_booking.Margin = new System.Windows.Forms.Padding(5);
            this.lsv_booking.Name = "lsv_booking";
            this.lsv_booking.Size = new System.Drawing.Size(1286, 231);
            this.lsv_booking.TabIndex = 96;
            this.lsv_booking.UseCompatibleStateImageBehavior = false;
            this.lsv_booking.View = System.Windows.Forms.View.Details;
            // 
            // ten
            // 
            this.ten.Text = "Khách hàng";
            this.ten.Width = 172;
            // 
            // Type
            // 
            this.Type.Text = "CCCD";
            this.Type.Width = 123;
            // 
            // note
            // 
            this.note.Text = "SĐT";
            this.note.Width = 122;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Phòng";
            this.columnHeader1.Width = 80;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Kiểu";
            this.columnHeader2.Width = 95;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Trạng thái";
            this.columnHeader3.Width = 143;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Ngày nhận";
            this.columnHeader4.Width = 142;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Ngày trả";
            this.columnHeader5.Width = 91;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Tiền trả trước";
            this.columnHeader6.Width = 113;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "TK nhận";
            this.columnHeader7.Width = 116;
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
            this.txt_tim.Dock = System.Windows.Forms.DockStyle.Top;
            this.txt_tim.FillColor = System.Drawing.Color.AliceBlue;
            this.txt_tim.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_tim.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tim.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_tim.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_tim.Location = new System.Drawing.Point(0, 98);
            this.txt_tim.Margin = new System.Windows.Forms.Padding(7);
            this.txt_tim.Name = "txt_tim";
            this.txt_tim.PasswordChar = '\0';
            this.txt_tim.PlaceholderText = "Tìm kiếm";
            this.txt_tim.SelectedText = "";
            this.txt_tim.Size = new System.Drawing.Size(1286, 32);
            this.txt_tim.TabIndex = 92;
            this.txt_tim.Tag = "0";
            this.txt_tim.TextChanged += new System.EventHandler(this.txt_tim_TextChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.bt_find);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.dtpk_end);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.dtpk_start);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 62);
            this.panel1.Margin = new System.Windows.Forms.Padding(5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1286, 36);
            this.panel1.TabIndex = 94;
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
            this.bt_find.ForeColor = System.Drawing.Color.White;
            this.bt_find.Image = ((System.Drawing.Image)(resources.GetObject("bt_find.Image")));
            this.bt_find.ImageSize = new System.Drawing.Size(50, 50);
            this.bt_find.Location = new System.Drawing.Point(633, 0);
            this.bt_find.Margin = new System.Windows.Forms.Padding(5);
            this.bt_find.Name = "bt_find";
            this.bt_find.Size = new System.Drawing.Size(84, 36);
            this.bt_find.TabIndex = 15;
            this.bt_find.UseTransparentBackground = true;
            this.bt_find.Click += new System.EventHandler(this.bt_find_Click);
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Left;
            this.label3.Location = new System.Drawing.Point(592, 0);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 36);
            this.label3.TabIndex = 16;
            // 
            // dtpk_end
            // 
            this.dtpk_end.Checked = false;
            this.dtpk_end.Dock = System.Windows.Forms.DockStyle.Left;
            this.dtpk_end.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpk_end.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpk_end.Location = new System.Drawing.Point(318, 0);
            this.dtpk_end.Margin = new System.Windows.Forms.Padding(5);
            this.dtpk_end.Name = "dtpk_end";
            this.dtpk_end.Size = new System.Drawing.Size(274, 28);
            this.dtpk_end.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Left;
            this.label2.Location = new System.Drawing.Point(274, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 36);
            this.label2.TabIndex = 11;
            // 
            // dtpk_start
            // 
            this.dtpk_start.Checked = false;
            this.dtpk_start.Dock = System.Windows.Forms.DockStyle.Left;
            this.dtpk_start.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpk_start.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpk_start.Location = new System.Drawing.Point(0, 0);
            this.dtpk_start.Margin = new System.Windows.Forms.Padding(5);
            this.dtpk_start.Name = "dtpk_start";
            this.dtpk_start.Size = new System.Drawing.Size(274, 28);
            this.dtpk_start.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(0, 46);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(380, 16);
            this.label1.TabIndex = 95;
            this.label1.Text = "Từ ngày                                                                          " +
    "               Đến ngày";
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.AutoSize = false;
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(0, 0);
            this.guna2HtmlLabel1.Margin = new System.Windows.Forms.Padding(5);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(1286, 46);
            this.guna2HtmlLabel1.TabIndex = 93;
            this.guna2HtmlLabel1.Text = null;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Find
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(19)))), ((int)(((byte)(43)))));
            this.ClientSize = new System.Drawing.Size(1296, 647);
            this.Controls.Add(this.tbly_byroom);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Find";
            this.Text = "Find";
            this.tbly_byroom.ResumeLayout(false);
            this.pn_in4.ResumeLayout(false);
            this.pn_in4.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tbly_byroom;
        private System.Windows.Forms.Panel pn_in4;
        private Guna.UI2.WinForms.Guna2Button bt_find;
        private System.Windows.Forms.DateTimePicker dtpk_end;
        private System.Windows.Forms.DateTimePicker dtpk_start;
        internal Guna.UI2.WinForms.Guna2TextBox txt_tim;
        private System.Windows.Forms.Timer timer1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView lsv_booking;
        private System.Windows.Forms.ColumnHeader ten;
        private System.Windows.Forms.ColumnHeader Type;
        private System.Windows.Forms.ColumnHeader note;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
    }
}