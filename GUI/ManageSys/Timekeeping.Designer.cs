namespace GUI.ManageSys
{
    partial class Timekeeping
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Timekeeping));
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.dtpk_ngay = new System.Windows.Forms.DateTimePicker();
            this.lsv_time = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.bt_export = new Guna.UI2.WinForms.Guna2Button();
            this.bt_out = new Guna.UI2.WinForms.Guna2ControlBox();
            this.SuspendLayout();
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.SystemColors.Control;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(78, 61);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(155, 20);
            this.guna2HtmlLabel1.TabIndex = 0;
            this.guna2HtmlLabel1.Text = "Bảng chấm công tháng";
            // 
            // dtpk_ngay
            // 
            this.dtpk_ngay.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(19)))), ((int)(((byte)(43)))));
            this.dtpk_ngay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpk_ngay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpk_ngay.Location = new System.Drawing.Point(260, 61);
            this.dtpk_ngay.Name = "dtpk_ngay";
            this.dtpk_ngay.ShowUpDown = true;
            this.dtpk_ngay.Size = new System.Drawing.Size(200, 27);
            this.dtpk_ngay.TabIndex = 2;
            this.dtpk_ngay.ValueChanged += new System.EventHandler(this.dtpk_ngay_ValueChanged);
            // 
            // lsv_time
            // 
            this.lsv_time.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(19)))), ((int)(((byte)(43)))));
            this.lsv_time.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader4,
            this.columnHeader5});
            this.lsv_time.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsv_time.ForeColor = System.Drawing.SystemColors.Control;
            this.lsv_time.HideSelection = false;
            this.lsv_time.Location = new System.Drawing.Point(172, 153);
            this.lsv_time.Name = "lsv_time";
            this.lsv_time.Size = new System.Drawing.Size(581, 179);
            this.lsv_time.TabIndex = 3;
            this.lsv_time.UseCompatibleStateImageBehavior = false;
            this.lsv_time.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Tài khoản";
            this.columnHeader1.Width = 114;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Chức vụ";
            this.columnHeader4.Width = 126;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Tổng thời gian làm";
            this.columnHeader5.Width = 335;
            // 
            // bt_export
            // 
            this.bt_export.Animated = true;
            this.bt_export.BackColor = System.Drawing.Color.Transparent;
            this.bt_export.BorderRadius = 8;
            this.bt_export.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.bt_export.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.bt_export.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.bt_export.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.bt_export.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(19)))), ((int)(((byte)(43)))));
            this.bt_export.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_export.ForeColor = System.Drawing.Color.DarkCyan;
            this.bt_export.Image = ((System.Drawing.Image)(resources.GetObject("bt_export.Image")));
            this.bt_export.ImageSize = new System.Drawing.Size(40, 40);
            this.bt_export.Location = new System.Drawing.Point(591, 44);
            this.bt_export.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.bt_export.Name = "bt_export";
            this.bt_export.Size = new System.Drawing.Size(162, 44);
            this.bt_export.TabIndex = 20;
            this.bt_export.Text = "Xuất Excel";
            this.bt_export.UseTransparentBackground = true;
            this.bt_export.Click += new System.EventHandler(this.bt_export_Click);
            // 
            // bt_out
            // 
            this.bt_out.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_out.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(152)))), ((int)(((byte)(166)))));
            this.bt_out.IconColor = System.Drawing.Color.White;
            this.bt_out.Location = new System.Drawing.Point(891, 1);
            this.bt_out.Name = "bt_out";
            this.bt_out.Size = new System.Drawing.Size(38, 29);
            this.bt_out.TabIndex = 21;
            this.bt_out.Click += new System.EventHandler(this.bt_out_Click);
            // 
            // Timekeeping
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(7)))), ((int)(((byte)(42)))));
            this.ClientSize = new System.Drawing.Size(929, 487);
            this.Controls.Add(this.bt_out);
            this.Controls.Add(this.bt_export);
            this.Controls.Add(this.lsv_time);
            this.Controls.Add(this.dtpk_ngay);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Timekeeping";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chấm công";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private System.Windows.Forms.DateTimePicker dtpk_ngay;
        private System.Windows.Forms.ListView lsv_time;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private Guna.UI2.WinForms.Guna2Button bt_export;
        private Guna.UI2.WinForms.Guna2ControlBox bt_out;
    }
}