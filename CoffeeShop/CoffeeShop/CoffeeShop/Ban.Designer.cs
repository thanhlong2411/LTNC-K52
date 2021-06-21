namespace CoffeeShop
{
    partial class Ban
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ban));
            this.dgvTable = new System.Windows.Forms.DataGridView();
            this.panel18 = new System.Windows.Forms.Panel();
            this.btnViewTable = new System.Windows.Forms.Button();
            this.btnAddTable = new System.Windows.Forms.Button();
            this.btnEditTable = new System.Windows.Forms.Button();
            this.btnDeleteTable = new System.Windows.Forms.Button();
            this.panel12 = new System.Windows.Forms.Panel();
            this.panel21 = new System.Windows.Forms.Panel();
            this.txtTableStatus = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.panel13 = new System.Windows.Forms.Panel();
            this.txtTableName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel17 = new System.Windows.Forms.Panel();
            this.txtTableId = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTable)).BeginInit();
            this.panel18.SuspendLayout();
            this.panel12.SuspendLayout();
            this.panel21.SuspendLayout();
            this.panel13.SuspendLayout();
            this.panel17.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvTable
            // 
            this.dgvTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTable.BackgroundColor = System.Drawing.Color.White;
            this.dgvTable.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTable.Dock = System.Windows.Forms.DockStyle.Left;
            this.dgvTable.GridColor = System.Drawing.Color.DarkGray;
            this.dgvTable.Location = new System.Drawing.Point(0, 0);
            this.dgvTable.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvTable.MultiSelect = false;
            this.dgvTable.Name = "dgvTable";
            this.dgvTable.RowHeadersWidth = 62;
            this.dgvTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTable.Size = new System.Drawing.Size(584, 764);
            this.dgvTable.TabIndex = 2;
            // 
            // panel18
            // 
            this.panel18.Controls.Add(this.btnViewTable);
            this.panel18.Controls.Add(this.btnAddTable);
            this.panel18.Controls.Add(this.btnEditTable);
            this.panel18.Controls.Add(this.btnDeleteTable);
            this.panel18.Location = new System.Drawing.Point(592, 5);
            this.panel18.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel18.Name = "panel18";
            this.panel18.Size = new System.Drawing.Size(578, 95);
            this.panel18.TabIndex = 5;
            // 
            // btnViewTable
            // 
            this.btnViewTable.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnViewTable.BackgroundImage")));
            this.btnViewTable.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnViewTable.FlatAppearance.BorderSize = 0;
            this.btnViewTable.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnViewTable.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnViewTable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewTable.Image = global::CoffeeShop.Properties.Resources.upload;
            this.btnViewTable.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnViewTable.Location = new System.Drawing.Point(25, 23);
            this.btnViewTable.Margin = new System.Windows.Forms.Padding(4);
            this.btnViewTable.Name = "btnViewTable";
            this.btnViewTable.Size = new System.Drawing.Size(105, 48);
            this.btnViewTable.TabIndex = 10;
            this.btnViewTable.Text = "Hiện Thị";
            this.btnViewTable.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnViewTable.UseVisualStyleBackColor = true;
            this.btnViewTable.Click += new System.EventHandler(this.btnViewTable_Click);
            // 
            // btnAddTable
            // 
            this.btnAddTable.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAddTable.BackgroundImage")));
            this.btnAddTable.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddTable.FlatAppearance.BorderSize = 0;
            this.btnAddTable.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnAddTable.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnAddTable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddTable.Image = global::CoffeeShop.Properties.Resources.add_user;
            this.btnAddTable.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddTable.Location = new System.Drawing.Point(159, 23);
            this.btnAddTable.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddTable.Name = "btnAddTable";
            this.btnAddTable.Size = new System.Drawing.Size(105, 48);
            this.btnAddTable.TabIndex = 11;
            this.btnAddTable.Text = "Thêm ";
            this.btnAddTable.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddTable.UseVisualStyleBackColor = true;
            this.btnAddTable.Click += new System.EventHandler(this.btnAddTable_Click);
            // 
            // btnEditTable
            // 
            this.btnEditTable.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEditTable.BackgroundImage")));
            this.btnEditTable.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEditTable.FlatAppearance.BorderSize = 0;
            this.btnEditTable.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnEditTable.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnEditTable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditTable.Image = global::CoffeeShop.Properties.Resources.edit_user1;
            this.btnEditTable.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEditTable.Location = new System.Drawing.Point(309, 23);
            this.btnEditTable.Margin = new System.Windows.Forms.Padding(4);
            this.btnEditTable.Name = "btnEditTable";
            this.btnEditTable.Size = new System.Drawing.Size(105, 48);
            this.btnEditTable.TabIndex = 12;
            this.btnEditTable.Text = "Sửa   ";
            this.btnEditTable.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditTable.UseVisualStyleBackColor = true;
            this.btnEditTable.Click += new System.EventHandler(this.btnEditTable_Click);
            // 
            // btnDeleteTable
            // 
            this.btnDeleteTable.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDeleteTable.BackgroundImage")));
            this.btnDeleteTable.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDeleteTable.FlatAppearance.BorderSize = 0;
            this.btnDeleteTable.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnDeleteTable.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnDeleteTable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteTable.Image = global::CoffeeShop.Properties.Resources.remove_user;
            this.btnDeleteTable.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDeleteTable.Location = new System.Drawing.Point(449, 23);
            this.btnDeleteTable.Margin = new System.Windows.Forms.Padding(4);
            this.btnDeleteTable.Name = "btnDeleteTable";
            this.btnDeleteTable.Size = new System.Drawing.Size(105, 48);
            this.btnDeleteTable.TabIndex = 13;
            this.btnDeleteTable.Text = "Xóa   ";
            this.btnDeleteTable.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeleteTable.UseVisualStyleBackColor = true;
            this.btnDeleteTable.Click += new System.EventHandler(this.btnDeleteTable_Click);
            // 
            // panel12
            // 
            this.panel12.Controls.Add(this.panel21);
            this.panel12.Controls.Add(this.panel13);
            this.panel12.Controls.Add(this.panel17);
            this.panel12.Location = new System.Drawing.Point(592, 110);
            this.panel12.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(578, 654);
            this.panel12.TabIndex = 10;
            // 
            // panel21
            // 
            this.panel21.Controls.Add(this.txtTableStatus);
            this.panel21.Controls.Add(this.label9);
            this.panel21.Location = new System.Drawing.Point(6, 214);
            this.panel21.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel21.Name = "panel21";
            this.panel21.Size = new System.Drawing.Size(560, 86);
            this.panel21.TabIndex = 3;
            // 
            // txtTableStatus
            // 
            this.txtTableStatus.Location = new System.Drawing.Point(200, 26);
            this.txtTableStatus.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTableStatus.Name = "txtTableStatus";
            this.txtTableStatus.Size = new System.Drawing.Size(354, 26);
            this.txtTableStatus.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(4, 25);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(136, 29);
            this.label9.TabIndex = 0;
            this.label9.Text = "Trạng thái:";
            // 
            // panel13
            // 
            this.panel13.Controls.Add(this.txtTableName);
            this.panel13.Controls.Add(this.label5);
            this.panel13.Location = new System.Drawing.Point(6, 118);
            this.panel13.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(560, 86);
            this.panel13.TabIndex = 2;
            // 
            // txtTableName
            // 
            this.txtTableName.Location = new System.Drawing.Point(200, 26);
            this.txtTableName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTableName.Name = "txtTableName";
            this.txtTableName.Size = new System.Drawing.Size(354, 26);
            this.txtTableName.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(4, 25);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 29);
            this.label5.TabIndex = 0;
            this.label5.Text = "Tên bàn:";
            // 
            // panel17
            // 
            this.panel17.Controls.Add(this.txtTableId);
            this.panel17.Controls.Add(this.label6);
            this.panel17.Location = new System.Drawing.Point(6, 23);
            this.panel17.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel17.Name = "panel17";
            this.panel17.Size = new System.Drawing.Size(560, 86);
            this.panel17.TabIndex = 1;
            // 
            // txtTableId
            // 
            this.txtTableId.Location = new System.Drawing.Point(200, 26);
            this.txtTableId.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTableId.Name = "txtTableId";
            this.txtTableId.ReadOnly = true;
            this.txtTableId.Size = new System.Drawing.Size(354, 26);
            this.txtTableId.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(4, 25);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 29);
            this.label6.TabIndex = 0;
            this.label6.Text = "ID:";
            // 
            // Ban
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel12);
            this.Controls.Add(this.panel18);
            this.Controls.Add(this.dgvTable);
            this.Name = "Ban";
            this.Size = new System.Drawing.Size(1186, 764);
            this.Load += new System.EventHandler(this.Ban_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTable)).EndInit();
            this.panel18.ResumeLayout(false);
            this.panel12.ResumeLayout(false);
            this.panel21.ResumeLayout(false);
            this.panel21.PerformLayout();
            this.panel13.ResumeLayout(false);
            this.panel13.PerformLayout();
            this.panel17.ResumeLayout(false);
            this.panel17.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTable;
        private System.Windows.Forms.Panel panel18;
        private System.Windows.Forms.Button btnViewTable;
        private System.Windows.Forms.Button btnAddTable;
        private System.Windows.Forms.Button btnEditTable;
        private System.Windows.Forms.Button btnDeleteTable;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Panel panel21;
        private System.Windows.Forms.TextBox txtTableStatus;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.TextBox txtTableName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel17;
        private System.Windows.Forms.TextBox txtTableId;
        private System.Windows.Forms.Label label6;
    }
}
