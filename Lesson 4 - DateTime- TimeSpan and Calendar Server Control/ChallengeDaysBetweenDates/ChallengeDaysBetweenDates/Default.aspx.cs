﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChallengeDaysBetweenDates
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void okButton_Click(object sender, EventArgs e)
        {
            /*String firstSelectedDate = firstCalendar.SelectedDate.ToShortDateString();
            DateTime firstselectedDate = DateTime.Parse(firstSelectedDate);
            String secondSelectedDate = secondCalendar.SelectedDate.ToShortDateString();
            DateTime secondselectedDate = DateTime.Parse(secondSelectedDate);

            int firstDate = firstselectedDate.Day;
            int secondDate = secondselectedDate.Day;


            if (firstDate > secondDate)
            {
                int resultDays = firstDate - secondDate;
                resultLabel.Text = resultDays.ToString();
            }
            else
            {
                int resultDays = secondDate - firstDate;
                resultLabel.Text = resultDays.ToString();
            }
            */

            if (firstCalendar.SelectedDate > secondCalendar.SelectedDate)
            {
                resultLabel.Text = firstCalendar.SelectedDate
                                .Subtract(secondCalendar.SelectedDate)
                                .TotalDays.ToString();
            }
            else
            {
                resultLabel.Text = secondCalendar.SelectedDate
                .Subtract(firstCalendar.SelectedDate)
                .TotalDays.ToString();
            }
            



        }
    }
}