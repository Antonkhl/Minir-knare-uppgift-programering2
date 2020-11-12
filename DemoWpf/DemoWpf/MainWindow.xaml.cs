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

namespace DemoWpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();


        }

        private void button_click(object sender, RoutedEventArgs e)
        {
            if (sender is Button knapp)
            {
                switch (knapp.Content)
                {
                    case "1":
                    case "2":
                    case "3":
                    case "4":
                    case "5":
                    case "6":
                    case "7":
                    case "8":
                    case "9":
                    case "10":


                        screen.Text += knapp.Content;
                        break;
                    default:
                        break;
                }
            }


        }

        private void button_dot_text(object sender, RoutedEventArgs e)
        {
            if (sender is Button)
            {
                screen.Text += ".";
            }


        }
    }

    private void button_clear_text(object sender, RoutedEventArgs e)
    {
        if (sender is Button)
        {
            screen.Text += String.Empty;
        }
    }
}
    
