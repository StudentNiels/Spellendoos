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
        public GameSelector()
        {
            InitializeComponent();
        }

        private void quit_Btn_Click(object sender, RoutedEventArgs e)
        {
            Environment.Exit(1);
        }

        private void options_Btn_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void start_Yahtzee_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
