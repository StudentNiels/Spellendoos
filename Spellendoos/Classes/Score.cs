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
            for(int i = 0; i < 4; i ++)
            {
                Label label = new Label();
                labelScores.Add(label);
            }
            for (int i = 0; i < players.Count; i++)
            {
                Player p = new Player(players[i].getPlayerName());
                labelScores[i].Content += p.getPlayerName() + ": " + p.getWinScore().ToString();
            }

            sw.score_1 = new Label();
            sw.score_2 = new Label();
            sw.score_3 = new Label();
            sw.score_4 = new Label();


            sw.score_1.Content = labelScores[0].Content;
            sw.score_2.Content = labelScores[1].Content;
            sw.score_3.Content = labelScores[2].Content;
            sw.score_4.Content = labelScores[3].Content;
        }
    }
}
