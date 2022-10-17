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

namespace Calculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        double number1 = 0;
        double number2 = 0;
        string operation = null;
        
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            if (operation == null && number1 == 0)
            {
                number1 = (number1 * 10) + 1;
                textDisplay.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10) + 1;
                textDisplay.Text = number2.ToString();
            }
        }

        private void btn2_Click(object sender, RoutedEventArgs e)
        {
            if (operation == null && number1 == 0)
            {
                number1 = (number1 * 10) + 2;
                textDisplay.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10) + 2;
                textDisplay.Text = number2.ToString();
            }
        }

        private void btn3_Click(object sender, RoutedEventArgs e)
        {
            if (operation == null && number1 == 0)
            {
                number1 = (number1 * 10) + 3;
                textDisplay.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10) + 3;
                textDisplay.Text = number2.ToString();
            }
        }

        private void btn4_Click(object sender, RoutedEventArgs e)
        {
            if (operation == null && number1 == 0)
            {
                number1 = (number1 * 10) + 4;
                textDisplay.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10) + 4;
                textDisplay.Text = number2.ToString();
            }
        }

        private void btn5_Click(object sender, RoutedEventArgs e)
        {
            if (operation == null && number1 == 0)
            {
                number1 = (number1 * 10) + 5;
                textDisplay.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10) + 5;
                textDisplay.Text = number2.ToString();
            }
        }

        private void btn6_Click(object sender, RoutedEventArgs e)
        {
            if (operation == null && number1 == 0)
            {
                number1 = (number1 * 10) + 6;
                textDisplay.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10) + 6;
                textDisplay.Text = number2.ToString();
            }
        }

        private void btn7_Click(object sender, RoutedEventArgs e)
        {
            if (operation == null && number1 == 0)
            {
                number1 = (number1 * 10) + 7;
                textDisplay.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10) + 7;
                textDisplay.Text = number2.ToString();
            }
        }

        private void btn8_Click(object sender, RoutedEventArgs e)
        {
            if (operation == null && number1 == 0)
            {
                number1 = (number1 * 10) + 8;
                textDisplay.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10) + 8;
                textDisplay.Text = number2.ToString();
            }
        }

        private void btn9_Click(object sender, RoutedEventArgs e)
        {
            if (operation == null && number1 == 0)
            {
                number1 = (number1 * 10) + 9;
                textDisplay.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10) + 9;
                textDisplay.Text = number2.ToString();
            }
        }

        private void btn0_Click(object sender, RoutedEventArgs e)
        {
            if (operation == null && number1 == 0)
            {
                number1 = (number1 * 10) + 0;
                textDisplay.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10) + 0;
                textDisplay.Text = number2.ToString();
            }
        }

        private void btnPlus_Click(object sender, RoutedEventArgs e)
        {
            // if operation != null -> perform numA= A op B, display numA
            if (operation != null) performOp(operation);
            operation = "+";
            textDisplay.Text = "0";
        }

        private void btnMinus_Click(object sender, RoutedEventArgs e)
        {
            if (operation != null) performOp(operation);
            operation = "-";
            textDisplay.Text = "0";
        }

        private void btnMultiply_Click(object sender, RoutedEventArgs e)
        {
            if (operation != null) performOp(operation);
            operation = "*";
            textDisplay.Text = "0";
        }

        private void btnDivide_Click(object sender, RoutedEventArgs e)
        {
            if (operation != null) performOp(operation);
            operation = "/";
            textDisplay.Text = "0";
        }

        private void performOp(string operation)
        {
            switch (operation)
            {
                case "+":
                    textDisplay.Text = (number1 + number2).ToString();
                    number1 = number1 + number2;
                    number2 = 0;
                    resetOperation();
                    break;
                case "-":
                    textDisplay.Text = (number1 - number2).ToString();
                    number1 = number1 - number2;
                    number2 = 0;
                    resetOperation();
                    break;
                case "*":
                    textDisplay.Text = (number1 * number2).ToString();
                    number1 = number1 * number2;
                    number2 = 0;
                    resetOperation();
                    break;
                case "/":
                    textDisplay.Text = (number1 / number2).ToString();
                    number1 = number1 / number2;
                    number2 = 0;
                    resetOperation();
                    break;
            }
        }

        private void resetOperation()
        {
            operation = null;
        }

        private void btnEquals_Click(object sender, RoutedEventArgs e)
        {
            performOp(operation);
        }

        private void btnClearEntry_Click(object sender, RoutedEventArgs e)
        {
            if (operation == null)
            {
                number1 = 0;
            }
            else
            {
                number2 = 0;
            }
            textDisplay.Text = "0";
        }

        private void btnAllClear_Click(object sender, RoutedEventArgs e)
        {
            number1 = 0;
            number2 = 0;
            textDisplay.Text = "0";
            operation = null;
        }

        private void btnPlusMinus_Click(object sender, RoutedEventArgs e)
        {
            if (operation == null)
            {
                number1 *= -1;
                textDisplay.Text = number1.ToString();
            }
            else
            {
                number2 *= -1;
                textDisplay.Text = number2.ToString();
            }
        }
    }
}
