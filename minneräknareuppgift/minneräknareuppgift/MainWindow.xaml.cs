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

namespace minneräknareuppgift
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
           
            //För att få ut 1-9 i själva screen, använder switch för att see vad knapp.content är och baserad på det skriver det ut i screen.
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
                        screen.Text += knapp.Content;
                        break;
                    default:
                        break;
                }
            }


        }

        //När man klickar på "+" kollar den först om if-satsen nedant passar, satsen ser till att man inte skriver ut massor av "+" t.ex, eller om man inte skriver ut + när det ej finns några number
        // för att kolla om det är tomt kollar !string.isnullorempty om är ej tomt, och baserad på det skriver ut + eller ej
        private void button_variables_click_plus(object sender, RoutedEventArgs e)
        {
            if (!screen.Text.Contains('+') && !String.IsNullOrEmpty(screen.Text) && !screen.Text.Contains('-') && !screen.Text.Contains('/') && !screen.Text.Contains('*') && !screen.Text.Contains('√') && !screen.Text.Contains('^'))
            {
                screen.Text += "+";
            }
        }

        private void button_variables_click_minus(object sender, RoutedEventArgs e)
        {
            if (!screen.Text.Contains('+') && !String.IsNullOrEmpty(screen.Text) && !screen.Text.Contains('-') && !screen.Text.Contains('/') && !screen.Text.Contains('*') && !screen.Text.Contains('√') && !screen.Text.Contains('^'))
            {
                screen.Text += "-";
            }
        }

        private void button_variables_click_times(object sender, RoutedEventArgs e)
        {
            if (!screen.Text.Contains('+') && !String.IsNullOrEmpty(screen.Text) && !screen.Text.Contains('-') && !screen.Text.Contains('/') && !screen.Text.Contains('*') && !screen.Text.Contains('√') && !screen.Text.Contains('^'))
            {
                screen.Text += "*";
            }
        }

        private void button_variables_click_division(object sender, RoutedEventArgs e)
        {
            if (!screen.Text.Contains('+') && !String.IsNullOrEmpty(screen.Text) && !screen.Text.Contains('-') && !screen.Text.Contains('/') && !screen.Text.Contains('*') && !screen.Text.Contains('√') && !screen.Text.Contains('^'))
            {
                screen.Text += "/";
            }
        }

        // Tar bort !string.nullorempty här så att att man kunna skriva ut rotenur från början
        private void button_variables_click_square(object sender, RoutedEventArgs e)
        {
            if (!screen.Text.Contains('+') && !screen.Text.Contains('-') && !screen.Text.Contains('/') && !screen.Text.Contains('*') && !screen.Text.Contains('√') && !screen.Text.Contains('^'))
            {
                screen.Text += "√";
            }
        }

        private void button_variables_click_elevated(object sender, RoutedEventArgs e)
        {
            if (!screen.Text.Contains('+') && !String.IsNullOrEmpty(screen.Text) && !screen.Text.Contains('-') && !screen.Text.Contains('/') && !screen.Text.Contains('*') && !screen.Text.Contains('√') && !screen.Text.Contains('^'))
            {
                screen.Text += "^";
            }
        }



        private void button_result(object sender, RoutedEventArgs e)
        {

            // indexnumber ska se vad t.ex "+" är så att man kan sepera de två numbren som finns i screen
            int indexNumber = 0;
           


            if (screen.Text.Contains("+"))
            {
                indexNumber = screen.Text.IndexOf("+");
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

            if (screen.Text.Contains("√"))
            {
                indexNumber = screen.Text.IndexOf("√");
            }
            

            if (screen.Text.Contains("^"))
            {
                indexNumber = screen.Text.IndexOf("^");
            }

            button_result_caculation(indexNumber);

        }

        private void button_result_caculation(int indexNumber)
        {
            //DivisonDefniniton ska användas för att se vilken räknesätt det ska var aför senare
            String divisonDefiniton;

            //Anger vilken division jag ska använda till senare
            divisonDefiniton = screen.Text.Substring(indexNumber, 1);

            //här kollar vilka tal ska användas, firstnumber är talet till vänster av vad devisionen är och secondnumber är talet till höger av vad devisionen är.
            double firstNumber = 0;
            string substring = screen.Text.Substring(0, indexNumber);

            //if-satsen användas för att kolla om substringet är ett number eller inte, om det är så ska firstnumber användas.
            // Om ej, förblir firstnumber till 0 och secondnumber är det enda variablen som används
            if (double.TryParse(substring, out _))
            {
                firstNumber = Convert.ToDouble(substring);
            }
            string substring2 = screen.Text.Substring(indexNumber + 1);
            double SecondNumber = Convert.ToDouble(substring2);

            button_result_implimiation(firstNumber, substring, divisonDefiniton, substring2, SecondNumber);

        }

        private void button_result_implimiation(double firstNumber, string substring, string divisonDefiniton, string substring2, double SecondNumber)
        {
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

            if (divisonDefiniton == "√")
            {
                screen.Text += "=" + (Math.Sqrt(SecondNumber));
            }

            if (divisonDefiniton == "^")
            {
                screen.Text += "=" + (Math.Pow(firstNumber, SecondNumber));
            }
        }



        private void button_clearing(object sender, RoutedEventArgs e)
        {
            screen.Text = "";
        }

        private void button_dot_click(object sender, RoutedEventArgs e)
        {
           
                screen.Text += ",";
           

        }

        private void button_empty(object sender, RoutedEventArgs e)
        {

        }


    }
}
    


