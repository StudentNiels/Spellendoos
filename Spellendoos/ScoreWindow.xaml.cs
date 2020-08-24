using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

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

            /*first_place.Content = players[0].getPlayerName();
            string str1 = first_place.Content.ToString();
            char[] spearator1 = { ' ' };
            String[] splitStr1 = str1.Split(spearator1);
            first_place.Content = splitStr1[1];
            players[0].setPlayerName(first_place.Content.ToString());

            second_place.Content = players[1].getPlayerName();
            string str2 = second_place.Content.ToString();
            char[] spearator2 = { ' ' };
            String[] splitStr2 = str2.Split(spearator2);
            second_place.Content = splitStr2;
            players[1].setPlayerName(second_place.Content.ToString());

            third_place.Content = players[2].getPlayerName();
            string str3 = third_place.Content.ToString();
            char[] spearator3 = { ' ' };
            String[] splitStr3 = str3.Split(spearator3);
            third_place.Content = splitStr3;
            players[2].setPlayerName(third_place.Content.ToString());

            fourth_place.Content = players[3].getPlayerName();
            string str4 = fourth_place.Content.ToString();
            char[] spearator4 = { ' ' };
            String[] splitStr4 = str4.Split(spearator4);
            fourth_place.Content = splitStr4;
            players[3].setPlayerName(fourth_place.Content.ToString());*/

            first_place.Content = players[0].getPlayerName();

            first_placepoints.Content = players[0].getWinScore();
            second_placepoints.Content = players[1].getWinScore();
            third_placepoints.Content = players[2].getWinScore();
            fourth_placepoints.Content = players[3].getWinScore();
        }
    }
}
