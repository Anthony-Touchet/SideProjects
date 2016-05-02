using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DandD_Library
{
    public class Weapon
    {
        string weaponName;  //Name of the weapon
        int range;          //Range of weapon
        //Weapon Type
        //Attack ablilty
        int rolls;          //Number of rolls for the weapon
        int diceRange;      //Max range of the dice

        int attackBonus;    //Bonus from attributes
        bool proficient;    //Is character Proficent

        public Weapon(string na, int ra, int ro, int dr)
        {
            weaponName = na;
            range = ra;
            rolls = ro;
            diceRange = dr;
        }

        public int CalculateAttackBonus()
        {
            int result = 0;
            //Get Player's attribue the weapon uses. Calculate
            if (proficient == true)
            {
                result += 2;
            }

            return result;
        }

        public List<int> GetDamage()
        {
            List<int> attacks = new List<int>();
            Random ran = new Random();

            for (int i = 0; i < this.rolls; i++)
            {
                attacks.Add(ran.Next(0, this.diceRange));
            }

            return attacks;
        }
    }

    public class Character
    {
    }
}