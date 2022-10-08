using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LunchOrder
{
    public partial class frmLunchOrder : Form
    {

        // main course list in the form with defalut price.
        private double hamburger = 6.95;
        private double pizza = 5.95;
        private double salad = 4.95;

        // Add ons 
        // * For Hamberger
        //lettuce, tomato, onions, ketchup, mustard, mayo, frenchFries = 0.75 [all comes under setOne];
        private double checkBoxSetOne = 0.75;
        // * For Pizza
        //pepperoni, sausages, olives = 0.85 [ all comes under setTwo];
        private double checkBoxSetTwo = 0.85;
        // * For Salad
        // croutons, baconBits, breadSticks = 0.65 [ all comes under setThree];
        private double checkBoxSetThree = 0.65;
        // orderTotal bill calculation Variables

        private double subTotal; // variable for subTotal.
        private double orderTotal; // variable for orderTotal.
        private double tax = 13.0; // the tax is 13 percent.
        private double calcualtedTax = 0.0; // varibale to store calculated.

        public frmLunchOrder()
        {
            InitializeComponent();// initialization
            radioHamburger.Checked = true; // setting hamburger checked by default
        }
      
       
        /// <summary>
        /// Method to PlaceOrder when click Event occurs on 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPlaceOrder_Click(object sender, EventArgs e)
        {
            // subtotal is a recived for the method.
            subTotal = calculateSubTotal();
            // calcuating the tax from subtotal.
            calcualtedTax = subTotal * (tax / 100.0);
            // calcuating the order Total
            orderTotal = subTotal + calcualtedTax;
            // printing the calulated values on the form
            lblSalesTax.Text = calcualtedTax.ToString("c");
            lblSubtotal.Text = subTotal.ToString("c");
            lblOrderTotal.Text = orderTotal.ToString("c");


        }
        /// <summary>
        /// Method to Calculate subTotal when any addons are selected 
        /// </summary>
        /// <returns></returns>
        private double calculateSubTotal()
        {
            //  if hamburger is selected calcualted form this condition
            if (radioHamburger.Checked == true)
            {
              
                subTotal = hamburger;
                subTotal = addOnCalculate(subTotal);
            }
            //  if pizza is selected calcualted form this condition
            else if (radioPizza.Checked == true)
            {   
                subTotal = pizza;
                subTotal = addOnCalculate(subTotal);
            }
            //  if salad is selected calcualted form this condition
            else
            {
                subTotal = salad;
                subTotal = addOnCalculate(subTotal);
            }
            // returnig the subTotal
            return subTotal;
        }

        /// <summary>
        /// Event handler for hamburger checkedChanged and add gbxAddon items 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void radioHamburger_CheckedChanged(object sender, EventArgs e)
        {
            if(radioHamburger.Checked == true)
            {
                ClearTotals(); // method calling for clearing the textboxes in the form
                ClearAddOns(); //mehtod to clear addons in the form
                gbxAddOnItems.Text = "Add-on Items ($.75/each)";
                checkBoxAddOnOne.Text = "Lettuce, tomato, and oninons";
                checkBoxAddOnTwo.Text = "Ketchup, mustard, and mayo";
                checkBoxAddOnThree.Text = "French fries";
            }

        }
        /// <summary>
        /// Event handler for Pizza checkedChanged and add gbxAddon items 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void radioPizza_CheckedChanged(object sender, EventArgs e)
        {
            if (radioPizza.Checked == true)
            {

                ClearTotals(); // method calling for clearing the textboxes in the form
                ClearAddOns(); //mehtod to clear addons in the form
                gbxAddOnItems.Text = "Add-on Items ($.85/each)";
                checkBoxAddOnOne.Text = "Pepperoni";
                checkBoxAddOnTwo.Text = "Sausage";
                checkBoxAddOnThree.Text = "Olives";
            }

        }
        /// <summary>
        /// Event handler for Salad checkedChanged and add gbxAddon items 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void radioSalad_CheckedChanged(object sender, EventArgs e)
        {
            if (radioSalad.Checked == true)
            {

                ClearTotals(); // method calling for clearing the textboxes in the form
                ClearAddOns(); //mehtod to clear addons in the form
                gbxAddOnItems.Text = "Add-on Items ($.65/each)";
                checkBoxAddOnOne.Text = "Croutons";
                checkBoxAddOnTwo.Text = "Bacon bits";
                checkBoxAddOnThree.Text = "Breadsticks";
            }

        }
        /// <summary>
        /// Method to calculate the add on prices.
        /// </summary>
        /// <param name="subt"></param>
        /// <returns></returns>
        private double addOnCalculate(double subt)
        {
            // if radiohamburger is checked subtotal is added to the value of 0.75
            if (radioHamburger.Checked == true)
            {
                // if checkbox one is checked subtotal is added to the value of 0.75
                if (checkBoxAddOnOne.Checked == true)
                {
                    subTotal += checkBoxSetOne;
                }
                // if checkbox two is checked subtotal is added to the value of 0.75
                if (checkBoxAddOnTwo.Checked == true)
                {
                    subTotal += checkBoxSetOne;
                }
                // if checkbox three is checked subtotal is added to the value of 0.75
                if (checkBoxAddOnThree.Checked == true)
                {
                    subTotal += checkBoxSetOne;
                }
            }
            // if radioPizza is checked subtotal is added to the value of 0.85
            else if (radioPizza.Checked == true)
            {
                // if checkbox one is checked subtotal is added to the value of 0.85
                if (checkBoxAddOnOne.Checked == true)
                {
                    subTotal += checkBoxSetTwo;
                }
                // if checkbox two is checked subtotal is added to the value of 0.85
                if (checkBoxAddOnTwo.Checked == true)
                {
                    subTotal += checkBoxSetTwo;
                }
                // if checkbox three is checked subtotal is added to the value of 0.85
                if (checkBoxAddOnThree.Checked == true)
                {
                    subTotal += checkBoxSetTwo;
                }

            }
            // if radioSalad is checked subtotal is added to the value of 0.65
            else
            {
                // if checkbox one is checked subtotal is added to the value of 0.65
                if (checkBoxAddOnOne.Checked == true)
                {
                    subTotal += checkBoxSetThree;
                }
                // if checkbox two is checked subtotal is added to the value of 0.65
                if (checkBoxAddOnTwo.Checked == true)
                {
                    subTotal += checkBoxSetThree;
                }
                // if checkbox three is checked subtotal is added to the value of 0.65
                if (checkBoxAddOnThree.Checked == true)
                {
                    subTotal += checkBoxSetThree;
                }
            }
            // returnig subtotal
             return subTotal;
        }

        /// <summary>
        /// Method to clear all the textboxes
        /// </summary>
        private void ClearTotals()
        {
            lblOrderTotal.Text = "";
            lblSalesTax.Text = "";
            lblSubtotal.Text = "";
        }

        /// <summary>
        /// Method to clear checkboxes
        /// </summary>
        private void ClearAddOns()
        {
            checkBoxAddOnThree.Checked = false;
            checkBoxAddOnTwo.Checked = false;
            checkBoxAddOnOne.Checked = false;
        }

        /// <summary>
        /// Method to close application or window
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

/*
 * **********************************************************************************************************************************************************************************************
 * *************************************************************************END-OF-THE-TEST-3******************************************************************************************************
 * **********************************************************************************************************************************************************************************************
 */