using System;
using System.Data;
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


namespace Сalculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string input = string.Empty;
        string operand1 = string.Empty;
        string operand2 = string.Empty;
        char operation;
        double result = 0.0;
        public MainWindow()
        {
            InitializeComponent();
        }
        private void ButtonAC(object sender, RoutedEventArgs e)
        {
            textLabel.Text = "";
            input = string.Empty;
            operand1 = string.Empty;
            operand2 = string.Empty;
        }

        private void NumberClick0(object sender, RoutedEventArgs e)
        {
            textLabel.Text = "";
            input += "0";
            textLabel.Text += input;
        }

        private void NumberClick1(object sender, RoutedEventArgs e)
        {
            textLabel.Text = "";
            input += "1";
            textLabel.Text += input;
        }

        private void NumberClick2(object sender, RoutedEventArgs e)
        {
            textLabel.Text = "";
            input += "2";
            textLabel.Text += input;
        }

        private void NumberClick3(object sender, RoutedEventArgs e)
        {
            textLabel.Text = "";
            input += "3";
            textLabel.Text += input;
        }

        private void NumberClick4(object sender, RoutedEventArgs e)
        {
            textLabel.Text = "";
            input += "4";
            textLabel.Text += input;
        }

        private void NumberClick5(object sender, RoutedEventArgs e)
        {
            textLabel.Text = "";
            input += "5";
            textLabel.Text += input;
        }

        private void NumberClick6(object sender, RoutedEventArgs e)
        {
            textLabel.Text = "";
            input += "6";
            textLabel.Text += input;
        }

        private void NumberClick7(object sender, RoutedEventArgs e)
        {
            textLabel.Text = "";
            input += "7";
            textLabel.Text += input;
        }

        private void NumberClick8(object sender, RoutedEventArgs e)
        {
            textLabel.Text = "";
            input += "8";
            textLabel.Text += input;
        }

        private void NumberClick9(object sender, RoutedEventArgs e)
        {
            textLabel.Text = "";
            input += "9";
            textLabel.Text += input;
        }

        private void PercentageClick(object sender, RoutedEventArgs e)
        {
            decimal percentage;
            decimal.TryParse(operand1, out percentage);
            decimal iphone = (percentage / 100);
            textLabel.Text = iphone.ToString();
        }

        private void DivideClick(object sender, RoutedEventArgs e)
        {
            operand1 = input;
            operation = '/';
            input = string.Empty;
        }

        private void MultiplyClick(object sender, RoutedEventArgs e)
        {
            operand1 = input;
            operation = '*';
            input = string.Empty;
        }

        private void MinusClick(object sender, RoutedEventArgs e)
        {
            operand1 = input;
            operation = '-';
            input = string.Empty;
        }

        private void PlusClick(object sender, RoutedEventArgs e)
        {
            operand1 = input;
            operation = '+';
            input = string.Empty;
        }

        private void EgaleClick(object sender, RoutedEventArgs e)
        {
            operand2 = input;
            double num1, num2;
            double.TryParse(operand1, out num1);
            double.TryParse(operand2, out num2);

            if (operation == '+')
            {
                result = num1 + num2;
                textLabel.Text = result.ToString();
            }
            else if (operation == '-')
            {
                result = num1 - num2;
                textLabel.Text = result.ToString();
            }
            else if (operation == '*')
            {
                result = num1 * num2;
                textLabel.Text = result.ToString();
            }
            else if (operation == '/')
            {
                if (num2 != 0)
                {
                    result = num1 / num2;
                    textLabel.Text = result.ToString();
                }
                else
                {
                    textLabel.Text = "DIV/Zero!";
                }
            }
        }
        
        private void VirguleClick(object sender, RoutedEventArgs e)
        {
            textLabel.Text = "";
            input += ",";
            textLabel.Text += input;
        }

        private void PlusOrMinus(object sender, RoutedEventArgs e)
        {
            textLabel.Text = "";
            input += "0";
            textLabel.Text += input;
        }
    }
}
