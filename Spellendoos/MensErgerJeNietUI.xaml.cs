using Spellendoos.Classes;
using System.Collections.Generic;
using System.Windows;

namespace Spellendoos
{
    /// <summary>
    /// Interaction logic for MensErgerJeNietUI.xaml
    /// This .XAML file is used to start the console with the game and can be extended upon to be the game in the future
    /// </summary>
    public partial class MensErgerJeNietUI : Window
    {
        private MensErgerJeNiet MEJN;
        private GameSelector gameSelector;
        private List<Player> players;
        public MensErgerJeNietUI(string gameName, List<Player> players)
        {
            this.gameSelector = new GameSelector(players);
            this.players = players;
            InitializeComponent();
            //Player's names are set on the UI
            player1Field.Text = players[0].getPlayerName();
            player2Field.Text = players[1].getPlayerName();
            player3Field.Text = players[2].getPlayerName();
            player4Field.Text = players[3].getPlayerName();
        }

        private void InitializeComponent(string gameName, List<Player> players)
        {
            ///Wil be used to initialize components in  the future
        }

        private void Throw_dice_Click(object sender, RoutedEventArgs e)
        {
            ///Start the game in console
            this.MEJN = new MensErgerJeNiet("Mens erger je niet", this.players, 44);
            this.MEJN.PlayGame();
        }

        private void quit_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            ///To goback to the gamselector
            this.gameSelector.Show();
        }
    }
}