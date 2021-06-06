
using DailyAccounts.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using DailyAccounts.Data;

namespace DailyAccounts.GUI
{
    public partial class frmAddProduct : Form
    {
        private Label label2;
        private TextBox txtProductName;
        private Button btnCancel;
        private Button btnSave;
        private Label label3;
        private ComboBox cbxCategory;
        private Label lblHeader;

        ActionType actionType = ActionType.Add;
        private Label label4;
        private TextBox txtPrice;
        private Label label6;
        private TextBox txtQuantity;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        public frmAddProduct()
        {
            InitializeComponent();
        }



        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddProduct));
            this.lblHeader = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbxCategory = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.BackColor = System.Drawing.Color.Transparent;
            this.lblHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.Location = new System.Drawing.Point(481, 136);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(182, 31);
            this.lblHeader.TabIndex = 1;
            this.lblHeader.Text = "Add Product ";
            this.lblHeader.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(381, 205);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Product Name";
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(487, 198);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(230, 20);
            this.txtProductName.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(381, 229);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Select Category";
            // 
            // cbxCategory
            // 
            this.cbxCategory.DisplayMember = "name";
            this.cbxCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCategory.FormattingEnabled = true;
            this.cbxCategory.Location = new System.Drawing.Point(487, 229);
            this.cbxCategory.Name = "cbxCategory";
            this.cbxCategory.Size = new System.Drawing.Size(230, 21);
            this.cbxCategory.TabIndex = 2;
            this.cbxCategory.ValueMember = "id";
            this.cbxCategory.SelectedIndexChanged += new System.EventHandler(this.cbxCategory_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(381, 267);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Sale Price";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(487, 260);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(81, 20);
            this.txtPrice.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(584, 267);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Stock";
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(636, 260);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(81, 20);
            this.txtQuantity.TabIndex = 4;
            // 
            // btnCancel
            // 
            this.btnCancel.Image = global::DailyAccounts.Properties.Resources.delete;
            this.btnCancel.Location = new System.Drawing.Point(519, 311);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(96, 28);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Image = global::DailyAccounts.Properties.Resources.save;
            this.btnSave.Location = new System.Drawing.Point(621, 311);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(96, 28);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Save";
            this.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DailyAccounts.Properties.Resources.pos_780100;
            this.pictureBox1.Location = new System.Drawing.Point(-1, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(780, 100);
            this.pictureBox1.TabIndex = 43;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = global::DailyAccounts.Properties.Resources.addProduct;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(12, 136);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(343, 229);
            this.pictureBox2.TabIndex = 62;
            this.pictureBox2.TabStop = false;
            // 
            // frmAddProduct
            // 
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(764, 388);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbxCategory);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtProductName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblHeader);
            this.DoubleBuffered = true;
            this.Name = "frmAddProduct";
            this.Text = "Product";
            this.Load += new System.EventHandler(this.frmAddProduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int price = 0, quantity = 0, categoryId=0; string categoryName, productName;
            if (string.IsNullOrWhiteSpace(txtProductName.Text))
            {
                MessageBox.Show("Enter Product Name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtProductName.Focus();
            }
            else if (cbxCategory.SelectedIndex == -1)
            {
                MessageBox.Show("Select Category ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cbxCategory.Focus();
            }
            else if(!Int32.TryParse(txtPrice.Text,out price))
            {
                MessageBox.Show("Invalid Price ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPrice.Focus();
            }
            else if (!Int32.TryParse(txtQuantity.Text, out quantity))
            {
                MessageBox.Show("Invalid Quantity ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtQuantity.Focus();
            }
            else if(quantity < 1)
            {
                MessageBox.Show("Quantity Must be greater than or equal to 1 ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtQuantity.Focus();
            }
            //else if (!Int32.TryParse(txtActualPrice.Text, out actual_price))
            //{
            //    MessageBox.Show("Invalid Actual Price ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    txtPrice.Focus();
            //}
            //else if (!Int32.TryParse(txtActualQuantity.Text, out actual_quantity))
            //{
            //    MessageBox.Show("Invalid Actual Quantity ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    txtQuantity.Focus();
            //}
            else if (quantity < 1)
            {
                MessageBox.Show("Actual Quantity Must be greater than or equal to 1 ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtQuantity.Focus();
            }
            else
            {
                try
                {
                    productName = txtProductName.Text;
                    quantity = Convert.ToInt16(txtQuantity.Text);
                    price = Convert.ToInt16(txtPrice.Text);

                    string connectionstring = ConfigurationManager.ConnectionStrings["connectionstring"].ToString();
                   
                    categoryId =Convert.ToInt16(cbxCategory.SelectedValue);
                    ProductRepository productRepository = new ProductRepository(connectionstring);
                    productRepository.AddProduct(categoryId, productName, quantity, price);

                    MessageBox.Show($"'{productName}' Added Successfully.", ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error:" + ex.Message);
                }
            }
        }

        private void frmAddProduct_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = Common.Img780x100;

            string connectionstring = ConfigurationManager.ConnectionStrings["connectionstring"].ToString();

            CategoryRepository categoryRepository = new CategoryRepository(connectionstring);
            DataTable dataTable = categoryRepository.GetAllCategories();
            cbxCategory.DataSource = dataTable;
            cbxCategory.DisplayMember = "category_name";
            cbxCategory.ValueMember = "id";
        }

        private void cbxCategory_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
