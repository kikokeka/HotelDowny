namespace GUI.Checkinout
{
    partial class ClearRoom
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClearRoom));
            this.ctxmenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ctx_cleared = new System.Windows.Forms.ToolStripMenuItem();
            this.pn_show = new System.Windows.Forms.Panel();
            this.ctxmenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // ctxmenu
            // 
            this.ctxmenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ctxmenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ctx_cleared});
            this.ctxmenu.Name = "ctxmenu";
            this.ctxmenu.Size = new System.Drawing.Size(132, 30);
            // 
            // ctx_cleared
            // 
            this.ctx_cleared.Image = ((System.Drawing.Image)(resources.GetObject("ctx_cleared.Image")));
            this.ctx_cleared.Name = "ctx_cleared";
            this.ctx_cleared.Size = new System.Drawing.Size(131, 26);
            this.ctx_cleared.Text = "Đã dọn";
            this.ctx_cleared.Click += new System.EventHandler(this.ctx_cleared_Click);
            // 
            // pn_show
            // 
            this.pn_show.BackColor = System.Drawing.Color.AliceBlue;
            this.pn_show.Dock = System.Windows.Forms.DockStyle.Left;
            this.pn_show.Location = new System.Drawing.Point(0, 0);
            this.pn_show.Name = "pn_show";
            this.pn_show.Size = new System.Drawing.Size(962, 647);
            this.pn_show.TabIndex = 1;
            // 
            // ClearRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(1296, 647);
            this.Controls.Add(this.pn_show);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "ClearRoom";
            this.Text = "ClearRoom";
            this.ctxmenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip ctxmenu;
        private System.Windows.Forms.ToolStripMenuItem ctx_cleared;
        private System.Windows.Forms.Panel pn_show;
    }
}