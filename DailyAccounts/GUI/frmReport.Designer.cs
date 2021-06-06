namespace DailyAccounts.GUI
{
    partial class frmReport
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnGenerateReport = new System.Windows.Forms.Button();
            this.tabControlReports = new System.Windows.Forms.TabControl();
            this.tpCashFlow = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblCashFlowDateSelection = new System.Windows.Forms.Label();
            this.dtpCashFlow = new System.Windows.Forms.DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rbAvailableStock = new System.Windows.Forms.RadioButton();
            this.rbMonthWiseCashFlow = new System.Windows.Forms.RadioButton();
            this.rbDateWiseManualCashFlow = new System.Windows.Forms.RadioButton();
            this.rbDateWiseCashFlow = new System.Windows.Forms.RadioButton();
            this.tpExpenses = new System.Windows.Forms.TabPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label16 = new System.Windows.Forms.Label();
            this.cmbexpensetype = new System.Windows.Forms.ComboBox();
            this.lbexpensedate = new System.Windows.Forms.Label();
            this.dtexpansepiker = new System.Windows.Forms.DateTimePicker();
            this.panel4 = new System.Windows.Forms.Panel();
            this.rbExpenseTitleWiseSummary = new System.Windows.Forms.RadioButton();
            this.rbExpenseTypeMonthWise = new System.Windows.Forms.RadioButton();
            this.rbMonthExpenses = new System.Windows.Forms.RadioButton();
            this.rbDailyExpenses = new System.Windows.Forms.RadioButton();
            this.tpProducts = new System.Windows.Forms.TabPage();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpSaleDate = new System.Windows.Forms.DateTimePicker();
            this.panel6 = new System.Windows.Forms.Panel();
            this.rbDateWisetransactions = new System.Windows.Forms.RadioButton();
            this.rbDateWiseSale = new System.Windows.Forms.RadioButton();
            this.tpCustomers = new System.Windows.Forms.TabPage();
            this.panel7 = new System.Windows.Forms.Panel();
            this.txtCustomerContact = new System.Windows.Forms.TextBox();
            this.lblCustomerContact = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.rbCustomerTransactions = new System.Windows.Forms.RadioButton();
            this.rbReceivableFromCustomers = new System.Windows.Forms.RadioButton();
            this.rbPayableToCustomers = new System.Windows.Forms.RadioButton();
            this.rbCustomers = new System.Windows.Forms.RadioButton();
            this.tpSuppliers = new System.Windows.Forms.TabPage();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.rbReceivableFromSuppliers = new System.Windows.Forms.RadioButton();
            this.rbPayableToSuppliers = new System.Windows.Forms.RadioButton();
            this.rbSuppliers = new System.Windows.Forms.RadioButton();
            this.btnCancel = new System.Windows.Forms.Button();
            this.tabControlReports.SuspendLayout();
            this.tpCashFlow.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tpExpenses.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.tpProducts.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.tpCustomers.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel8.SuspendLayout();
            this.tpSuppliers.SuspendLayout();
            this.panel10.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(247, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 31);
            this.label1.TabIndex = 36;
            this.label1.Text = "Report Wizard";
            // 
            // btnGenerateReport
            // 
            this.btnGenerateReport.Location = new System.Drawing.Point(614, 432);
            this.btnGenerateReport.Name = "btnGenerateReport";
            this.btnGenerateReport.Size = new System.Drawing.Size(108, 23);
            this.btnGenerateReport.TabIndex = 35;
            this.btnGenerateReport.Text = "Generate Report";
            this.btnGenerateReport.UseVisualStyleBackColor = true;
            this.btnGenerateReport.Click += new System.EventHandler(this.btnGenerateReport_Click);
            // 
            // tabControlReports
            // 
            this.tabControlReports.Controls.Add(this.tpCashFlow);
            this.tabControlReports.Controls.Add(this.tpExpenses);
            this.tabControlReports.Controls.Add(this.tpProducts);
            this.tabControlReports.Controls.Add(this.tpCustomers);
            this.tabControlReports.Controls.Add(this.tpSuppliers);
            this.tabControlReports.Location = new System.Drawing.Point(12, 43);
            this.tabControlReports.Name = "tabControlReports";
            this.tabControlReports.SelectedIndex = 0;
            this.tabControlReports.Size = new System.Drawing.Size(717, 383);
            this.tabControlReports.TabIndex = 44;
            // 
            // tpCashFlow
            // 
            this.tpCashFlow.Controls.Add(this.panel2);
            this.tpCashFlow.Controls.Add(this.panel1);
            this.tpCashFlow.Location = new System.Drawing.Point(4, 22);
            this.tpCashFlow.Name = "tpCashFlow";
            this.tpCashFlow.Padding = new System.Windows.Forms.Padding(3);
            this.tpCashFlow.Size = new System.Drawing.Size(709, 357);
            this.tpCashFlow.TabIndex = 0;
            this.tpCashFlow.Text = "Flow Tracking";
            this.tpCashFlow.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblCashFlowDateSelection);
            this.panel2.Controls.Add(this.dtpCashFlow);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(203, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(503, 351);
            this.panel2.TabIndex = 1;
            // 
            // lblCashFlowDateSelection
            // 
            this.lblCashFlowDateSelection.AutoSize = true;
            this.lblCashFlowDateSelection.Location = new System.Drawing.Point(64, 45);
            this.lblCashFlowDateSelection.Name = "lblCashFlowDateSelection";
            this.lblCashFlowDateSelection.Size = new System.Drawing.Size(70, 13);
            this.lblCashFlowDateSelection.TabIndex = 1;
            this.lblCashFlowDateSelection.Text = "Select Month";
            // 
            // dtpCashFlow
            // 
            this.dtpCashFlow.CustomFormat = "MMM-yyyy";
            this.dtpCashFlow.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpCashFlow.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpCashFlow.Location = new System.Drawing.Point(64, 64);
            this.dtpCashFlow.Name = "dtpCashFlow";
            this.dtpCashFlow.Size = new System.Drawing.Size(167, 31);
            this.dtpCashFlow.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rbAvailableStock);
            this.panel1.Controls.Add(this.rbMonthWiseCashFlow);
            this.panel1.Controls.Add(this.rbDateWiseManualCashFlow);
            this.panel1.Controls.Add(this.rbDateWiseCashFlow);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 351);
            this.panel1.TabIndex = 0;
            // 
            // rbAvailableStock
            // 
            this.rbAvailableStock.AutoSize = true;
            this.rbAvailableStock.Location = new System.Drawing.Point(16, 106);
            this.rbAvailableStock.Name = "rbAvailableStock";
            this.rbAvailableStock.Size = new System.Drawing.Size(134, 17);
            this.rbAvailableStock.TabIndex = 1;
            this.rbAvailableStock.Text = "Available Stock Report";
            this.rbAvailableStock.UseVisualStyleBackColor = true;
            // 
            // rbMonthWiseCashFlow
            // 
            this.rbMonthWiseCashFlow.AutoSize = true;
            this.rbMonthWiseCashFlow.Location = new System.Drawing.Point(16, 68);
            this.rbMonthWiseCashFlow.Name = "rbMonthWiseCashFlow";
            this.rbMonthWiseCashFlow.Size = new System.Drawing.Size(134, 17);
            this.rbMonthWiseCashFlow.TabIndex = 0;
            this.rbMonthWiseCashFlow.Text = "Month Wise Cash Flow";
            this.rbMonthWiseCashFlow.UseVisualStyleBackColor = true;
            this.rbMonthWiseCashFlow.CheckedChanged += new System.EventHandler(this.rbRadioButton_CheckedChanged);
            // 
            // rbDateWiseManualCashFlow
            // 
            this.rbDateWiseManualCashFlow.AutoSize = true;
            this.rbDateWiseManualCashFlow.Checked = true;
            this.rbDateWiseManualCashFlow.Location = new System.Drawing.Point(16, 142);
            this.rbDateWiseManualCashFlow.Name = "rbDateWiseManualCashFlow";
            this.rbDateWiseManualCashFlow.Size = new System.Drawing.Size(144, 17);
            this.rbDateWiseManualCashFlow.TabIndex = 0;
            this.rbDateWiseManualCashFlow.TabStop = true;
            this.rbDateWiseManualCashFlow.Text = "Date Wise Manual Sheet";
            this.rbDateWiseManualCashFlow.UseVisualStyleBackColor = true;
            this.rbDateWiseManualCashFlow.CheckedChanged += new System.EventHandler(this.rbRadioButton_CheckedChanged);
            // 
            // rbDateWiseCashFlow
            // 
            this.rbDateWiseCashFlow.AutoSize = true;
            this.rbDateWiseCashFlow.Checked = true;
            this.rbDateWiseCashFlow.Location = new System.Drawing.Point(16, 34);
            this.rbDateWiseCashFlow.Name = "rbDateWiseCashFlow";
            this.rbDateWiseCashFlow.Size = new System.Drawing.Size(127, 17);
            this.rbDateWiseCashFlow.TabIndex = 0;
            this.rbDateWiseCashFlow.TabStop = true;
            this.rbDateWiseCashFlow.Text = "Date Wise Cash Flow";
            this.rbDateWiseCashFlow.UseVisualStyleBackColor = true;
            this.rbDateWiseCashFlow.CheckedChanged += new System.EventHandler(this.rbRadioButton_CheckedChanged);
            // 
            // tpExpenses
            // 
            this.tpExpenses.Controls.Add(this.panel3);
            this.tpExpenses.Controls.Add(this.panel4);
            this.tpExpenses.Location = new System.Drawing.Point(4, 22);
            this.tpExpenses.Name = "tpExpenses";
            this.tpExpenses.Padding = new System.Windows.Forms.Padding(3);
            this.tpExpenses.Size = new System.Drawing.Size(709, 357);
            this.tpExpenses.TabIndex = 2;
            this.tpExpenses.Text = "Expenses";
            this.tpExpenses.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label16);
            this.panel3.Controls.Add(this.cmbexpensetype);
            this.panel3.Controls.Add(this.lbexpensedate);
            this.panel3.Controls.Add(this.dtexpansepiker);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(203, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(503, 351);
            this.panel3.TabIndex = 3;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.ForeColor = System.Drawing.Color.Green;
            this.label16.Location = new System.Drawing.Point(68, 99);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(108, 13);
            this.label16.TabIndex = 85;
            this.label16.Text = "Select Expense Type";
            // 
            // cmbexpensetype
            // 
            this.cmbexpensetype.DisplayMember = "expense_title";
            this.cmbexpensetype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbexpensetype.Enabled = false;
            this.cmbexpensetype.FormattingEnabled = true;
            this.cmbexpensetype.Items.AddRange(new object[] {
            "Cafeteria",
            "Stationary",
            "Both",
            "School Expense"});
            this.cmbexpensetype.Location = new System.Drawing.Point(71, 115);
            this.cmbexpensetype.Name = "cmbexpensetype";
            this.cmbexpensetype.Size = new System.Drawing.Size(166, 21);
            this.cmbexpensetype.TabIndex = 84;
            this.cmbexpensetype.ValueMember = "expensetype_id";
            // 
            // lbexpensedate
            // 
            this.lbexpensedate.AutoSize = true;
            this.lbexpensedate.ForeColor = System.Drawing.Color.Green;
            this.lbexpensedate.Location = new System.Drawing.Point(68, 34);
            this.lbexpensedate.Name = "lbexpensedate";
            this.lbexpensedate.Size = new System.Drawing.Size(63, 13);
            this.lbexpensedate.TabIndex = 82;
            this.lbexpensedate.Text = "Select Date";
            // 
            // dtexpansepiker
            // 
            this.dtexpansepiker.CustomFormat = "dd-MM-yyyy";
            this.dtexpansepiker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtexpansepiker.Location = new System.Drawing.Point(71, 50);
            this.dtexpansepiker.Name = "dtexpansepiker";
            this.dtexpansepiker.Size = new System.Drawing.Size(169, 20);
            this.dtexpansepiker.TabIndex = 81;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.rbExpenseTitleWiseSummary);
            this.panel4.Controls.Add(this.rbExpenseTypeMonthWise);
            this.panel4.Controls.Add(this.rbMonthExpenses);
            this.panel4.Controls.Add(this.rbDailyExpenses);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(3, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(200, 351);
            this.panel4.TabIndex = 2;
            // 
            // rbExpenseTitleWiseSummary
            // 
            this.rbExpenseTitleWiseSummary.AutoSize = true;
            this.rbExpenseTitleWiseSummary.Location = new System.Drawing.Point(14, 165);
            this.rbExpenseTitleWiseSummary.Name = "rbExpenseTitleWiseSummary";
            this.rbExpenseTitleWiseSummary.Size = new System.Drawing.Size(175, 17);
            this.rbExpenseTitleWiseSummary.TabIndex = 10;
            this.rbExpenseTitleWiseSummary.Text = "Monthly Expense Title Summary";
            this.rbExpenseTitleWiseSummary.UseVisualStyleBackColor = true;
            this.rbExpenseTitleWiseSummary.CheckedChanged += new System.EventHandler(this.rbRadioButton_CheckedChanged);
            // 
            // rbExpenseTypeMonthWise
            // 
            this.rbExpenseTypeMonthWise.AutoSize = true;
            this.rbExpenseTypeMonthWise.Location = new System.Drawing.Point(14, 115);
            this.rbExpenseTypeMonthWise.Name = "rbExpenseTypeMonthWise";
            this.rbExpenseTypeMonthWise.Size = new System.Drawing.Size(165, 17);
            this.rbExpenseTypeMonthWise.TabIndex = 8;
            this.rbExpenseTypeMonthWise.Text = "Monthly Repot Expense Wise";
            this.rbExpenseTypeMonthWise.UseVisualStyleBackColor = true;
            this.rbExpenseTypeMonthWise.CheckedChanged += new System.EventHandler(this.rbRadioButton_CheckedChanged);
            // 
            // rbMonthExpenses
            // 
            this.rbMonthExpenses.AutoSize = true;
            this.rbMonthExpenses.Location = new System.Drawing.Point(14, 77);
            this.rbMonthExpenses.Name = "rbMonthExpenses";
            this.rbMonthExpenses.Size = new System.Drawing.Size(88, 17);
            this.rbMonthExpenses.TabIndex = 7;
            this.rbMonthExpenses.Text = "Month Based";
            this.rbMonthExpenses.UseVisualStyleBackColor = true;
            this.rbMonthExpenses.CheckedChanged += new System.EventHandler(this.rbRadioButton_CheckedChanged);
            // 
            // rbDailyExpenses
            // 
            this.rbDailyExpenses.AutoSize = true;
            this.rbDailyExpenses.Checked = true;
            this.rbDailyExpenses.Location = new System.Drawing.Point(14, 36);
            this.rbDailyExpenses.Name = "rbDailyExpenses";
            this.rbDailyExpenses.Size = new System.Drawing.Size(81, 17);
            this.rbDailyExpenses.TabIndex = 6;
            this.rbDailyExpenses.TabStop = true;
            this.rbDailyExpenses.Text = "Daily Based";
            this.rbDailyExpenses.UseVisualStyleBackColor = true;
            this.rbDailyExpenses.CheckedChanged += new System.EventHandler(this.rbRadioButton_CheckedChanged);
            // 
            // tpProducts
            // 
            this.tpProducts.Controls.Add(this.panel5);
            this.tpProducts.Controls.Add(this.panel6);
            this.tpProducts.Location = new System.Drawing.Point(4, 22);
            this.tpProducts.Name = "tpProducts";
            this.tpProducts.Padding = new System.Windows.Forms.Padding(3);
            this.tpProducts.Size = new System.Drawing.Size(709, 357);
            this.tpProducts.TabIndex = 3;
            this.tpProducts.Text = "Sale";
            this.tpProducts.UseVisualStyleBackColor = true;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.label2);
            this.panel5.Controls.Add(this.dtpSaleDate);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(203, 3);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(503, 351);
            this.panel5.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Select Date";
            // 
            // dtpSaleDate
            // 
            this.dtpSaleDate.CustomFormat = "dd-MMM-yyyy";
            this.dtpSaleDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpSaleDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpSaleDate.Location = new System.Drawing.Point(64, 64);
            this.dtpSaleDate.Name = "dtpSaleDate";
            this.dtpSaleDate.Size = new System.Drawing.Size(167, 31);
            this.dtpSaleDate.TabIndex = 0;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.rbDateWisetransactions);
            this.panel6.Controls.Add(this.rbDateWiseSale);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel6.Location = new System.Drawing.Point(3, 3);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(200, 351);
            this.panel6.TabIndex = 2;
            // 
            // rbDateWisetransactions
            // 
            this.rbDateWisetransactions.AutoSize = true;
            this.rbDateWisetransactions.Location = new System.Drawing.Point(16, 76);
            this.rbDateWisetransactions.Name = "rbDateWisetransactions";
            this.rbDateWisetransactions.Size = new System.Drawing.Size(139, 17);
            this.rbDateWisetransactions.TabIndex = 1;
            this.rbDateWisetransactions.Text = "Date Wise Transactions";
            this.rbDateWisetransactions.UseVisualStyleBackColor = true;
            // 
            // rbDateWiseSale
            // 
            this.rbDateWiseSale.AutoSize = true;
            this.rbDateWiseSale.Checked = true;
            this.rbDateWiseSale.Location = new System.Drawing.Point(16, 34);
            this.rbDateWiseSale.Name = "rbDateWiseSale";
            this.rbDateWiseSale.Size = new System.Drawing.Size(99, 17);
            this.rbDateWiseSale.TabIndex = 0;
            this.rbDateWiseSale.TabStop = true;
            this.rbDateWiseSale.Text = "Date Wise Sale";
            this.rbDateWiseSale.UseVisualStyleBackColor = true;
            // 
            // tpCustomers
            // 
            this.tpCustomers.Controls.Add(this.panel7);
            this.tpCustomers.Controls.Add(this.panel8);
            this.tpCustomers.Location = new System.Drawing.Point(4, 22);
            this.tpCustomers.Name = "tpCustomers";
            this.tpCustomers.Padding = new System.Windows.Forms.Padding(3);
            this.tpCustomers.Size = new System.Drawing.Size(709, 357);
            this.tpCustomers.TabIndex = 4;
            this.tpCustomers.Text = "Customers";
            this.tpCustomers.UseVisualStyleBackColor = true;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.txtCustomerContact);
            this.panel7.Controls.Add(this.lblCustomerContact);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.Location = new System.Drawing.Point(203, 3);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(503, 351);
            this.panel7.TabIndex = 5;
            // 
            // txtCustomerContact
            // 
            this.txtCustomerContact.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustomerContact.Location = new System.Drawing.Point(98, 66);
            this.txtCustomerContact.Name = "txtCustomerContact";
            this.txtCustomerContact.Size = new System.Drawing.Size(233, 26);
            this.txtCustomerContact.TabIndex = 29;
            this.txtCustomerContact.Visible = false;
            // 
            // lblCustomerContact
            // 
            this.lblCustomerContact.AutoSize = true;
            this.lblCustomerContact.Location = new System.Drawing.Point(95, 50);
            this.lblCustomerContact.Name = "lblCustomerContact";
            this.lblCustomerContact.Size = new System.Drawing.Size(54, 13);
            this.lblCustomerContact.TabIndex = 30;
            this.lblCustomerContact.Text = "Contact #";
            this.lblCustomerContact.Visible = false;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.rbCustomerTransactions);
            this.panel8.Controls.Add(this.rbReceivableFromCustomers);
            this.panel8.Controls.Add(this.rbPayableToCustomers);
            this.panel8.Controls.Add(this.rbCustomers);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel8.Location = new System.Drawing.Point(3, 3);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(200, 351);
            this.panel8.TabIndex = 4;
            // 
            // rbCustomerTransactions
            // 
            this.rbCustomerTransactions.AutoSize = true;
            this.rbCustomerTransactions.Location = new System.Drawing.Point(15, 147);
            this.rbCustomerTransactions.Name = "rbCustomerTransactions";
            this.rbCustomerTransactions.Size = new System.Drawing.Size(138, 17);
            this.rbCustomerTransactions.TabIndex = 4;
            this.rbCustomerTransactions.Text = "Customers Transactions";
            this.rbCustomerTransactions.UseVisualStyleBackColor = true;
            this.rbCustomerTransactions.CheckedChanged += new System.EventHandler(this.rbRadioButton_CheckedChanged);
            // 
            // rbReceivableFromCustomers
            // 
            this.rbReceivableFromCustomers.AutoSize = true;
            this.rbReceivableFromCustomers.Location = new System.Drawing.Point(15, 106);
            this.rbReceivableFromCustomers.Name = "rbReceivableFromCustomers";
            this.rbReceivableFromCustomers.Size = new System.Drawing.Size(157, 17);
            this.rbReceivableFromCustomers.TabIndex = 3;
            this.rbReceivableFromCustomers.Text = "Receivable From Customers";
            this.rbReceivableFromCustomers.UseVisualStyleBackColor = true;
            // 
            // rbPayableToCustomers
            // 
            this.rbPayableToCustomers.AutoSize = true;
            this.rbPayableToCustomers.Location = new System.Drawing.Point(15, 66);
            this.rbPayableToCustomers.Name = "rbPayableToCustomers";
            this.rbPayableToCustomers.Size = new System.Drawing.Size(131, 17);
            this.rbPayableToCustomers.TabIndex = 3;
            this.rbPayableToCustomers.Text = "Payable To Customers";
            this.rbPayableToCustomers.UseVisualStyleBackColor = true;
            // 
            // rbCustomers
            // 
            this.rbCustomers.AutoSize = true;
            this.rbCustomers.Checked = true;
            this.rbCustomers.Location = new System.Drawing.Point(15, 31);
            this.rbCustomers.Name = "rbCustomers";
            this.rbCustomers.Size = new System.Drawing.Size(93, 17);
            this.rbCustomers.TabIndex = 3;
            this.rbCustomers.TabStop = true;
            this.rbCustomers.Text = "Customers List";
            this.rbCustomers.UseVisualStyleBackColor = true;
            // 
            // tpSuppliers
            // 
            this.tpSuppliers.Controls.Add(this.panel9);
            this.tpSuppliers.Controls.Add(this.panel10);
            this.tpSuppliers.Location = new System.Drawing.Point(4, 22);
            this.tpSuppliers.Name = "tpSuppliers";
            this.tpSuppliers.Padding = new System.Windows.Forms.Padding(3);
            this.tpSuppliers.Size = new System.Drawing.Size(709, 357);
            this.tpSuppliers.TabIndex = 5;
            this.tpSuppliers.Text = "Suppliers";
            this.tpSuppliers.UseVisualStyleBackColor = true;
            // 
            // panel9
            // 
            this.panel9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel9.Location = new System.Drawing.Point(203, 3);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(503, 351);
            this.panel9.TabIndex = 5;
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.rbReceivableFromSuppliers);
            this.panel10.Controls.Add(this.rbPayableToSuppliers);
            this.panel10.Controls.Add(this.rbSuppliers);
            this.panel10.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel10.Location = new System.Drawing.Point(3, 3);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(200, 351);
            this.panel10.TabIndex = 4;
            // 
            // rbReceivableFromSuppliers
            // 
            this.rbReceivableFromSuppliers.AutoSize = true;
            this.rbReceivableFromSuppliers.Location = new System.Drawing.Point(19, 111);
            this.rbReceivableFromSuppliers.Name = "rbReceivableFromSuppliers";
            this.rbReceivableFromSuppliers.Size = new System.Drawing.Size(148, 17);
            this.rbReceivableFromSuppliers.TabIndex = 4;
            this.rbReceivableFromSuppliers.Text = "Receivable from Suppliers";
            this.rbReceivableFromSuppliers.UseVisualStyleBackColor = true;
            // 
            // rbPayableToSuppliers
            // 
            this.rbPayableToSuppliers.AutoSize = true;
            this.rbPayableToSuppliers.Location = new System.Drawing.Point(19, 71);
            this.rbPayableToSuppliers.Name = "rbPayableToSuppliers";
            this.rbPayableToSuppliers.Size = new System.Drawing.Size(121, 17);
            this.rbPayableToSuppliers.TabIndex = 4;
            this.rbPayableToSuppliers.Text = "Payable to Suppliers";
            this.rbPayableToSuppliers.UseVisualStyleBackColor = true;
            // 
            // rbSuppliers
            // 
            this.rbSuppliers.AutoSize = true;
            this.rbSuppliers.Checked = true;
            this.rbSuppliers.Location = new System.Drawing.Point(19, 30);
            this.rbSuppliers.Name = "rbSuppliers";
            this.rbSuppliers.Size = new System.Drawing.Size(87, 17);
            this.rbSuppliers.TabIndex = 3;
            this.rbSuppliers.TabStop = true;
            this.rbSuppliers.Text = "Suppliers List";
            this.rbSuppliers.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(533, 432);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 45;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // frmReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(734, 471);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.tabControlReports);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGenerateReport);
            this.Name = "frmReport";
            this.Text = "Report";
            this.Load += new System.EventHandler(this.Report_Load);
            this.tabControlReports.ResumeLayout(false);
            this.tpCashFlow.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tpExpenses.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.tpProducts.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.tpCustomers.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.tpSuppliers.ResumeLayout(false);
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGenerateReport;
        private System.Windows.Forms.TabControl tabControlReports;
        private System.Windows.Forms.TabPage tpCashFlow;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rbMonthWiseCashFlow;
        private System.Windows.Forms.RadioButton rbDateWiseCashFlow;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblCashFlowDateSelection;
        private System.Windows.Forms.DateTimePicker dtpCashFlow;
        private System.Windows.Forms.TabPage tpExpenses;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.RadioButton rbExpenseTitleWiseSummary;
        private System.Windows.Forms.RadioButton rbExpenseTypeMonthWise;
        private System.Windows.Forms.RadioButton rbMonthExpenses;
        private System.Windows.Forms.RadioButton rbDailyExpenses;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox cmbexpensetype;
        private System.Windows.Forms.Label lbexpensedate;
        private System.Windows.Forms.DateTimePicker dtexpansepiker;
        private System.Windows.Forms.RadioButton rbAvailableStock;
        private System.Windows.Forms.TabPage tpProducts;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpSaleDate;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.RadioButton rbDateWiseSale;
        private System.Windows.Forms.TabPage tpCustomers;
        private System.Windows.Forms.TabPage tpSuppliers;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.RadioButton rbCustomers;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.RadioButton rbSuppliers;
        private System.Windows.Forms.RadioButton rbReceivableFromSuppliers;
        private System.Windows.Forms.RadioButton rbPayableToSuppliers;
        private System.Windows.Forms.RadioButton rbReceivableFromCustomers;
        private System.Windows.Forms.RadioButton rbPayableToCustomers;
        private System.Windows.Forms.RadioButton rbCustomerTransactions;
        private System.Windows.Forms.TextBox txtCustomerContact;
        private System.Windows.Forms.Label lblCustomerContact;
        private System.Windows.Forms.RadioButton rbDateWisetransactions;
        private System.Windows.Forms.RadioButton rbDateWiseManualCashFlow;
    }
}