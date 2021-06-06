namespace DailyAccounts.GUI
{
    using DailyAccounts.CommonFiles;
    using DailyAccounts.Data;
    using DailyAccounts.Model;
    using System;
    using System.ComponentModel;
    using System.Configuration;
    using System.Diagnostics;
    using System.Drawing;
    using System.Windows.Forms;

    public class welcome_page : Form
    {
        private ToolStripMenuItem aboutToolStripMenuItem;
        private Button btnlogin;
        private IContainer components = null;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        public bool isHide = false;
        private Label label1;
        private Label label2;
        private Label lblmainheader;
        private LinkLabel linkpasswordforget;
        private GroupBox login_panel;
        private PictureBox main_header;
        private MenuStrip menuStrip1;
        private PictureBox pictureBox1;
        private ToolStripSeparator toolStripSeparator1;
        private TextBox txtpassword;
        private Label lblDevelopedBy;
        private Label lbl_Developer;
        private Label lbl_developerDetail;
        private TextBox txtusername;

        public welcome_page()
        {
            this.InitializeComponent();
            main_header.Image = Common.Img1024x150;
            pictureBox1.Image = Common.welcome_564x464;
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new about().Show();
        }

        private void authenticate()
        {
            if (this.txtusername.Text == "")
            {
                MessageBox.Show("Please enter username to login!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.txtusername.Focus();
            }
            else if (this.txtpassword.Text == "")
            {
                MessageBox.Show("Please enter password to login!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.txtpassword.Focus();
            }
            else
            {
                try
                {
                    if (this.txtusername.Text == "admin" && this.txtpassword.Text == "123")
                    {
                        new welcome_page();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error:" + ex.Message);
                }
            }
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtusername.Text))
            {
                MessageBox.Show("Enter Username.");
                txtusername.Focus();
            }
            else if (string.IsNullOrEmpty(txtpassword.Text))
            {
                MessageBox.Show("Enter Password.");
                txtpassword.Focus();
            }
            else
            {
                try
                {
                    string username = txtusername.Text;
                    string password = txtpassword.Text;
                    string connectionString = ConfigurationManager.ConnectionStrings["connectionstring"].ToString();
                    UserRepository repository = new UserRepository(connectionString);
                    User user = repository.Authenticate(username, password);

                    if (user != null)
                    {
                        this.Visible = false;
                        new admin_home_page().Show();
                    }
                    else
                    {
                        MessageBox.Show(Constants.InvalidCredeentials);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }

            }


            // this.authenticate();
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

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(welcome_page));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.login_panel = new System.Windows.Forms.GroupBox();
            this.linkpasswordforget = new System.Windows.Forms.LinkLabel();
            this.btnlogin = new System.Windows.Forms.Button();
            this.txtpassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtusername = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblmainheader = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.main_header = new System.Windows.Forms.PictureBox();
            this.lblDevelopedBy = new System.Windows.Forms.Label();
            this.lbl_Developer = new System.Windows.Forms.Label();
            this.lbl_developerDetail = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.login_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.main_header)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1008, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem,
            this.toolStripSeparator1});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.aboutToolStripMenuItem.Text = "About SMS ";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(175, 6);
            // 
            // login_panel
            // 
            this.login_panel.BackColor = System.Drawing.Color.Transparent;
            this.login_panel.Controls.Add(this.linkpasswordforget);
            this.login_panel.Controls.Add(this.btnlogin);
            this.login_panel.Controls.Add(this.txtpassword);
            this.login_panel.Controls.Add(this.label2);
            this.login_panel.Controls.Add(this.txtusername);
            this.login_panel.Controls.Add(this.label1);
            this.login_panel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.login_panel.Location = new System.Drawing.Point(577, 219);
            this.login_panel.Name = "login_panel";
            this.login_panel.Size = new System.Drawing.Size(419, 197);
            this.login_panel.TabIndex = 2;
            this.login_panel.TabStop = false;
            this.login_panel.Text = "Login Credentials";
            // 
            // linkpasswordforget
            // 
            this.linkpasswordforget.AutoSize = true;
            this.linkpasswordforget.Font = new System.Drawing.Font("Tahoma", 8.5F);
            this.linkpasswordforget.Location = new System.Drawing.Point(235, 166);
            this.linkpasswordforget.Name = "linkpasswordforget";
            this.linkpasswordforget.Size = new System.Drawing.Size(156, 14);
            this.linkpasswordforget.TabIndex = 4;
            this.linkpasswordforget.TabStop = true;
            this.linkpasswordforget.Text = "Can\'t access your account?";
            this.linkpasswordforget.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkpasswordforget_LinkClicked);
            // 
            // btnlogin
            // 
            this.btnlogin.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnlogin.Location = new System.Drawing.Point(151, 157);
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.Size = new System.Drawing.Size(84, 28);
            this.btnlogin.TabIndex = 3;
            this.btnlogin.Text = "Login";
            this.btnlogin.UseVisualStyleBackColor = true;
            this.btnlogin.Click += new System.EventHandler(this.btnlogin_Click);
            // 
            // txtpassword
            // 
            this.txtpassword.Location = new System.Drawing.Point(151, 106);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.Size = new System.Drawing.Size(240, 21);
            this.txtpassword.TabIndex = 2;
            this.txtpassword.Text = "123";
            this.txtpassword.UseSystemPasswordChar = true;
            this.txtpassword.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtpassword_KeyUp);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label2.Location = new System.Drawing.Point(34, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Password:";
            // 
            // txtusername
            // 
            this.txtusername.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtusername.Location = new System.Drawing.Point(151, 48);
            this.txtusername.Name = "txtusername";
            this.txtusername.Size = new System.Drawing.Size(240, 22);
            this.txtusername.TabIndex = 1;
            this.txtusername.Text = "admin";
            this.txtusername.TextChanged += new System.EventHandler(this.txtusername_TextChanged);
            this.txtusername.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtusername_KeyUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label1.Location = new System.Drawing.Point(34, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "User Name:";
            // 
            // lblmainheader
            // 
            this.lblmainheader.AutoSize = true;
            this.lblmainheader.BackColor = System.Drawing.Color.Transparent;
            this.lblmainheader.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmainheader.Location = new System.Drawing.Point(315, 180);
            this.lblmainheader.Name = "lblmainheader";
            this.lblmainheader.Size = new System.Drawing.Size(357, 31);
            this.lblmainheader.TabIndex = 38;
            this.lblmainheader.Text = "Login to Point of Sale System";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 226);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(544, 464);
            this.pictureBox1.TabIndex = 39;
            this.pictureBox1.TabStop = false;
            // 
            // main_header
            // 
            this.main_header.Image = global::DailyAccounts.Properties.Resources.pos_1024150;
            this.main_header.Location = new System.Drawing.Point(-3, 27);
            this.main_header.Name = "main_header";
            this.main_header.Size = new System.Drawing.Size(1024, 150);
            this.main_header.TabIndex = 0;
            this.main_header.TabStop = false;
            // 
            // lblDevelopedBy
            // 
            this.lblDevelopedBy.AutoSize = true;
            this.lblDevelopedBy.BackColor = System.Drawing.Color.Transparent;
            this.lblDevelopedBy.Font = new System.Drawing.Font("Trebuchet MS", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDevelopedBy.ForeColor = System.Drawing.Color.BlueViolet;
            this.lblDevelopedBy.Location = new System.Drawing.Point(613, 512);
            this.lblDevelopedBy.Name = "lblDevelopedBy";
            this.lblDevelopedBy.Size = new System.Drawing.Size(94, 18);
            this.lblDevelopedBy.TabIndex = 60;
            this.lblDevelopedBy.Text = "Developed By: ";
            // 
            // lbl_Developer
            // 
            this.lbl_Developer.AutoSize = true;
            this.lbl_Developer.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Developer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Developer.Location = new System.Drawing.Point(613, 535);
            this.lbl_Developer.Name = "lbl_Developer";
            this.lbl_Developer.Size = new System.Drawing.Size(85, 15);
            this.lbl_Developer.TabIndex = 61;
            this.lbl_Developer.Text = "Ayub Ahmad";
            // 
            // lbl_developerDetail
            // 
            this.lbl_developerDetail.AutoSize = true;
            this.lbl_developerDetail.BackColor = System.Drawing.Color.Transparent;
            this.lbl_developerDetail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lbl_developerDetail.Location = new System.Drawing.Point(613, 554);
            this.lbl_developerDetail.Name = "lbl_developerDetail";
            this.lbl_developerDetail.Size = new System.Drawing.Size(225, 75);
            this.lbl_developerDetail.TabIndex = 62;
            this.lbl_developerDetail.Text = "Roll No :    115-BSCS-18\r\nSemester : 4th\r\n\r\nDepartment Of Computer Science\r\nGover" +
    "nment College University, Lahore  \r\n";
            // 
            // welcome_page
            // 
            this.BackgroundImage = global::DailyAccounts.Properties.Resources.gradient8ayub;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1008, 691);
            this.Controls.Add(this.lbl_developerDetail);
            this.Controls.Add(this.lbl_Developer);
            this.Controls.Add(this.lblDevelopedBy);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblmainheader);
            this.Controls.Add(this.login_panel);
            this.Controls.Add(this.main_header);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.Name = "welcome_page";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Point of Sale System";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.welcome_page_FormClosing);
            this.Load += new System.EventHandler(this.welcome_page_Load);
            this.Shown += new System.EventHandler(this.welcome_page_Shown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.login_panel.ResumeLayout(false);
            this.login_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.main_header)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private bool is_closing_application()
        {
            if (!this.isHide)
            {
                if (MessageBox.Show("Are you sure to close the application?\n", "Closing Application Varification!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        //if (clsSMS_Interface.ModemPort.IsOpen)
                        //{
                        //    clsSMS_Interface.ModemPort.Close();
                        //}
                    }
                    catch (Exception exception)
                    {
                        MessageBox.Show(exception.Message);
                    }
                    return true;
                }
                return false;
            }
            return true;
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void linkMetalogics_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ProcessStartInfo startInfo = new ProcessStartInfo(e.Link.LinkData.ToString());
            Process.Start(startInfo);
        }

        private void linkpasswordforget_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Please contact the administrator for password re-newal!", "Forget Password", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void txtpassword_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
            }
        }

        private void txtusername_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
            }
        }

        private void txtusername_TextChanged(object sender, EventArgs e)
        {
        }

        private void viewHelpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start((Application.StartupPath + @"\Help\sms_help.html").Replace(@"\bin\Debug", string.Empty));
        }

        private void welcome_page_FormClosing(object sender, FormClosingEventArgs e)
        {
            //    if (!this.is_closing_application())
            //    {
            //        e.Cancel = true;
            //    }
            //    else
            //base.Close();
            Application.Exit();
        }

        private void welcome_page_Load(object sender, EventArgs e)
        {
            //this.link.Links.Remove(this.link.Links[0]);
            //this.link.Links.Add(0, this.link.Text.Length, "http://www.paksolutions.com.pk/");
            //this.lblImportant.Text = "This product is license under the single copy use to " + Common.StoreName.Replace("&", "&&") + "," + Common.StoreAddress + " This can only be used at one installation place. Voilation of license may cuase law suit against user.";
            //base.AcceptButton = this.btnlogin;
            try
            {
                //this.BackgroundImage = Common.Img_Frmbackground;

            }
            catch (Exception)
            {
            }
        }

        private void welcome_page_Shown(object sender, EventArgs e)
        {
        }
    }
}

