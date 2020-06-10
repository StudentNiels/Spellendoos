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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Spellendoos
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Player> players = new List<Player>();

        public MainWindow()
        {
            InitializeComponent();
            SplashScreen sp = new SplashScreen("SplashScreen.jpg");
            sp.Show(true);
           
        }

        public void startButton_Click(object sender, RoutedEventArgs e)
        {
            string p1 = $"{playerName1}";
            string p2 = $"{playerName2}";
            string p3 = $"{playerName3}";
            string p4 = $"{playerName4}";
           
            //Check if there are 4 players
            MessageBox.Show($"Spelers {playerName1.Text}, {playerName2.Text}, {playerName3.Text}, {playerName4.Text} gaan een spel starten, Veel plezier!");
            GameSelector gs = new GameSelector(p1, p2, p3, p4);
            this.Visibility = Visibility.Hidden;
            gs.Show();
        }


    }
}
