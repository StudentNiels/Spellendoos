using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spellendoos
{
    class DiceTray
    {
        //List of Dice objects
        public List<Dice> Dices;

        public DiceTray() 
        {
            //Create a list of dices to roll them all at once.
            Dices = new List<Dice>();
        }
        public int[] RollDices()
        {
            //Create an empty array for the dice results
            int[] diceResults = new int[Dices.Count];
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
