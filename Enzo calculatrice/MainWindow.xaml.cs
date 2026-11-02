using System;
using System.Windows;
using System.Windows.Controls;

namespace Enzo_calculatrice
{
    public partial class MainWindow : Window
    {
        // variables
        double no1 = 0;
        double no2 = 0;
        double result = 0;
        Char opp = 'a';

        public MainWindow()
        {
            InitializeComponent();
        }
        private void BTN_1_Click(object sender, RoutedEventArgs e)
        {
            display_num("1");
        }
        private void BTN_2_Click(object sender, RoutedEventArgs e)
        {
            display_num("2");
        }
        private void BTN_3_Click(object sender, RoutedEventArgs e)
        {
            display_num("3");
        }
        private void BTN_4_Click(object sender, RoutedEventArgs e)
        {
            display_num("4");
        }
        private void BTN_5_Click(object sender, RoutedEventArgs e)
        {
            display_num("5");
        }
        private void BTN_6_Click(object sender, RoutedEventArgs e)
        {
            display_num("6");
        }
        private void BTN_7_Click(object sender, RoutedEventArgs e)
        {
            display_num("7");
        }
        private void BTN_8_Click(object sender, RoutedEventArgs e)
        {
            display_num("8");
        }
        private void BTN_9_Click(object sender, RoutedEventArgs e)
        {
            display_num("9");
        }
        private void BTN_0_Click(object sender, RoutedEventArgs e)
        {
            display_num("0");
        }
        private void BTN_Plus_Click(object sender, RoutedEventArgs e)
        {
            no1 = double.Parse(TB_Display.Text);
            opp = '+';
            TB_Display.Text = "";
        }
        private void BTN_moin_Click(object sender, RoutedEventArgs e)
        {
            no1 = double.Parse(TB_Display.Text);
            opp = '-';
            TB_Display.Text = "";
        }

        private void BTN_fois_Click(object sender, RoutedEventArgs e)
        {
            no1 = double.Parse(TB_Display.Text);
            opp = '*';
            TB_Display.Text = "";
        }

        private void BTN_div_Click(object sender, RoutedEventArgs e)
        {
            no1 = double.Parse(TB_Display.Text);
            opp = '/';
            TB_Display.Text = "";
        }

        private void BTN_egale_Click(object sender, RoutedEventArgs e)
        {
            no2 = double.Parse(TB_Display.Text);
            if (opp == '+')
            {
                result = no1 + no2;
                TB_Display.Text = result.ToString();
            }
            else if (opp == '-')
            {
                result = no1 - no2;
                TB_Display.Text = result.ToString();
            }
            else if (opp == '*')
            {
                result = no1 * no2;
                TB_Display.Text = result.ToString();
                    }
            else if (opp == '/')
                if (no2 != 0)
                {
                    result = no1 / no2;
                    TB_Display.Text = result.ToString();
                }
                else
                {
                    TB_Display.Text = "Error: Division by zero";
                }
        }

        private void BTN_CLR_Click(object sender, RoutedEventArgs e)
        {
            TB_Display.Text = "";
        }

        private void display_num(string picknum)
        {
            if (TB_Display.Text == "0")
            {
                TB_Display.Text = picknum;
            }
            else
            {
                TB_Display.Text += picknum;
            }
        }

        private void BTN_virgule_Click(object sender, RoutedEventArgs e)
        {
            if (!TB_Display.Text.Contains(","))
            {
                display_num(",");
            }
        }
        private void BTN_Racine_Click(object sender, RoutedEventArgs e)
        {
            if (TB_Display.Text. Contains("√"))
            {
                display_num("√");
            }
        }
        private void BTN_pourcent_Click(object sender, RoutedEventArgs e)
        {
            if (TB_Display.Text.Contains("%"))
            {
                display_num("%");
            }
        }
        private void BTN_exponentielle_Click(object sender, RoutedEventArgs e)
        {
            if (TB_Display.Text.Contains("^"))
            {
                display_num("^");
            }
        }
        private void BTN_Log_Click(object sender, RoutedEventArgs e)
        {
            if (TB_Display.Text.Contains("log"))
            {
                display_num("log");
            }
        }
        private void BTN_cos_Click(object sender, RoutedEventArgs e)
        {
            if (TB_Display.Text.Contains("cos"))
            {
                display_num("cos");
            }
        }
        private void BTN_Tan_Click(object sender, RoutedEventArgs e)
        {
            if (TB_Display.Text.Contains("tan"))
            {
                display_num("tan");
            }
        }
        private void BTN_Sin_Click(object sender, RoutedEventArgs e)
        {
            if (TB_Display.Text.Contains("sin"))
            {
                display_num("sin");
            }
        }
        private void BTN_Carre_Click(object sender, RoutedEventArgs e)
        {
            if (TB_Display.Text.Contains("x²"))
            {
                display_num("x²");
            }
        }
        private void BTN_egale_Click_ (object sender , RoutedEventArgs e)
        {
            no2 = double.Parse(TB_Display.Text);
        }
    }       
}
