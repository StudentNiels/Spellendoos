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
            SplashScreen sp = new SplashScreen("SplashScreen.jpg");
            sp.Show(true);
            InitializeComponent();
            
        }

        public void startButton_Click(object sender, RoutedEventArgs e)
        {
            //Check if there are 4 players
            //Dit hoort waarschijnlijk te gaan via game.cs
            String p1 = $"{playerName1}";
            String p2 = $"{playerName2}"; ;
            String p3 = $"{playerName3}"; ;
            String p4 = $"{playerName4}"; ;
            players.Add(new Player() { playerName = p1 });
            players.Add(new Player() { playerName = p2 });
            players.Add(new Player() { playerName = p3 });
            players.Add(new Player() { playerName = p4 });
            MessageBox.Show($"Spelers {playerName1.Text}, {playerName2.Text}, {playerName3.Text}, {playerName4.Text} gaan een spel starten, Veel plezier!");
            GameSelector gs = new GameSelector();
            this.Visibility = Visibility.Hidden;
            gs.Show();
        }
    }
}
