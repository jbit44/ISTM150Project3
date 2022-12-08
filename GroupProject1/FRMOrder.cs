using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Drawing.Text;
using static System.Net.Mime.MediaTypeNames;
using System.Runtime.CompilerServices;

/*
Our Group (ALL OF US) completed our student evaluations!
AUTHORS: Nicole Mulkern, Josh Bittlestone, Callie Guest, Jessica Liu, Grant Taylor
COURSE: ISTM 250
FORM: FRMOrder.cs
PURPOSE: This form takes orders from users for a sandwhich and pizza shop.
INPUT: The user inputs at least 1 order item to buy, basic customer information, and,
    if they want delivery, information about their delivery address.
PROCESS: Information for each order item is validated and the total is outputted to the textbox
    while the information for that individual order item are outputted to the listbox. Data in
    the customer information group box is validated and so is the information in the delivery
    group box (if the user selects the delivery checkbox).
OUTPUT: The final order is outputted in the listbox. When the user has entered in all required
    fields sufficiently, the process order button will output their total to the screen in a 
    messagebox and clear the form.
HONOR CODE: “On my honor, as an Aggie, I have neither given nor
received unauthorized aid on this academic work.”
*/

namespace GroupProject1
{
    public partial class FRMOrder : Form
    {
        public FRMOrder()
        {
            InitializeComponent();
        }

        #region Class Level Variable Declaration
        // Creating an food type array to fill the combo box and a food prices array that corresponds to the food type array
        string[] strFoodTypes = { "Ham & Swiss Sandwich", "Turkey & Provolone Sandwich", "BLT Sandwich", "Med. Cheese Pizza", "Med. Pepperoni Pizza", "Med. Supreme Pizza" };
        decimal[] decFoodPrices = { 5m, 5m, 5m, 9.5m, 9.5m, 9.5m };

        // Creating two arrays for bread options and crust options to fill the second combo box depending on what food type is selected by the user
        string[] strBreadTypes = { "White", "Pumpernickel", "Rye", "Sourdough", "Multigrain" };
        string[] strCrustTypes = { "Original", "Pan", "Thin", "Wheat" };

        // Creating a math related decimals used in price calculation
        decimal decTaxRate = 0.0825m;
        decimal decTotal = 0m;
        decimal decSubtotal = 0;

        // Creating a list of all 50 U.S. states to fill the states combo box and a list of all valid (non-PO box) Bryan/College Station zip codes to simplify data validation
        string[] strStates = {"Alabama", "Alaska", "Arizona", "Arkansas", "California", "Colorado", "Connecticut", "Delaware", "Florida", "Georgia",
                              "Hawaii", "Idaho", "Illinois", "Indiana", "Iowa", "Kansas", "Kentucky", "Louisiana", "Maine", "Maryland", "Massachusetts",
                              "Michigan", "Minnesota", "Mississippi", "Missouri", "Montana", "Nebraska", "Nevada", "New Hampshire", "New Jersey", "New Mexico",
                              "New York", "North Carolina", "North Dakota", "Ohio", "Oklahoma", "Oregon", "Pennsylvania", "Rhode Island", "South Carolina",
                              "South Dakota", "Tennessee", "Texas", "Utah", "Vermont", "Virginia", "Washington", "West Virginia", "Wisconsin", "Wyoming"};
        int[] intBryanCollegeStationZipCodes = { 77801, 77802, 77803, 77807, 77808, 77840, 77843, 77845 };

        // Names of each inventory item
        string[] strIngredientNames = { "Flour", "Yeast", "Sugar", "Oil", "Ham",
                                        "Turkey", "SCheese", "Lettuce", "Tomato",
                                        "Bacon", "Pickles", "Mayo", "Mustard",
                                        "Pepperoni", "Sauce", "GCheese", "Salt", "Pepper" };

        // Current inventory levels 
        decimal[] decIngredientLevels = { 200m, 50m, 30m, 25m, 10m, 10m, 20m, 14m, 14m,
                                          10m, 20m, 15m, 12m, 20m, 60m, 25m, 10m, 10m};

