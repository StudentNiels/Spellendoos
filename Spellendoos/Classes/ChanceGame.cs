﻿using Spellendoos.Classes;
using System.Collections.Generic;

namespace Spellendoos
{
    abstract class ChanceGame
    {
        ///Name of the game.
        public string name;
        ///List of players.
        public List<Player> players;
        ///Dices in the game.
        public DiceTray dices;
        ///Array of score in the game
        public int[] score;
        ///Determines how many actions the player can perform in their turn
        public int maxActionCount;
        ///For checking whether or not the game is supposed to be active.
        public bool active;
        ///Maximum amount of rounds in the game
        public int maxRounds;
        ///Actions taken by the player within a turn
        public int actionCount = 0;
        ///Rule list for the game.
        public YahtzeeRules rules;
        ///Score for the game
        public Dictionary<string, int> gameScore;
        ///Dices to be held
        public int[] heldDices;
        ///Bool to toggle dice rolling
        public bool canRollDice;

        public abstract void setHeldDie(int dieToHold);
        public abstract void clearHeldDie();
        public abstract bool IsActive();


        public abstract void PlayGame();
        public abstract void EndGame();
        public abstract string GetGameName();

        public abstract int GetMaxRounds();

        public abstract void setActionCount(int newActionCount);

        public abstract bool getDiceRollAvailability();
    }
}
