using DailyAccounts.DTO;
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
    public partial class frmEditCategory : Form
    {
        ActionType actionType = ActionType.Add;
        int _categoryId;
        public frmEditCategory(int categoryId)
        {
            InitializeComponent();
            _categoryId = categoryId;
        }



        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCategoryName.Text))
            {
                MessageBox.Show("Enter Category Name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCategoryName.Focus();
            }
            else
            {
                try
                {
                    string categoryName = txtCategoryName.Text;
                    string connectionString = ConfigurationManager.ConnectionStrings["connectionString"].ToString();
                    CategoryRepository repository = new CategoryRepository(connectionString);
                    
                    repository.EditCategory(_categoryId, categoryName);
                    MessageBox.Show("Sucessfully Edited", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                //Save
            }
        }

        private void frmEditCategory_Load(object sender, EventArgs e)
        {
            this.BackgroundImage = Common.Img_Frmbackground;
        }
    }
}