        // Number of ingredients used per order of each type of sandwhich/pizza
        decimal[,] decIngredientsUsed = { { 1m, 1m, 1m, 3m, 3m, 3m},
                                          { 0.5m, 0.5m, 0.5m, 2m, 2m, 2m},
                                          { 0.03m, 0.03m, 0.03m, 0.5m, 0.5m, 0.5m},
                                          { 0.05m, 0.05m, 0.05m, 0.1m, 0.1m, 0.1m},
                                          { 0.1m, 0m, 0m, 0m, 0m, 0.1m},
                                          { 0m, 0.1m, 0m, 0m, 0m, 0.1m},
                                          { 0.1m, 0.1m, 0m, 0m, 0m, 0m},
                                          { 0.25m, 0.25m, 0.3m, 0m, 0m, 0m},
                                          { 0.25m, 0.25m, 0.3m, 0m, 0m, 0.3m },
                                          { 0m, 0m, 0.1m, 0m, 0m, 0.1m},
                                          { 0.02m, 0.02m, 0m, 0m, 0m, 0m},
                                          { 0.02m, 0.02m, 0.02m, 0m, 0m, 0m},
                                          { 0.02m, 0.02m, 0.02m, 0m, 0m, 0m},
                                          { 0m, 0m, 0m, 0m, 0.3m, 0.3m},
                                          { 0m, 0m, 0m, 1m, 1m, 1m},
                                          { 0m, 0m, 0m, 0.3m, 0.2m, 0.2m},
                                          { 0.01m, 0.01m, 0.01m, 0.02m, 0.02m, 0.02m},
                                          { 0.01m, 0.01m, 0.01m, 0.02m, 0.02m, 0.02m}};

        // 
        List<int> LSTOrderIndexVale = new List<int>();
        List<int> LSTOrderQuantity = new List<int>();
        #endregion

        /// <summary>
        /// Food type combo box is populated and controls are set to default values
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FRMOrder_Load(object sender, EventArgs e)
        {
            // Filling the Food Type Combo Box with the Food Types array 
            CBOFoodType.Items.Clear();
            foreach (string strFoodTypes in strFoodTypes)
            {
                CBOFoodType.Items.Add(strFoodTypes);
            }

            // Filling the Billing State Combo Box with the States array
            CBOBililngState.Items.Clear();
            foreach (string strStates in strStates)
            {
                CBOBililngState.Items.Add(strStates);
            }
            // Autofilling Texas as the State (per directions in Project #2)
            CBOBililngState.SelectedIndex = 42;

            // Filling the Delivery State Combo Box with the States array
            CBODeliveryState.Items.Clear();
            foreach (string strStates in strStates)
            {
                CBODeliveryState.Items.Add(strStates);
            }

            // Setting picture, delivery group box, and delivery checkbox to default settings
            GBXDeliveryInformation.Enabled = false;
            CHKDelivery.Checked = false;
            CBOFoodType.SelectedIndex = 0;
            CBOBreadOrCrustType.SelectedIndex = 0;
        }

        /// <summary>
        /// The image box & bread/crust type combo box is populated based on the index of the food type combo box
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CBOFoodType_SelectedIndexChanged(object sender, EventArgs e)
        {
            CBOBreadOrCrustType.Items.Clear();
            // Filling the Bread/Crust Combobox with bread types if a sandwhich is selected
            if (CBOFoodType.SelectedIndex <= 2)
            {
                foreach (string strBreadTypes in strBreadTypes)
                {
                    CBOBreadOrCrustType.Items.Add(strBreadTypes);
                }
                PBXFoodOrder.Image = (GroupProject1.Properties.Resources.Sandwhich);
            }

            // Filling the Bread/Crust Combobox with crust types if a pizza is selected
            else
            {
                foreach (string strCrustTypes in strCrustTypes)
                {
                    CBOBreadOrCrustType.Items.Add(strCrustTypes);
                }
                PBXFoodOrder.Image = (GroupProject1.Properties.Resources.Pizza);
            }

            // Recalculating subtotal
            CalculateSubtotal(sender, e);

            // Defaulting to the first Bread/Crust option and putting focus on the Bread/Crust Combobox
            CBOBreadOrCrustType.SelectedIndex = 1;
            CBOBreadOrCrustType.Focus();
        }
        /// <summary>
        /// Creates an error message that tells the user why their quantity entered is incorrect
        /// & returns a string = "" if their quantity is valid
        /// </summary>
        /// <param name="strQuantityErrors"></param>
        /// <returns></returns>
        public string ValidQuantity(string strQuantityErrors)
        {
            string strErrorMessage = "";

            // Step #1: Check that quantity is a number 
            bool blnIsNumber = Regex.IsMatch(strQuantityErrors, "^[0-9]*$");
            if (!blnIsNumber || TXTQuantity.Text == "0")
            {
                strErrorMessage += "Please only enter numeric digits greater than zero";
                //TXTQuantity.Text = "";
                return strErrorMessage;
            }

            // Step #2: Check that quantity is a whole number
            char chrDecimal = '.';
            if (TXTQuantity.Text.Contains(chrDecimal))
            {
                strErrorMessage += "Please enter a whole number (no decimals)";
                TXTQuantity.Text = "";
                return strErrorMessage;
            }


            // Returning an empty error message if there were no errors
            return strErrorMessage;
        }

