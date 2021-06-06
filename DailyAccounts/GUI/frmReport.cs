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
using DailyAccounts.Data;
using DailyAccounts.Reports;
using DailyAccounts.Reports.ReportViewfrm;

namespace DailyAccounts.GUI
{
    public partial class frmReport : Form
    {
        string _connectionstring;
        public frmReport()
        {
            InitializeComponent();
            _connectionstring = ConfigurationManager.ConnectionStrings["connectionstring"].ToString();
        }

        private void SrNo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Report_Load(object sender, EventArgs e)
        {
            this.BackgroundImage = Common.Img_Frmbackground;
            tabControlReports.TabPages.Remove(tpExpenses);
            base.AcceptButton = btnGenerateReport;

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
        private void rbRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            UpdateGUI();
        }

        private void btnGenerateReport_Click(object sender, EventArgs e)
        {
            GenerateReport();
        }

        #region Private Helper Methods
        private void UpdateGUI()
        {
            
            #region Cash Flow
            if (rbDateWiseCashFlow.Checked)
            {
                lblCashFlowDateSelection.Text = "Select Month";
                dtpCashFlow.CustomFormat = "MMM-yyyyy";
            }
            else if (rbMonthWiseCashFlow.Checked)
            {
                lblCashFlowDateSelection.Text = "Select Year";
                dtpCashFlow.CustomFormat = "yyyyy";
            }
            else if (rbDateWiseManualCashFlow.Checked)
            {
                lblCashFlowDateSelection.Text = "Select Month";
                dtpCashFlow.CustomFormat = "MMM-yyyyy";
            }
            #endregion

            #region Expenses

            if (rbDailyExpenses.Checked)
            {
                this.lbexpensedate.Text = "Select Date";
                this.dtexpansepiker.Format = DateTimePickerFormat.Custom;
                this.dtexpansepiker.CustomFormat = "dd-MM-yyyy";
                this.cmbexpensetype.Enabled = false;
            }
            else if (rbMonthExpenses.Checked)
            {
                this.lbexpensedate.Text = "Select Month";
                this.dtexpansepiker.Format = DateTimePickerFormat.Custom;
                this.dtexpansepiker.CustomFormat = "MM-yyyy";
                this.cmbexpensetype.Enabled = false;
            }
            else if (rbExpenseTypeMonthWise.Checked)
            {
                this.cmbexpensetype.Enabled = true;
                this.lbexpensedate.Text = "Select Month";
                this.dtexpansepiker.Format = DateTimePickerFormat.Custom;
                this.dtexpansepiker.CustomFormat = "MM-yyyy";
            }
            else if (rbExpenseTitleWiseSummary.Checked)
            {
                this.cmbexpensetype.Enabled = true;
                this.lbexpensedate.Text = "Select Month";
                this.dtexpansepiker.Format = DateTimePickerFormat.Custom;
                this.dtexpansepiker.CustomFormat = "MM-yyyy";
            }

            #endregion

            #region Customer
            if(rbCustomerTransactions.Checked)
            {
                txtCustomerContact.Focus();
            }
            lblCustomerContact.Visible = txtCustomerContact.Visible = rbCustomerTransactions.Checked;
            #endregion


        }

        private void GenerateReport()
        {
            ProductRepository repository = new ProductRepository(_connectionstring);
            DataTable dt = repository.getAllOrders();
            SalesReport rptObj = new SalesReport();
            rptObj.SetDataSource(dt);
            SalesReportViewer viewerObj = new SalesReportViewer();
            
            
        }

        #endregion

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
