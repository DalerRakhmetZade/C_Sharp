using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChallengePhunWithStrings
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // CHALLENGE 1
           /* string name = "Bob Tabor";
            string reverse = "";
            for (int i = name.Length - 1; i >= 0; i--)
            {
                reverse += name[i];
            }
            resultLabel.Text = reverse; */



            //CHALLENGE 2
            /*string names = "Luke,Leia,Han,Chewbacca";
            string reverse = "";
            string[] index = names.Split(',');
            for (int i = index.Length - 1; i >= 0; i--)
            {
                reverse += index[i] + ", ";
            }
            reverse = reverse.Remove(reverse.Length - 2, 1);
            resultLabel.Text = reverse;*/

            //CHALLENGE 3
            /*string names = "Luke,Leia,Han,Chewbacca";
            string result = "";
            string[] index = names.Split(',');
            for (int i = 0; i < index.Length; i++)
            {
                int padleft = (14 - index[i].Length) / 2;
                string temp = index[i].PadLeft(index[i].Length + padleft, '*');
                result += temp.PadRight(14, '*');
                result += "<br/>";
            }
            resultLabel.Text = result;*/

            // CHALLENGE 4 
           /* string puzzle = "NOW IS ZHEremove-me ZIME FOR ALL GOOD MEN ZO COME ZO ZHE AID OF ZHEIR COUNZRY.";
            string removeMe = "remove-me";
            int index = puzzle.IndexOf("remove-me");
            puzzle = puzzle.Remove(index, removeMe.Length);
            puzzle = puzzle.ToLower();
            puzzle = puzzle.Replace("z", "t");
            puzzle = puzzle.Remove(0, 1);
            puzzle = puzzle.Insert(0, "N");
            

            resultLabel.Text = puzzle; */
        }
    }
}