        /// <summary>
        /// Calculates the subtotal if all 3 components are present & quantity is valid
        /// If all 3 components are not present, the subtotal is not calculated
        /// If all 3 components are presernt, but the quantity is invalid, an error box appears
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CalculateSubtotal(object sender, EventArgs e)
        {
            // Step #1: Check if all 3 components are present
            string strOrderItemsNotPresent = "";
            if (OrderItemComponentsPresent(strOrderItemsNotPresent) == "")
            {
                // Step #2: Check if the quantity entered is valid
                string strQuantityErrors = TXTQuantity.Text;
                if (ValidQuantity(strQuantityErrors) == "")
                {
                    // Step #3: Calculatie the subtotal & display it
                    decimal decQuantity = Convert.ToDecimal(TXTQuantity.Text);
                    decimal decPriceWithoutTax = decFoodPrices[CBOFoodType.SelectedIndex];
                    decSubtotal = decQuantity * decPriceWithoutTax;

                    TXTSubtotal.Text = decSubtotal.ToString("c");
                }
                // If Step #2 Fails: An invalid quantity is entered, show error box
                else
                {
                    TXTSubtotal.Text = "";
                    MessageBox.Show(ValidQuantity(strQuantityErrors), "Quantity Error(s)");
                    TXTQuantity.Text = "";
                }
            }
            // If Step #1 Fails: not all components have been entered, don't calculate subtotal yet
        }

        #region Data validation for Add Item to Order Button Click
        /// <summary>
        /// If all 3 components of the order are present & quantity is valid, the listbox and total are updated & order components are cleared
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BTNAddItemToOrder_Click(object sender, EventArgs e)
        {
            string strOrderItemsNotPresent = "";
            string strQuantityErrors = "";

            // Step #1: Check that all order components are present
            if (OrderItemComponentsPresent(strOrderItemsNotPresent) != "")
            {
                MessageBox.Show(OrderItemComponentsPresent(strOrderItemsNotPresent), "Missing Field(s)");
            }

            // Step #2: Check that the quantity is valid (is a number, is an integer, is not 0)
            else if (ValidQuantity(strQuantityErrors) != "")
            {
                MessageBox.Show(ValidQuantity(strQuantityErrors), "Quantity Entry Error");
                TXTQuantity.Text = "";
            }

            // Step #3: Calculate totals, update price, and output order item to the listbox 
            else
            {
                // Calculating the price of this order item + tax
                decimal decOrderTotal = decSubtotal + (decSubtotal * decTaxRate);

                // Calculating the total price of all order items (includes tax)
                decTotal += decOrderTotal;

                // Outputting Total to the Total textbox and all order item information to the list box
                TXTTotal.Text = decTotal.ToString("c");
                LBXOrders.Items.Add(CBOBreadOrCrustType.Text + " " + CBOFoodType.Text + ", " + TXTQuantity.Text + "@" + TXTSubtotal.Text + ", total: " + decOrderTotal.ToString("c"));

                // 
                LSTOrderIndexVale.Add(CBOFoodType.SelectedIndex);
                LSTOrderQuantity.Add(Convert.ToInt32(TXTQuantity.Text));

                // Clearing the 3 inputs/components for a new order item and refocusing on the first component
                ClearOrderComponents();
                CBOFoodType.Focus();
            }
        }

