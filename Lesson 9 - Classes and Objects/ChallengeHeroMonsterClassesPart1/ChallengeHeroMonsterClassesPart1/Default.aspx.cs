using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChallengeHeroMonsterClassesPart1
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Character myHero = new Character();
            myHero.Name = "Hero";
            myHero.Health = 35;
            myHero.DamageMaximum = 20;
            myHero.AttackBonus = false;

            Character myMonster = new Character();
            myMonster.Name = "Monster";
            myMonster.Health = 30;
            myMonster.DamageMaximum = 20;
            myMonster.AttackBonus = true;


            int damage = myHero.Attack();
            myMonster.Defend(damage);

            damage = myMonster.Attack();
            myHero.Defend(damage);

            printStats(myHero);
            printStats(myMonster);

        }
        private void printStats(Character character)
        {
            returnLabel.Text += String.Format("<p>Name:{0} - Health: {1} - DamageMaximum: {2} - AttackBonus: {3}</p>", 
                character.Name, 
                character.Health, 
                character.DamageMaximum, 
                character.AttackBonus); 
        }
    }

    class Character
    {
        public string Name { get; set; }
        public int Health { get; set; }
        public int DamageMaximum { get; set; }
        public bool AttackBonus { get; set; }

        public int Attack()
        {
            Random random = new Random();
            int damage = random.Next(this.DamageMaximum);
            return damage;
        }
        public void Defend(int damage)
        {
            this.Health -= damage;
        }
        
    }
}