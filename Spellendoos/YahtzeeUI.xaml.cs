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
    /// YahtzeeUI is not yet combined together with YahtzeeWithUI.
    /// </summary>
    public partial class YahtzeeUI : Window
    {
        private YahtzeeWithUI Y;
        public List<Player> players;
        public List<string> scoreNames;

        public List<TextBlock> player1Fields;
        public List<string> player2Fields;
        public List<string> player3Fields;
        public List<string> player4Fields;

        public YahtzeeUI(List<Player> players)
        {
            InitializeComponent();
            this.Y = new YahtzeeWithUI("Yahtzee", players, 5, 6, 3, 13);
            this.players = players;
            this.scoreNames = new List<string>();
            this.player1Fields = new List<TextBlock>();
            this.player2Fields = new List<string>();
            this.player3Fields = new List<string>();
            this.player4Fields = new List<string>();


            //Player's names are set on the UI
            player1Field.Text = players[0].getPlayerName(); 
            player2Field.Text = players[1].getPlayerName();
            player3Field.Text = players[2].getPlayerName();
            player4Field.Text = players[3].getPlayerName();

            setupGame();
            Y.PlayGame();
        }

        private void YhtzRollDice_Click(object sender, RoutedEventArgs e)
        {
            if (Y.getDiceRollAvailability() == true)
            {
                int[] results = Y.RollDice();
                BitmapImage BM1 = new BitmapImage();
                BM1.BeginInit();
                BM1.UriSource = new Uri($"Assets/dob{results[0]}.png", UriKind.RelativeOrAbsolute);
                BM1.EndInit();
                this.diceImage1.Source = BM1;

                BitmapImage BM2 = new BitmapImage();
                BM2.BeginInit();
                BM2.UriSource = new Uri($"Assets/dob{results[1]}.png", UriKind.RelativeOrAbsolute);
                BM2.EndInit();
                this.diceImage2.Source = BM2;

                BitmapImage BM3 = new BitmapImage();
                BM3.BeginInit();
                BM3.UriSource = new Uri($"Assets/dob{results[2]}.png", UriKind.RelativeOrAbsolute);
                BM3.EndInit();
                this.diceImage3.Source = BM3;

                BitmapImage BM4 = new BitmapImage();
                BM4.BeginInit();
                BM4.UriSource = new Uri($"Assets/dob{results[3]}.png", UriKind.RelativeOrAbsolute);
                BM4.EndInit();
                this.diceImage4.Source = BM4;

                BitmapImage BM5 = new BitmapImage();
                BM5.BeginInit();
                BM5.UriSource = new Uri($"Assets/dob{results[4]}.png", UriKind.RelativeOrAbsolute);
                BM5.EndInit();
                this.diceImage5.Source = BM5;


                IEnumerable<string> distinctResults = Y.getAllScoreTypes(results).Distinct();
                IEnumerable<string> distinctScoreResults = Y.getAllScores(results).Distinct();
                int dRAmount = distinctResults.Count();
                int dSRAmount = distinctScoreResults.Count();
                int times = 1;




                foreach (string scoreN in this.scoreNames)
                {
                    for (int i = 0; i < this.scoreNames.Count(); i++)
                    {
                        foreach (TextBlock player1Field in player1Fields)
                        {
                            
                            if (dRAmount > times || dSRAmount > times)
                            {
                                Console.Write("a");
                                //Console.WriteLine(distinctResults.ElementAt(dRAmount) + "score N");
                                //if (scoreN == distinctResults.ElementAt(dRAmount))
                                //{
                                 //   times++;
                                //    if (distinctScoreResults.ElementAt(dSRAmount) != "0")
                                 //   {
                                 //       player1Field.Text = distinctScoreResults.ElementAt(dSRAmount);
                                    
                                 //   }

                                //}
                            }
                            else
                            {
                                player1Field.Text = "0";
                            }
                        }
                    }
                }
                Y.actionCount++;
            }
        }

        private void HoldBtn1(object sender, RoutedEventArgs e)
        {
            Y.setHeldDie(0);
        }

        private void HoldBtn2(object sender, RoutedEventArgs e)
        {
            Y.setHeldDie(1);
        }

        private void HoldBtn3(object sender, RoutedEventArgs e)
        {
            Y.setHeldDie(2);
        }
        private void HoldBtn4(object sender, RoutedEventArgs e)
        {
            Y.setHeldDie(3);
        }
        private void HoldBtn5(object sender, RoutedEventArgs e)
        {
            Y.setHeldDie(4);
        }
        private void BackToGameSelector_Click(object sender, RoutedEventArgs e)
        {
            GameSelector gs = new GameSelector(players);
            this.Visibility = Visibility.Hidden;
            gs.Show();
        }

        private void EndTurn_Click(object sender, RoutedEventArgs e)
        {
            ///Set action count to 3 so the player's turn ends.
           // Y.setActionCount(3);
        }

        private List<string> setupGame()
        {
            //add corresponding fields to be used when filling in scores
            this.player1Fields.Add(onesPlayer1);
            this.player1Fields.Add(twosPlayer1);
            this.player1Fields.Add(threesPlayer1);
            this.player1Fields.Add(foursPlayer1);
            this.player1Fields.Add(fivesPlayer1);
            this.player1Fields.Add(sixesPlayer1);
            this.player1Fields.Add(sumPlayer1);
            this.player1Fields.Add(bonusPlayer1);
            this.player1Fields.Add(ThreeKindPlayer1);
            this.player1Fields.Add(FourKindPlayer1);
            this.player1Fields.Add(FullHousePlayer1);
            this.player1Fields.Add(SmallStraightPlayer1);
            this.player1Fields.Add(LargeStraightPlayer1);
            this.player1Fields.Add(ChancePlayer1);
            this.player1Fields.Add(YahtzeePlayer1);
            this.player1Fields.Add(TotalScorePlayer1);

            this.player2Fields.Add("onesPlayer2");
            this.player2Fields.Add("twosPlayer2");
            this.player2Fields.Add("threesPlayer2");
            this.player2Fields.Add("foursPlayer2");
            this.player2Fields.Add("fivesPlayer2");
            this.player2Fields.Add("sixesPlayer2");
            this.player2Fields.Add("sumPlayer2");
            this.player2Fields.Add("bonusPlayer2");
            this.player2Fields.Add("ThreeKindPlayer2");
            this.player2Fields.Add("FourKindPlayer2");
            this.player2Fields.Add("FullHousePlayer2");
            this.player2Fields.Add("SmallStraightPlayer2");
            this.player2Fields.Add("LargeStraightPlayer2");
            this.player2Fields.Add("ChancePlayer2");
            this.player2Fields.Add("YahtzeePlayer2");
            this.player2Fields.Add("TotalScorePlayer2");

            this.player3Fields.Add("onesPlayer3");
            this.player3Fields.Add("twosPlayer3");
            this.player3Fields.Add("threesPlayer3");
            this.player3Fields.Add("foursPlayer3");
            this.player3Fields.Add("fivesPlayer3");
            this.player3Fields.Add("sixesPlayer3");
            this.player3Fields.Add("sumPlayer3");
            this.player3Fields.Add("bonusPlayer3");
            this.player3Fields.Add("ThreeKindPlayer3");
            this.player3Fields.Add("FourKindPlayer3");
            this.player3Fields.Add("FullHousePlayer3");
            this.player3Fields.Add("SmallStraightPlayer3");
            this.player3Fields.Add("LargeStraightPlayer3");
            this.player3Fields.Add("ChancePlayer3");
            this.player3Fields.Add("YahtzeePlayer3");
            this.player3Fields.Add("TotalScorePlayer3");

            this.player4Fields.Add("onesPlayer4");
            this.player4Fields.Add("twosPlayer4");
            this.player4Fields.Add("threesPlayer4");
            this.player4Fields.Add("foursPlayer4");
            this.player4Fields.Add("fivesPlayer4");
            this.player4Fields.Add("sixesPlayer4");
            this.player4Fields.Add("sumPlayer4");
            this.player4Fields.Add("bonusPlayer4");
            this.player4Fields.Add("ThreeKindPlayer4");
            this.player4Fields.Add("FourKindPlayer4");
            this.player4Fields.Add("FullHousePlayer4");
            this.player4Fields.Add("SmallStraightPlayer4");
            this.player4Fields.Add("LargeStraightPlayer4");
            this.player4Fields.Add("ChancePlayer4");
            this.player4Fields.Add("YahtzeePlayer4");
            this.player4Fields.Add("TotalScorePlayer4");

            this.scoreNames.Add("Ones");
            this.scoreNames.Add("Twos");
            this.scoreNames.Add("Threes");
            this.scoreNames.Add("Fours");
            this.scoreNames.Add("Fives");
            this.scoreNames.Add("Sixes");
            this.scoreNames.Add("Sum");
            this.scoreNames.Add("Bonus");
            this.scoreNames.Add("Three of a kind");
            this.scoreNames.Add("Four of a kind");
            this.scoreNames.Add("Full House");
            this.scoreNames.Add("Small Straight");
            this.scoreNames.Add("Large Straight");
            this.scoreNames.Add("Chance");
            this.scoreNames.Add("Yahtzee");

            return this.scoreNames;
        }


    }
}
