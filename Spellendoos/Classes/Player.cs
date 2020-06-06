using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Spellendoos
{
    public class Player
    {
        public string playerName;
        public int winScore;
        public string colour;


        public Player()
        {
            this.playerName = "";
            this.winScore = 0;
            this.colour = "Empty";
        }

        public string getPlayerName()
        {
            return this.playerName;
        }

        public void setPlayerName(string playerName)
        {
            this.playerName = playerName;
        }

        public int getWinScore()
        {
            return this.winScore;
        }

        public void setWinScore(int winScore)
        {
            this.points = winScore;
        }

        public string getColour()
        {
            return this.colour;
        }

        public void setColour(string colour)
        {
            this.colour = colour;
        }
    }
}
