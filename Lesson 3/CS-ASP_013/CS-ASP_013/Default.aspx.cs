﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CS_ASP_013
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //comparisonTypeLabel.Text = "equal to";
            //comparisonTypeLabel.Text = "not equal to";
            //comparisonTypeLabel.Text = "greater than";
            //comparisonTypeLabel.Text = "less or equal than";
            
        }

        protected void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        protected void OKButton_Click(object sender, EventArgs e)
        {
            // resultLabel.Text = (firstTextBox.Text == secondTextBox.Text) ? "Yes" : "No";
            // resultLabel.Text = (firstTextBox.Text != secondTextBox.Text) ? "Yes" : "No";
            //int first = int.Parse(firstTextBox.Text);
            //int second = int.Parse(secondTextBox.Text);
            //resultLabel.Text = (first > second) ? "Yes" : "No";
            //resultLabel.Text = (first >= second) ? "Yes" : "No";
            //resultLabel.Text = (first <= second) ? "Yes" : "No";

            //resultLabel.Text = (!CheckBox.Checked) ? "NO" : "YES";
            resultLabel.Text = "";
            /*if (CheckBox.Checked 
                && firstTextBox.Text == "Bob" 
                && secondTextBox.Text == "Tabor")
            {
                resultLabel.Text = "Perfect trifectal!";*/

            /*if (CheckBox.Checked || firstTextBox.Text == "Bob" || secondTextBox.Text == "Tabor")
            {
                resultLabel.Text = "One out of three ain't bad.";*/
                if ((CheckBox.Checked 
                || firstTextBox.Text == "Bob") 
                && secondTextBox.Text == "Tabor")
            {
                resultLabel.Text = "Two out of three ain't bad.";
            }
            

        }
    }
}
