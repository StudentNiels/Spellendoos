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
        public YahtzeeUI(List<Player> players)
        {
            InitializeComponent();
            this.Y = new YahtzeeWithUI("Yahtzee", players, 5, 6, 3, 13);
            
                //Player's names are set on the UI
                player1Field.Text = players[0].getPlayerName(); 
                player2Field.Text = players[1].getPlayerName();
                player3Field.Text = players[2].getPlayerName();
                player4Field.Text = players[3].getPlayerName();
        }

        private void YhtzRollDice_Click(object sender, RoutedEventArgs e)
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
        private void startYhtzBtn_Click(object sender, RoutedEventArgs e)
        {
            this.Y.PlayGame();
        }
    }
}
