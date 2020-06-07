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
            //Create a dicetray with predetmined amount of dices
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
                Console.WriteLine("Yatzhee is actief!");
                return true;
            }
            else
            {
                Console.WriteLine("Yatzhee is niet actief.");
                return false;
            }
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
