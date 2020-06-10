using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Navigation;

namespace Spellendoos
{
    class Game 
    {
        public List<Player> players;

        public Game(string p1, string p2, string p3, string p4)
        {
            this.players = new List<Player>
            {
                new Player() { playerName = p1 },
                new Player() { playerName = p2 },
                new Player() { playerName = p3 },
                new Player() { playerName = p4 }
            };
        }

        public void GetPlayersNames(List<Player> players)
        {
            foreach(Player p in players)
            {
                p.getPlayerName();
            }
        }

        public int getPlayerCount(List<Player> players)
        {
            return players.Count;
        }

        public List<Player> getList()
        {
            return this.players;
        }
    }
}
