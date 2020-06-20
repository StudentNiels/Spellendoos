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
    /// Interaction logic for MensErgerJeNiet.xaml
    /// </summary>
    public partial class MensErgerJeNietUI : Window  
    {
        public string playerName;
        public MensErgerJeNietUI(string name, List<Player> players)
        {
            playerName = "test";
           
            InitializeComponent();
        }



        private void InitializeComponent()
        {
            throw new NotImplementedException();
        }


        private void quit_Click(object sender, RoutedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private static void EndGame()
        {
            throw new NotImplementedException();
        }

        private void Throw_dice_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
