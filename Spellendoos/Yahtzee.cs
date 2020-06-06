using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spellendoos
{
    internal class Yahtzee : ChanceGame
    {
        public Yahtzee(string name, List<Player> player, DiceTray dices) : base(name, player, dices)
        {
            name = "Yahtzee";
        }

        public override void AddPlayer(Player player)
        {
            throw new NotImplementedException();
        }

        public override string GetGameName()
        {
            throw new NotImplementedException();
        }

        public override void RemovePlayer(Player player)
        {
            throw new NotImplementedException();
        }

        public override void StartGame(string name, List<Player> PlayerList)
        {
            throw new NotImplementedException();
        }

        public override DiceTray ThrowDice(DiceTray dices)
        {
            throw new NotImplementedException();
        }
    }
}
