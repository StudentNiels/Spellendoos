using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spellendoos
{
    class Yahtzee : ChanceGame
    {
        public Yahtzee(string name, List<Player> players, int diceAmount, int diceEyeAmount, int maxActionCount)
        {
            this.name = name;
            this.players = players;
            //Create a dicetray with predetermined amount of dices
            this.dices = new DiceTray(diceAmount, diceEyeAmount);
            //Maximum amount of actions a player can take per turn
            this.maxActionCount = maxActionCount;
            this.score = new int[players.Count];
            this.playerTurn = 0;
            this.active = true;
        }

        public override bool IsActive()
        {
            //This method is simply to check whether or not the game is currently active for testing purposes.
            if(active == true)
            {
                Console.WriteLine("Yahtzee is actief!");
                return true;
            }
            else
            {
                Console.WriteLine("Yahtzee is niet actief.");
                return false;
            }
        }

        public override void Turn()
        {
            //Check if turncount hasn't exceeded playercount, if it has reset it.
            if (playerTurn >= players.Count - 1)
            {
                playerTurn = 0;
            }
            //Get player name so we don't have to constantly call that method
            string playerName = players[playerTurn].getPlayerName();
            Console.WriteLine($"It's {playerName}'s turn. Press any key to roll the dice");
            Console.ReadKey();
            //Roll the pre-defined dices
            int[] results = dices.RollDices();
            int diceNumber = 1;
            //Make a stringbuilder to get one neat string instead of 5 different console lines.
            StringBuilder diceResults = new StringBuilder();
            foreach (int result in results) 
            {
                diceResults.AppendLine($"Dice {diceNumber}'s result was {result}.");
                diceNumber++;
            }
            Console.WriteLine(diceResults.ToString());
        }

        public override void EndGame()
        {
            //Close the game.
            active = false;
        }

        public override string GetGameName()
        {
            return name;
        }
    }
}
