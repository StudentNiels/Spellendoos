﻿using System;
using System.Collections.Generic;

namespace Spellendoos
{
    abstract class ChanceGame
    {
        //Name of the game.
        public string name;
        //List of players.
        public List<Player> players;
        //Dices in the game.
        public DiceTray dices;
        //Array of score in the game
        public int[] score;
        //Determines which player's turn it is.
        public int playerTurn;
        //Determines how many actions the player can perform in their turn
        public int maxActionCount;

        public abstract void EndGame();
        public abstract string GetGameName();
    }
}
