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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Spellendoos
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            SplashScreen sp = new SplashScreen("SplashScreen.jpg");
            sp.Show(true);
            InitializeComponent();
            
        }

        public void startButton_Click(object sender, RoutedEventArgs e)
        {
            
            MessageBox.Show($"Spelers {playerName1.Text}, {playerName2.Text}, {playerName3.Text}, {playerName4.Text} gaan een spel starten, Veel plezier!");
            GameSelector gs = new GameSelector();
            this.Visibility = Visibility.Hidden;
            gs.Show();
        }
    }
}
