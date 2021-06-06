
using DailyAccounts.Data;
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
    public partial class frmProducts : Form
    {
        public frmProducts()
        {
            InitializeComponent();
        }
        int categoryId;

        private void frmItems_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = Common.Img780x100;
            this.BackgroundImage = Common.Img_Frmbackground;

            string connectionstring = ConfigurationManager.ConnectionStrings["connectionstring"].ToString();
            CategoryRepository categoryRepository = new CategoryRepository(connectionstring);
            DataTable dataTable = categoryRepository.GetAllCategories();
            cbxCategory.DataSource = dataTable;
            cbxCategory.DisplayMember = "category_name";
            cbxCategory.ValueMember = "id";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            new frmAddProduct().ShowDialog();
            LoadProducts(categoryId);
        }

        private void LoadProducts(int id)
        {
            try
            {
                dgvProducts.AutoGenerateColumns = false;
                dgvProducts.AllowUserToResizeColumns = false;
                dgvProducts.AllowUserToResizeRows = false;
                string connectionString = ConfigurationManager.ConnectionStrings["connectionString"].ToString();
                ProductRepository repository = new ProductRepository(connectionString);
                DataTable dt = repository.GetProductsByCategoryId(id);
                dgvProducts.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error While Getting Products:" + ex.Message);
            }
        }

        private void cbxCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            categoryId =Convert.ToInt32(cbxCategory.SelectedValue);
            LoadProducts(categoryId);
        }

        private void dgvProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                try
                {
                    if (dgvProducts.Columns[e.ColumnIndex].HeaderText.Equals("Delete"))
                    {
                        int productId = Convert.ToInt32(dgvProducts.Rows[e.RowIndex].Cells["productId"].Value);
                        string connectionString = ConfigurationManager.ConnectionStrings["connectionString"].ToString();
                        ProductRepository repository = new ProductRepository(connectionString);
                        bool res = repository.deleteProduct(productId);
                        if (res)
                            MessageBox.Show("Product deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        else
                            MessageBox.Show("product Not deleted .", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        LoadProducts(categoryId);
                    }
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error:" + ex.Message);
                }
            }
        }

        private void dgvProducts_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            this.dgvProducts.Rows[e.RowIndex].Cells["SrNo"].Value = (e.RowIndex + 1).ToString();
        }
    }
}
