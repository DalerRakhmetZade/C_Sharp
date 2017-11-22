using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MegaChallengeCasino
{
    public partial class Default : System.Web.UI.Page
    {
        //Random class is part of spinReel() helper method. 
        Random random = new Random();
       
        protected void Page_Load(object sender, EventArgs e)
        {
            // This sets the initial player's balance to $100. 
            if (!Page.IsPostBack)
            {
                ViewState.Add("initialBalance", 100);
                determineBalance();
            }
        }
        //This helper method send the player's balance to the moneyLabel.
        private void determineBalance()
        {
            if (int.Parse(ViewState["initialBalance"].ToString()) > 0)
            {
                moneyLabel.Text = String.Format("Player's Money: {0:C}", ViewState["initialBalance"]);
            }
            else
            {
                moneyLabel.Text = String.Format("Your balance is {0:C}, you lost all your money. Game Over", ViewState["initialBalance"]);
                betTextBox.Text = "0";
            }
        }


        protected void pullButton_Click(object sender, EventArgs e)
        {
            pullReel(out int Bet, out int Winnings);
            displayResult(Bet, Winnings);
            calculateBalance(Bet, Winnings);
            determineBalance();
            
        }

        
        // This helper method will return random images to the reel along with the Bet value and total amount of Winnings. 
        private int pullReel(out int Bet, out int Winnings)
        {
            string[] reels = new string[] { spinReel(), spinReel(), spinReel() };
            determineImages(reels);
            int multiplier = determineMultiplier(reels);
            Bet = int.Parse(betTextBox.Text);
            Winnings = Bet * multiplier;
            return Winnings;
        }

       
        // This helper method is used to ramdomize the name of the image to show when reel is pulled. 
        private string spinReel()
        {
            string[] images = new string[] { "Strawberry", "Bar", "Lemon", "Bell", "Clover", "Cherry", "Diamond", "Orange", "Seven", "HorseShoe", "Plum", "Watermelon" };
            return images[random.Next(11)];

        }
        // This helper method directs images to random URL in Images Folder. It covers all three images. 
        private void determineImages(string[] reels)
        {
            Reel1.ImageUrl = "/Images/" + reels[0] + ".png";
            Reel2.ImageUrl = "/Images/" + reels[1] + ".png";
            Reel3.ImageUrl = "/Images/" + reels[2] + ".png";
        }
        // This helper method determines the multiplier that is used to calculate potential winnings. 
        private int determineMultiplier(string[] reels)
        {
            int multiplier = 0;
            if (isBar(reels)) return 0;
            if (isJackpot(reels)) return 100;
            if (isWinner(reels, out multiplier)) return multiplier;
            return 0;

        }

        
       // This helper methos determines if "Bar" reel exists 
        private bool isBar(string[] reels)
        {
            if (reels[0] == "Bar" || reels[1] == "Bar" || reels[2] == "Bar")
                return true;
            else
                return false;
        }
        // This helper method determines existence of Jackpot 
        private bool isJackpot(string[] reels)
        {
            if (reels[0] == "Seven" && reels[1] == "Seven" && reels[2] == "Seven")
                return true;
            else
                return false;
        }
        //This helper wethod will determine existence of "Cherry"
        private bool isWinner(string[] reels, out int multiplier)
        {
            multiplier = determineCherryMultiplier(reels);
            if (multiplier > 0)
                return true;
            else
                return false;
        }
        //This helper method return the Cherry multiplier
        private int determineCherryMultiplier(string[] reels)
        {
            int cherryCount = determineCherryCount(reels);
            if (cherryCount == 1) return 2;
            if (cherryCount == 2) return 3;
            if (cherryCount == 3) return 4;
            return 0;
        }
        //This helper method counts how many "Cherry" images are there
        private int determineCherryCount(string[] reels)
        {
            int cherryCount = 0;
            if (reels[0] == "Cherry") cherryCount++;
            if (reels[1] == "Cherry") cherryCount++;
            if (reels[2] == "Cherry") cherryCount++;
            return cherryCount;
        }
        //This Helper will display message to the user
        private void displayResult(int bet, int winnings)
        {
            if (winnings > 0)
            {
                resultLabel.Text = String.Format("You bet {0:C} and won {1:C}", bet, winnings);

            }
            else
            {
                resultLabel.Text = String.Format("Sorry, you lost {0:C}. Better luck next time.", bet);
            }
        }
        private void calculateBalance(int Bet, int Winnings)
        {
            int currentBalance = int.Parse(ViewState["initialBalance"].ToString());
            currentBalance += Winnings;
            currentBalance -= Bet;
            ViewState["initialBalance"] = currentBalance;

        }

        
    }
}