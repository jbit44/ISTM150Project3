using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
/*
Our Group (ALL OF US) completed our student evaluations!
AUTHORS: Nicole Mulkern, Josh Bittlestone, Callie Guest, Jessica Liu, Grant Taylor
COURSE: ISTM 250
FORM: FRMVendor.cs
PURPOSE: This form enables the user to view vendor payment history in addition to accessing and
updating data regarding vendors.
INPUT: Data is inputted and displayed on the form through the separate Vendors.xml database
PROCESS: The user is able to click through the different vendors and change the data in the textboxes, 
which updates the information in the stored database.
OUTPUT: Individual vendor information is displayed in the textboxes.
HONOR CODE: “On my honor, as an Aggie, I have neither given nor
received unauthorized aid on this academic work.”
Our Group (ALL OF US) completed our student evaluations!
*/
namespace GroupProject1
{
    public partial class FRMVendor : Form
    {
        public FRMVendor()
        {
            InitializeComponent();
        }
        //initialize list to store database data
        private List<Vendor> lstVendors = null;
        //initialize global variable that will be used to navigate through the list
        int intCurrentIndex = 0;




        private void FRMVendor_Load(object sender, EventArgs e) //when the form loads, the first vendor populates the textboxes
        {
            
            lstVendors = VendorDB.GetVendors(); //takes all the data and bring it to the code in the "middle"
            FillVendorInformation();

            
        }
        public void FillVendorInformation()
        {
            //clear all textboxes (cannot clear entire groupbox at once?)
            TXTVendorName.Clear();
            TXTAddress.Clear();
            TXTCity.Clear();
            TXTState.Clear();
            TXTZipcode.Clear();
            TXTPhoneNumber.Clear();
            TXTSalesYearToDate.Clear();
            TXTSalesRepName.Clear();
            TXTComments.Clear();
            CBODefaultDiscount.Items.Clear();

            //fills all the textboxes with lstVendor[0]
            TXTVendorName.Text = lstVendors[intCurrentIndex].Name;
            TXTAddress.Text = lstVendors[intCurrentIndex].Address;
            TXTCity.Text = lstVendors[intCurrentIndex].City;
            TXTState.Text = lstVendors[intCurrentIndex].State;
            TXTZipcode.Text = lstVendors[intCurrentIndex].Zip;
            TXTPhoneNumber.Text = lstVendors[intCurrentIndex].Phone;
            TXTSalesYearToDate.Text = Convert.ToString(lstVendors[intCurrentIndex].YTD);
            TXTSalesRepName.Text = lstVendors[intCurrentIndex].Contact;
            TXTComments.Text = lstVendors[intCurrentIndex].Comment;
            CBODefaultDiscount.Items.Add("10 days");
            CBODefaultDiscount.Items.Add("15 days");
            CBODefaultDiscount.Items.Add("20 days");
            CBODefaultDiscount.SelectedIndex = CBODefaultDiscount.Items.IndexOf(lstVendors[intCurrentIndex].DefaultDiscount + " days");


        }

        private void BTNReadNextDataRecord_Click(object sender, EventArgs e)
        {
    
            if (TXTChanged(sender, e) == true) //we have unsaved data
            {
                //yes = save , no= don't save, cancel = get me out of here
                DialogResult button = MessageBox.Show("You have unsaved data. \n Do you want to save it before moving on?", "Unsaved Data",
                    MessageBoxButtons.YesNoCancel,
                    MessageBoxIcon.Warning);

                if (button == DialogResult.Yes) //the user wants to save
                {
                    if (isValidData())
                    {
                        SaveData();
                        NavigateNextRecord();
                    }

                }

                if (button == DialogResult.Cancel) //the user doesn't want to save OR not save
                {
                    //do nothing
                    
                }
                else if (button == DialogResult.No)
                {
                    NavigateNextRecord();
                }
                //if button == Dialog.No : close the form. so... no code, let the close continue
            }
            else //if there is no unsaved data navigate forward
            {
                NavigateNextRecord();
            }
                
            
        }

        private void BTNReadPreviousDataRecord_Click(object sender, EventArgs e)
        {
            if (TXTChanged(sender, e) == true) //we have unsaved data
            {
                //yes = save , no= don't save, cancel = get me out of here
                DialogResult button = MessageBox.Show("You have unsaved data. \n Do you want to save it before moving on?", "Unsaved Data",
                    MessageBoxButtons.YesNoCancel,
                    MessageBoxIcon.Warning);

                if (button == DialogResult.Yes) //the user wants to save
                {
                    if (isValidData())
                    {
                        SaveData();
                        NavigatePreviousRecord();
                    }

                }

                if (button == DialogResult.Cancel) //the user doesn't want to save OR not save
                {
                    //do nothing

                }
                else if (button == DialogResult.No)
                {
                    NavigatePreviousRecord();
                }
                //if button == Dialog.No : close the form. so... no code, let the close continue
            }
            else //if there is not unsaved data, navigate backwards
            {
                NavigatePreviousRecord();
            }

        }

