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

namespace Zeus
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Btn_login(object sender, RoutedEventArgs e)
        {
            forms.overview ov = new forms.overview();
            ov.Show();

            this.Close();
        }

        private void Btn_settings(object sender, RoutedEventArgs e)
        {
            forms.Settings se = new forms.Settings();
            se.Show();
        }
    }
}
