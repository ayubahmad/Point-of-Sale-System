using DailyAccounts.Data;
using DailyAccounts.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DailyAccounts.GUI
{
    public partial class frmPurchase : Form
    {
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtProductQuantity;
        private Button btnCancel;
        private Button btnSave;
        private ComboBox cbxCategory;
        private ComboBox cbxProduct;
        private Label label7;
        private Label lblAvailableStock;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private TextBox txtPaidAmount;
        private Label label13;
        private Label label16;

        public frmPurchase()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPurchase));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtProductQuantity = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.cbxCategory = new System.Windows.Forms.ComboBox();
            this.cbxProduct = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lblAvailableStock = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.txtPaidAmount = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(423, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(307, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Update Product  Stock";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(422, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Select Category";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(422, 208);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Select Product";
            // 
            // txtProductQuantity
            // 
            this.txtProductQuantity.Location = new System.Drawing.Point(652, 234);
            this.txtProductQuantity.Name = "txtProductQuantity";
            this.txtProductQuantity.Size = new System.Drawing.Size(78, 20);
            this.txtProductQuantity.TabIndex = 3;
            this.txtProductQuantity.TextChanged += new System.EventHandler(this.txtProductQuantity_TextChanged);
            // 
            // btnCancel
            // 
            this.btnCancel.Image = global::DailyAccounts.Properties.Resources.delete;
            this.btnCancel.Location = new System.Drawing.Point(521, 294);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(108, 38);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Image = global::DailyAccounts.Properties.Resources.save;
            this.btnSave.Location = new System.Drawing.Point(635, 294);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(95, 38);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Save";
            this.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // cbxCategory
            // 
            this.cbxCategory.DisplayMember = "name";
            this.cbxCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCategory.FormattingEnabled = true;
            this.cbxCategory.Location = new System.Drawing.Point(521, 177);
            this.cbxCategory.Name = "cbxCategory";
            this.cbxCategory.Size = new System.Drawing.Size(209, 21);
            this.cbxCategory.TabIndex = 1;
            this.cbxCategory.ValueMember = "id";
            this.cbxCategory.SelectedIndexChanged += new System.EventHandler(this.cbxCategory_SelectedIndexChanged);
            // 
            // cbxProduct
            // 
            this.cbxProduct.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbxProduct.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxProduct.DisplayMember = "name";
            this.cbxProduct.FormattingEnabled = true;
            this.cbxProduct.Location = new System.Drawing.Point(521, 205);
            this.cbxProduct.Name = "cbxProduct";
            this.cbxProduct.Size = new System.Drawing.Size(209, 21);
            this.cbxProduct.TabIndex = 2;
            this.cbxProduct.ValueMember = "id";
            this.cbxProduct.SelectedIndexChanged += new System.EventHandler(this.cbxProduct_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(422, 237);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Available Stock";
            // 
            // lblAvailableStock
            // 
            this.lblAvailableStock.AutoSize = true;
            this.lblAvailableStock.BackColor = System.Drawing.Color.Transparent;
            this.lblAvailableStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAvailableStock.Location = new System.Drawing.Point(517, 232);
            this.lblAvailableStock.Name = "lblAvailableStock";
            this.lblAvailableStock.Size = new System.Drawing.Size(27, 20);
            this.lblAvailableStock.TabIndex = 16;
            this.lblAvailableStock.Text = "00";
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
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::DailyAccounts.Properties.Resources.graph;
            this.pictureBox2.Location = new System.Drawing.Point(26, 132);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(343, 229);
            this.pictureBox2.TabIndex = 67;
            this.pictureBox2.TabStop = false;
            // 
            // txtPaidAmount
            // 
            this.txtPaidAmount.Location = new System.Drawing.Point(521, 260);
            this.txtPaidAmount.Name = "txtPaidAmount";
            this.txtPaidAmount.Size = new System.Drawing.Size(209, 20);
            this.txtPaidAmount.TabIndex = 6;
            this.txtPaidAmount.TextChanged += new System.EventHandler(this.txtPaidAmount_TextChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Location = new System.Drawing.Point(422, 263);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(67, 13);
            this.label13.TabIndex = 72;
            this.label13.Text = "Paid Amount";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Location = new System.Drawing.Point(586, 237);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(60, 13);
            this.label16.TabIndex = 77;
            this.label16.Text = "New Stock";
            // 
            // frmPurchase
            // 
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(778, 413);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.txtPaidAmount);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblAvailableStock);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cbxProduct);
            this.Controls.Add(this.cbxCategory);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtProductQuantity);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Name = "frmPurchase";
            this.Text = "Update Product Stock";
            this.Load += new System.EventHandler(this.frmPurchase_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void frmPurchase_Load(object sender, EventArgs e)
        {
            string connectionstring = ConfigurationManager.ConnectionStrings["connectionstring"].ToString();
            CategoryRepository categoryRepository = new CategoryRepository(connectionstring);
            DataTable dataTable = categoryRepository.GetAllCategories();
            cbxCategory.DataSource = dataTable;
            cbxCategory.DisplayMember = "category_name";
            cbxCategory.ValueMember = "id";
            //ReInit();
        }
        private void ReInit()
        {
            try
            {


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message);
            }
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int categoryId = 0;
            int productId = 0;
            int available_stock = 0;
            int productQuantity = 0;
            int paidAmount = 0;
            int newStock = 0;
            DateTime dateTime;
            if (cbxCategory.SelectedIndex == -1)
            {
                MessageBox.Show("Select Product Category ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cbxCategory.Focus();
            }
            else if (cbxProduct.SelectedIndex == -1)
            {
                MessageBox.Show("Select Product ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cbxProduct.Focus();
            }
            else if (string.IsNullOrWhiteSpace(txtProductQuantity.Text))
            {
                MessageBox.Show("Enter Product Quantity", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtProductQuantity.Focus();
            }
            else if (!int.TryParse(txtProductQuantity.Text, out productQuantity))
            {
                MessageBox.Show("Invalid Product Quantity", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtProductQuantity.Focus();
            }
            //else if (string.IsNullOrWhiteSpace(txtProductPrice.Text))
            //{
            //    MessageBox.Show("Enter Product Price ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    txtProductPrice.Focus();
            //}
            //else if (!int.TryParse(txtProductPrice.Text, out billedAmount))
            //{
            //    MessageBox.Show("Invalid Bill Amount", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    txtProductQuantity.Focus();
            //}
            else if (string.IsNullOrWhiteSpace(txtPaidAmount.Text))
            {
                MessageBox.Show("Enter Paid Amount ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPaidAmount.Focus();
            }
            else if (!int.TryParse(txtPaidAmount.Text, out paidAmount))
            {
                MessageBox.Show("Invalid Paid Amount", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtProductQuantity.Focus();
            }
            else
            {
                try
                {
                    categoryId = Convert.ToInt32(cbxCategory.SelectedValue);
                    productId = Convert.ToInt32(cbxProduct.SelectedValue);

                    string connectionString = ConfigurationManager.ConnectionStrings["connectionstring"].ToString();
                    ProductRepository productRepository = new ProductRepository(connectionString);
                    Product product = productRepository.GetProduct(productId);
                    available_stock = product.availableStock;
                    productQuantity = Convert.ToInt32(txtProductQuantity.Text);
                    paidAmount = Convert.ToInt32(txtPaidAmount.Text);
                    newStock = available_stock + productQuantity;
                    dateTime = DateTime.Now;
                    productRepository.purchase(productId,dateTime,productQuantity,newStock,paidAmount);
                    MessageBox.Show("Stock updated successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error:" + ex.Message);

                }
            }
        }

        private void cbxCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                //if (cbxCategory.SelectedIndex < 0)
                  //  return;
                //cbxProduct.Items.Clear();
                string connectionString = ConfigurationManager.ConnectionStrings["connectionstring"].ToString();
                int categoryId = Convert.ToInt32(cbxCategory.SelectedValue);
                ProductRepository productRepository = new ProductRepository(connectionString);
                DataTable dt = productRepository.GetProductsByCategoryId(categoryId);
                //DataRow[] rows = dt.Select($"category_id={categoryId}");

                //for (int i =0;i<dt.Rows.Count;i++)
                //{
                //    int categoryIdIntblProduct =Convert.ToInt32(dt.Rows[i]["category_id"].ToString());
                //    if (categoryId == categoryIdIntblProduct)
                //    {
                //        cbxProduct.Items.Add(dt.Rows[i]["product_name"].ToString());
                //    }
                //}
                cbxProduct.DataSource = dt;
                cbxProduct.DisplayMember = "product_name";
                cbxProduct.ValueMember = "id";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in cbxcategory_SelectedIndexChanged:" + ex.Message + " ");
            }
        }

        private void cbxProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {

                //DataRow row = (DataRow)cbxProduct.SelectedItem;
                //lblAvailableStock.Text = row["available_stock"].ToString();
                //if (cbxProduct.SelectedIndex < 0)
                  //  return;
                
                string connectionString = ConfigurationManager.ConnectionStrings["connectionstring"].ToString();
                int productId = Convert.ToInt32(cbxProduct.SelectedValue);
                ProductRepository productRepository = new ProductRepository(connectionString);
                Product product = productRepository.GetProduct(productId);
                //DataRow[] dr = dt.Select($"id='{productId}'");
                if (product != null)
                {
                    lblAvailableStock.Text = product.availableStock.ToString();
                    //MessageBox.Show("product is not null "+product.availableStock);
                }
                //else
                //{
                //    MessageBox.Show("product is null");
                //}
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message+ "cbxProduct_SelectedIndexChanged");
            }
        }

        private void txtProductQuantity_TextChanged(object sender, EventArgs e)
        {


        }
        private void UpdateSupplier()
        {

        }
        #region Members

        #endregion

        private void txtPaidAmount_TextChanged(object sender, EventArgs e)
        {
            int totalPaidAmount = 0;
            if (Int32.TryParse(txtPaidAmount.Text, out totalPaidAmount))
            {
                //lblNewSupplierBalance.Text = (Convert.ToInt32(lblPayableAmount.Text) - totalPaidAmount).ToString();
            }
        }

        private void cbxSupplier_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
