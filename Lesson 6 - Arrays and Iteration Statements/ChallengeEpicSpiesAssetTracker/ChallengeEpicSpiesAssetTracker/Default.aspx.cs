using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChallengeEpicSpiesAssetTracker
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!Page.IsPostBack)
            {
                string[] assetName = new string[0];
                ViewState.Add("Asset Name", assetName);

                double[] elections = new double[0];
                ViewState.Add("Elections Rigged", elections);

                double[] acts = new double[0];
                ViewState.Add("Acts of Subterfuge", acts);
            }
        }

        protected void addButton_Click(object sender, EventArgs e)
        {
            string[] assetName = (string[])ViewState["Asset Name"];

            Array.Resize(ref assetName, assetName.Length + 1);
            int newestItem = assetName.GetUpperBound(0);

            assetName[newestItem] = nameTextBox.Text;
            ViewState["Asset Name"] = assetName;



            double[] elections = (double[])ViewState["Elections Rigged"];

            Array.Resize(ref elections, elections.Length + 1);
            int newestItem1 = elections.GetUpperBound(0);

            elections[newestItem1] = double.Parse(electionsTextBox.Text);
            ViewState["Elections Rigged"] = elections;



            double[] acts = (double[])ViewState["Acts of Subterfuge"];

            Array.Resize(ref acts, acts.Length + 1);
            int newestItem2 = acts.GetUpperBound(0);

            acts[newestItem] = double.Parse(actsTextBox.Text);
            ViewState["Acts of Subterfuge"] = acts;




            resultLabel.Text = String.Format("Total Elections Rigged: {0} <br /> Average Acts of Subterfuge per Asset: {1:N2} <br /> (Last Asset you Added: {2})", 
                elections.Sum(),
                acts.Average(),
                assetName.Last());

           
        }
    }
}