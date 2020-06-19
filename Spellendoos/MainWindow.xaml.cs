using System.Collections.Generic;
using System.Windows;

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
            SplashScreen sp = new SplashScreen("Assets/SplashScreen.jpg");
            InitializeComponent();
            sp.Show(true);
        }

        public void StartButton_Click(object sender, RoutedEventArgs e)
        {
            string p1 = $"{playerName1}";
            string p2 = $"{playerName2}";
            string p3 = $"{playerName3}";
            string p4 = $"{playerName4}";

            Player pl1 = new Player(p1);
            Player pl2 = new Player(p2);
            Player pl3 = new Player(p3);
            Player pl4 = new Player(p4);

            this.players.Add(pl1);
            this.players.Add(pl2);
            this.players.Add(pl3);
            this.players.Add(pl4);

            //Check if there are 4 players
            MessageBox.Show($"Spelers {playerName1.Text}, {playerName2.Text}, {playerName3.Text}, {playerName4.Text} gaan een spel starten, Veel plezier!");
            GameSelector gs = new GameSelector(players);
            this.Visibility = Visibility.Hidden;
            gs.Show();
        }

        public static List<Player> getPlayers()
        {
            MainWindow mw = new MainWindow();
            List<Player> players = mw.players;

            return players;
        }
    }
}
