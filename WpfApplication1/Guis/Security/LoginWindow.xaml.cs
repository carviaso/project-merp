﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using FrontEnd;

namespace WpfApplication1.Guis.Security {
    /// <summary>
    /// Interaktionslogik für LoginWindow.xaml
    /// </summary>
    public partial class LoginWindow : Window
    {
        private MainWindow _mm;

        public LoginWindow() {
            InitializeComponent();
            _mm = new MainWindow();
            Application.Current.MainWindow = _mm;
        
        }

        private void Button_Click(object sender, RoutedEventArgs e) {
            this.Close();
            Application.Current.MainWindow.Activate();
        }
    }
}
