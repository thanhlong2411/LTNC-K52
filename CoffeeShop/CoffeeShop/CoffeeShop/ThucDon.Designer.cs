namespace CoffeeShop
{
    partial class ThucDon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ThucDon));
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtSearchFoodName = new System.Windows.Forms.TextBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.panel10 = new System.Windows.Forms.Panel();
            this.nmFoodPrice = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.cbFoodCategory = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.txtFoodName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.txtFoodId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvFood = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnSearchFood = new System.Windows.Forms.Button();
            this.btnViewFood = new System.Windows.Forms.Button();
            this.btnAddFood = new System.Windows.Forms.Button();
            this.btnEditFood = new System.Windows.Forms.Button();
            this.btnDeleteFood = new System.Windows.Forms.Button();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmFoodPrice)).BeginInit();
            this.panel9.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFood)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnViewFood);
            this.panel3.Controls.Add(this.btnAddFood);
            this.panel3.Controls.Add(this.btnEditFood);
            this.panel3.Controls.Add(this.btnDeleteFood);
            this.panel3.Location = new System.Drawing.Point(4, 18);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(584, 95);
            this.panel3.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnSearchFood);
            this.panel4.Controls.Add(this.txtSearchFoodName);
            this.panel4.Location = new System.Drawing.Point(596, 18);
            this.panel4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(578, 95);
            this.panel4.TabIndex = 2;
            // 
            // txtSearchFoodName
            // 
            this.txtSearchFoodName.Location = new System.Drawing.Point(14, 34);
            this.txtSearchFoodName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSearchFoodName.Name = "txtSearchFoodName";
            this.txtSearchFoodName.Size = new System.Drawing.Size(420, 26);
            this.txtSearchFoodName.TabIndex = 5;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.label5);
            this.panel6.Controls.Add(this.pictureBox1);
            this.panel6.Controls.Add(this.panel10);
            this.panel6.Controls.Add(this.panel9);
            this.panel6.Controls.Add(this.panel8);
            this.panel6.Controls.Add(this.panel7);
            this.panel6.Location = new System.Drawing.Point(596, 123);
            this.panel6.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(578, 552);
            this.panel6.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(9, 72);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 29);
            this.label5.TabIndex = 6;
            this.label5.Text = "Hình Ảnh:";
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.nmFoodPrice);
            this.panel10.Controls.Add(this.label4);
            this.panel10.Location = new System.Drawing.Point(5, 462);
            this.panel10.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(560, 86);
            this.panel10.TabIndex = 4;
            // 
            // nmFoodPrice
            // 
            this.nmFoodPrice.Increment = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nmFoodPrice.Location = new System.Drawing.Point(153, 28);
            this.nmFoodPrice.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nmFoodPrice.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.nmFoodPrice.Name = "nmFoodPrice";
            this.nmFoodPrice.Size = new System.Drawing.Size(402, 26);
            this.nmFoodPrice.TabIndex = 1;
            this.nmFoodPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nmFoodPrice.ThousandsSeparator = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(4, 25);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 29);
            this.label4.TabIndex = 0;
            this.label4.Text = "Giá:";
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.cbFoodCategory);
            this.panel9.Controls.Add(this.label3);
            this.panel9.Location = new System.Drawing.Point(5, 367);
            this.panel9.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(560, 86);
            this.panel9.TabIndex = 3;
            // 
            // cbFoodCategory
            // 
            this.cbFoodCategory.FormattingEnabled = true;
            this.cbFoodCategory.Location = new System.Drawing.Point(153, 26);
            this.cbFoodCategory.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbFoodCategory.Name = "cbFoodCategory";
            this.cbFoodCategory.Size = new System.Drawing.Size(400, 28);
            this.cbFoodCategory.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(4, 25);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 29);
            this.label3.TabIndex = 0;
            this.label3.Text = "Danh mục:";
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.txtFoodName);
            this.panel8.Controls.Add(this.label2);
            this.panel8.Location = new System.Drawing.Point(5, 271);
            this.panel8.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(560, 86);
            this.panel8.TabIndex = 2;
            // 
            // txtFoodName
            // 
            this.txtFoodName.Location = new System.Drawing.Point(153, 26);
            this.txtFoodName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtFoodName.Name = "txtFoodName";
            this.txtFoodName.Size = new System.Drawing.Size(400, 26);
            this.txtFoodName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(4, 25);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 29);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên món:";
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.txtFoodId);
            this.panel7.Controls.Add(this.label1);
            this.panel7.Location = new System.Drawing.Point(5, 176);
            this.panel7.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(560, 86);
            this.panel7.TabIndex = 1;
            // 
            // txtFoodId
            // 
            this.txtFoodId.Location = new System.Drawing.Point(153, 28);
            this.txtFoodId.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtFoodId.Name = "txtFoodId";
            this.txtFoodId.ReadOnly = true;
            this.txtFoodId.Size = new System.Drawing.Size(400, 26);
            this.txtFoodId.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID:";
            // 
            // dgvFood
            // 
            this.dgvFood.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvFood.BackgroundColor = System.Drawing.Color.White;
            this.dgvFood.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvFood.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFood.GridColor = System.Drawing.Color.DarkGray;
            this.dgvFood.Location = new System.Drawing.Point(4, 123);
            this.dgvFood.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvFood.MultiSelect = false;
            this.dgvFood.Name = "dgvFood";
            this.dgvFood.RowHeadersWidth = 62;
            this.dgvFood.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFood.Size = new System.Drawing.Size(584, 552);
            this.dgvFood.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(158, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(400, 156);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btnSearchFood
            // 
            this.btnSearchFood.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSearchFood.BackgroundImage")));
            this.btnSearchFood.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSearchFood.FlatAppearance.BorderSize = 0;
            this.btnSearchFood.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnSearchFood.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnSearchFood.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchFood.Image = global::CoffeeShop.Properties.Resources.magnifying_glass;
            this.btnSearchFood.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSearchFood.Location = new System.Drawing.Point(455, 23);
            this.btnSearchFood.Margin = new System.Windows.Forms.Padding(4);
            this.btnSearchFood.Name = "btnSearchFood";
            this.btnSearchFood.Size = new System.Drawing.Size(103, 48);
            this.btnSearchFood.TabIndex = 10;
            this.btnSearchFood.Text = "Tìm Kiếm";
            this.btnSearchFood.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearchFood.UseVisualStyleBackColor = true;
            this.btnSearchFood.Click += new System.EventHandler(this.btnSearchFood_Click);
            // 
            // btnViewFood
            // 
            this.btnViewFood.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnViewFood.BackgroundImage")));
            this.btnViewFood.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnViewFood.FlatAppearance.BorderSize = 0;
            this.btnViewFood.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnViewFood.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnViewFood.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewFood.Image = global::CoffeeShop.Properties.Resources.upload;
            this.btnViewFood.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnViewFood.Location = new System.Drawing.Point(15, 23);
            this.btnViewFood.Margin = new System.Windows.Forms.Padding(4);
            this.btnViewFood.Name = "btnViewFood";
            this.btnViewFood.Size = new System.Drawing.Size(105, 48);
            this.btnViewFood.TabIndex = 6;
            this.btnViewFood.Text = "Hiện Thị";
            this.btnViewFood.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnViewFood.UseVisualStyleBackColor = true;
            this.btnViewFood.Click += new System.EventHandler(this.btnViewFood_Click);
            // 
            // btnAddFood
            // 
            this.btnAddFood.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAddFood.BackgroundImage")));
            this.btnAddFood.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddFood.FlatAppearance.BorderSize = 0;
            this.btnAddFood.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnAddFood.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnAddFood.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddFood.Image = global::CoffeeShop.Properties.Resources.add_user;
            this.btnAddFood.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddFood.Location = new System.Drawing.Point(149, 23);
            this.btnAddFood.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddFood.Name = "btnAddFood";
            this.btnAddFood.Size = new System.Drawing.Size(105, 48);
            this.btnAddFood.TabIndex = 7;
            this.btnAddFood.Text = "Thêm ";
            this.btnAddFood.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddFood.UseVisualStyleBackColor = true;
            this.btnAddFood.Click += new System.EventHandler(this.btnAddFood_Click);
            // 
            // btnEditFood
            // 
            this.btnEditFood.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEditFood.BackgroundImage")));
            this.btnEditFood.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEditFood.FlatAppearance.BorderSize = 0;
            this.btnEditFood.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnEditFood.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnEditFood.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditFood.Image = global::CoffeeShop.Properties.Resources.edit_user1;
            this.btnEditFood.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEditFood.Location = new System.Drawing.Point(299, 23);
            this.btnEditFood.Margin = new System.Windows.Forms.Padding(4);
            this.btnEditFood.Name = "btnEditFood";
            this.btnEditFood.Size = new System.Drawing.Size(105, 48);
            this.btnEditFood.TabIndex = 8;
            this.btnEditFood.Text = "Sửa   ";
            this.btnEditFood.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditFood.UseVisualStyleBackColor = true;
            this.btnEditFood.Click += new System.EventHandler(this.btnEditFood_Click);
            // 
            // btnDeleteFood
            // 
            this.btnDeleteFood.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDeleteFood.BackgroundImage")));
            this.btnDeleteFood.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDeleteFood.FlatAppearance.BorderSize = 0;
            this.btnDeleteFood.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnDeleteFood.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnDeleteFood.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteFood.Image = global::CoffeeShop.Properties.Resources.remove_user;
            this.btnDeleteFood.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDeleteFood.Location = new System.Drawing.Point(439, 23);
            this.btnDeleteFood.Margin = new System.Windows.Forms.Padding(4);
            this.btnDeleteFood.Name = "btnDeleteFood";
            this.btnDeleteFood.Size = new System.Drawing.Size(105, 48);
            this.btnDeleteFood.TabIndex = 9;
            this.btnDeleteFood.Text = "Xóa   ";
            this.btnDeleteFood.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeleteFood.UseVisualStyleBackColor = true;
            this.btnDeleteFood.Click += new System.EventHandler(this.btnDeleteFood_Click);
            // 
            // ThucDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvFood);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Name = "ThucDon";
            this.Size = new System.Drawing.Size(1189, 699);
            this.Load += new System.EventHandler(this.ThucDon_Load);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmFoodPrice)).EndInit();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFood)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txtSearchFoodName;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.NumericUpDown nmFoodPrice;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.ComboBox cbFoodCategory;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.TextBox txtFoodName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.TextBox txtFoodId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvFood;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnViewFood;
        private System.Windows.Forms.Button btnAddFood;
        private System.Windows.Forms.Button btnEditFood;
        private System.Windows.Forms.Button btnDeleteFood;
        private System.Windows.Forms.Button btnSearchFood;
    }
}
