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
        //Dices in the game.
        public DiceTray dices;
        //Is the game active
        public bool active;
        //Number of turns.
        public int MaxActionCount;
        public int PlayerTurn;
        //List of players.
        public List<Player> players;
        //Dices in the game.
        public Dice dice;
        //Array of score in the game
        public int[] score;
        //Grid of the board
        public LinkedList<int> Grid;

        public abstract bool IsActive();

        public abstract void SetGrid(int horizontal, int vertical);

        public abstract LinkedList<int> GetGrid();

        public abstract string GetGameName();

        public abstract void EndGame();

    }
}