        private void BTNClose_Click(object sender, EventArgs e) //this closes the vendor form
        {
            if (TXTChanged(sender, e) == true) //we have unsaved data
            {
                //yes = save , no= don't save, cancel = get me out of here
                DialogResult button = MessageBox.Show("You have unsaved data. \n Do you want to save it?", "Unsaved Data",
                    MessageBoxButtons.YesNoCancel,
                    MessageBoxIcon.Warning);

                if (button == DialogResult.Yes) //the user wants to save
                {
                    if (isValidData())
                    {
                        SaveData();
                        
                        Close();
                    }
                }

                if (button == DialogResult.Cancel) //the user doesn't want to save OR not save
                {
                    //do nothing

                }
                else if (button == DialogResult.No)
                {
                    Close();
                }
                //if button == Dialog.No : close the form. so... no code, let the close continue
            }
            else
            {
                Close();
            }
        }


        private void BTNSaveDataRecord_Click(object sender, EventArgs e)
        {
            //saves the data if valid
            SaveData();
            
        }

        private void SaveData()
        {
            //checks the data is valid
            if (isValidData())
            {
                lstVendors[intCurrentIndex].Name = TXTVendorName.Text; //updates the list's current index to values in the textbox
                lstVendors[intCurrentIndex].Address = TXTAddress.Text;
                lstVendors[intCurrentIndex].City = TXTCity.Text;
                lstVendors[intCurrentIndex].State = TXTState.Text;
                lstVendors[intCurrentIndex].Zip = TXTZipcode.Text;
                lstVendors[intCurrentIndex].Phone = TXTPhoneNumber.Text;
                lstVendors[intCurrentIndex].YTD = Convert.ToDecimal(TXTSalesYearToDate.Text);
                lstVendors[intCurrentIndex].Contact = TXTSalesRepName.Text;
                lstVendors[intCurrentIndex].Comment = TXTComments.Text;
                string strDefaultDiscount = Convert.ToString(CBODefaultDiscount.SelectedItem);
                strDefaultDiscount = strDefaultDiscount.Remove(3);
                lstVendors[intCurrentIndex].DefaultDiscount = Convert.ToInt32(strDefaultDiscount);
                VendorDB.SaveVendors(lstVendors);
                FillVendorInformation();
            }
        }

        private bool isValidData() //checks the data is valid
        {
            if (Validator.PhoneIsNumber(TXTPhoneNumber.Text, TXTPhoneNumber.Tag.ToString()) &&
                Validator.IsNumber(TXTSalesYearToDate.Text, TXTSalesYearToDate.Tag.ToString()) &&
                Validator.IsPresent(TXTVendorName.Text, TXTVendorName.Tag.ToString()) &&
                Validator.IsPresent(TXTAddress.Text, TXTAddress.Tag.ToString()) &&
                Validator.IsPresent(TXTCity.Text, TXTCity.Tag.ToString()) &&
                Validator.IsPresent(TXTState.Text, TXTState.Tag.ToString()) &&
                Validator.IsPresent(TXTZipcode.Text, TXTZipcode.Tag.ToString()) &&
                Validator.IsPresent(TXTPhoneNumber.Text, TXTPhoneNumber.Tag.ToString()) &&
                Validator.IsPresent(TXTSalesYearToDate.Text, TXTSalesYearToDate.Tag.ToString()) &&
                Validator.IsPresent(TXTSalesRepName.Text, TXTSalesRepName.Tag.ToString()) 
                )
            {
                // Check that the City is valid (contains only letters)
                string strCity = TXTCity.Text.Trim();
                bool blnIsLetter = Regex.IsMatch(strCity, "^[a-zA-Z ]+$");

                if (!blnIsLetter)
                {
                    MessageBox.Show("Please enter a valid city (letters only)", "Invalid City");
                    return false;
                }

                // Check that Phone Number is Valid (contains only numbers)
                string strPhoneNumber = TXTPhoneNumber.Text.Trim();
                strPhoneNumber = strPhoneNumber.Replace("(", "");
                strPhoneNumber = strPhoneNumber.Replace(")", "");
                strPhoneNumber = strPhoneNumber.Replace("-", "");

                if (!Validator.VendorPhoneAndZipCode(strPhoneNumber, TXTPhoneNumber.Tag.ToString()))
                    return false;

                // Check that the Zip Code is valid (contains only numbers and letters)
                string strZipCode = TXTZipcode.Text.Trim();
                if (!Validator.VendorPhoneAndZipCode(TXTZipcode.Text, TXTZipcode.Tag.ToString()))
                {
                    return false;
                }
                return true; //if data is valid, return true
            }

            
            else return false; //if data is not valid, return false

        }

/// <summary>
/// checks if the user has ACTUALLY changed the text, compares text and returns true if anything is changed
/// </summary>
/// <param name="sender"></param>
/// <param name="e"></param>
        private bool TXTChanged(object sender, EventArgs e)
        {
            //check through every textbox that the user COULD change

            //ensures if user changes something and then changes it back to what it previously was, 3 button message box won't show
            //if utilizing the TextChanged property, user can change data then change back to normal, it will trigger an event
            //create string to test that the combo box hasn't changed
            string strComboBoxTester = "";
            strComboBoxTester = lstVendors[intCurrentIndex].DefaultDiscount.ToString() + " days";
            //check vendor name
            if (TXTVendorName.Text != lstVendors[intCurrentIndex].Name)
            {
                return true;
            }
            //check vendor addresss
            else if (TXTAddress.Text != lstVendors[intCurrentIndex].Address)
            {
                return true;
            }
            //check vendor state
            else if (TXTState.Text != lstVendors[intCurrentIndex].State)
            {
                return true;
            }
            //check vendor city
            else if (TXTCity.Text != lstVendors[intCurrentIndex].City)
            {
                return true;
            }
            //check vendor zipcode
            else if(TXTZipcode.Text != lstVendors[intCurrentIndex].Zip)
            {
                return true;
            }
            //check vendor phone number
            else if (TXTPhoneNumber.Text != lstVendors[intCurrentIndex].Phone)
            {
                return true;
            }
            //check vendor sales YTD
            else if (Convert.ToDecimal(TXTSalesYearToDate.Text) != lstVendors[intCurrentIndex].YTD)
            {
                return true;
            }
            //check vendor rep name
            else if(TXTSalesRepName.Text != lstVendors[intCurrentIndex].Contact)
            {
                return true;
            }
            //check vendor comments
            else if(TXTComments.Text != lstVendors[intCurrentIndex].Comment)
            {
                return true;
            }
            //check vendor default discount
            else if(CBODefaultDiscount.Text != strComboBoxTester)
            {

                return true;
            }
            //return false if they're all the same
            else
            {
                return false;
            }
            
        }

