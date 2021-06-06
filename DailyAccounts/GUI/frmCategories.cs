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
    public partial class frmCategories : Form
    {
        string connectionString;
        public frmCategories()
        {
            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings["connectionString"].ToString();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if(e.RowIndex >= 0)
            {
                try
                {
                    if (dgvCategories.Columns[e.ColumnIndex].HeaderText.Equals("Delete"))
                    {
                        int categoryId =Convert.ToInt32(dgvCategories.Rows[e.RowIndex].Cells["categoryId"].Value);
                        CategoryRepository repository = new CategoryRepository(connectionString);
                        bool res= repository.deleteCategory(categoryId);
                        if (res)
                            MessageBox.Show("Category deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        else
                            MessageBox.Show("Category Not deleted .", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        LoadCategories();
                    }
                    else if (dgvCategories.Columns[e.ColumnIndex].HeaderText.Equals("Edit"))
                    {
                        int categoryId = Convert.ToInt32(dgvCategories.Rows[e.RowIndex].Cells["categoryId"].Value);
                        new frmEditCategory(categoryId).ShowDialog();
                        LoadCategories();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error:" + ex.Message);
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            new frmAddCategory().ShowDialog(); LoadCategories();
        }

        private void frmCategories_Load(object sender, EventArgs e)
        {
            this.BackgroundImage = Common.Img_Frmbackground;
            pictureBox1.Image = Common.Img780x100;
            LoadCategories();
        }

        private void LoadCategories()
        {
            try
            {
                dgvCategories.AutoGenerateColumns = false;
                dgvCategories.AllowUserToResizeColumns = false;
                dgvCategories.AllowUserToResizeRows = false;
                
                CategoryRepository repository = new CategoryRepository(connectionString);
                DataTable dt = repository.GetAllCategories();
                dgvCategories.DataSource = dt;
                
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error While Getting Categories:" + ex.Message);
            }
        }

        private void dgvCategories_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            this.dgvCategories.Rows[e.RowIndex].Cells["SrNo"].Value = (e.RowIndex + 1).ToString();
        }
    }
}
