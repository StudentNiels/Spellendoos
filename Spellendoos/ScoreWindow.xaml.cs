using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;

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
            printScore();
        }

        public void printScore()
        {
            foreach(Player p in players)
            {
                Console.WriteLine(p.getPlayerName() + ": " + p.getWinScore());
            }
        }

        private void back_Btn_Click(object sender, RoutedEventArgs e)
        {
            GameSelector gs = new GameSelector(players);
            this.Visibility = Visibility.Hidden;
            gs.Show();
        }
    }
}