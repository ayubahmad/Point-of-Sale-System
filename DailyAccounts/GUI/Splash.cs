using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DailyAccounts.GUI
{
    public partial class Splash : Form
    {
        Timer tmr;
        public Splash()
        {
            InitializeComponent();
        }

        private void Splash_Load(object sender, EventArgs e)
        {
            tmr = new Timer();

            //set time interval 3 sec

            tmr.Interval = 3000;

            //starts the timer


            tmr.Tick += tmr_Tick;
            tmr.Start();
        }

        void tmr_Tick(object sender, EventArgs e)

        {

            //after 3 sec stop the timer

            tmr.Stop();

            //display mainform

            welcome_page mf = new welcome_page();

            mf.Show();

            //hide this form

            this.Hide();

        }

        //void RestoreDB(string user,string pwd)
        //{
        //    ProcessStartInfo startInfo = new ProcessStartInfo("cmd.exe");
        //    startInfo.WindowStyle = ProcessWindowStyle.Hidden;
        //    Process.Start(startInfo);
        //    startInfo.Arguments = "mysqldump -u root -p rootpassword test > c:\backupfile.sql";
        //    Process p = Process.Start(startInfo);
        //}
    }
}
