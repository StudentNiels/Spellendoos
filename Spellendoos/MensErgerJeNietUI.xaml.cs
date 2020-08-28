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
        private MensErgerJeNietWithUI MEJN;

        public MensErgerJeNietUI(string gameName, List<Player> players)
        {
            InitializeComponent();
            //Player's names are set on the UI
            player1Field.Text = players[0].getPlayerName();
            player2Field.Text = players[1].getPlayerName();
            player3Field.Text = players[2].getPlayerName();
            player4Field.Text = players[3].getPlayerName();

            ///add pawns to board
            ///ObservableCollection<Pawn> pieces = new ObservableCollection<Pawn>();
            //pieces.Add(
            ///    new Pawn { Row = 0, Column = 0, Fill = new SolidColorBrush(Colors.BlanchedAlmond) });
            ///pieces.Add(
            ///    new Pawn { Row = 7, Column = 7, Fill = new SolidColorBrush(Colors.RosyBrown) });
            ///pieces.Add(
            ///    new Pawn { Row = 3, Column = 4, Fill = new SolidColorBrush(Colors.BlueViolet) });
            ///pieces.Add(
            ///    new Pawn { Row = 5, Column = 4, Fill = new SolidColorBrush(Colors.Orange) });

            ///board.DataContext = pieces;

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
            this.MEJN = new MensErgerJeNietWithUI("Mens erger je niet", players);
            Image img = CreateImage("Assets/Red-pawn.png");

            
        }

        private void Throw_dice_Click(object sender, RoutedEventArgs e)
        {

        }

        private void quit_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
        }
    }
}