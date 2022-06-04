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

namespace Wpf_Kalkulacka
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        long cislo1 = 0;
        long cislo2 = 0;
        string operace = "";


        public MainWindow()
        {
            InitializeComponent();
        }

        private void btn0_Click(object sender, RoutedEventArgs e)
        {
            if (operace == "")
            {
                cislo1 = (cislo1 * 10) + 0; 
                Displej.Text = cislo1.ToString();
            }
            else
            {
                cislo2 = (cislo2 * 10) + 0;
                Displej.Text = cislo2.ToString();
            }
        }

        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            if (operace == "")
            {
                cislo1 = (cislo1 * 10) + 1;
                Displej.Text = cislo1.ToString();
            }
            else
            {
                cislo2 = (cislo2 * 10) + 1;
                Displej.Text = cislo2.ToString();
            }
        }

        private void btn2_Click(object sender, RoutedEventArgs e)
        {
            if (operace == "")
            {
                cislo1 = (cislo1 * 10) + 2;
                Displej.Text = cislo1.ToString();
            }
            else
            {
                cislo2 = (cislo2 * 10) + 2;
                Displej.Text = cislo2.ToString();
            }
        }

        private void btn3_Click(object sender, RoutedEventArgs e)
        {
            if (operace == "")
            {
                cislo1 = (cislo1 * 10) + 3;
                Displej.Text = cislo1.ToString();
            }
            else
            {
                cislo2 = (cislo2 * 10) + 3;
                Displej.Text = cislo2.ToString();
            }
        }

        private void btn4_Click(object sender, RoutedEventArgs e)
        {
            if (operace == "")
            {
                cislo1 = (cislo1 * 10) + 4;
                Displej.Text = cislo1.ToString();
            }
            else
            {
                cislo2 = (cislo2 * 10) + 4;
                Displej.Text = cislo2.ToString();
            }
        }

        private void btn5_Click(object sender, RoutedEventArgs e)
        {
            if (operace == "")
            {
                cislo1 = (cislo1 * 10) + 5;
                Displej.Text = cislo1.ToString();
            }
            else
            {
                cislo2 = (cislo2 * 10) + 5;
                Displej.Text = cislo2.ToString();
            }
        }

        private void btn6_Click(object sender, RoutedEventArgs e)
        {
            if (operace == "")
            {
                cislo1 = (cislo1 * 10) + 6;
                Displej.Text = cislo1.ToString();
            }
            else
            {
                cislo2 = (cislo2 * 10) + 6;
                Displej.Text = cislo2.ToString();
            }
        }

        private void btn7_Click(object sender, RoutedEventArgs e)
        {
            if (operace == "")
            {
                cislo1 = (cislo1 * 10) + 7;
                Displej.Text = cislo1.ToString();
            }
            else
            {
                cislo2 = (cislo2 * 10) + 7;
                Displej.Text = cislo2.ToString();
            }
        }

        private void btn8_Click(object sender, RoutedEventArgs e)
        {
            if (operace == "")
            {
                cislo1 = (cislo1 * 10) + 8;
                Displej.Text = cislo1.ToString();
            }
            else
            {
                cislo2 = (cislo2 * 10) + 8;
                Displej.Text = cislo2.ToString();
            }
        }

        private void btn9_Click(object sender, RoutedEventArgs e)
        {
            if (operace == "")
            {
                cislo1 = (cislo1 * 10) + 9;
                Displej.Text = cislo1.ToString();
            }
            else
            {
                cislo2 = (cislo2 * 10) + 9;
                Displej.Text = cislo2.ToString();
            }
        }

        private void btn_plus_Click(object sender, RoutedEventArgs e)
        {
            operace = "+";
            Displej.Text = "0"; 
        }

        private void btn_minus_Click(object sender, RoutedEventArgs e)
        {
            operace = "-";
            Displej.Text = "0";
        }

        private void btn_krat_Click(object sender, RoutedEventArgs e)
        {
            operace = "*";
            Displej.Text = "0";
        }

        private void btn_deleno_Click(object sender, RoutedEventArgs e)
        {
            operace = "/";
            Displej.Text = "0";
        }

        private void btn_rovno_Click(object sender, RoutedEventArgs e)
        {
            switch (operace)
            {
                case "+":
                    Displej.Text = (cislo1 + cislo2).ToString();
                    break;
                case "-":
                    Displej.Text = (cislo1 - cislo2).ToString();
                    break;
                case "*":
                    Displej.Text = (cislo1 * cislo2).ToString();
                    break;
                case "/":
                    Displej.Text = (cislo1 / cislo2).ToString();
                    break;
            }
            cislo1 = 0;
            cislo2 = 0;
            operace = "";
        }
        private void btn_ce_Click(object sender, RoutedEventArgs e)
        {
            if (operace == "")
            {
                cislo1 = 0;
            }
            else
            {
                cislo2 = 0;
            }
            Displej.Text = "0";
        }

        private void btn_c_Click(object sender, RoutedEventArgs e)
        {
            cislo1 = 0;
            cislo2 = 0;
            operace = "";
            Displej.Text = "0";
        }

        private void btn_back_Click(object sender, RoutedEventArgs e)
        {
            if (operace == "")
            {
                cislo1 = cislo1 / 10;
                Displej.Text = cislo1.ToString();
            }
            else
            {
                cislo2 = cislo2 / 10;
                Displej.Text = cislo2.ToString();
            }
        }
    }
}
