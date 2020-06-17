using Spellendoos.Classes;
using System.Collections.Generic;
using System.Windows;

namespace Spellendoos
{
    /// <summary>
    /// Interaction logic for ScoreWindow.xaml
    /// </summary>
    public partial class ScoreWindow : Window
    {
        private List<Player> players;
        private Score score;
        public ScoreWindow(List<Player> players)
        {
            InitializeComponent();
            this.players = players;
            score = new Score(this.players);
            score.printScore();
        }

        public ScoreWindow() { }

        private void back_Btn_Click(object sender, RoutedEventArgs e)
        {
            GameSelector gs = new GameSelector(players);
            this.Visibility = Visibility.Hidden;
            gs.Show();
        }
    }
}