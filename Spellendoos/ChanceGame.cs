using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spellendoos
{
    abstract class ChanceGame
    {
        private string name;
        private List<Player> player;
        private DiceTray dices;

        public string Name { get => name; set => name = value; }
        public List<Player> Player { get => player; set => player = value; }
        internal DiceTray Dices { get => dices; set => dices = value; }

        protected ChanceGame(string name, List<Player> player, DiceTray dices)
        {
            this.name = name;
            this.player = player;
            this.dices = dices;
        }

        public abstract void StartGame(String name, List<Player> players);
        public abstract void RemovePlayer(Player player);
        public abstract void AddPlayer(Player player);
        public abstract DiceTray ThrowDice(DiceTray dices);
        public abstract string GetGameName();
    }
}
