namespace DailyAccounts.GUI
{
    using System;
    using System.ComponentModel;
    using System.Drawing;
    using System.Runtime.CompilerServices;
    using System.Windows.Forms;

    public enum ItemTpe
    {
        ExpenseType, ExpenseItem
    }

    public class add_type : Form
    {
        private Button btncancel;
        private Button btnsubmit;
        private IContainer components;
        private GroupBox grbtype;
        private Label lblitemtype;
        private Label lblmainheader;
        private Label lbltitle;
        private Label lbltype;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private TextBox txtDuesType;

        public add_type()
        {
            this.components = null;
            this.InitializeComponent();
        }






        private void add_dues_type_Load(object sender, EventArgs e)
        {
            
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
           
        }

        private void btnsubmit_Click(object sender, EventArgs e)
        {
            
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing && (this.components != null))
            {
                this.components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(add_type));
            this.lblmainheader = new System.Windows.Forms.Label();
            this.grbtype = new System.Windows.Forms.GroupBox();
            this.lbltitle = new System.Windows.Forms.Label();
            this.lblitemtype = new System.Windows.Forms.Label();
            this.lbltype = new System.Windows.Forms.Label();
            this.txtDuesType = new System.Windows.Forms.TextBox();
            this.btnsubmit = new System.Windows.Forms.Button();
            this.btncancel = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.grbtype.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblmainheader
            // 
            this.lblmainheader.AutoSize = true;
            this.lblmainheader.BackColor = System.Drawing.Color.Transparent;
            this.lblmainheader.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmainheader.Location = new System.Drawing.Point(447, 129);
            this.lblmainheader.Name = "lblmainheader";
            this.lblmainheader.Size = new System.Drawing.Size(191, 31);
            this.lblmainheader.TabIndex = 4;
            this.lblmainheader.Text = "Add Dues Type";
            // 
            // grbtype
            // 
            this.grbtype.BackColor = System.Drawing.Color.Transparent;
            this.grbtype.Controls.Add(this.lbltitle);
            this.grbtype.Controls.Add(this.lblitemtype);
            this.grbtype.Controls.Add(this.lbltype);
            this.grbtype.Controls.Add(this.txtDuesType);
            this.grbtype.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbtype.Location = new System.Drawing.Point(392, 190);
            this.grbtype.Name = "grbtype";
            this.grbtype.Size = new System.Drawing.Size(344, 143);
            this.grbtype.TabIndex = 6;
            this.grbtype.TabStop = false;
            this.grbtype.Text = "Type Information";
            // 
            // lbltitle
            // 
            this.lbltitle.AutoSize = true;
            this.lbltitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitle.Location = new System.Drawing.Point(6, 35);
            this.lbltitle.Name = "lbltitle";
            this.lbltitle.Size = new System.Drawing.Size(36, 15);
            this.lbltitle.TabIndex = 52;
            this.lbltitle.Text = "Type:";
            this.lbltitle.Visible = false;
            // 
            // lblitemtype
            // 
            this.lblitemtype.AutoSize = true;
            this.lblitemtype.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblitemtype.Location = new System.Drawing.Point(108, 35);
            this.lblitemtype.Name = "lblitemtype";
            this.lblitemtype.Size = new System.Drawing.Size(68, 15);
            this.lblitemtype.TabIndex = 51;
            this.lblitemtype.Text = "Dues Type:";
            this.lblitemtype.Visible = false;
            // 
            // lbltype
            // 
            this.lbltype.AutoSize = true;
            this.lbltype.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltype.Location = new System.Drawing.Point(6, 81);
            this.lbltype.Name = "lbltype";
            this.lbltype.Size = new System.Drawing.Size(61, 15);
            this.lbltype.TabIndex = 50;
            this.lbltype.Text = "Sub Type:";
            // 
            // txtDuesType
            // 
            this.txtDuesType.Location = new System.Drawing.Point(111, 77);
            this.txtDuesType.Name = "txtDuesType";
            this.txtDuesType.Size = new System.Drawing.Size(208, 21);
            this.txtDuesType.TabIndex = 0;
            this.txtDuesType.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnsubmit
            // 
            this.btnsubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnsubmit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnsubmit.Location = new System.Drawing.Point(644, 359);
            this.btnsubmit.Name = "btnsubmit";
            this.btnsubmit.Size = new System.Drawing.Size(92, 28);
            this.btnsubmit.TabIndex = 51;
            this.btnsubmit.Text = "   Submit";
            this.btnsubmit.UseVisualStyleBackColor = true;
            this.btnsubmit.Click += new System.EventHandler(this.btnsubmit_Click);
            // 
            // btncancel
            // 
            this.btncancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btncancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btncancel.Location = new System.Drawing.Point(539, 359);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(87, 28);
            this.btncancel.TabIndex = 52;
            this.btncancel.Text = "  Close";
            this.btncancel.UseVisualStyleBackColor = true;
            this.btncancel.Click += new System.EventHandler(this.btncancel_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Location = new System.Drawing.Point(12, 129);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(357, 272);
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DailyAccounts.Properties.Resources.pos_780100;
            this.pictureBox1.Location = new System.Drawing.Point(-1, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(780, 100);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // add_type
            // 
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(764, 425);
            this.Controls.Add(this.btncancel);
            this.Controls.Add(this.btnsubmit);
            this.Controls.Add(this.grbtype);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.lblmainheader);
            this.Controls.Add(this.pictureBox1);
            this.DoubleBuffered = true;
            this.Name = "add_type";
            this.Text = "Add Dues Type";
            this.Load += new System.EventHandler(this.add_dues_type_Load);
            this.grbtype.ResumeLayout(false);
            this.grbtype.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (!ValidationChecks.AlphaStringIsValid(this.txtDuesType.Text))
            {
                MessageBox.Show("Only characters are allowed.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.txtDuesType.Text = this.txtDuesType.Text.Substring(0, this.txtDuesType.Text.Length - 1);
                this.txtDuesType.Select(this.txtDuesType.Text.Length, 0);
            }
        }


    }
}

