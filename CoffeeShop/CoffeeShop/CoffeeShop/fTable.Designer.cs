namespace CoffeeShop
{
    partial class fTable
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuAdmin = new System.Windows.Forms.ToolStripMenuItem();
            this.khuVựcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tầng1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tầng2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinTàiKhoảnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuPersonalInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.menuLogOut = new System.Windows.Forms.ToolStripMenuItem();
            this.chứcNăngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thêmMónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thanhToánToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 36);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1185, 876);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuAdmin,
            this.khuVựcToolStripMenuItem,
            this.thôngTinTàiKhoảnToolStripMenuItem,
            this.chứcNăngToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(477, 33);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuAdmin
            // 
            this.menuAdmin.Name = "menuAdmin";
            this.menuAdmin.Size = new System.Drawing.Size(81, 32);
            this.menuAdmin.Text = "Admin";
            this.menuAdmin.Click += new System.EventHandler(this.menuAdmin_Click);
            // 
            // khuVựcToolStripMenuItem
            // 
            this.khuVựcToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tầng1ToolStripMenuItem,
            this.tầng2ToolStripMenuItem});
            this.khuVựcToolStripMenuItem.Name = "khuVựcToolStripMenuItem";
            this.khuVựcToolStripMenuItem.Size = new System.Drawing.Size(93, 32);
            this.khuVựcToolStripMenuItem.Text = "Khu Vực";
            // 
            // tầng1ToolStripMenuItem
            // 
            this.tầng1ToolStripMenuItem.Name = "tầng1ToolStripMenuItem";
            this.tầng1ToolStripMenuItem.Size = new System.Drawing.Size(168, 34);
            this.tầng1ToolStripMenuItem.Text = "Tầng 1";
            this.tầng1ToolStripMenuItem.Click += new System.EventHandler(this.tầng1ToolStripMenuItem_Click);
            // 
            // tầng2ToolStripMenuItem
            // 
            this.tầng2ToolStripMenuItem.Name = "tầng2ToolStripMenuItem";
            this.tầng2ToolStripMenuItem.Size = new System.Drawing.Size(168, 34);
            this.tầng2ToolStripMenuItem.Text = "Tầng 2";
            this.tầng2ToolStripMenuItem.Click += new System.EventHandler(this.tầng2ToolStripMenuItem_Click);
            // 
            // thôngTinTàiKhoảnToolStripMenuItem
            // 
            this.thôngTinTàiKhoảnToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuPersonalInfo,
            this.menuLogOut});
            this.thôngTinTàiKhoảnToolStripMenuItem.Name = "thôngTinTàiKhoảnToolStripMenuItem";
            this.thôngTinTàiKhoảnToolStripMenuItem.Size = new System.Drawing.Size(182, 32);
            this.thôngTinTàiKhoảnToolStripMenuItem.Text = "Thông tin tài khoản";
            // 
            // menuPersonalInfo
            // 
            this.menuPersonalInfo.Name = "menuPersonalInfo";
            this.menuPersonalInfo.Size = new System.Drawing.Size(256, 34);
            this.menuPersonalInfo.Text = "Thông tin cá nhân";
            this.menuPersonalInfo.Click += new System.EventHandler(this.menuPersonalInfo_Click);
            // 
            // menuLogOut
            // 
            this.menuLogOut.Name = "menuLogOut";
            this.menuLogOut.Size = new System.Drawing.Size(256, 34);
            this.menuLogOut.Text = "Đăng xuất";
            // 
            // chứcNăngToolStripMenuItem
            // 
            this.chứcNăngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thêmMónToolStripMenuItem,
            this.thanhToánToolStripMenuItem});
            this.chứcNăngToolStripMenuItem.Name = "chứcNăngToolStripMenuItem";
            this.chứcNăngToolStripMenuItem.Size = new System.Drawing.Size(113, 32);
            this.chứcNăngToolStripMenuItem.Text = "Chức năng";
            // 
            // thêmMónToolStripMenuItem
            // 
            this.thêmMónToolStripMenuItem.Name = "thêmMónToolStripMenuItem";
            this.thêmMónToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.thêmMónToolStripMenuItem.Size = new System.Drawing.Size(264, 34);
            this.thêmMónToolStripMenuItem.Text = "Thêm món";
            // 
            // thanhToánToolStripMenuItem
            // 
            this.thanhToánToolStripMenuItem.Name = "thanhToánToolStripMenuItem";
            this.thanhToánToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.T)));
            this.thanhToánToolStripMenuItem.Size = new System.Drawing.Size(264, 34);
            this.thanhToánToolStripMenuItem.Text = "Thanh toán";
            // 
            // fTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1185, 912);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.panel1);
            this.Name = "fTable";
            this.Text = "fTable";
            this.Load += new System.EventHandler(this.fTable_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuAdmin;
        private System.Windows.Forms.ToolStripMenuItem thôngTinTàiKhoảnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuPersonalInfo;
        private System.Windows.Forms.ToolStripMenuItem menuLogOut;
        private System.Windows.Forms.ToolStripMenuItem chứcNăngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thêmMónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thanhToánToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem khuVựcToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tầng1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tầng2ToolStripMenuItem;
    }
}