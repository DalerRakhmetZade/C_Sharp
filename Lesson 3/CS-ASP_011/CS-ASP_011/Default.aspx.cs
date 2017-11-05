using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CS_ASP_011
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            resultLabel.Text = "";
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            /*if  (firstTextBox.Text == secondTextBox.Text)
            {
                resultLabel.Text = "Yes, they are equal!";
            }
            else
            {
                resultLabel.Text = "No! They're not equal!";
            }*/
            /*
            if (coolCheckBox.Checked)
            {
                resultLabel.Text = "Yes, you are definitely cool!";
            }
            else
            {
                resultLabel.Text = "Don't be sp hard on yourself.";
            }*/
            if (pizzaButton.Checked)
            {
                resultLabel.Text = "You must be from Chicago";
            }
            else if (saladButton.Checked)
            {
                resultLabel.Text = "You must be healthy";
            }
            else if (pbjButton.Checked)
            {
                resultLabel.Text = "You must be a fun loving person";
            }
            else
            {
                resultLabel.Text = "Please select one of the options above";
            }

        }

        protected void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}