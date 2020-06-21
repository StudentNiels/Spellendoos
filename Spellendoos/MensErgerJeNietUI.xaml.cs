using System.Windows;

namespace Spellendoos
{
    /// <summary>
    /// Interaction logic for MensErgerJeNietUI.xaml
    /// This XAML file is not used at the moment but is intended for later usage
    /// </summary>
    public partial class MensErgerJeNietUI : Window
    {
        private string playerName;

        public MensErgerJeNietUI()
        {
            playerName = "test";
           
            InitializeComponent();
        }

        private void Throw_dice_Click(object sender, RoutedEventArgs e)
        {

        }

        private void quit_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
