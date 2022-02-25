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
using System.Windows.Shapes;

namespace lab_1
{
    /// <summary>
    /// Логика взаимодействия для Side1.xaml
    /// </summary>
    public partial class Side2 : Window
    {
        static ComboBox[,] cells = new ComboBox[5,5];
        static char[,] arr = new char[5,5];
        public Side2()
        {
            InitializeComponent();
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    arr[i,j] = 'e';
                    cells[i,j] = new ComboBox();
                    var pt = new TextBlock();
                    pt.Text = "x";
                    pt.FontSize = 72;
                    cells[i, j].Items.Add(pt);
                    pt = new TextBlock();
                    pt.Text = "o";
                    pt.FontSize = 72;
                    cells[i, j].Items.Add(pt);
                    cells[i, j].Name = "n_" + i.ToString() + "_" + j.ToString();
                    Grid.SetRow(cells[i, j], i);
                    Grid.SetColumn(cells[i, j], j);
                    game_grid.Children.Add(cells[i, j]);
                    cells[i, j].SelectionChanged +=cng;
                }
            }
        }

        private void Home(object sender, RoutedEventArgs e)
        {
            var mw = new MainWindow();
            mw.Show();
            Hide();

        }
        private void cng(object sender, SelectionChangedEventArgs e)
        {
            var cb = (ComboBox)sender;
            int x = int.Parse(cb.Name.Split('_')[1]);
            int y = int.Parse(cb.Name.Split('_')[2]);
            arr[x, y] = ((TextBlock)cb.SelectedValue).Text[0];
            if (Win('x'))
            {
                MessageBox.Show("x won");
                var mw = new MainWindow();
                mw.Show();
                Hide();
            }
            if (Win('o'))
            {
                MessageBox.Show("o won");
                var mw = new MainWindow();
                mw.Show();
                Hide();
            }
        }

        static bool Win(char ch)
        {
            var ert = false;
            for (int i = 0; i < 5; i++)
                for (int j = 0; j < 2; j++)
                {
                    int cl = 0;
                    int cl2 = 0;
                    for (int k = 0; k < 4; k++)
                    {
                        cl += (arr[i,j+k] == ch)?1:0;
                        cl2 += (arr[j + k, i] == ch) ? 1 : 0;
                    }
                    if(cl == 4)
                        ert = true;
                    if (cl2 == 4)
                        ert = true;
                }
            for (int i = 0; i < 2; i++)
                for (int j = 0; j < 2; j++)
                {
                    int cl = 0;
                    int cl2 = 0;
                    for (int k = 0; k < 4; k++)
                    {
                        cl += (arr[i + k, j + k] == ch) ? 1 : 0;
                        cl2 += (arr[i + k,4 - j - k] == ch) ? 1 : 0;
                    }
                    if (cl == 4)
                        ert = true;
                    if (cl2 == 4)
                        ert = true;
                }
            return ert;
        }

      

    }
}
