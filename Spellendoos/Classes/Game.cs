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
        public List<Player> players = new List<Player>();

        public Game(string p1, string p2, string p3, string p4)
        {
            Player pl1 = new Player(p1);
            Player pl2 = new Player(p2);
            Player pl3 = new Player(p3);
            Player pl4 = new Player(p4);

            this.players.Add(pl1);
            this.players.Add(pl2);
            this.players.Add(pl3);
            this.players.Add(pl4);
        }

        public Game() { }

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
