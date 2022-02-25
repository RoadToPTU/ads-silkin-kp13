using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace lab_1
{
    /// <summary>
    /// Логика взаимодействия для Side1.xaml
    /// </summary>
    /// 
  
    public partial class Side3 : Window
    {
        string value = "0";
        char sign = 'e';
        public Side3()
        {
            InitializeComponent();
            textBox.Focus();
        }
        private void Home(object sender, RoutedEventArgs e)
        {
            var mw = new MainWindow();
            mw.Show();
            Hide(); 
        }

       

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            textBox.Text += "0";
            textBox.Focus();
            textBox.SelectionStart = int.MaxValue;
        }

        

        private void cl2(object sender, RoutedEventArgs e)
        {
            textBox.Text = funk(value, textBox.Text, sign);
            textBox.Focus();
            textBox.SelectionStart = int.MaxValue;
        }

        static string funk(string a, string b, char sign)
        {
            switch (sign)
            { 
                case '+' : return (double.Parse(a) + double.Parse(b)).ToString();
                case '-': return (double.Parse(a) - double.Parse(b)).ToString();
                case '*': return (double.Parse(a) * double.Parse(b)).ToString();
                case '/': return (double.Parse(a) / double.Parse(b)).ToString();
                default: return "";
            }


        }

        private void cl3(object sender, RoutedEventArgs e)
        {
            textBox.Text += "1";
            textBox.Focus();
            textBox.SelectionStart = int.MaxValue;
        }

        private void cl4(object sender, RoutedEventArgs e)
        {
            textBox.Text += "2";
            textBox.Focus();
            textBox.SelectionStart = int.MaxValue;
        }

        private void cl5(object sender, RoutedEventArgs e)
        {
            textBox.Text += "3";
            textBox.Focus();
            textBox.SelectionStart = int.MaxValue;
        }

        private void cl6(object sender, RoutedEventArgs e)
        {
            textBox.Text += "4";
            textBox.Focus();
            textBox.SelectionStart = int.MaxValue;
        }

        private void cl7(object sender, RoutedEventArgs e)
        {
            textBox.Text += "5";
            textBox.Focus();
            textBox.SelectionStart = int.MaxValue;
        }

        private void cl8(object sender, RoutedEventArgs e)
        {
            textBox.Text += "6";
            textBox.Focus();
            textBox.SelectionStart = int.MaxValue;
        }

        private void cl9(object sender, RoutedEventArgs e)
        {
            textBox.Text += "7";
            textBox.Focus();
            textBox.SelectionStart = int.MaxValue;
        }

        private void cl10(object sender, RoutedEventArgs e)
        {
            textBox.Text += "8";
            textBox.Focus();
            textBox.SelectionStart = int.MaxValue;
        }

        private void cl11(object sender, RoutedEventArgs e)
        {
            textBox.Text += "9";
            textBox.Focus();
            textBox.SelectionStart = int.MaxValue;
        }

        private void cl12(object sender, RoutedEventArgs e)
        {
            value = textBox.Text;
            textBox.Text = "";
            sign = '/';
            textBox.Focus();
        }

        private void cl13(object sender, RoutedEventArgs e)
        {
            value = textBox.Text;
            textBox.Text = "";
            sign = '*';
            textBox.Focus();
        }

        private void cl14(object sender, RoutedEventArgs e)
        {
            value = textBox.Text;
            textBox.Text = "";
            sign = '-';
            textBox.Focus();
        }

        private void cl15(object sender, RoutedEventArgs e)
        {
            value = textBox.Text;
            textBox.Text = "";
            sign = '+';
            textBox.Focus();
        }

        private void cl16(object sender, RoutedEventArgs e)
        {
            textBox.Text += ",";
            textBox.Focus();
            textBox.SelectionStart = int.MaxValue;
        }

        private void cl17(object sender, RoutedEventArgs e)
        {
            if(textBox.Text[0] == '-')
            {
                textBox.Text = textBox.Text.Substring(1);
            }
            else
            {
                textBox.Text = "-"+textBox.Text;
            }
            textBox.Focus();
            textBox.SelectionStart = int.MaxValue;
        }

        private void cl18(object sender, RoutedEventArgs e)
        {
            textBox.Text = "";
            textBox.Focus();
            textBox.SelectionStart = int.MaxValue;
        }

        private void cl19(object sender, RoutedEventArgs e)
        {
            textBox.Text = textBox.Text.Substring(0,textBox.Text.Length-1);
            textBox.Focus();
            textBox.SelectionStart = int.MaxValue;
        }
    }
}
