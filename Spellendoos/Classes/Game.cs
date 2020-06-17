using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
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
                new Player(p1),
                new Player(p2),
                new Player(p3),
                new Player(p4)
            };
        }

        public void GetPlayersNames(List<Player> players)
        {
            foreach(Player p in players)
            {
                p.getPlayerName();
            }
        }

        public int GetPlayerCount(List<Player> players)
        {
            return players.Count;
        }

        public List<Player> getList()
        {
            return this.players;
        }

        public Yahtzee CreateYahtzee()
        {
            Yahtzee ytz = new Yahtzee("Yahtzee", players, 5, 6, 3, 5);
            ytz.PlayGame();
            return ytz;
        }
    }
}
