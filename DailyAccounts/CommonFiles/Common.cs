#define AbbasCommunication
//#define RafiqMedical
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32;

namespace DailyAccounts
{
    public class Common
    {
        public const string EditColumn = "Edit";
        public const string DeleteColumn = "Delete";
        public const string HeaderFont = "Bookman Old Style";
        public static float FontSize = 20;

        // public const bool  EnablePriniting = false;
        // public const string StoreName = "Abbas Communications";
        // public const string StoreAddress = "Near Habib Bank Usman Wala,";
        // public const string Contact = "0300 4114114";
        public static Image Img780x100 = Properties.Resources.pos_780100;
        public static Image Img1024x150 = Properties.Resources.pos_1024150;

        public static Image Img_Frmbackground = Properties.Resources.gradient8ayub;

        public static Image welcome_564x464 = Properties.Resources.Point_of_sale;
        public static Image home_600x450 = Properties.Resources.admin_page;
        public static Image Owner_48x60 = null;
        
        public static string developedBy = "Ayub Ahmad";
        public static string developerDetail = "Roll No :    115-BSCS-18\r\nSemester : 4th\r\n\r\nDepartment Of Computer Science\r\nGover" +
    "nment College University, Lahore  \r\n";


    }
}
