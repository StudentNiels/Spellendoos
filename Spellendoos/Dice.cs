using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spellendoos
{
    class Dice
    {
        private int eyes;
        private Random rand;
        public Dice(int eyes) 
        {
            //Determines the amount of eyes the dice has, while for the games we are doing the amount should be always 6. Its nice to  be able to determine these things.
            this.eyes = eyes;
            //instance the Random class to randomly do random things like rolling a dice.
            rand = new Random();
        }

        public int RollDice() 
        {
            //Add a one to the amount of eyes due to the way Next() works with indexes
            return rand.Next(0, eyes + 1);
        }
    }
}
