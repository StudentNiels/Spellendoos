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
    /// Interaction logic for YahtzeeUI.xaml
    /// </summary>
    public partial class YahtzeeUI : Window
    {
        public List<Player> players;
        public YahtzeeUI(List<Player> players)
        {
            InitializeComponent();
            this.players = players;
            YahtzeeWithUI YtzWUI = new YahtzeeWithUI("Yahtzee", players, 5, 6, 3, 5);
            YtzWUI.PlayGame();

        }

        public void YhtzRollDice_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void HoldBtn1(object sender, RoutedEventArgs e)
        {

        }

        private void HoldBtn2(object sender, RoutedEventArgs e)
        {

        }

        private void HoldBtn3(object sender, RoutedEventArgs e)
        {

        }
        private void HoldBtn4(object sender, RoutedEventArgs e)
        {

        }
        private void HoldBtn5(object sender, RoutedEventArgs e)
        {

        }
    }
}
