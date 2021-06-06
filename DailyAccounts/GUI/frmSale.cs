
using DailyAccounts.Data;
using DailyAccounts.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using DailyAccounts.CommonFiles;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DailyAccounts.GUI
{
  
    public partial class frmSale : Form
    {
        private List<Item> itemsList;
        int totalBill;
        int gridViewSerialNumber;
        public frmSale()
        {
            InitializeComponent();
            itemsList = new List<Item>();
            gridViewSerialNumber = 0;
            totalBill = 0;
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
            int dummy = 0;
            string productName = cbxProduct.GetItemText(cbxProduct.SelectedItem);
            int productId =Convert.ToInt32(cbxProduct.SelectedValue);
            int quantity = Convert.ToInt32(txtProductQuantity.Text);
            int price = Convert.ToInt32(lblPrice.Text);
            int amount = quantity * price;
            totalBill += amount;
            
            
            if (cbxProduct.SelectedIndex == -1)
            {
                MessageBox.Show("Select product", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrWhiteSpace(txtProductQuantity.Text))
            {
                MessageBox.Show("Enter Product Quantity", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!Int32.TryParse(txtProductQuantity.Text, out dummy))
            {
                MessageBox.Show("Invalid Product Quantity", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (quantity>Convert.ToInt32(lblAvailableStock.Text))
            {
                MessageBox.Show("Stock is not Enough.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (quantity <= 0)
            {
                MessageBox.Show("Enter Quantity", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
               try
                {
                    lbllTotalBill.Text = totalBill.ToString();
                    lblPayableAmount.Text = totalBill.ToString();
                    lblAvailableStock.Text = (Convert.ToInt32(lblAvailableStock.Text) - quantity).ToString();
                    itemsList.Add(new Item(productId, productName, quantity, price));
                    DataGridViewRow newRow = new DataGridViewRow();
                    newRow.CreateCells(dataGridView1);
                    newRow.Cells[0].Value = ++gridViewSerialNumber;
                    newRow.Cells[1].Value = productName;
                    newRow.Cells[2].Value = quantity;
                    newRow.Cells[3].Value = amount;
                    dataGridView1.Rows.Add(newRow);
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }


        private void frmSale_Load(object sender, EventArgs e)
        {
            try
            {
                this.BackgroundImage = Common.Img_Frmbackground;

                string connectionstring = ConfigurationManager.ConnectionStrings["connectionstring"].ToString();
                CategoryRepository categoryRepository = new CategoryRepository(connectionstring);
                DataTable dataTable = categoryRepository.GetAllCategories();
                cbxcategory.DataSource = dataTable;
                cbxcategory.DisplayMember = "category_name";
                cbxcategory.ValueMember = "id";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message);
            }
        }

        private void cbxProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                
                string connectionString = ConfigurationManager.ConnectionStrings["connectionstring"].ToString();
                int productId = Convert.ToInt32(cbxProduct.SelectedValue);
                ProductRepository productRepository = new ProductRepository(connectionString);
                Product product = productRepository.GetProduct(productId);
                //DataRow[] dr = dt.Select($"id='{productId}'");
                if (product != null)
                {
                    lblAvailableStock.Text = product.availableStock.ToString();
                    lblPrice.Text = product.saleprice.ToString();
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message + "cbxProduct_SelectedIndexChanged");
            }
        }

        private void RefreshGrid()
        {
            
        }




        private void cancelTransaction()
        {

        }

        private void txtProductQuantity_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int totalBilledAmount = Convert.ToInt32(lbllTotalBill.Text);
            int discount = 0;
            int newCustomerBalance = Convert.ToInt32(lblNewCustomerBalance.Text);
            int paidAmount = 0;
            DateTime dateTime = DateTime.Now;
            int items = itemsList.Count;
            string remarks;

            if (!int.TryParse(txtDiscount.Text, out discount))
            {
                MessageBox.Show("Invalid Discount Amount");
                txtDiscount.Focus();
            }
            else if (!int.TryParse(txtPaidAmount.Text, out paidAmount))
            {
                MessageBox.Show("Invalid Paid Amount");
                txtPaidAmount.Focus();
            }
            else if(discount > totalBilledAmount)
            {
                MessageBox.Show("Discount Cannot be Greater Than Total Bill");
            }
            else if (items==0)
            {
                MessageBox.Show("Blank transaction cannot be saved.");
            }
            else
            {
                try
                {
                    int totalBill = Convert.ToInt32(lbllTotalBill.Text);
                    discount = Convert.ToInt32(txtDiscount.Text);
                    remarks = txtRemarks.Text;
                    string connectionString = ConfigurationManager.ConnectionStrings["connectionstring"].ToString();
                    ProductRepository repository = new ProductRepository(connectionString);
                    repository.sale(itemsList,discount,totalBill,remarks,dateTime);
                    MessageBox.Show("Order added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
                
            }

        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        //    if (e.RowIndex >= 0)
        //    {
        //        try
        //        {
        //            if (dataGridView1.Columns[e.ColumnIndex].HeaderText.Equals("Delete"))
        //            {
        //                ////lblAvailableStock.Text = (Convert.ToInt32(lblAvailableStock.Text) - quantity).ToString();
        //                //int categoryId = Convert.ToInt32(dgvCategories.Rows[e.RowIndex].Cells["categoryId"].Value);
        //                //CategoryRepository repository = new CategoryRepository(connectionString);
        //                //bool res = repository.deleteCategory(categoryId);
        //                //if (res)
        //                //    MessageBox.Show("Category deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //                //else
        //                //    MessageBox.Show("Category Not deleted .", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //                //LoadCategories();
                        

        //                dataGridView1.Rows[e.RowIndex].Visible = false;
        //                itemsList.RemoveAt(e.RowIndex);
        //            }
                    
        //        }
        //        catch (Exception ex)
        //        {
        //            MessageBox.Show("Error:" + ex.Message);
        //        }
        //    }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            SearchCustomer();
        }

        private void txtPaidAmount_TextChanged(object sender, EventArgs e)
        {
            UpdateNewCustomerBalance();
        }
        #region Private Methods
        private void SearchCustomer()
        {

        }
        private void UpdateNewCustomerBalance()
        {
            if(txtPaidAmount.Text == "")
            {
                txtPaidAmount.Text = "0";
            }
            else
                lblCustomerBalance.Text = (Convert.ToInt32(txtPaidAmount.Text) - Convert.ToInt32(lblPayableAmount.Text)).ToString();
        }
        #endregion

        private void txtDiscount_TextChanged(object sender, EventArgs e)
        {
            int discount = 0;
            if(int.TryParse(txtDiscount.Text,out discount))
            {
               txtPaidAmount.Text =  lblPayableAmount.Text = (Convert.ToInt32(lbllTotalBill.Text) - discount).ToString();
                
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void cbxcategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["connectionstring"].ToString();
                int categoryId = Convert.ToInt32(cbxcategory.SelectedValue);
                ProductRepository productRepository = new ProductRepository(connectionString);
                DataTable dt = productRepository.GetProductsByCategoryId(categoryId);
                cbxProduct.DataSource = dt;
                cbxProduct.DisplayMember = "product_name";
                cbxProduct.ValueMember = "id";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in cbxcategory_SelectedIndexChanged:" + ex.Message + " ");
            }
        }
    }
}
