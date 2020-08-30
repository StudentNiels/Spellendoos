using Spellendoos.Classes;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace Spellendoos
{
    /// <summary>
    /// Interaction logic for MensErgerJeNietUI.xaml
    /// This XAML file is not used at the moment but is intended for later usage
    /// </summary>
    public partial class MensErgerJeNietUI : Window
    {
        private MensErgerJeNiet MEJN;
        private List<Player> players;
        public MensErgerJeNietUI(string gameName, List<Player> players)
        {
            this.players = players;
            InitializeComponent();
            //Player's names are set on the UI
            player1Field.Text = players[0].getPlayerName();
            player2Field.Text = players[1].getPlayerName();
            player3Field.Text = players[2].getPlayerName();
            player4Field.Text = players[3].getPlayerName();

            

        }

        private Image CreateImage(string imgSource)
        {
            Image pawn = new Image();
            pawn.Width = 36;
            pawn.Height = 38;
            ImageSource pawnImage = new BitmapImage(new Uri(imgSource));
            pawn.Source = pawnImage;
            return pawn;
        }

        private void InitializeComponent(string gameName, List<Player> players)
        {
            
            Image img = CreateImage("Assets/Red-pawn.png");
        }

        private void Throw_dice_Click(object sender, RoutedEventArgs e)
        {
            this.MEJN = new MensErgerJeNiet("Mens erger je niet", this.players, 44);
            this.MEJN.PlayGame();
        }

        private void quit_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
        }
    }
}