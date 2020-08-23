using Spellendoos.Classes;
using System.Collections.Generic;
using System.Windows;

namespace Spellendoos
{
    /// <summary>
    /// Interaction logic for MensErgerJeNietUI.xaml
    /// This XAML file is not used at the moment but is intended for later usage
    /// </summary>
    public partial class MensErgerJeNietUI : Window
    {
        private MensErgerJeNietWithUI MEIJN;

        public MensErgerJeNietUI(string name, List<Player> players)
        {
            InitializeComponent();
            this.MEIJN = new MensErgerJeNietWithUI("Mens erger je niet", players);

        }

        private void Throw_dice_Click(object sender, RoutedEventArgs e)
        {

        }

        private void quit_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