        /// <summary>
        /// Creates an error message that tells the user which order item components are missing
        /// & returns a string = "" if no components are missing
        /// </summary>
        /// <param name="strErrorMessage"></param>
        /// <returns></returns>
        private string OrderItemComponentsPresent(string strOrderItemsNotPresent)
        {
            // Checking that a food type has been selected
            if (CBOFoodType.SelectedIndex == -1)
            {
                strOrderItemsNotPresent += "Please select a food type\n";
            }

            // Checking that a bread or crust type has been selected
            if (CBOBreadOrCrustType.SelectedIndex == -1)
            {
                strOrderItemsNotPresent += "Please select a bread/crust type\n";
            }

            // Checking that a quantity has been entered
            if (TXTQuantity.Text == "")
            {
                strOrderItemsNotPresent += "Please enter a quantity\n";
            }

            // Returning an error message with a seperate line for each of the components that are not present
            return strOrderItemsNotPresent;

        }

    

        /// <summary>
        /// Autofills the delivery information checkbox if checked and undoes it if unchecked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CHKDelivery_CheckedChanged(object sender, EventArgs e)
        {
            // If the user wants delivery...
            if (CHKDelivery.Checked)
            {
                // Enabling the Delivery Groupbox
                GBXDeliveryInformation.Enabled = true;

                // Copying Customer Info over to Delivery Info
                TXTDeliveryName.Text = TXTBillingName.Text;
                TXTDeliveryPhoneNumber.Text = TXTBillingPhoneNumber.Text;
                TXTDeliveryStreetAddress.Text = TXTBillingStreetAddress.Text;
                TXTDeliveryCity.Text = TXTBillingCity.Text;
                CBODeliveryState.SelectedIndex = CBOBililngState.SelectedIndex;
                TXTDeliveryZipCode.Text = TXTBillingZipCode.Text;
                TXTDeliverySubdivision.Text = TXTBillingSubdivision.Text;

                // Focusing on top component in case they need to change delivery information
                TXTDeliveryName.Focus();
            }

            // If the user wants carry out...
            else
            {
                // Disabling the Delivery Groupbox
                GBXDeliveryInformation.Enabled = false;

                // Clearing all text in the Delivery Info textboxes & combobox
                TXTDeliveryName.Text = "";
                TXTDeliveryPhoneNumber.Text = "";
                TXTDeliveryStreetAddress.Text = "";
                TXTDeliveryCity.Text = "";
                CBODeliveryState.SelectedIndex = -1;
                TXTDeliveryZipCode.Text = "";
                TXTDeliverySubdivision.Text = "";
            }
        }

        #region Methods for Clearing the Form
        /// <summary>
        /// Clears listboxes, total, customer information groupbox, delivery group box, and order item area
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BTNClearForm_Click(object sender, EventArgs e)
        {
            // Clear order area of the form
            ClearOrderComponents();

            // Clear listbox and total
            LBXOrders.Items.Clear();
            TXTTotal.Text = "";
            decTotal = 0;

            LSTOrderIndexVale.Clear();
            LSTOrderQuantity.Clear();

            //// Clear customer information group box
            //TXTBillingName.Text = "";
            //TXTBillingPhoneNumber.Text = "";
            //TXTBillingStreetAddress.Text = "";
            //TXTBillingCity.Text = "";
            //CBOBililngState.SelectedIndex = -1;
            //TXTBillingZipCode.Text = "";
            //TXTBillingSubdivision.Text = "";

            // Clear and disable delivery group box
            CHKDelivery.Checked = false;

            // Changing focus back to the starting tab index
            CBOFoodType.Focus();
        }

        /// <summary>
        /// Clears the components of the new order item area of the form
        /// </summary>
        private void ClearOrderComponents()
        {
            // Reseting both comboboxes so the first option is selected
            CBOFoodType.SelectedIndex = 0;
            CBOBreadOrCrustType.SelectedIndex = 0;

            // Clearing the quantity and subtotal textboxes
            TXTQuantity.Text = "";
            TXTSubtotal.Text = "";

            // Resetting the picture box
            PBXFoodOrder.Image = (GroupProject1.Properties.Resources.Sandwhich);
        }
        #endregion

