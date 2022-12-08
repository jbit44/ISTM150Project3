using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GroupProject1

{

    public static class Validator
    {

        /// <summary>
        /// Checks that phone #/zip code is all numbers and the correct length of digits
        /// </summary>
        /// <param name="strPhoneOrZip"></param>
        /// <param name="strDescription"></param>
        /// <param name="intNumberOfDigits"></param>
        /// <returns></returns>
        public static bool ValidPhoneAndZipCode(string strPhoneOrZip, string strDescription, int intNumberOfDigits)
        {
            // Step #1: Check that phone number or zip code contains only numbers
            bool blnIsNumber = Regex.IsMatch(strPhoneOrZip, "[0-9]");
            if (!blnIsNumber)
            {
                MessageBox.Show("Your " + strDescription + " should only contain numbers", "Entry Error: " + strDescription);
                return false;
            }

            // Step #2: Check that phone number or zip code is the correct # of digits
            if (strPhoneOrZip.Length != intNumberOfDigits)
            {
                MessageBox.Show("Please ensure that your " + strDescription + " is " + intNumberOfDigits + " digits ", "Entry Error: " + strDescription);
                return false;
            }

            // Step #3: Phone number or zip code has been validated: return true
            return true;
        }

        public static bool VendorPhoneAndZipCode(string strPhoneOrZip, string strDescription)
        {
            // Step #1: Check that phone number or zip code contains only numbers
            
            bool blnIsNumber = Regex.IsMatch(strPhoneOrZip, @"^[a-zA-Z0-9\s]+$");
            if (!blnIsNumber)
            {
                MessageBox.Show("Your " + strDescription + " should only contain numbers and/or letters", "Entry Error: " + strDescription);
                return false;
            }

            // Step #3: Phone number or zip code has been validated: return true
            return true;
        }

        public static bool PhoneIsNumber(string strNumber, string strDescription)
        {
            strNumber = strNumber.Replace("(", "");
            strNumber = strNumber.Replace(")", "");
            strNumber = strNumber.Replace("-", "");
            bool blnIsNumber = Regex.IsMatch(strNumber, "^[0-9]*$");
            if (!blnIsNumber)
            {
                MessageBox.Show("The " + strDescription + " should only contain numbers", "Entry Error: " + strDescription);
                return false;
            }
            return true;
        }

        public static bool IsNumber(string strNumber, string strDescription)
        {
            bool blnIsNumber = Regex.IsMatch(strNumber, "^[0-9]*$");
            if (!blnIsNumber)
            {
                MessageBox.Show("The " + strDescription + " should only contain numbers", "Entry Error: " + strDescription);
                return false;
            }
            return true;
        }



        /// <summary>
        /// Checks that phone # is valid with the only numbers and correct length of digits
        /// </summary>
        /// <param name="strTestValue"></param>
        /// <returns></returns>
        public static string IsPhone(string strTestValue)
        {
            strTestValue = strTestValue.Replace("(", "");
            strTestValue = strTestValue.Replace(")", "");
            strTestValue = strTestValue.Replace("-", "");
            return null;
        }
       
       
        /// <summary>
        /// Checks that every textbox has an input
        /// </summary>
        /// <param name="strTestValue"></param>
        ///<param name="strControlName"></param>
        /// <returns></returns>
        public static bool IsPresent(string strUserInput, string strDescription)
        {
            // If the user put anything in the textbox, data is present: return true
            if (strUserInput != "")
                return true;

            // If the user didn't put anything in the textbox, data is not present: show error message & return false
            else
            {
                MessageBox.Show("Please enter " + strDescription, "Missing Field: " + strDescription); // Use tag to identify
                return false;
            }
        }
    }
}
