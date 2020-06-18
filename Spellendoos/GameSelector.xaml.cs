using System;
using System.Collections.Generic;
using System.Windows;

namespace Spellendoos
{
    /// <summary>
    /// Interaction logic for GameSelector.xaml
    /// </summary>
    public partial class GameSelector : Window
    {
        private List<Player> players;

        public GameSelector(List<Player> players)
        {
            InitializeComponent();
            this.players = players;
        }

        public void Quit_Btn_Click(object sender, RoutedEventArgs e)
        {
            Environment.Exit(1);
        }

        public void Options_Btn_Click(object sender, RoutedEventArgs e)
        {
            
        }

        public void Start_Yahtzee_Click(object sender, RoutedEventArgs e)
        {
            Yahtzee Ytz = new Yahtzee("Yahtzee", players, 5, 6, 3, 13);
            Ytz.IsActive();
        }

        public void Score_Btn_Click(object sender, RoutedEventArgs e)
        {
            ScoreWindow sw = new ScoreWindow(players);
            this.Visibility = Visibility.Hidden;
            sw.Show();
        }

        public void Start_MEJN_Click(object sender, RoutedEventArgs e)
        {
            MensErgerJeNiet MEJN = new MensErgerJeNiet("Mens erger je niet", players);
            MensErgerJeNiet.IsActive();
        }
    }
}
