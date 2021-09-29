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

namespace WpfApp7.View
{
    /// <summary>
    /// Логика взаимодействия для MenuWindow.xaml
    /// </summary>
    public partial class MenuWindow : Window
    {
        public MenuWindow()
        {
            InitializeComponent();
        }

        private void btAddGame_Click(object sender, RoutedEventArgs e)
        {
            AddGameWindow add = new AddGameWindow();
            add.Show();
            this.Close();
        }

        private void btAllGame_Click(object sender, RoutedEventArgs e)
        {
            AllGameWindow all = new AllGameWindow();
            all.Show();
            this.Close();
        }

        private void btBack_Click(object sender, RoutedEventArgs e)
        {
            MainWindow main = new MainWindow();
            main.Show();
            this.Close();
        }
    }
}
