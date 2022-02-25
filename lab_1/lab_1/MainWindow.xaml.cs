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

namespace lab_1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }


        private void Button_Exit(object sender, RoutedEventArgs e)
        {
            System.Windows.Application.Current.Shutdown();
        }

        private void goto1(object sender, RoutedEventArgs e)
        {
            (new Side1()).Show();
            Hide();
        }

        private void goto2(object sender, RoutedEventArgs e)
        {
            (new Side2()).Show();
            Hide();
        }

        private void goto3(object sender, RoutedEventArgs e)
        {
            (new Side3()).Show();
            Hide();

        }

        private void goto4(object sender, RoutedEventArgs e)
        {
            (new About()).Show();
            Hide();
        }
    }
}