        /// <summary>
        /// Outputs total and clears form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BTNProcessOrder_Click(object sender, EventArgs e)
        {
            // Step #1: Check that they ordered at least 1 item
            if (LBXOrders.Items.Count <= 0)
            {
                MessageBox.Show("Please order at least 1 item", "No Item(s) Have Been Added to Order");
            }

            // Step #2: Check that all info in the Customer Info Groupbox is correct
            else if (ValidCustomerInfo())
            {
                // 
                for (int i = 0; i < LBXOrders.Items.Count; i++)
                {
                    int intItemOrder = LSTOrderIndexVale[i];
                    for (int j = 0; j < decIngredientLevels.Length; j++)
                    {
                        decIngredientLevels[j] -= decIngredientsUsed[j, intItemOrder] * LSTOrderQuantity[i];
                    }
                }

                // Step #3: Check if they want the food delivered  
                if (CHKDelivery.Checked)
                {
                    // Step #4 A: If they DO want the food delivered, check that the Delivery Info Groupbox is correct    
                    if (ValidDeliveryInfo())
                    {
                        // Step #5: Everything is validated: show total & clear form
                        MessageBox.Show("Order Total: " + decTotal.ToString("c")); // Show total & clear the form
                        BTNClearForm_Click(sender, e);
                    }
                }

                // Step #4 B: If they DO NOT want the food delivered, everything is validated: show total & clear form
                else
                {
                    MessageBox.Show("Order Total: " + decTotal.ToString("c"));
                    BTNClearForm_Click(sender, e);
                }
            }
        }

        #region Data Validation for Process Order Button Click
        /// <summary>
        /// Checks all objects in the Customer Information Group Box
        /// </summary>
        /// <returns></returns>
        private bool ValidCustomerInfo()
        {
            // Step #1: Check that every textbox has a value
            if (!Validator.IsPresent(TXTBillingName.Text, TXTBillingName.Tag.ToString()) ||
                !Validator.IsPresent(TXTBillingPhoneNumber.Text, TXTBillingPhoneNumber.Tag.ToString()) ||
                !Validator.IsPresent(TXTBillingStreetAddress.Text, TXTBillingStreetAddress.Tag.ToString()) ||
                !Validator.IsPresent(TXTBillingCity.Text, TXTBillingCity.Tag.ToString()) ||
                !Validator.IsPresent(TXTBillingZipCode.Text, TXTBillingZipCode.Tag.ToString()) ||
                !Validator.IsPresent(TXTBillingSubdivision.Text, TXTBillingSubdivision.Tag.ToString()))
                return false;

            // Step #2: Check that the State Combobox has a value
            if (CBOBililngState.SelectedIndex == -1)
            {
                MessageBox.Show("Please enter a state for your billing address", "Missing Field: Billing State Combo Box");
                return false;
            }

            // Step #3: Check that Phone Number is Valid (contains only numbers, 10 digits long)
            string strBillingPhoneNumber = TXTBillingPhoneNumber.Text.Trim();
            strBillingPhoneNumber = strBillingPhoneNumber.Replace("(", "");
            strBillingPhoneNumber = strBillingPhoneNumber.Replace(")", "");
            strBillingPhoneNumber = strBillingPhoneNumber.Replace("-", "");

            if (!Validator.ValidPhoneAndZipCode(strBillingPhoneNumber, TXTBillingPhoneNumber.Tag.ToString(), 10))
                return false;

            // Step #4: Check that the City is valid (contains only letters)
            string strBillingCity = TXTBillingCity.Text.Trim();
            bool blnIsLetter = Regex.IsMatch(strBillingCity, "^[a-zA-Z ]+$");

            if (!blnIsLetter)
            {
                MessageBox.Show("Please enter a valid city (letters only)", "Invalid City");
                return false;
            }

            // Step #5: Check that the Zip Code is valid (contains only numbers, 5 digits long)
            string strBillingZipCode = TXTBillingZipCode.Text.Trim();
            if (!Validator.ValidPhoneAndZipCode(strBillingZipCode, TXTBillingZipCode.Tag.ToString(), 5))
                return false;

            // Step #6: Everything in the Customer Info Groupbox has been validated: return true         
            return true;
        }



