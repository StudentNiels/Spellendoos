using System.Collections.Generic;
using System.Windows;

namespace Spellendoos
{
    /// <summary>
    /// Interaction logic for ScoreWindow.xaml
    /// </summary>
    public partial class ScoreWindow : Window
    {
        public List<Player> players;
        public ScoreWindow(List<Player> players)
        {
            InitializeComponent();
            this.players = players;
            getScores();
        }

        private void backButton_Click(object sender, RoutedEventArgs e)
        {
            GameSelector gs = new GameSelector(players);
            this.Visibility = Visibility.Hidden;
            gs.Show();
        }

        public void getScores()
        {
            List<Player> players;
            players = this.players;
            players.Reverse();

            first_place.Content = players[0].getPlayerName();
            second_place.Content = players[1].getPlayerName();
            third_place.Content = players[2].getPlayerName();
            fourth_place.Content = players[3].getPlayerName();

            first_placepoints.Content = players[0].getWinScore();
            second_placepoints.Content = players[1].getWinScore();
            third_placepoints.Content = players[2].getWinScore();
            fourth_placepoints.Content = players[3].getWinScore();
        }
    }
}
