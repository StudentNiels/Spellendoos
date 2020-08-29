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
    /// YahtzeeUI is not yet combined together with YahtzeeWithUI.
    /// </summary>
    public partial class YahtzeeUI : Window
    {
        private YahtzeeWithUI Y;
        public List<Player> players;
        public YahtzeeUI(List<Player> players)
        {
            InitializeComponent();
            this.Y = new YahtzeeWithUI("Yahtzee", players, 5, 6, 3, 13);
            this.players = players;

                //Player's names are set on the UI
                player1Field.Text = players[0].getPlayerName(); 
                player2Field.Text = players[1].getPlayerName();
                player3Field.Text = players[2].getPlayerName();
                player4Field.Text = players[3].getPlayerName();

            setupGame();
        }

        private void YhtzRollDice_Click(object sender, RoutedEventArgs e)
        {
            if (Y.getDiceRollAvailability() == true)
            {

                int[] results = Y.RollDice();

                BitmapImage BM1 = new BitmapImage();
                BM1.BeginInit();
                BM1.UriSource = new Uri($"Assets/dob{results[0]}.png", UriKind.RelativeOrAbsolute);
                BM1.EndInit();
                this.diceImage1.Source = BM1;

                BitmapImage BM2 = new BitmapImage();
                BM2.BeginInit();
                BM2.UriSource = new Uri($"Assets/dob{results[1]}.png", UriKind.RelativeOrAbsolute);
                BM2.EndInit();
                this.diceImage2.Source = BM2;

                BitmapImage BM3 = new BitmapImage();
                BM3.BeginInit();
                BM3.UriSource = new Uri($"Assets/dob{results[2]}.png", UriKind.RelativeOrAbsolute);
                BM3.EndInit();
                this.diceImage3.Source = BM3;

                BitmapImage BM4 = new BitmapImage();
                BM4.BeginInit();
                BM4.UriSource = new Uri($"Assets/dob{results[3]}.png", UriKind.RelativeOrAbsolute);
                BM4.EndInit();
                this.diceImage4.Source = BM4;

                BitmapImage BM5 = new BitmapImage();
                BM5.BeginInit();
                BM5.UriSource = new Uri($"Assets/dob{results[4]}.png", UriKind.RelativeOrAbsolute);
                BM5.EndInit();
                this.diceImage5.Source = BM5;

                Y.getAllScores(results);
                Y.actionCount++;
            }
        }

        private void HoldBtn1(object sender, RoutedEventArgs e)
        {
            Y.setHeldDie(0);
        }

        private void HoldBtn2(object sender, RoutedEventArgs e)
        {
            Y.setHeldDie(1);
        }

        private void HoldBtn3(object sender, RoutedEventArgs e)
        {
            Y.setHeldDie(2);
        }
        private void HoldBtn4(object sender, RoutedEventArgs e)
        {
            Y.setHeldDie(3);
        }
        private void HoldBtn5(object sender, RoutedEventArgs e)
        {
            Y.setHeldDie(4);
        }
        private void BackToGameSelector_Click(object sender, RoutedEventArgs e)
        {
            GameSelector gs = new GameSelector(players);
            this.Visibility = Visibility.Hidden;
            gs.Show();
        }

        private void EndTurn_Click(object sender, RoutedEventArgs e)
        {
            ///Set action count to 3 so the player's turn ends.
           // Y.setActionCount(3);
        }

        private void setupGame()
        {
            List<string> scoreNames = new List<string>();

            scoreNames.Add("Three of a kind");
            scoreNames.Add("Four of a kind");
            scoreNames.Add("Full House");
            scoreNames.Add("Small Straight");
            scoreNames.Add("Large Straight");
            scoreNames.Add("Chance");
            scoreNames.Add("Yahtzee");
        }
    }
}
