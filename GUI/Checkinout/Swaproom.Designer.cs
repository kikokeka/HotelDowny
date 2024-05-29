namespace GUI.Checkinout
{
    partial class Swaproom
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
            this.bt_thoatdoip = new System.Windows.Forms.Button();
            this.bt_doiphong = new System.Windows.Forms.Button();
            this.txt_name = new Guna.UI2.WinForms.Guna2TextBox();
            this.cbx_type = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cbx_dsp = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lb_message = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.SuspendLayout();
            // 
            // bt_thoatdoip
            // 
            this.bt_thoatdoip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(134)))), ((int)(((byte)(133)))));
            this.bt_thoatdoip.FlatAppearance.BorderSize = 0;
            this.bt_thoatdoip.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_thoatdoip.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_thoatdoip.ForeColor = System.Drawing.Color.White;
            this.bt_thoatdoip.Location = new System.Drawing.Point(326, 235);
            this.bt_thoatdoip.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.bt_thoatdoip.Name = "bt_thoatdoip";
            this.bt_thoatdoip.Size = new System.Drawing.Size(118, 44);
            this.bt_thoatdoip.TabIndex = 7;
            this.bt_thoatdoip.Text = "Thoát";
            this.bt_thoatdoip.UseVisualStyleBackColor = false;
            this.bt_thoatdoip.Click += new System.EventHandler(this.bt_thoatdoip_Click);
            // 
            // bt_doiphong
            // 
            this.bt_doiphong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.bt_doiphong.FlatAppearance.BorderSize = 0;
            this.bt_doiphong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_doiphong.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_doiphong.ForeColor = System.Drawing.Color.White;
            this.bt_doiphong.Location = new System.Drawing.Point(5, 233);
            this.bt_doiphong.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.bt_doiphong.Name = "bt_doiphong";
            this.bt_doiphong.Size = new System.Drawing.Size(117, 49);
            this.bt_doiphong.TabIndex = 5;
            this.bt_doiphong.Text = "Đổi phòng";
            this.bt_doiphong.UseVisualStyleBackColor = false;
            this.bt_doiphong.Click += new System.EventHandler(this.bt_doiphong_Click);
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
            this.txt_name.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(7)))), ((int)(((byte)(42)))));
            this.txt_name.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_name.Font = new System.Drawing.Font("Times New Roman", 10.8F);
            this.txt_name.ForeColor = System.Drawing.Color.White;
            this.txt_name.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_name.Location = new System.Drawing.Point(231, 67);
            this.txt_name.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_name.Name = "txt_name";
            this.txt_name.PasswordChar = '\0';
            this.txt_name.PlaceholderText = "Tìm kiếm phòng";
            this.txt_name.SelectedText = "";
            this.txt_name.Size = new System.Drawing.Size(193, 36);
            this.txt_name.TabIndex = 13;
            this.txt_name.Tag = "0";
            this.txt_name.TextChanged += new System.EventHandler(this.txt_name_TextChanged);
            // 
            // cbx_type
            // 
            this.cbx_type.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(7)))), ((int)(((byte)(42)))));
            this.cbx_type.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(7)))), ((int)(((byte)(42)))));
            this.cbx_type.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbx_type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_type.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(7)))), ((int)(((byte)(42)))));
            this.cbx_type.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbx_type.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbx_type.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbx_type.ForeColor = System.Drawing.SystemColors.Control;
            this.cbx_type.ItemHeight = 30;
            this.cbx_type.Items.AddRange(new object[] {
            "Tất cả"});
            this.cbx_type.Location = new System.Drawing.Point(24, 67);
            this.cbx_type.Name = "cbx_type";
            this.cbx_type.Size = new System.Drawing.Size(140, 36);
            this.cbx_type.TabIndex = 14;
            this.cbx_type.SelectedIndexChanged += new System.EventHandler(this.cbx_type_SelectedIndexChanged);
            // 
            // cbx_dsp
            // 
            this.cbx_dsp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(7)))), ((int)(((byte)(42)))));
            this.cbx_dsp.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(7)))), ((int)(((byte)(42)))));
            this.cbx_dsp.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbx_dsp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_dsp.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(7)))), ((int)(((byte)(42)))));
            this.cbx_dsp.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbx_dsp.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbx_dsp.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbx_dsp.ForeColor = System.Drawing.SystemColors.Control;
            this.cbx_dsp.ItemHeight = 30;
            this.cbx_dsp.Location = new System.Drawing.Point(45, 150);
            this.cbx_dsp.Name = "cbx_dsp";
            this.cbx_dsp.Size = new System.Drawing.Size(321, 36);
            this.cbx_dsp.TabIndex = 15;
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel2.ForeColor = System.Drawing.SystemColors.Control;
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(45, 124);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(119, 20);
            this.guna2HtmlLabel2.TabIndex = 23;
            this.guna2HtmlLabel2.Text = "Danh sách phòng";
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.SystemColors.Control;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(33, 41);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(76, 20);
            this.guna2HtmlLabel1.TabIndex = 24;
            this.guna2HtmlLabel1.Text = "Loại phòng";
            // 
            // lb_message
            // 
            this.lb_message.BackColor = System.Drawing.Color.Transparent;
            this.lb_message.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_message.ForeColor = System.Drawing.SystemColors.Control;
            this.lb_message.Location = new System.Drawing.Point(139, 12);
            this.lb_message.Name = "lb_message";
            this.lb_message.Size = new System.Drawing.Size(76, 20);
            this.lb_message.TabIndex = 25;
            this.lb_message.Text = "Loại phòng";
            // 
            // Swaproom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(7)))), ((int)(((byte)(42)))));
            this.Controls.Add(this.lb_message);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.guna2HtmlLabel2);
            this.Controls.Add(this.cbx_dsp);
            this.Controls.Add(this.cbx_type);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.bt_thoatdoip);
            this.Controls.Add(this.bt_doiphong);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "Swaproom";
            this.Size = new System.Drawing.Size(444, 284);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button bt_thoatdoip;
        private System.Windows.Forms.Button bt_doiphong;
        private Guna.UI2.WinForms.Guna2ComboBox cbx_type;
        private Guna.UI2.WinForms.Guna2TextBox txt_name;
        private Guna.UI2.WinForms.Guna2ComboBox cbx_dsp;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel lb_message;
    }
}
