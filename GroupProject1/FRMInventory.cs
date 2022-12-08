using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
AUTHORS: Nicole Mulkern, Josh Bittlestone, Callie Guest, Jessica Liu, Grant Taylor
COURSE: ISTM 250
FORM: FRMInventory.cs
PURPOSE: This form receives the updated ingredients inventory from the parent form and displays it in the listbox.
INPUT: There is no direct input for this form. 
PROCESS: Once the user clicks "View Inventory" on the parent form, the ingredients array is sent 
        to be processed in this form.
OUTPUT: The output is the updated inventory as customers place orders throughout the day.
HONOR CODE: “On my honor, as an Aggie, I have neither given nor
received unauthorized aid on this academic work.”
*/

namespace GroupProject1
{
    public partial class FRMInventory : Form
    {
        public FRMInventory()
        {
            InitializeComponent();
        }

        public string[] strIngredientNames { get; set; }
        public decimal[] decIngredientLevels { get; set; }

        public void FRMInventory_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < strIngredientNames.Length; i++)
            {
                LBXInventory.Items.Add(strIngredientNames[i] + " " + decIngredientLevels[i]);
            }
        }
    }
}
