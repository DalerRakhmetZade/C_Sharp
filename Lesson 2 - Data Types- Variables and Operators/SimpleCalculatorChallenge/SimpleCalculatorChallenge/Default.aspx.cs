using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SimpleCalculatorChallenge
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            string firstValue = firstValueTextBox.Text;
            string secondValue = secondValueTextBox.Text;
            double myResult = double.Parse(firstValue) - double.Parse(secondValue);
            returnLabel.Text = myResult.ToString();
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            string firstValue = firstValueTextBox.Text;
            string secondValue = secondValueTextBox.Text;
            double myResult = double.Parse(firstValue) / double.Parse(secondValue);
            returnLabel.Text = myResult.ToString();
        }

        protected void plusButton_Click(object sender, EventArgs e)
        {
            string firstValue = firstValueTextBox.Text;
            string secondValue = secondValueTextBox.Text;
            double myResult = double.Parse(firstValue) + double.Parse(secondValue);
            returnLabel.Text = myResult.ToString();
        }

        protected void multiplicationButton_Click(object sender, EventArgs e)
        {
            string firstValue = firstValueTextBox.Text;
            string secondValue = secondValueTextBox.Text;
            double myResult = double.Parse(firstValue) * double.Parse(secondValue);
            returnLabel.Text = myResult.ToString();
        }

        protected void firstValueTextBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        protected void secondValueTextBox_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}