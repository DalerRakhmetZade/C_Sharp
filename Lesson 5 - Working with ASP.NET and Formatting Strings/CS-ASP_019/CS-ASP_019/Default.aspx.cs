using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CS_ASP_019
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void okButton_Click(object sender, EventArgs e)
        {
            int ssn = int.Parse(ssnTextBox.Text);
            double phone = double.Parse(phoneTextBox.Text);

            //string result = String.Format("Thank you, {0}, for your business", nameTextBox.Text);
            /*string result = String.Format("Thank you, {0}, for your business." +
                "<br />Your Social Secirity Number is: {1:000-00-0000}" +
                "<br />Your Phone number is: {2:(000)000-0000}", nameTextBox.Text, ssn, phone);*/

            /*string result = String.Format("Thank you, {0}, for your business." +
            "<br />Your Social Secirity Number is: {1:000-00-0000}" +
            "<br />Your Phone number is: {2:(000)000-0000}" +
            "<br />Loan Date: {3:ddd -- d, M, yy}",
            nameTextBox.Text, 
            ssn, 
            phone,
            Calendar1.SelectedDate);

            resultLabel.Text = result;*/

            double salary = double.Parse(salaryTextBox.Text);
            string result = String.Format("Thank you, {0}, for your business." +
            "<br />Your Social Secirity Number is: {1:000-00-0000}" +
            "<br />Your Phone number is: {2:(000)000-0000}" +
            "<br />Loan Date: {3:ddd -- d, M, yy}" +
            "<br />Salary:{4:C} ",
            nameTextBox.Text,
            ssn,
            phone,
            Calendar1.SelectedDate,
            salary);

            resultLabel.Text = result;
        }
    }
}