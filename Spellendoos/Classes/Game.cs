using System.Collections.Generic;

namespace Spellendoos
{
    class Game 
    {
        public List<Player> players;

        public Game(List<Player> players)
        {
            this.players = players;
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