        /// <summary>
        /// Clecks all information in the Delivery Information Group Box if the Delivery checkbox is checked
        /// </summary>
        /// <returns></returns>
        private bool ValidDeliveryInfo()
        {

            // Step #1: Check that every textbox has a value
            if (!Validator.IsPresent(TXTDeliveryName.Text, TXTDeliveryName.Tag.ToString()) ||
                !Validator.IsPresent(TXTDeliveryPhoneNumber.Text, TXTDeliveryPhoneNumber.Tag.ToString()) ||
                !Validator.IsPresent(TXTDeliveryStreetAddress.Text, TXTDeliveryStreetAddress.Tag.ToString()) ||
                !Validator.IsPresent(TXTDeliveryCity.Text, TXTDeliveryCity.Tag.ToString()) ||
                !Validator.IsPresent(TXTDeliveryZipCode.Text, TXTDeliveryZipCode.Tag.ToString()) ||
                !Validator.IsPresent(TXTDeliverySubdivision.Text, TXTDeliverySubdivision.Tag.ToString()))
                return false;

            // Step #2: Check that the combobox has a value
            if (CBOBililngState.SelectedIndex == -1)
            {
                MessageBox.Show("Please enter a state for your delivery address (NOTE: WE ONLY DELIVER IN TEXAS)", "Empty Field: Delivery State");
                return false;
            }

            // Step #3: Check that the Delivery Phone Number is valid (contains only numbers, is 10 digits long)
            string strDeliveryPhoneNumber = TXTDeliveryPhoneNumber.Text.Trim();
            strDeliveryPhoneNumber = strDeliveryPhoneNumber.Replace("(", "");
            strDeliveryPhoneNumber = strDeliveryPhoneNumber.Replace(")", "");
            strDeliveryPhoneNumber = strDeliveryPhoneNumber.Replace("-", "");

            if (!Validator.ValidPhoneAndZipCode(strDeliveryPhoneNumber, TXTDeliveryPhoneNumber.Tag.ToString(), 10))
                return false;

            // Step #4: Check that Delivery City is Bryan or College Station
            if (TXTDeliveryCity.Text.Trim().ToLower() != "college station" && TXTDeliveryCity.Text.Trim().ToLower() != "bryan")
            {
                MessageBox.Show("Please enter a delivery address with Bryan or College Station as the city", "Delivery Address Out of Range: City");
                return false;
            }

            // Step #5: Check that the Delivery State is Texas
            if (CBODeliveryState.SelectedIndex != 42)
            {
                MessageBox.Show("Please enter a delivery address with Texas as the state ", "Delivery Address Out of Range: State");
                return false;
            }

            // Step #6: Check that Delivery Zip Code is in College Station or Bryan (P.O. box zip codes are not included since food can't be delivered there)
            bool blnValidZipCode = false;

            foreach (int intBryanCollegeStationZipCodes in intBryanCollegeStationZipCodes)
            {
                if (TXTDeliveryZipCode.Text == intBryanCollegeStationZipCodes.ToString())
                    blnValidZipCode = true;
            }

            if (!blnValidZipCode)
            {
                string strZipCodeMessage = "Please enter a delivery address with a zip code in Bryan/College Station\n We only accept:\n";
                foreach (int intBryanCollegeStationZipCodes in intBryanCollegeStationZipCodes)
                {
                    strZipCodeMessage += intBryanCollegeStationZipCodes.ToString() + "\n";
                }
                MessageBox.Show(strZipCodeMessage, "Delivery Address Out of Range: Zip Code");
                return false;
            }

            // Step #7: Delivery Info Groupbox has been validated: return true
            return true;
        }

        /// <summary>
        /// Checks if textboxes have an input or are empty
        /// </summary>
        /// <param name="strUserInput"></param>
        /// <param name="strDescription"></param>
        /// <returns></returns>

        #endregion

        /// <summary>
        /// Closes the form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BTNCancelOrder_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Opens the inventory form when clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BTNViewInventory_Click_1(object sender, EventArgs e)
        {
            //if (!System.Windows.Forms.Application.OpenForms.Cast<FRMInventory>().Any())
            FRMInventory newInventoryForm = new FRMInventory();
            newInventoryForm.strIngredientNames = strIngredientNames;
            newInventoryForm.decIngredientLevels = decIngredientLevels;
            newInventoryForm.ShowDialog();
        }

        private void BTNOpenVendorForm_Click(object sender, EventArgs e)
        {
            FRMVendor fRMVendor = new FRMVendor();
            fRMVendor.ShowDialog();
        }
    }
}
#endregion