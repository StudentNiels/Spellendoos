using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spellendoos
{
    public class Player
    {
        public string playerName;
        public int points;

        public Player()
        {
        }

        public Player(string playerName, int points)
        {
            this.playerName = playerName;
            this.points = 0;
        }
    }
}
