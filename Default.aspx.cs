/*
 * Author Harita Lolla
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DollarConversion
{
    public partial class Default : System.Web.UI.Page
    {
        /*
         * Result is displayed when the action button is displayed.
         * @return Result
         */
        protected void btnOK_Click(object sender, EventArgs e)
        {
            // conversion formula
            try
            {
                double i = Convert.ToDouble(dlstCurrencies.SelectedValue.ToString()) * Convert.ToDouble(txtbxDollar.Text.ToString());

                lblMessage.Text = txtbxDollar.Text + " " + "US dollar =" + " " + i.ToString() + " " + dlstCurrencies.SelectedItem;

            }

            catch (FormatException)
            {
                // Error message 
                lblMessage.Text = "The number you typed in was not in correct format. Use only numbers";
            }
        }
        protected void Page_Load(object sender, EventArgs e)
        {

        }
    }
}