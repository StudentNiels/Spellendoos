using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Spellendoos.Classes
{
    class Score
    {
        private readonly List<Player> players;
        private ScoreWindow sw = new ScoreWindow();

        public Score(List<Player> players)
        {
            this.players = players;
        }

        public void printScore()
        {
            List<Label> labelScores = new List<Label>();
            Label[] labels = new Label[4];
            labelScores.AddRange(labels);
            for (int i = 0; i < players.Count; i++)
            {
                Player p = new Player(players[i].getPlayerName());
                labelScores[i].Content = p.getPlayerName() + ": " + p.getWinScore().ToString();
                sw.Panel.Children.Add(labelScores[i]);
            }
        }
    }
}
