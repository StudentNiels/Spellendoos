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
    /// Interaction logic for ScoreWindow.xaml
    /// </summary>
    public partial class ScoreWindow : Window
    {
        private List<String> names = new List<string>();
        public ScoreWindow()
        {
            InitializeComponent();
            addNames();
            printScore();
        }

        public void addNames()
        {
            Game g = new Game();
            foreach(Player p in g.getList())
            {
                String name = p.getPlayerName();
                names.Add(name);
            }
        }

        public void printScore()
        {
            foreach(String n in names)
            {
                Label l = new Label
                {
                    Content = n
                };
                Console.WriteLine(n);
            }
        }

        private void back_Btn_Click(object sender, RoutedEventArgs e)
        {
            GameSelector gs = new GameSelector();
            this.Visibility = Visibility.Hidden;
            gs.Show();
        }
    }
}
