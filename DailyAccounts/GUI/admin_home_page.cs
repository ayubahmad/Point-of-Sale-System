namespace DailyAccounts.GUI
{
    using DailyAccounts.GUI;
    using System;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Drawing;
    using System.IO;
    using System.IO.Ports;
    using System.Linq;
    using System.Windows.Forms;

    public class admin_home_page : Form
    {
        private ToolStripMenuItem aboutToolStripMenuItem;
        private IContainer components;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem fileToolStripMenuItem;
        private Label label1;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label lblmainheader;
        private Label lblSchoolName;
        private ToolStripMenuItem logOutToolStripMenuItem;
        private MenuStrip menuStrip1;
        private string password;
        private PictureBox pictureBox1;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem toolStripMenuItem2;
        private ToolStripSeparator toolStripSeparator7;
        private ToolStripSeparator toolStripSeparator8;
        private ToolStripSeparator toolStripSeparator9;
        private ToolStripMenuItem updatePasswordToolStripMenuItem;
        private string username;
        public static string UserType = string.Empty;
        private Button btnExit;
        private Button btnSale;
        private Button btnItems;
        private Button btnPurchase;
        private Button btnCategory;
        private GroupBox groupBox1;
        private Button btnReports;
        private ToolStripMenuItem addManualStockToolStripMenuItem;
        private Label lblAddress;
        private welcome_page welcome;


        public admin_home_page()
        {
            InitializeComponent();
        }
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new about().ShowDialog();
        }
        private void admin_home_page_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void admin_home_page_Load(object sender, EventArgs e)
        {

            pictureBox1.Image = Common.Img1024x150;
            //this.lblrights.Text = "Version  " + Application.ProductVersion + " (Beta)\n\x00a9 2019 Metalogics.\nAll rights reserved.";
            //this.lblSchoolName.Text = Common.StoreName.Replace("&", "&&");
            //this.lblAddress.Text = Common.StoreAddress;
            //this.lblPhone.Text = "Contact # " + Common.Contact;

        }

        private void btnprint_Click(object sender, EventArgs e)
        {
            this.logoutPage();
        }

        
        protected override void Dispose(bool disposing)
        {
            if (disposing && (this.components != null))
            {
                this.components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            base.Close();
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }


        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(admin_home_page));
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblSchoolName = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblmainheader = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addManualStockToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.updatePasswordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator9 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnSale = new System.Windows.Forms.Button();
            this.btnItems = new System.Windows.Forms.Button();
            this.btnPurchase = new System.Windows.Forms.Button();
            this.btnCategory = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnReports = new System.Windows.Forms.Button();
            this.lblAddress = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Tahoma", 8.5F);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(31, 435);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(227, 70);
            this.label4.TabIndex = 75;
            this.label4.Text = "Roll No :    115-BSCS-18\r\nSemester : 4th\r\n\r\nDepartment Of Computer Science\r\nGover" +
    "nment College University, Lahore  \r\n";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(31, 417);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 14);
            this.label5.TabIndex = 74;
            this.label5.Text = "Ayub Ahmad";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // lblSchoolName
            // 
            this.lblSchoolName.AutoSize = true;
            this.lblSchoolName.BackColor = System.Drawing.Color.Transparent;
            this.lblSchoolName.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.lblSchoolName.ForeColor = System.Drawing.Color.Black;
            this.lblSchoolName.Location = new System.Drawing.Point(31, 351);
            this.lblSchoolName.Name = "lblSchoolName";
            this.lblSchoolName.Size = new System.Drawing.Size(121, 14);
            this.lblSchoolName.TabIndex = 72;
            this.lblSchoolName.Text = "Mam Asma Kanwal";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Underline);
            this.label6.ForeColor = System.Drawing.Color.BlueViolet;
            this.label6.Location = new System.Drawing.Point(29, 392);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 14);
            this.label6.TabIndex = 53;
            this.label6.Text = "Developed By:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.BlueViolet;
            this.label7.Location = new System.Drawing.Point(51, 238);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(207, 23);
            this.label7.TabIndex = 57;
            this.label7.Text = "Point of Sale System";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Underline);
            this.label1.ForeColor = System.Drawing.Color.BlueViolet;
            this.label1.Location = new System.Drawing.Point(29, 327);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 14);
            this.label1.TabIndex = 53;
            this.label1.Text = "Submitted To:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblmainheader
            // 
            this.lblmainheader.AutoSize = true;
            this.lblmainheader.BackColor = System.Drawing.Color.Transparent;
            this.lblmainheader.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmainheader.Location = new System.Drawing.Point(28, 186);
            this.lblmainheader.Name = "lblmainheader";
            this.lblmainheader.Size = new System.Drawing.Size(295, 31);
            this.lblmainheader.TabIndex = 37;
            this.lblmainheader.Text = "Welcome Administrator";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.toolStripMenuItem1,
            this.toolStripMenuItem2});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1008, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addManualStockToolStripMenuItem,
            this.logOutToolStripMenuItem,
            this.toolStripSeparator7,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // addManualStockToolStripMenuItem
            // 
            this.addManualStockToolStripMenuItem.Name = "addManualStockToolStripMenuItem";
            this.addManualStockToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.addManualStockToolStripMenuItem.Text = "Add Manual Stock";
            this.addManualStockToolStripMenuItem.Click += new System.EventHandler(this.addManualStockToolStripMenuItem_Click);
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.RightToLeftAutoMirrorImage = true;
            this.logOutToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.F4)));
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.logOutToolStripMenuItem.Text = "Sign out";
            this.logOutToolStripMenuItem.Click += new System.EventHandler(this.logOutToolStripMenuItem_Click);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(184, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem,
            this.toolStripSeparator8,
            this.updatePasswordToolStripMenuItem,
            this.toolStripSeparator9});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(44, 20);
            this.toolStripMenuItem1.Text = "&Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(238, 22);
            this.aboutToolStripMenuItem.Text = "About SMS ";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(235, 6);
            // 
            // updatePasswordToolStripMenuItem
            // 
            this.updatePasswordToolStripMenuItem.Name = "updatePasswordToolStripMenuItem";
            this.updatePasswordToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.P)));
            this.updatePasswordToolStripMenuItem.Size = new System.Drawing.Size(238, 22);
            this.updatePasswordToolStripMenuItem.Text = "Update Password";
            // 
            // toolStripSeparator9
            // 
            this.toolStripSeparator9.Name = "toolStripSeparator9";
            this.toolStripSeparator9.Size = new System.Drawing.Size(235, 6);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(12, 20);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DailyAccounts.Properties.Resources.pos_1024150;
            this.pictureBox1.InitialImage = global::DailyAccounts.Properties.Resources.pos_1024150;
            this.pictureBox1.Location = new System.Drawing.Point(0, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1015, 150);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Image = global::DailyAccounts.Properties.Resources.exit;
            this.btnExit.Location = new System.Drawing.Point(273, 216);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(241, 73);
            this.btnExit.TabIndex = 9;
            this.btnExit.Text = "Logout";
            this.btnExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnSale
            // 
            this.btnSale.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.btnSale.Image = global::DailyAccounts.Properties.Resources.sale2;
            this.btnSale.Location = new System.Drawing.Point(17, 27);
            this.btnSale.Name = "btnSale";
            this.btnSale.Size = new System.Drawing.Size(241, 73);
            this.btnSale.TabIndex = 1;
            this.btnSale.Text = "Sale";
            this.btnSale.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSale.UseVisualStyleBackColor = true;
            this.btnSale.Click += new System.EventHandler(this.btnSale_Click);
            // 
            // btnItems
            // 
            this.btnItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.btnItems.Image = global::DailyAccounts.Properties.Resources.products;
            this.btnItems.Location = new System.Drawing.Point(273, 122);
            this.btnItems.Name = "btnItems";
            this.btnItems.Size = new System.Drawing.Size(241, 72);
            this.btnItems.TabIndex = 6;
            this.btnItems.Text = "Products";
            this.btnItems.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnItems.UseVisualStyleBackColor = true;
            this.btnItems.Click += new System.EventHandler(this.btnItems_Click);
            // 
            // btnPurchase
            // 
            this.btnPurchase.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.btnPurchase.Image = global::DailyAccounts.Properties.Resources.purchase1;
            this.btnPurchase.Location = new System.Drawing.Point(273, 27);
            this.btnPurchase.Name = "btnPurchase";
            this.btnPurchase.Size = new System.Drawing.Size(243, 73);
            this.btnPurchase.TabIndex = 4;
            this.btnPurchase.Text = "Stock Update";
            this.btnPurchase.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPurchase.UseVisualStyleBackColor = true;
            this.btnPurchase.Click += new System.EventHandler(this.btnPurchase_Click);
            // 
            // btnCategory
            // 
            this.btnCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.btnCategory.Image = global::DailyAccounts.Properties.Resources.category1;
            this.btnCategory.Location = new System.Drawing.Point(15, 122);
            this.btnCategory.Name = "btnCategory";
            this.btnCategory.Size = new System.Drawing.Size(243, 72);
            this.btnCategory.TabIndex = 3;
            this.btnCategory.Text = "Product Category";
            this.btnCategory.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCategory.UseVisualStyleBackColor = true;
            this.btnCategory.Click += new System.EventHandler(this.btnCategory_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.btnSale);
            this.groupBox1.Controls.Add(this.btnPurchase);
            this.groupBox1.Controls.Add(this.btnReports);
            this.groupBox1.Controls.Add(this.btnExit);
            this.groupBox1.Controls.Add(this.btnCategory);
            this.groupBox1.Controls.Add(this.btnItems);
            this.groupBox1.Location = new System.Drawing.Point(409, 186);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(543, 307);
            this.groupBox1.TabIndex = 88;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Menu";
            // 
            // btnReports
            // 
            this.btnReports.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.btnReports.Location = new System.Drawing.Point(15, 216);
            this.btnReports.Name = "btnReports";
            this.btnReports.Size = new System.Drawing.Size(243, 73);
            this.btnReports.TabIndex = 7;
            this.btnReports.Text = "Reports";
            this.btnReports.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnReports.UseVisualStyleBackColor = true;
            this.btnReports.Click += new System.EventHandler(this.btnReports_Click);
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.BackColor = System.Drawing.Color.Transparent;
            this.lblAddress.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.ForeColor = System.Drawing.Color.Black;
            this.lblAddress.Location = new System.Drawing.Point(52, 270);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(183, 28);
            this.lblAddress.TabIndex = 78;
            this.lblAddress.Text = "          Semester Project\r\nSubject: Visual Programming";
            this.lblAddress.Click += new System.EventHandler(this.lblAddress_Click);
            // 
            // admin_home_page
            // 
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1008, 571);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblSchoolName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblmainheader);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.groupBox1);
            this.DoubleBuffered = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "admin_home_page";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Welcome to Point of Sale System";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.admin_home_page_FormClosing);
            this.Load += new System.EventHandler(this.admin_home_page_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        


        private void linkHorizon_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ProcessStartInfo startInfo = new ProcessStartInfo(e.Link.LinkData.ToString());
            Process.Start(startInfo);
        }

        private void linkMetalogics_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ProcessStartInfo startInfo = new ProcessStartInfo(e.Link.LinkData.ToString());
            Process.Start(startInfo);
        }


        private void logoutPage()
        {
            if (MessageBox.Show("Are you sure to sign out?\n Make sure that you have closed all opened work properly to avoid data loss.", "Sign Out!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                welcome = new welcome_page();
                this.welcome.isHide = false;
                this.welcome.Show();
                //try
                //{
                //    //if (clsSMS_Interface.ModemPort.IsOpen)
                //    //{
                //    //    clsSMS_Interface.ModemPort.Close();
                //    //}
                //}
                //catch (Exception)
                //{
                //}
                base.Close();
            }
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.logoutPage();
        }



        private void viewHelpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start((Application.StartupPath + @"\Help\sms_help.html").Replace(@"\bin\Debug", string.Empty));
        }

        public static void LoadPic(PictureBox pic)
        {
            OpenFileDialog dialog = new OpenFileDialog
            {
                Filter = "Image Files|*.png;"
            };
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                using (FileStream stream = File.OpenRead(dialog.FileName))
                {
                    Image img = Image.FromFile(dialog.FileName);
                    //MessageBox.Show(Image.FromStream(stream).Size.Width + "x" + Image.FromStream(stream).Size.Height);
                    //if (Image.FromStream(stream).Size.Width != pic.Width || Image.FromStream(stream).Size.Height != pic.Height)
                    if (img.Size.Width != pic.Width || img.Size.Height != pic.Height)
                    {
                        MessageBox.Show("Selected Image Size is not Valid." + Environment.NewLine + "Expected Image Size ::" + pic.Width + "x" + pic.Height);
                    }
                    else
                    {
                        pic.Image = img;
                        //pic.Image = Image.FromStream(stream);
                    }
                }
            }
        }

        private void btnSupplier_Click(object sender, EventArgs e)
        {
        }

        private void btnCategory_Click(object sender, EventArgs e)
        {
            new frmCategories().ShowDialog();
        }

        private void btnItems_Click(object sender, EventArgs e)
        {
            new frmProducts().ShowDialog();
        }

        private void btnPurchase_Click(object sender, EventArgs e)
        {
            new frmPurchase().Show();
        }

        private void btnSale_Click(object sender, EventArgs e)
        {
            new frmSale().Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
           
            this.logoutPage();
        }

        private void btnExpenses_Click(object sender, EventArgs e)
        {
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            new frmReport().Show();
        }

        private void addManualStockToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblAddress_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}

