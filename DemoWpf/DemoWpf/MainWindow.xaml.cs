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
                    case "11":
                    case "12":
                    case "13":
                    case "14":
                    case "15":
                    case "16":
                        screen.Text += knapp.Content;
                        break;
                    default:
                        break;
                }
            }


        }

        private void button_variables_click(object sender, RoutedEventArgs e)
        {
            if (sender is Button knapp)
            {
                switch (knapp.Content)
                {
                    case "1":
                    case "2":
                    case "3":
                    case "4":
                        screen.Text += knapp.Content.ToString();

                        break;
                    default:
                        break;
                }
                screen.Text += knapp.Content.ToString();
            }
        }

        private void button_result(object sender, RoutedEventArgs e)
        {
            String divisonDefiniton;
            int indexNumber = 0;

            if (screen.Text.Contains("+"))
            {
                indexNumber = screen.Text.IndexOf("+");
            }

            if (screen.Text.Contains("-"))
            {
                indexNumber = screen.Text.IndexOf("-");
            }

            if (screen.Text.Contains("-"))
            {
                indexNumber = screen.Text.IndexOf("-");
            }

            if (screen.Text.Contains("*"))
            {
                indexNumber = screen.Text.IndexOf("*");
            }

            if (screen.Text.Contains("/"))
            {
                indexNumber = screen.Text.IndexOf("/");
            }

            divisonDefiniton = screen.Text.Substring(indexNumber, 1);
            double firstNumber = Convert.ToDouble(screen.Text.Substring(0, indexNumber));
            double SecondNumber = Convert.ToDouble(screen.Text.Substring(indexNumber + 1, screen.Text.Length - indexNumber - 1));

            if (divisonDefiniton == "+")
            {
                screen.Text += "=" + (firstNumber + SecondNumber);
            }

            if (divisonDefiniton == "-")
            {
                screen.Text += "=" + (firstNumber - SecondNumber);
            }

            if (divisonDefiniton == "*")
            {
                screen.Text += "=" + (firstNumber * SecondNumber);
            }

            if (divisonDefiniton == "/")
            {
                screen.Text += "=" + (firstNumber / SecondNumber);
            }


        }

        private void button_clearing(object sender, RoutedEventArgs e)
        {
            screen.Text = "";

        }




    }
    }

    

