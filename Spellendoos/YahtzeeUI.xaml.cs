﻿using System;
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
                //string str1 = player1Field.Text;
                //char[] spearator1 = { ' ' };
                //String[] splitStr1 = str1.Split(spearator1);
                //player1Field.Text = splitStr1[1];
                //players[0].setPlayerName(player1Field.Text);

                player2Field.Text = players[1].playerName;

                player3Field.Text = players[2].playerName;

                player4Field.Text = players[3].playerName;
        }

        private void YhtzRollDice_Click(object sender, RoutedEventArgs e)
        {
            int[] results = Y.RollDice();
            diceImage1.Source = new BitmapImage(new Uri($"Assets/dob{results[0]}.png"));
            diceImage2.Source = new BitmapImage(new Uri($"Assets/dob{results[1]}.png"));
            diceImage3.Source = new BitmapImage(new Uri($"Assets/dob{results[2]}.png"));
            diceImage4.Source = new BitmapImage(new Uri($"Assets/dob{results[3]}.png"));
            diceImage5.Source = new BitmapImage(new Uri($"Assets/dob{results[4]}.png"));
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
        private void startYhtzBtn_Click(object sender, RoutedEventArgs e)
        {
            this.Y.PlayGame();
        }
    }
}
