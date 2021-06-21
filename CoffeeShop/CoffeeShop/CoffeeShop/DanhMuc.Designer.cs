namespace CoffeeShop
{
    partial class DanhMuc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DanhMuc));
            this.panel18 = new System.Windows.Forms.Panel();
            this.btnViewCategory = new System.Windows.Forms.Button();
            this.btnAddCategory = new System.Windows.Forms.Button();
            this.btnEditCategory = new System.Windows.Forms.Button();
            this.btnDeleteCategory = new System.Windows.Forms.Button();
            this.panel11 = new System.Windows.Forms.Panel();
            this.panel14 = new System.Windows.Forms.Panel();
            this.txtCategoryName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel15 = new System.Windows.Forms.Panel();
            this.txtCategoryId = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dgvCategory = new System.Windows.Forms.DataGridView();
            this.panel18.SuspendLayout();
            this.panel11.SuspendLayout();
            this.panel14.SuspendLayout();
            this.panel15.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategory)).BeginInit();
            this.SuspendLayout();
            // 
            // panel18
            // 
            this.panel18.Controls.Add(this.btnViewCategory);
            this.panel18.Controls.Add(this.btnAddCategory);
            this.panel18.Controls.Add(this.btnEditCategory);
            this.panel18.Controls.Add(this.btnDeleteCategory);
            this.panel18.Location = new System.Drawing.Point(607, 22);
            this.panel18.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel18.Name = "panel18";
            this.panel18.Size = new System.Drawing.Size(578, 95);
            this.panel18.TabIndex = 4;
            // 
            // btnViewCategory
            // 
            this.btnViewCategory.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnViewCategory.BackgroundImage")));
            this.btnViewCategory.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnViewCategory.FlatAppearance.BorderSize = 0;
            this.btnViewCategory.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnViewCategory.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnViewCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewCategory.Image = global::CoffeeShop.Properties.Resources.upload;
            this.btnViewCategory.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnViewCategory.Location = new System.Drawing.Point(25, 23);
            this.btnViewCategory.Margin = new System.Windows.Forms.Padding(4);
            this.btnViewCategory.Name = "btnViewCategory";
            this.btnViewCategory.Size = new System.Drawing.Size(105, 48);
            this.btnViewCategory.TabIndex = 10;
            this.btnViewCategory.Text = "Hiện Thị";
            this.btnViewCategory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnViewCategory.UseVisualStyleBackColor = true;
            this.btnViewCategory.Click += new System.EventHandler(this.btnViewCategory_Click);
            // 
            // btnAddCategory
            // 
            this.btnAddCategory.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAddCategory.BackgroundImage")));
            this.btnAddCategory.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddCategory.FlatAppearance.BorderSize = 0;
            this.btnAddCategory.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnAddCategory.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnAddCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddCategory.Image = global::CoffeeShop.Properties.Resources.add_user;
            this.btnAddCategory.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddCategory.Location = new System.Drawing.Point(159, 23);
            this.btnAddCategory.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddCategory.Name = "btnAddCategory";
            this.btnAddCategory.Size = new System.Drawing.Size(105, 48);
            this.btnAddCategory.TabIndex = 11;
            this.btnAddCategory.Text = "Thêm ";
            this.btnAddCategory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddCategory.UseVisualStyleBackColor = true;
            this.btnAddCategory.Click += new System.EventHandler(this.btnAddCategory_Click);
            // 
            // btnEditCategory
            // 
            this.btnEditCategory.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEditCategory.BackgroundImage")));
            this.btnEditCategory.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEditCategory.FlatAppearance.BorderSize = 0;
            this.btnEditCategory.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnEditCategory.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnEditCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditCategory.Image = global::CoffeeShop.Properties.Resources.edit_user1;
            this.btnEditCategory.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEditCategory.Location = new System.Drawing.Point(309, 23);
            this.btnEditCategory.Margin = new System.Windows.Forms.Padding(4);
            this.btnEditCategory.Name = "btnEditCategory";
            this.btnEditCategory.Size = new System.Drawing.Size(105, 48);
            this.btnEditCategory.TabIndex = 12;
            this.btnEditCategory.Text = "Sửa   ";
            this.btnEditCategory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditCategory.UseVisualStyleBackColor = true;
            this.btnEditCategory.Click += new System.EventHandler(this.btnEditCategory_Click);
            // 
            // btnDeleteCategory
            // 
            this.btnDeleteCategory.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDeleteCategory.BackgroundImage")));
            this.btnDeleteCategory.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDeleteCategory.FlatAppearance.BorderSize = 0;
            this.btnDeleteCategory.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnDeleteCategory.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnDeleteCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteCategory.Image = global::CoffeeShop.Properties.Resources.remove_user;
            this.btnDeleteCategory.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDeleteCategory.Location = new System.Drawing.Point(449, 23);
            this.btnDeleteCategory.Margin = new System.Windows.Forms.Padding(4);
            this.btnDeleteCategory.Name = "btnDeleteCategory";
            this.btnDeleteCategory.Size = new System.Drawing.Size(105, 48);
            this.btnDeleteCategory.TabIndex = 13;
            this.btnDeleteCategory.Text = "Xóa   ";
            this.btnDeleteCategory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeleteCategory.UseVisualStyleBackColor = true;
            this.btnDeleteCategory.Click += new System.EventHandler(this.btnDeleteCategory_Click);
            // 
            // panel11
            // 
            this.panel11.Controls.Add(this.panel14);
            this.panel11.Controls.Add(this.panel15);
            this.panel11.Location = new System.Drawing.Point(605, 127);
            this.panel11.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(578, 222);
            this.panel11.TabIndex = 7;
            // 
            // panel14
            // 
            this.panel14.Controls.Add(this.txtCategoryName);
            this.panel14.Controls.Add(this.label7);
            this.panel14.Location = new System.Drawing.Point(6, 118);
            this.panel14.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(560, 86);
            this.panel14.TabIndex = 2;
            // 
            // txtCategoryName
            // 
            this.txtCategoryName.Location = new System.Drawing.Point(200, 26);
            this.txtCategoryName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCategoryName.Name = "txtCategoryName";
            this.txtCategoryName.Size = new System.Drawing.Size(354, 26);
            this.txtCategoryName.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(4, 25);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(184, 29);
            this.label7.TabIndex = 0;
            this.label7.Text = "Tên danh mục:";
            // 
            // panel15
            // 
            this.panel15.Controls.Add(this.txtCategoryId);
            this.panel15.Controls.Add(this.label8);
            this.panel15.Location = new System.Drawing.Point(6, 23);
            this.panel15.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(560, 86);
            this.panel15.TabIndex = 1;
            // 
            // txtCategoryId
            // 
            this.txtCategoryId.Location = new System.Drawing.Point(200, 26);
            this.txtCategoryId.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCategoryId.Name = "txtCategoryId";
            this.txtCategoryId.ReadOnly = true;
            this.txtCategoryId.Size = new System.Drawing.Size(354, 26);
            this.txtCategoryId.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(4, 25);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 29);
            this.label8.TabIndex = 0;
            this.label8.Text = "ID:";
            // 
            // dgvCategory
            // 
            this.dgvCategory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCategory.BackgroundColor = System.Drawing.Color.White;
            this.dgvCategory.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvCategory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCategory.Dock = System.Windows.Forms.DockStyle.Left;
            this.dgvCategory.GridColor = System.Drawing.Color.DarkGray;
            this.dgvCategory.Location = new System.Drawing.Point(0, 0);
            this.dgvCategory.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvCategory.MultiSelect = false;
            this.dgvCategory.Name = "dgvCategory";
            this.dgvCategory.RowHeadersWidth = 62;
            this.dgvCategory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCategory.Size = new System.Drawing.Size(583, 616);
            this.dgvCategory.TabIndex = 8;
            // 
            // DanhMuc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvCategory);
            this.Controls.Add(this.panel11);
            this.Controls.Add(this.panel18);
            this.Name = "DanhMuc";
            this.Size = new System.Drawing.Size(1191, 616);
            this.Load += new System.EventHandler(this.DanhMuc_Load);
            this.panel18.ResumeLayout(false);
            this.panel11.ResumeLayout(false);
            this.panel14.ResumeLayout(false);
            this.panel14.PerformLayout();
            this.panel15.ResumeLayout(false);
            this.panel15.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategory)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel18;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Panel panel14;
        private System.Windows.Forms.TextBox txtCategoryName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel15;
        private System.Windows.Forms.TextBox txtCategoryId;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dgvCategory;
        private System.Windows.Forms.Button btnViewCategory;
        private System.Windows.Forms.Button btnAddCategory;
        private System.Windows.Forms.Button btnEditCategory;
        private System.Windows.Forms.Button btnDeleteCategory;
    }
}
