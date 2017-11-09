using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChallengeEpicSpiesAssignment
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                previousCalendar.SelectedDate = DateTime.Today;
                newCalendar.SelectedDate = DateTime.Today.AddDays(14);
                endDateCalendar.SelectedDate = DateTime.Today.AddDays(21);
            }

        }

        protected void assignButton_Click(object sender, EventArgs e)
        {
            Double totalDaysWorked = endDateCalendar.SelectedDate.Subtract(newCalendar.SelectedDate).TotalDays;
            Double totalAmountPaid = totalDaysWorked * 500;
            if (totalDaysWorked > 21)
                totalAmountPaid = totalAmountPaid + 1000;

            Double daysBetween = newCalendar.SelectedDate.Subtract(previousCalendar.SelectedDate).TotalDays;
            DateTime startDate = previousCalendar.SelectedDate.AddDays(14);
            DateTime endDate = previousCalendar.SelectedDate.AddDays(21);
            if (daysBetween < 14)
            {
                newCalendar.SelectedDate = startDate;
                endDateCalendar.SelectedDate = endDate;
                resultLabel.Text = String.Format("Error: Must allow at least two weeks between previous assignment and new assignment." +
                    "{0} can start New Assignment as soon as {1:MMMM dd, yyyy}", spyNameTextBox.Text, startDate);
            }
            else resultLabel.Text = String.Format("Assignment of {0} " + "to assignment Project: {1} is authorized."
                + "Budget Total: {2:C}",
                spyNameTextBox.Text, assignmentTextBox.Text, totalAmountPaid);



        }
    }
}