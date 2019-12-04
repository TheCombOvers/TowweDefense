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

namespace TowerDefenseGUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainMenu : Window
    {
        public bool cheat = true;
        public bool load = false;
        public MainMenu()
        {
            InitializeComponent();
        }

        private void PlayButton_Click(object sender, RoutedEventArgs e)
        {
            //DifficultyPage diffPage = new DifficultyPage();
            //this.Content = diffPage;

            // Run code to open difficulty selection and map selection window
            // If page closes without finishing, return;
            // else:
            // Start Game with current variables and selections

            // For Alpha, just launch Game Window

            DifficultyPage diffPage = new DifficultyPage();
            this.Content = diffPage;
                           
        }

        private void HighScoreButton_Click(object sender, RoutedEventArgs e)
        {
            // Bring up the High Score screen
            var newMenu = new HighScoresWindow();
            newMenu.ShowDialog();
        }

        private void HelpButton_Click(object sender, RoutedEventArgs e)
        {
            // Bring up the Help Menu
            var newMenu = new HelpWindow();
            newMenu.ShowDialog();
        }

        private void AboutButton_Click(object sender, RoutedEventArgs e)
        {
            // Bring up the wiki page in a browser
            System.Diagnostics.Process.Start("https://github.com/TheCombOvers/TowerDefense/wiki");
        }

        private void LoadButton_Click(object sender, RoutedEventArgs e)
        {
            // if we're loading a old save then pass in true for isLoad, else pass false
            load = sender == LoadButton ? true : false;
            var gameWindow = new GameWindow(cheat, load);
            gameWindow.Show();
            Close();

        }
    }
}