        private void NavigateNextRecord()
        {
            if (intCurrentIndex == lstVendors.Count - 1)
            {
                intCurrentIndex = -1;

            }
            //when the user clicks "read next data record", the index changes to 'current index + 1'
            TXTVendorName.Text = lstVendors[intCurrentIndex + 1].Name;
            TXTAddress.Text = lstVendors[intCurrentIndex + 1].Address;
            TXTCity.Text = lstVendors[intCurrentIndex + 1].City;
            TXTState.Text = lstVendors[intCurrentIndex + 1].State;
            TXTZipcode.Text = lstVendors[intCurrentIndex + 1].Zip;
            TXTPhoneNumber.Text = lstVendors[intCurrentIndex + 1].Phone;
            TXTSalesYearToDate.Text = Convert.ToString(lstVendors[intCurrentIndex + 1].YTD);
            TXTSalesRepName.Text = lstVendors[intCurrentIndex + 1].Contact;
            TXTComments.Text = lstVendors[intCurrentIndex + 1].Comment;
            CBODefaultDiscount.SelectedIndex = CBODefaultDiscount.Items.IndexOf(lstVendors[intCurrentIndex + 1].DefaultDiscount + " days");
            intCurrentIndex++;
        }

        private void NavigatePreviousRecord()
        {
            if (intCurrentIndex == 0 || intCurrentIndex == -1) //if index value of the data is 0
            {
                intCurrentIndex = lstVendors.Count; //make the index value equal to the number of venders

            }
            //when the user clicks "read previous data record", the index changes to 'current index - '
            TXTVendorName.Text = lstVendors[intCurrentIndex - 1].Name;
            TXTAddress.Text = lstVendors[intCurrentIndex - 1].Address;
            TXTCity.Text = lstVendors[intCurrentIndex - 1].City;
            TXTState.Text = lstVendors[intCurrentIndex - 1].State;
            TXTZipcode.Text = lstVendors[intCurrentIndex - 1].Zip;
            TXTPhoneNumber.Text = lstVendors[intCurrentIndex - 1].Phone;
            TXTSalesYearToDate.Text = Convert.ToString(lstVendors[intCurrentIndex - 1].YTD);
            TXTSalesRepName.Text = lstVendors[intCurrentIndex - 1].Contact;
            TXTComments.Text = lstVendors[intCurrentIndex - 1].Comment;
            CBODefaultDiscount.SelectedIndex = CBODefaultDiscount.Items.IndexOf(lstVendors[intCurrentIndex - 1].DefaultDiscount + " days");
            intCurrentIndex--;
        }

    }
}
