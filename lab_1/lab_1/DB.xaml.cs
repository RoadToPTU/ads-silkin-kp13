using System;
using System.Collections;
using System.IO;
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

    public class Preson
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Comment { get; set; }
    }
    public partial class Side1 : Window
    {
        public Side1()
        {
            InitializeComponent();
        }

        private void Home(object sender, RoutedEventArgs e)
        {
            var mw = new MainWindow();
            mw.Show();
            Hide(); 

        }

        private void Add(object sender, RoutedEventArgs e)
        {
            string path = "Side1.csv";

            
            var student = new Preson();
            student.ID = int.Parse(id1.Text);
            student.Name = name.Text;
            student.Comment = comment.Text;
            File.AppendAllText(path, String.Format("{0};{1};{2}\n", student.ID, student.Name, student.Comment));
        }

        private void Del(object sender, RoutedEventArgs e)
        {
            var students = new List<Preson>();
            var student = new Preson();
            string path = "Side1.csv";
            using (StreamReader streamReader = new StreamReader(path))
            {
                string line;
                while ((line = streamReader.ReadLine()) != null)
                {
                    student = new Preson();
                    var vals = line.Split(';');
                    student.ID = Convert.ToInt32(vals[0]);
                    student.Name = vals[1];
                    student.Comment = vals[2];
                    students.Add(student);
                }
            }

            students = students.FindAll(x => x.ID != int.Parse(id2.Text)).ToList();

            var csv = new StringBuilder();

            foreach (var stud in students) 
            {
                var newLine = String.Format("{0};{1};{2}", stud.ID, stud.Name, stud.Comment);
                csv.AppendLine(newLine);
            }
            File.WriteAllText(path, csv.ToString());
        }

        private void TextBox_GotFocus(object sender, RoutedEventArgs e)
        {
            string path = "Side1.csv";
            ((TextBox)sender).Text = File.ReadAllText(path);

        }

        
    }
}
