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
        //List of Dices and their die amount
        public List<int> dices;
        //Random object for rng
        public Random rand;

        public DiceTray(int diceAmount, int diceEyes) 
        {
            this.diceAmount = diceAmount;
            this.diceEyes = diceEyes;
            this.rand = new Random();
            //Create a list of dices to roll them all at once.
            dices = new List<int>();
            for (int i = 0; i < diceAmount + 1; i++) 
            {
                dices.Add(diceEyes);
            }
        }

        public int[] RollDices()
        {
            //Create an empty array for the dice results
            int[] diceResults = new int[diceAmount + 1];
            for (int i = 0; i < diceAmount + 1; i++) 
            {
                diceResults[i] = rand.Next(1, (diceEyes + 1));
            }
            return diceResults;
        } 
    }
}
