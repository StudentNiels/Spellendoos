using Spellendoos.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace Spellendoos
{
    class Yahtzee : ChanceGame
    {
        ///Yahtzee version for Command line.
        public Yahtzee(string name, List<Player> players, int diceAmount, int diceEyeAmount, int maxActionCount, int maxRounds)
        {
            this.name = name;
            this.players = players;
            ///Create a dicetray with predetermined amount of dices
            this.dices = new DiceTray(diceAmount, diceEyeAmount);
            ///Maximum amount of actions a player can take per turn
            this.maxActionCount = maxActionCount;
            this.score = new int[players.Count];
            this.active = true;
            this.maxRounds = maxRounds;
            this.rules = new YahtzeeRules();
            this.gameScore = new Dictionary<string, int>();
            this.actionCount = 0;
            foreach (Player player in players)
            {
                gameScore.Add(player.playerName, 0);
            }
        }

        
        public override bool IsActive()
        {
            ///This method is simply to check whether or not the game is currently active for testing purposes.
            if (active == true)
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


        public override void PlayGame()
        {
            int roundCount = 1;
            int currentTurn = 0;
            while (roundCount < maxRounds + 1)
            { 
                if (currentTurn > (players.Count - 1))
                {
                    currentTurn = 0;
                    roundCount++;
                }
                ///Prevent roundcount from overflowing
                if (roundCount < maxRounds + 1)
                {
                    //Display the roundcount in the UI
                    Console.Write($"Round {roundCount}");
                    currentTurn++;
                }
            }
            Console.WriteLine("Game has Ended.");
        }

        public override void EndGame()
        {
            ///Close the game.
            active = false;
        }

        public override string GetGameName()
        {
            return name;
        }

        public override int GetMaxRounds()
        {
            return maxRounds;
        }


        ///methods required for UI version
        public override void setHeldDie(int dieToHold)
        {
            throw new NotImplementedException();
        }

        public override void clearHeldDie()
        {
            throw new NotImplementedException();
        }

        public override void setActionCount(int newActionCount)
        {
            this.actionCount = newActionCount;
        }

        public override bool getDiceRollAvailability() 
        {
            throw new NotImplementedException();
        }
    }
}
