namespace DailyAccounts.GUI
{
    partial class frmProducts
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
            this.btnAddCategory = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbxCategory = new System.Windows.Forms.ComboBox();
            this.dgvProducts = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.SrNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Product_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salePrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edit = new System.Windows.Forms.DataGridViewImageColumn();
            this.productId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddCategory
            // 
            this.btnAddCategory.Image = global::DailyAccounts.Properties.Resources.add;
            this.btnAddCategory.Location = new System.Drawing.Point(597, 349);
            this.btnAddCategory.Name = "btnAddCategory";
            this.btnAddCategory.Size = new System.Drawing.Size(105, 35);
            this.btnAddCategory.TabIndex = 24;
            this.btnAddCategory.Text = "Add New";
            this.btnAddCategory.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddCategory.UseVisualStyleBackColor = true;
            this.btnAddCategory.Click += new System.EventHandler(this.btnAddCategory_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Image = global::DailyAccounts.Properties.Resources.delete;
            this.btnCancel.Location = new System.Drawing.Point(493, 349);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(98, 35);
            this.btnCancel.TabIndex = 22;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(60, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 31);
            this.label1.TabIndex = 21;
            this.label1.Text = "View Products";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(381, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 28;
            this.label2.Text = "Select Category";
            // 
            // cbxCategory
            // 
            this.cbxCategory.DisplayMember = "name";
            this.cbxCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCategory.FormattingEnabled = true;
            this.cbxCategory.Location = new System.Drawing.Point(469, 118);
            this.cbxCategory.Name = "cbxCategory";
            this.cbxCategory.Size = new System.Drawing.Size(233, 21);
            this.cbxCategory.TabIndex = 29;
            this.cbxCategory.ValueMember = "id";
            this.cbxCategory.SelectedIndexChanged += new System.EventHandler(this.cbxCategory_SelectedIndexChanged);
            // 
            // dgvProducts
            // 
            this.dgvProducts.AllowUserToAddRows = false;
            this.dgvProducts.AllowUserToDeleteRows = false;
            this.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProducts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SrNo,
            this.Product_Name,
            this.ProductStock,
            this.salePrice,
            this.Edit,
            this.productId});
            this.dgvProducts.Location = new System.Drawing.Point(66, 145);
            this.dgvProducts.Name = "dgvProducts";
            this.dgvProducts.ReadOnly = true;
            this.dgvProducts.RowHeadersVisible = false;
            this.dgvProducts.Size = new System.Drawing.Size(636, 198);
            this.dgvProducts.TabIndex = 30;
            this.dgvProducts.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProducts_CellContentClick);
            this.dgvProducts.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dgvProducts_RowPostPaint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DailyAccounts.Properties.Resources.pos_780100;
            this.pictureBox1.Location = new System.Drawing.Point(-1, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(780, 100);
            this.pictureBox1.TabIndex = 65;
            this.pictureBox1.TabStop = false;
            // 
            // SrNo
            // 
            this.SrNo.Frozen = true;
            this.SrNo.HeaderText = "Sr. No.";
            this.SrNo.Name = "SrNo";
            this.SrNo.ReadOnly = true;
            this.SrNo.Width = 50;
            // 
            // Product_Name
            // 
            this.Product_Name.DataPropertyName = "product_name";
            this.Product_Name.Frozen = true;
            this.Product_Name.HeaderText = "Product Name";
            this.Product_Name.Name = "Product_Name";
            this.Product_Name.ReadOnly = true;
            this.Product_Name.Width = 280;
            // 
            // ProductStock
            // 
            this.ProductStock.DataPropertyName = "available_stock";
            this.ProductStock.Frozen = true;
            this.ProductStock.HeaderText = "Product Stock";
            this.ProductStock.Name = "ProductStock";
            this.ProductStock.ReadOnly = true;
            this.ProductStock.Width = 125;
            // 
            // salePrice
            // 
            this.salePrice.DataPropertyName = "sale_price";
            this.salePrice.HeaderText = "Sale Price";
            this.salePrice.Name = "salePrice";
            this.salePrice.ReadOnly = true;
            // 
            // Edit
            // 
            this.Edit.HeaderText = "Delete";
            this.Edit.Image = global::DailyAccounts.Properties.Resources.delete;
            this.Edit.Name = "Edit";
            this.Edit.ReadOnly = true;
            this.Edit.Width = 75;
            // 
            // productId
            // 
            this.productId.DataPropertyName = "id";
            this.productId.HeaderText = "productId";
            this.productId.Name = "productId";
            this.productId.ReadOnly = true;
            this.productId.Visible = false;
            // 
            // frmProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(764, 407);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dgvProducts);
            this.Controls.Add(this.cbxCategory);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnAddCategory);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.label1);
            this.Name = "frmProducts";
            this.Text = "Products List";
            this.Load += new System.EventHandler(this.frmItems_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnAddCategory;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbxCategory;
        private System.Windows.Forms.DataGridView dgvProducts;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn SrNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Product_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductStock;
        private System.Windows.Forms.DataGridViewTextBoxColumn salePrice;
        private System.Windows.Forms.DataGridViewImageColumn Edit;
        private System.Windows.Forms.DataGridViewTextBoxColumn productId;
    }
}