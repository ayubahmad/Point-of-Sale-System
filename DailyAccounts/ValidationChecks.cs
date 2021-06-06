using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyAccounts
{
    using System;
    using System.Text.RegularExpressions;

    internal class ValidationChecks
    {
        public static bool AlphaNumericStringIsValid(string value)
        {
            if (value == string.Empty)
            {
                return true;
            }
            char[] chArray = value.ToCharArray();
            bool flag = true;
            for (int i = 0; i < chArray.Length; i++)
            {
                if (!((char.IsLetter(chArray[i]) || char.IsNumber(chArray[i])) || char.IsWhiteSpace(chArray[i])))
                {
                    flag = false;
                }
            }
            return flag;
        }

        public static bool AlphaStringIsValid(string value)
        {
            if (value == string.Empty)
            {
                return true;
            }
            char[] chArray = value.ToCharArray();
            bool flag = true;
            for (int i = 0; i < chArray.Length; i++)
            {
                if (!char.IsLetter(chArray[i]) && !char.IsWhiteSpace(chArray[i]))
                {
                    flag = false;
                }
            }
            return flag;
        }

        public static bool checkDoubleNumber(string value)
        {
            bool flag = false;
            double result = 0.0;
            try
            {
                if (!double.TryParse(value, out result))
                {
                    return flag;
                }
                if ((Convert.ToDouble(value) >= 0.0) || (value == ""))
                {
                    flag = true;
                }
            }
            catch (Exception)
            {
                flag = false;
            }
            return flag;
        }

        public static bool checkNumeric(string value)
        {
            bool flag = true;
            try
            {
                if (value == string.Empty)
                {
                    return true;
                }
                char[] chArray = value.ToCharArray();
                for (int i = 0; i < chArray.Length; i++)
                {
                    if ((chArray[i] != '-') && !char.IsNumber(chArray[i]))
                    {
                        flag = false;
                    }
                }
            }
            catch (Exception)
            {
            }
            return flag;
        }

        public static bool CNICIsValid(string value)
        {

            return ((value == string.Empty) || Regex.IsMatch(value, @"\d{5}[-|]\d{7}[-|]\d"));
        }

        public static bool isFloatingNumber(string value)
        {
            bool flag = false;
            if (value == string.Empty)
            {
                return true;
            }
            char[] chArray = value.ToCharArray();
            for (int i = 0; i < chArray.Length; i++)
            {
                if (!(!chArray[i].Equals('.') || flag))
                {
                    flag = true;
                }
                else if (!((char.IsDigit(chArray[i]) || !flag) && char.IsDigit(chArray[i])))
                {
                    return false;
                }
            }
            return true;
        }

        public static bool RangeValidationIsValid(string value)
        {
            int num = 0;
            try
            {
                num = Convert.ToInt32(value);
            }
            catch
            {
            }
            bool flag = true;
            if ((num < 100) && (num > 50))
            {
                flag = false;
            }
            return flag;
        }

        public static bool RegExStringIsValid(string textToValidate)
        {
            string pattern = @"[2-9]\d{2}-\d{3}-\d{4}";
            string input = textToValidate;
            Regex regex = new Regex(pattern);
            return regex.IsMatch(input);
        }

        public static bool SpecialCharsIsValid(string value)
        {
            if (value == string.Empty)
            {
                return false;
            }
            char[] chArray = value.ToCharArray();
            bool flag = false;
            for (int i = 0; i < chArray.Length; i++)
            {
                if (!char.IsSymbol(chArray[i]))
                {
                    flag = true;
                }
                if (char.IsLetterOrDigit(chArray[i]))
                {
                    flag = false;
                }
            }
            return flag;
        }

        public static bool validateEmail(string email)
        {
            string pattern = "^(([\\w-]+\\.)+[\\w-]+|([a-zA-Z]{1}|[\\w-]{2,}))@((([0-1]?[0-9]{1,2}|25[0-5]|2[0-4][0-9])\\.([0-1]?\r\n\t\t\t\t                                    [0-9]{1,2}|25[0-5]|2[0-4][0-9])\\.([0-1]?[0-9]{1,2}|25[0-5]|2[0-4][0-9])\\.([0-1]?\r\n\t\t\t\t                                    [0-9]{1,2}|25[0-5]|2[0-4][0-9])){1}|([a-zA-Z]+[\\w-]+\\.)+[a-zA-Z]{2,4})$";
            Regex regex = new Regex(pattern);
            return regex.IsMatch(email);
        }
    }
}
