using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChallengeFirstPapaBobsPizza
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void CheckBox4_CheckedChanged(object sender, EventArgs e)
        {

        }

        protected void purchaseButton_Click(object sender, EventArgs e)
        {
            double totalPrice = 0;

            //  -- SIZE --

            if (babySizeRadioButton.Checked)
            {
                totalPrice = totalPrice + 10;
                totalLabel.Text = "$" + totalPrice.ToString();
            }
            else if (mamaSizeRadioButton.Checked)
            {
                totalPrice = totalPrice + 13;
                totalLabel.Text = "$" + totalPrice.ToString();
            }
            else
            {
                totalPrice = totalPrice + 16;
                totalLabel.Text = "$" + totalPrice.ToString();
            }

            //  --  CRUST --

            if (deepRadioButton.Checked)
            {
                totalPrice = totalPrice + 2;
                totalLabel.Text = "$" + totalPrice.ToString();
            }
            else
            {
                totalPrice = totalPrice + 0;
                totalLabel.Text = "$" + totalPrice.ToString();
            }

            //  -- TOPINGS -- 
            if (pepperoniCheckBox.Checked)
            {
                totalPrice = totalPrice + 1.50;
                totalLabel.Text = "$" + totalPrice.ToString();
            }
            if (onionsCheckBox.Checked)
            {
                totalPrice = totalPrice + 0.75;
                totalLabel.Text = "$" + totalPrice.ToString();
            }
            if (greenPeppersCheckBox.Checked)
            {
                totalPrice = totalPrice + 0.50;
                totalLabel.Text = "$" + totalPrice.ToString();
            }
            if (redPeppersCheckBox.Checked)
            {
                totalPrice = totalPrice + 0.75;
                totalLabel.Text = "$" + totalPrice.ToString();
            }
            if (anchoviesCheckBox.Checked)
            {
                totalPrice = totalPrice + 2;
                totalLabel.Text = "$" + totalPrice.ToString();
            }

            //  -- SPECIAL --
            if ((pepperoniCheckBox.Checked && greenPeppersCheckBox.Checked && anchoviesCheckBox.Checked) 
                || (pepperoniCheckBox.Checked && redPeppersCheckBox.Checked && onionsCheckBox.Checked))
            {
                totalPrice = totalPrice - 2;
                totalLabel.Text = "$" + totalPrice.ToString();
            }
        }
    }
}
