using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spellendoos.Classes
{
    abstract class BoardGame
    {
        //Name of the game.
        public string name;
        //Is the game active
        public bool Active;
        //Number of turns.
        public int MaxActionCount;
        public int PlayerTurn;
        //List of players.
        public List<Player> players;
        //Dices in the game.
        public Dice dices;
        //Array of score in the game
        public int[] score;
        //Grid of the board
        public LinkedList<int> Grid;
    }
}
