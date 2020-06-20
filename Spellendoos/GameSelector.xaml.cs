using Spellendoos.Classes;
using System;
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
    /// Interaction logic for GameSelector.xaml
    /// </summary>
    public partial class GameSelector : Window
    {
        public List<Player> players;

        public GameSelector(List<Player> players)
        {
            InitializeComponent();
            this.players = players;
        }

        private void Quit_Btn_Click(object sender, RoutedEventArgs e)
        {
            Environment.Exit(1);
        }

        private void Options_Btn_Click(object sender, RoutedEventArgs e)
        {
            
        }

        public void Start_Yahtzee_Click(object sender, RoutedEventArgs e)
        {
            Yahtzee Ytz = new Yahtzee("Yahtzee", players, 5, 6, 3, 13);
            Ytz.PlayGame();
        }

        private void Score_Btn_Click(object sender, RoutedEventArgs e)
        {
            ScoreWindow sw = new ScoreWindow(players);
            this.Visibility = Visibility.Hidden;
            sw.Show();
        }

        private void Start_MEJN_Click(object sender, RoutedEventArgs e)
        {
            MensErgerJeNiet MEJN = new MensErgerJeNiet("Mens erger je niet", players);
            MEJN.playGame();
        }

        public List<Player> GetPlayers()
        {
            return players;
        }
    }
}
