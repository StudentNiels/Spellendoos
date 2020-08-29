using Spellendoos.Classes;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using System.Windows.Input;
using System.Xml.Schema;
using System.Xml.XPath;
using MessageBox = System.Windows.Forms.MessageBox;

namespace Spellendoos
{
    class YahtzeeWithUI : ChanceGame
    {
        YahtzeeRules YRules = new YahtzeeRules();
        protected List<string> allScoreTypes;
        protected List<string> allScores;

        //Yahtzee version for User Interface
        public YahtzeeWithUI(string name, List<Player> players, int diceAmount, int diceEyeAmount, int maxActionCount, int maxRounds)
        {
            this.allScoreTypes = new List<string>();
            this.allScores = new List<string>();
            this.name = name;
            this.players = players;
            //Create a dicetray with predetermined amount of dices
            this.dices = new DiceTray(diceAmount, diceEyeAmount);
            //Maximum amount of actions a player can take per turn
            this.maxActionCount = maxActionCount;
            this.score = new int[players.Count];
            this.active = true;
            this.maxRounds = maxRounds;
            this.rules = new YahtzeeRules();
            this.gameScore = new Dictionary<string, int>();
            this.heldDices = new int[diceAmount];
            this.actionCount = 0;
            this.canRollDice = false;
            foreach (Player player in players)
            {
                gameScore.Add(player.playerName, 0);
            }
            
        }

        public override void setHeldDie(int dieToHold)
        {
            heldDices[dieToHold] = 1;
        }

        public override void clearHeldDie()
        {
            //Set heldDices back to original value
            for (int i= 0; i < heldDices.Count(); i++) 
            {
                heldDices[i] = 0;
            }
        }

        public override bool IsActive()
        {
            //This method is simply to check whether or not the game is currently active for testing purposes.
            if(active == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public int[] RollDice()
        {
            int[] results = dices.RollDices(heldDices);
            //int for displaying dice number
            int diceNumber = 1;

            foreach (int result in results)
            {
                diceNumber++;
                
            }
            return results;
        }

        ///method to color the playername of the player who is currently rolling
        public void playerColor(string playerName)
        {

        }

        /**
         * Takes diceroll results and interprets them into point and then returns only the scoreType(Three of a kind, full house etc)
         */
        public List<string> getAllScoreTypes(int[] results)
        {
            YRules.checkOptions(results);
            foreach (KeyValuePair<string, int> result in YRules.getScoreOptions())
            {
                string scoreType = result.Key;
                allScoreTypes.Add(scoreType);
                Console.WriteLine(scoreType);
            }
            return allScoreTypes;
        }

        /**
         * Takes diceroll results and interprets them into point and then returns only the score(numbers)
         */
        public List<string> getAllScores(int[] results)
        {
            YRules.checkOptions(results);
            foreach (KeyValuePair<string, int> result in YRules.getScoreOptions())
            {
                
                int score = result.Value;
                allScores.Add(score.ToString());
                Console.WriteLine(score.ToString());
            }
            return allScores;
        }

        public void SetupGame(int playerTurn)
        {
            ///Get player name so we don't have to constantly call that method
            
            ///Score for the player
            int score = 0;
            ///int list to store the scores the player selects in.
            List<int> pointStorage = new List<int>();

            foreach (KeyValuePair<string, int> gameScore in gameScore)
            {
                ///Show stuff

                string TotalScore = gameScore.Key;
                int TotalScorePoints = gameScore.Value;
            }
            while (actionCount < maxActionCount)
            {
                if (actionCount == 0)
                {

                    ///Roll the pre-defined dices
                    int[] results = RollDice();
                    ///Gives the current player the points that can be earned with the current dicethrow

                    Dictionary<string, int> options = rules.checkOptions(results);
                    pointStorage.Clear();

                    actionCount++;
                }
                while (actionCount < 3)
                {

                }
            }
        }


        /// <summary>
        /// Method continues the game untill all the rounds (usually 5) are completed
        /// This method calls the turn() method to to activate gameplay
        /// </summary>
        public override void PlayGame()
        {
            canRollDice = true;
            int roundCount = 1;
            int currentTurn = 0;
            while (roundCount < maxRounds + 1)
            { 
                if (currentTurn > (players.Count - 1))
                {
                    currentTurn = 0;
                    roundCount++;
                }
                //Prevent roundcount from overflowing
                if (roundCount < maxRounds + 1)
                {
                    //Turn(currentTurn);
                    currentTurn++;
                }
            }
            DialogResult DialogOK = MessageBox.Show("The game is finished press OK to return to the menu.", "finish!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (DialogOK == DialogResult.OK)
                {
                    EndGame();
                }
                else if (DialogOK != DialogResult.OK)
                {
                    EndGame();
                }
            }

        public override void EndGame()
        {
            //Close the game.
            //TO DO: check if game closes and gameselector starts up again
            active = false;
            System.Windows.Forms.Application.Exit();
            GameSelector gs = new GameSelector(players);
            gs.Show();
        }

        public override string GetGameName()
        {
            return name;
        }

        public override int GetMaxRounds()
        {
            return maxRounds;
        }

        public override void setActionCount(int newActionCount)
        {
            this.actionCount = newActionCount;
        }

        public override bool getDiceRollAvailability()
        {
            return canRollDice;
        }
    }
}
