namespace GUI.ManageSys
{
    partial class Setup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Setup));
            this.txt_name = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_phone = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_location = new Guna.UI2.WinForms.Guna2TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.bt_save = new Guna.UI2.WinForms.Guna2Button();
            this.lb_name = new System.Windows.Forms.Label();
            this.lb_sdt = new System.Windows.Forms.Label();
            this.lb_loca = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_name
            // 
            this.txt_name.Animated = true;
            this.txt_name.BackColor = System.Drawing.Color.AliceBlue;
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
            this.txt_name.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_name.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_name.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_name.Location = new System.Drawing.Point(150, 72);
            this.txt_name.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_name.Name = "txt_name";
            this.txt_name.PasswordChar = '\0';
            this.txt_name.PlaceholderForeColor = System.Drawing.SystemColors.GrayText;
            this.txt_name.PlaceholderText = "Tên nhà nghỉ - khách sạn";
            this.txt_name.SelectedText = "";
            this.txt_name.Size = new System.Drawing.Size(432, 45);
            this.txt_name.TabIndex = 7;
            this.txt_name.Tag = "0";
            this.txt_name.TextChanged += new System.EventHandler(this.txt_name_TextChanged);
            this.txt_name.Click += new System.EventHandler(this.txt_name_Click);
            this.txt_name.Leave += new System.EventHandler(this.txt_name_Leave);
            // 
            // txt_phone
            // 
            this.txt_phone.Animated = true;
            this.txt_phone.BackColor = System.Drawing.Color.AliceBlue;
            this.txt_phone.BorderColor = System.Drawing.Color.RosyBrown;
            this.txt_phone.BorderRadius = 8;
            this.txt_phone.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_phone.DefaultText = "";
            this.txt_phone.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_phone.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_phone.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_phone.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_phone.FillColor = System.Drawing.Color.AliceBlue;
            this.txt_phone.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_phone.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_phone.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_phone.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_phone.Location = new System.Drawing.Point(150, 218);
            this.txt_phone.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_phone.Name = "txt_phone";
            this.txt_phone.PasswordChar = '\0';
            this.txt_phone.PlaceholderForeColor = System.Drawing.SystemColors.GrayText;
            this.txt_phone.PlaceholderText = "Số điện thoại";
            this.txt_phone.SelectedText = "";
            this.txt_phone.Size = new System.Drawing.Size(432, 45);
            this.txt_phone.TabIndex = 8;
            this.txt_phone.Tag = "0";
            this.txt_phone.TextChanged += new System.EventHandler(this.txt_phone_TextChanged);
            this.txt_phone.Click += new System.EventHandler(this.txt_phone_Click);
            this.txt_phone.Leave += new System.EventHandler(this.txt_phone_Leave);
            // 
            // txt_location
            // 
            this.txt_location.Animated = true;
            this.txt_location.BackColor = System.Drawing.Color.AliceBlue;
            this.txt_location.BorderColor = System.Drawing.Color.RosyBrown;
            this.txt_location.BorderRadius = 8;
            this.txt_location.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_location.DefaultText = "";
            this.txt_location.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_location.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_location.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_location.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_location.FillColor = System.Drawing.Color.AliceBlue;
            this.txt_location.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_location.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_location.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_location.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_location.Location = new System.Drawing.Point(150, 143);
            this.txt_location.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_location.Name = "txt_location";
            this.txt_location.PasswordChar = '\0';
            this.txt_location.PlaceholderForeColor = System.Drawing.SystemColors.GrayText;
            this.txt_location.PlaceholderText = "Địa chỉ";
            this.txt_location.SelectedText = "";
            this.txt_location.Size = new System.Drawing.Size(432, 45);
            this.txt_location.TabIndex = 9;
            this.txt_location.Tag = "0";
            this.txt_location.TextChanged += new System.EventHandler(this.txt_location_TextChanged);
            this.txt_location.Click += new System.EventHandler(this.txt_location_Click);
            this.txt_location.Leave += new System.EventHandler(this.txt_location_Leave);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(26, 218);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(26, 67);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(26, 143);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(100, 50);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox3.TabIndex = 12;
            this.pictureBox3.TabStop = false;
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
            this.bt_save.ImageSize = new System.Drawing.Size(50, 50);
            this.bt_save.Location = new System.Drawing.Point(665, 67);
            this.bt_save.Name = "bt_save";
            this.bt_save.Size = new System.Drawing.Size(126, 58);
            this.bt_save.TabIndex = 13;
            this.bt_save.Text = "Lưu";
            this.bt_save.UseTransparentBackground = true;
            this.bt_save.Click += new System.EventHandler(this.bt_save_Click);
            // 
            // lb_name
            // 
            this.lb_name.AutoSize = true;
            this.lb_name.BackColor = System.Drawing.Color.AliceBlue;
            this.lb_name.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_name.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lb_name.Location = new System.Drawing.Point(156, 61);
            this.lb_name.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lb_name.Name = "lb_name";
            this.lb_name.Size = new System.Drawing.Size(156, 17);
            this.lb_name.TabIndex = 14;
            this.lb_name.Text = "Tên nhà nghỉ - khách sạn";
            this.lb_name.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lb_sdt
            // 
            this.lb_sdt.AutoSize = true;
            this.lb_sdt.BackColor = System.Drawing.Color.AliceBlue;
            this.lb_sdt.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_sdt.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lb_sdt.Location = new System.Drawing.Point(156, 208);
            this.lb_sdt.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lb_sdt.Name = "lb_sdt";
            this.lb_sdt.Size = new System.Drawing.Size(84, 17);
            this.lb_sdt.TabIndex = 15;
            this.lb_sdt.Text = "Số điện thoại";
            this.lb_sdt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lb_loca
            // 
            this.lb_loca.AutoSize = true;
            this.lb_loca.BackColor = System.Drawing.Color.AliceBlue;
            this.lb_loca.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_loca.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lb_loca.Location = new System.Drawing.Point(156, 131);
            this.lb_loca.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lb_loca.Name = "lb_loca";
            this.lb_loca.Size = new System.Drawing.Size(50, 17);
            this.lb_loca.TabIndex = 16;
            this.lb_loca.Text = "Địa chỉ";
            this.lb_loca.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Setup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(1296, 647);
            this.Controls.Add(this.lb_loca);
            this.Controls.Add(this.lb_sdt);
            this.Controls.Add(this.lb_name);
            this.Controls.Add(this.bt_save);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txt_location);
            this.Controls.Add(this.txt_phone);
            this.Controls.Add(this.txt_name);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Setup";
            this.Text = "Setup";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox txt_name;
        private Guna.UI2.WinForms.Guna2TextBox txt_phone;
        private Guna.UI2.WinForms.Guna2TextBox txt_location;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private Guna.UI2.WinForms.Guna2Button bt_save;
        private System.Windows.Forms.Label lb_name;
        private System.Windows.Forms.Label lb_sdt;
        private System.Windows.Forms.Label lb_loca;
    }
}