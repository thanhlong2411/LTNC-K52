namespace CoffeeShop
{
    partial class TaiKhoan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TaiKhoan));
            this.panel18 = new System.Windows.Forms.Panel();
            this.btnViewAcc = new System.Windows.Forms.Button();
            this.btnAddAcc = new System.Windows.Forms.Button();
            this.btnEditAcc = new System.Windows.Forms.Button();
            this.btnDeleteAcc = new System.Windows.Forms.Button();
            this.panel22 = new System.Windows.Forms.Panel();
            this.btnResetPassword = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel28 = new System.Windows.Forms.Panel();
            this.txtNewUserName = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.panel23 = new System.Windows.Forms.Panel();
            this.nmAccountType = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.panel24 = new System.Windows.Forms.Panel();
            this.txtDisplayName = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.panel25 = new System.Windows.Forms.Panel();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.dgvAccount = new System.Windows.Forms.DataGridView();
            this.panel18.SuspendLayout();
            this.panel22.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel28.SuspendLayout();
            this.panel23.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmAccountType)).BeginInit();
            this.panel24.SuspendLayout();
            this.panel25.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccount)).BeginInit();
            this.SuspendLayout();
            // 
            // panel18
            // 
            this.panel18.Controls.Add(this.btnViewAcc);
            this.panel18.Controls.Add(this.btnAddAcc);
            this.panel18.Controls.Add(this.btnEditAcc);
            this.panel18.Controls.Add(this.btnDeleteAcc);
            this.panel18.Location = new System.Drawing.Point(602, 5);
            this.panel18.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel18.Name = "panel18";
            this.panel18.Size = new System.Drawing.Size(578, 95);
            this.panel18.TabIndex = 5;
            // 
            // btnViewAcc
            // 
            this.btnViewAcc.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnViewAcc.BackgroundImage")));
            this.btnViewAcc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnViewAcc.FlatAppearance.BorderSize = 0;
            this.btnViewAcc.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnViewAcc.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnViewAcc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewAcc.Image = global::CoffeeShop.Properties.Resources.upload;
            this.btnViewAcc.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnViewAcc.Location = new System.Drawing.Point(25, 23);
            this.btnViewAcc.Margin = new System.Windows.Forms.Padding(4);
            this.btnViewAcc.Name = "btnViewAcc";
            this.btnViewAcc.Size = new System.Drawing.Size(105, 48);
            this.btnViewAcc.TabIndex = 10;
            this.btnViewAcc.Text = "Hiện Thị";
            this.btnViewAcc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnViewAcc.UseVisualStyleBackColor = true;
            this.btnViewAcc.Click += new System.EventHandler(this.btnViewAcc_Click);
            // 
            // btnAddAcc
            // 
            this.btnAddAcc.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAddAcc.BackgroundImage")));
            this.btnAddAcc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddAcc.FlatAppearance.BorderSize = 0;
            this.btnAddAcc.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnAddAcc.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnAddAcc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddAcc.Image = global::CoffeeShop.Properties.Resources.add_user;
            this.btnAddAcc.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddAcc.Location = new System.Drawing.Point(159, 23);
            this.btnAddAcc.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddAcc.Name = "btnAddAcc";
            this.btnAddAcc.Size = new System.Drawing.Size(105, 48);
            this.btnAddAcc.TabIndex = 11;
            this.btnAddAcc.Text = "Thêm ";
            this.btnAddAcc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddAcc.UseVisualStyleBackColor = true;
            this.btnAddAcc.Click += new System.EventHandler(this.btnAddAcc_Click);
            // 
            // btnEditAcc
            // 
            this.btnEditAcc.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEditAcc.BackgroundImage")));
            this.btnEditAcc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEditAcc.FlatAppearance.BorderSize = 0;
            this.btnEditAcc.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnEditAcc.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnEditAcc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditAcc.Image = global::CoffeeShop.Properties.Resources.edit_user1;
            this.btnEditAcc.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEditAcc.Location = new System.Drawing.Point(309, 23);
            this.btnEditAcc.Margin = new System.Windows.Forms.Padding(4);
            this.btnEditAcc.Name = "btnEditAcc";
            this.btnEditAcc.Size = new System.Drawing.Size(105, 48);
            this.btnEditAcc.TabIndex = 12;
            this.btnEditAcc.Text = "Sửa   ";
            this.btnEditAcc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditAcc.UseVisualStyleBackColor = true;
            this.btnEditAcc.Click += new System.EventHandler(this.btnEditAcc_Click);
            // 
            // btnDeleteAcc
            // 
            this.btnDeleteAcc.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDeleteAcc.BackgroundImage")));
            this.btnDeleteAcc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDeleteAcc.FlatAppearance.BorderSize = 0;
            this.btnDeleteAcc.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnDeleteAcc.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnDeleteAcc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteAcc.Image = global::CoffeeShop.Properties.Resources.remove_user;
            this.btnDeleteAcc.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDeleteAcc.Location = new System.Drawing.Point(449, 23);
            this.btnDeleteAcc.Margin = new System.Windows.Forms.Padding(4);
            this.btnDeleteAcc.Name = "btnDeleteAcc";
            this.btnDeleteAcc.Size = new System.Drawing.Size(105, 48);
            this.btnDeleteAcc.TabIndex = 13;
            this.btnDeleteAcc.Text = "Xóa   ";
            this.btnDeleteAcc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeleteAcc.UseVisualStyleBackColor = true;
            this.btnDeleteAcc.Click += new System.EventHandler(this.btnDeleteAcc_Click);
            // 
            // panel22
            // 
            this.panel22.Controls.Add(this.btnResetPassword);
            this.panel22.Controls.Add(this.panel1);
            this.panel22.Controls.Add(this.panel28);
            this.panel22.Controls.Add(this.panel23);
            this.panel22.Controls.Add(this.panel24);
            this.panel22.Controls.Add(this.panel25);
            this.panel22.Location = new System.Drawing.Point(602, 105);
            this.panel22.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel22.Name = "panel22";
            this.panel22.Size = new System.Drawing.Size(578, 663);
            this.panel22.TabIndex = 13;
            // 
            // btnResetPassword
            // 
            this.btnResetPassword.Location = new System.Drawing.Point(271, 599);
            this.btnResetPassword.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnResetPassword.Name = "btnResetPassword";
            this.btnResetPassword.Size = new System.Drawing.Size(286, 49);
            this.btnResetPassword.TabIndex = 4;
            this.btnResetPassword.Text = "Đặt lại mật khẩu";
            this.btnResetPassword.UseVisualStyleBackColor = true;
            this.btnResetPassword.Click += new System.EventHandler(this.btnResetPassword_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(4, 18);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(560, 177);
            this.panel1.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(4, 79);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 29);
            this.label5.TabIndex = 16;
            this.label5.Text = "Hình Ảnh:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(149, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(400, 141);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // panel28
            // 
            this.panel28.Controls.Add(this.txtNewUserName);
            this.panel28.Controls.Add(this.label13);
            this.panel28.Location = new System.Drawing.Point(4, 298);
            this.panel28.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel28.Name = "panel28";
            this.panel28.Size = new System.Drawing.Size(560, 86);
            this.panel28.TabIndex = 2;
            // 
            // txtNewUserName
            // 
            this.txtNewUserName.Location = new System.Drawing.Point(237, 26);
            this.txtNewUserName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNewUserName.Name = "txtNewUserName";
            this.txtNewUserName.Size = new System.Drawing.Size(316, 26);
            this.txtNewUserName.TabIndex = 1;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(4, 25);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(235, 29);
            this.label13.TabIndex = 0;
            this.label13.Text = "Tên tài khoản mới: ";
            // 
            // panel23
            // 
            this.panel23.Controls.Add(this.nmAccountType);
            this.panel23.Controls.Add(this.label10);
            this.panel23.Location = new System.Drawing.Point(4, 503);
            this.panel23.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel23.Name = "panel23";
            this.panel23.Size = new System.Drawing.Size(560, 86);
            this.panel23.TabIndex = 3;
            // 
            // nmAccountType
            // 
            this.nmAccountType.Location = new System.Drawing.Point(237, 28);
            this.nmAccountType.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nmAccountType.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmAccountType.Name = "nmAccountType";
            this.nmAccountType.Size = new System.Drawing.Size(82, 26);
            this.nmAccountType.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(4, 25);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(183, 29);
            this.label10.TabIndex = 0;
            this.label10.Text = "Loại tài khoản:";
            // 
            // panel24
            // 
            this.panel24.Controls.Add(this.txtDisplayName);
            this.panel24.Controls.Add(this.label11);
            this.panel24.Location = new System.Drawing.Point(4, 408);
            this.panel24.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel24.Name = "panel24";
            this.panel24.Size = new System.Drawing.Size(560, 86);
            this.panel24.TabIndex = 2;
            // 
            // txtDisplayName
            // 
            this.txtDisplayName.Location = new System.Drawing.Point(237, 26);
            this.txtDisplayName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDisplayName.Name = "txtDisplayName";
            this.txtDisplayName.Size = new System.Drawing.Size(316, 26);
            this.txtDisplayName.TabIndex = 1;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(4, 25);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(157, 29);
            this.label11.TabIndex = 0;
            this.label11.Text = "Tên hiển thị:";
            // 
            // panel25
            // 
            this.panel25.Controls.Add(this.txtUserName);
            this.panel25.Controls.Add(this.label12);
            this.panel25.Location = new System.Drawing.Point(4, 203);
            this.panel25.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel25.Name = "panel25";
            this.panel25.Size = new System.Drawing.Size(560, 86);
            this.panel25.TabIndex = 1;
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(237, 26);
            this.txtUserName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.ReadOnly = true;
            this.txtUserName.Size = new System.Drawing.Size(316, 26);
            this.txtUserName.TabIndex = 1;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(4, 25);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(176, 29);
            this.label12.TabIndex = 0;
            this.label12.Text = "Tên tài khoản:";
            // 
            // dgvAccount
            // 
            this.dgvAccount.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAccount.BackgroundColor = System.Drawing.Color.White;
            this.dgvAccount.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvAccount.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAccount.Dock = System.Windows.Forms.DockStyle.Left;
            this.dgvAccount.GridColor = System.Drawing.Color.DarkGray;
            this.dgvAccount.Location = new System.Drawing.Point(0, 0);
            this.dgvAccount.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvAccount.MultiSelect = false;
            this.dgvAccount.Name = "dgvAccount";
            this.dgvAccount.RowHeadersWidth = 62;
            this.dgvAccount.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAccount.Size = new System.Drawing.Size(584, 778);
            this.dgvAccount.TabIndex = 14;
            // 
            // TaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvAccount);
            this.Controls.Add(this.panel22);
            this.Controls.Add(this.panel18);
            this.Name = "TaiKhoan";
            this.Size = new System.Drawing.Size(1193, 778);
            this.Load += new System.EventHandler(this.TaiKhoan_Load);
            this.panel18.ResumeLayout(false);
            this.panel22.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel28.ResumeLayout(false);
            this.panel28.PerformLayout();
            this.panel23.ResumeLayout(false);
            this.panel23.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmAccountType)).EndInit();
            this.panel24.ResumeLayout(false);
            this.panel24.PerformLayout();
            this.panel25.ResumeLayout(false);
            this.panel25.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccount)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel18;
        private System.Windows.Forms.Button btnViewAcc;
        private System.Windows.Forms.Button btnAddAcc;
        private System.Windows.Forms.Button btnEditAcc;
        private System.Windows.Forms.Button btnDeleteAcc;
        private System.Windows.Forms.Panel panel22;
        private System.Windows.Forms.Panel panel28;
        private System.Windows.Forms.TextBox txtNewUserName;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnResetPassword;
        private System.Windows.Forms.Panel panel23;
        private System.Windows.Forms.NumericUpDown nmAccountType;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel24;
        private System.Windows.Forms.TextBox txtDisplayName;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel25;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridView dgvAccount;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
