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
        public int points;
        public string colour;


        public Player(String name)
        {
            this.playerName = name;
            this.points = 0;
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

        public int getPoints()
        {
            return this.points;
        }

        public void setPoints(int points)
        {
            this.points = points;
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
