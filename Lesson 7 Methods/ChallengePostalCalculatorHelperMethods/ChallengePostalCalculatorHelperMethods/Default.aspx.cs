using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChallengePostalCalculatorHelperMethods
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
           
        }


        protected void handleChange(object sender, EventArgs e)
        {
            // do the values in the texboxes exist? 
            if (!valuesExist()) return;

            // what is the volume? 
            int volume = 0;
            if (!tryGetVolume(out volume)) return;

            // which multiplier to use?
            double postageMulitplier = getPostageMuliplier();

            // determine the cost
            double cost = volume * postageMulitplier;

            //Show the user
            resultLabel.Text = String.Format("Your parcel will cost {0:C} to ship", cost);
        }


        private bool valuesExist()
        {
            if (!airRadioButton.Checked
                && !groundRadioButton.Checked
                && !nextDayRadioButton.Checked)
                return false;
            if (widthTextBox.Text.Trim().Length == 0
                || heightTextBox.Text.Trim().Length == 0)
                return false;
            return true;
        }

        private bool tryGetVolume(out int volume)
        {
            volume = 0;
            int width = 0;
            int height = 0;
            int length = 0;

            if (!int.TryParse(widthTextBox.Text.Trim(), out width)) return false;
            if (!int.TryParse(heightTextBox.Text.Trim(), out height)) return false;
            if (!int.TryParse(lengthTextBox.Text.Trim(), out length)) length = 1;

            volume = width * height * length;
            return true;
        }

        private double getPostageMuliplier()
        {
            if (groundRadioButton.Checked) return .15;
            else if (airRadioButton.Checked) return .25;
            else if (nextDayRadioButton.Checked) return .45;
            else return 0;
        }






        /* private void deliveryMethod(double multiplier)
        {
            double Price = 0.00;
            if (lengthTextBox.Text.Trim().Length == 0)
            {
                Price = int.Parse(widthTextBox.Text) * int.Parse(heightTextBox.Text) * multiplier;
            }
            else
            {
                Price = int.Parse(widthTextBox.Text) * int.Parse(heightTextBox.Text) * int.Parse(lengthTextBox.Text) * multiplier;
            }
            resultLabel.Text = String.Format("You parcel will cost {0:C} to ship", Price);
        } */




    }
      
}