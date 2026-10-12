using System;
using System.Windows;
using System.Windows.Controls;

namespace Enzo_calculatrice
{
    public partial class MainWindow : Window
    {
        // variables
        int no1 = 0;
        int no2 = 0;
        int result = 0;
        Char opp = 'a';

        public MainWindow()
        {
            InitializeComponent();
        }
        public void BTN_1_Click(object sender, RoutedEventArgs e)
        {
            display_num("1");
        }
        public void BTN_2_Click(object sender, RoutedEventArgs e)
        {
            display_num("2");
        }
        public void BTN_3_Click(object sender, RoutedEventArgs e)
        {
            display_num("3");
        }
        public void BTN_4_Click(object sender, RoutedEventArgs e)
        {
            display_num("4");
        }
        public void BTN_5_Click(object sender, RoutedEventArgs e)
        {
            display_num("5");
        }
        public void BTN_6_Click(object sender, RoutedEventArgs e)
        {
            display_num("6");
        }
        public void BTN_7_Click(object sender, RoutedEventArgs e)
        {
            display_num("7");
        }
        public void BTN_8_Click(object sender, RoutedEventArgs e)
        {
            display_num("8");
        }
        public void BTN_9_Click(object sender, RoutedEventArgs e)
        {
            display_num("9");
        }
        public void BTN_0_Click(object sender, RoutedEventArgs e)
        {
            display_num("0");
        }
        public void BTN_Plus_Click(object sender, RoutedEventArgs e)
        {
            no1 = int.Parse(TB_Display.Text);
            opp = '+';
            TB_Display.Text = "";
        }
        public void BTN_moin_Click(object sender, RoutedEventArgs e)
        {
            no1 = int.Parse(TB_Display.Text);
            opp = '-';
            TB_Display.Text = "";
        }

        public void BTN_fois_Click(object sender, RoutedEventArgs e)
        {
            no1 = int.Parse(TB_Display.Text);
            opp = '*';
            TB_Display.Text = "";
        }

        public void BTN_div_Click(object sender, RoutedEventArgs e)
        {
            no1 = int.Parse(TB_Display.Text);
            opp = '/';
            TB_Display.Text = "";
        }

        public void BTN_egale_Click(object sender, RoutedEventArgs e)
        {
            no2 = int.Parse(TB_Display.Text);
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
                result = no1 * no2;
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

        public void BTN_CLR_Click(object sender, RoutedEventArgs e)
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
            display_num(",");
        }
    }
}
