using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChallengeConditonalRadioButton
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void OKButton_Click(object sender, EventArgs e)
        {
            
            if (pencilButton.Checked)
            {
                resultLabel.Text = "You selected Pencil";
                resultImage.ImageUrl = "pencil.png";
            }
            else if (penButton.Checked)
            {
                resultLabel.Text = "You selected Pen";
                resultImage.ImageUrl = "pen.png";
            }
            else if (phoneButton.Checked)
            {
                resultLabel.Text = "You selected Phone";
                resultImage.ImageUrl = "phone.png";
            }
            else if (tabletButton.Checked)
            {
                resultLabel.Text = "You selected Tablet";
                resultImage.ImageUrl = "tablet.png";
            }
            else
            {
                resultLabel.Text = "Please select an option";
   
            }
            
        }
    }
}