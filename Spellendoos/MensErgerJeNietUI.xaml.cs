using Spellendoos.Classes;
using System;
using System.Collections.Generic;
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
            string str1 = player1Field.Text;
            char[] spearator1 = { ' ' };
            String[] splitStr1 = str1.Split(spearator1);
            player1Field.Text = splitStr1[1];
            players[0].setPlayerName(player1Field.Text);

            player2Field.Text = players[1].playerName;
            string str2 = player2Field.Text;
            char[] spearator2 = { ' ' };
            String[] splitStr2 = str2.Split(spearator2);
            player2Field.Text = splitStr2[1];
            players[1].setPlayerName(player2Field.Text);

            player3Field.Text = players[2].playerName;
            string str3 = player3Field.Text;
            char[] spearator3 = { ' ' };
            String[] splitStr3 = str3.Split(spearator3);
            player3Field.Text = splitStr3[1];
            players[2].setPlayerName(player3Field.Text);

            player4Field.Text = players[3].playerName;
            string str4 = player4Field.Text;
            char[] spearator4 = { ' ' };
            String[] splitStr4 = str4.Split(spearator4);
            player4Field.Text = splitStr4[1];
            players[3].setPlayerName(player4Field.Text);
            
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