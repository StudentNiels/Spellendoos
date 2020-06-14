using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media;

namespace Spellendoos
{
    public class Player
    {
        public string playerName;
        public int winScore;
        public Color[] colors = new Color[6];
        public Color colour;
        public int random;


        public Player(String name)
        {
            this.playerName = name;
            this.winScore = 0;
            setColour();
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
            this.winScore = winScore;
        }

        public Color getColour()
        {
            return this.colour;
        }

        public void setColour()
        {
            this.colors[0] = Color.FromRgb(255, 165, 0);
            this.colors[1] = Color.FromRgb(255, 0, 0);
            this.colors[2] = Color.FromRgb(0, 0, 128);
            this.colors[3] = Color.FromRgb(50, 205, 50);
            this.colors[4] = Color.FromRgb(255, 0, 255);
            Random randomGenerator = new Random();
            this.random = randomGenerator.Next(0, 4);
            this.colour = colors[this.random];
        }
    }
}
