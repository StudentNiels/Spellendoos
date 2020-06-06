using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Spellendoos
{
    class DiceTray
    {
        //amount of dices in the dicetray
        public int diceAmount;
        //amount of eyes the individual dices will have
        public int diceEyes;
        //List of Dice objects
        public List<Dice> Dices;

        public DiceTray(int diceAmount, int diceEyes) 
        {
            this.diceAmount = diceAmount;
            this.diceEyes = diceEyes;
            //Create a list of dices to roll them all at once.
            Dices = new List<Dice>();
            for (int i = 0; i < diceAmount + 1; i++) 
            {
                Dices.Add(new Dice(diceEyes));
            }
        }

        public int[] RollDices()
        {
            //Create an empty array for the dice results
            int[] diceResults = new int[diceAmount];
            //Index so we can add more dices to the int[]
            int currentIndex = 0;
            //Note that with this code, the index of Dices is the same as the index as diceResults.
            foreach (Dice Dice in Dices) 
            {
                diceResults[currentIndex] = Dice.RollDice();
                currentIndex++;
            }
            return diceResults;
        } 
    }
}
