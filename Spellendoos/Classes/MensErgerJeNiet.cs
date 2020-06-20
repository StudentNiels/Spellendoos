using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Spellendoos.Classes
{
    class MensErgerJeNiet : BoardGame
    {
        private int numberOfFields;
        private DiceTray dices = new DiceTray(1, 6);

        public MensErgerJeNiet(string name, List<Player> players)
        {
            this.name = name;
            this.players = players;
            this.active = true;
            //this.numberOfFields = 44;
            this.Grid = new LinkedList<int>();

        }

        public override void EndGame()
        {
            //Close the game.
            active = false;
        }

        public override string GetGameName()
        {
            return this.name;
        }

        public override LinkedList<int> GetGrid()
        {
            throw new NotImplementedException();
        }

        public override bool IsActive()
        {
            //This method is simply to check whether or not the game is currently active for testing purposes.
            if (active == true)
            {
                Console.WriteLine("Yahtzee is actief!");
                return true;
            }
            else
            {
                Console.WriteLine("Yahtzee is niet actief.");
                return false;
            }
        }

        public override void SetGrid(int horizontal, int vertical)
        {
            throw new NotImplementedException();
        }

       

    }
}
