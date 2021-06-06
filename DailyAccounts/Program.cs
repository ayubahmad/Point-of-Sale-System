using DailyAccounts.GUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DailyAccounts
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            try
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new Splash());
            }
            catch (Exception ex)
            {
                MessageBox.Show("An Error Occured:" + Environment.NewLine + "Detail: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
        }
    }
}
