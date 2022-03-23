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
using System.Text.RegularExpressions;

namespace WpfApp54
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

        private void button_Click(object sender, RoutedEventArgs e)
        {
           
            
            
        }

        private void textBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            string cn = textBox.Text;
            Regex regex = new Regex(@"^[0-9]{3}-[0-9]{3}-[0-9]{3}-[0-9]{2}$");
            Match match = regex.Match(cn);
            if(match.Success)
            {
                label3.Content = "Верно ✅";
                textBox.Background = new SolidColorBrush(Color.FromRgb(0, 255, 0));
            }
            else if (!match.Success)
            {
                label3.Content = "Неверно ❌";
                textBox.Background = new SolidColorBrush(Color.FromRgb(255, 0, 0));
            }
        }

        private void textBox1_TextChanged(object sender, TextChangedEventArgs e)
        {
            string tel = textBox1.Text;
            Regex regex1 = new Regex(@"^(8|\+7)[0-9]{10}$");
            Match match1 = regex1.Match(tel);
            if (match1.Success)
            {
                label4.Content = "Верно ✅";
                textBox1.Background = new SolidColorBrush(Color.FromRgb(0, 255, 0));
            }
            else if (!match1.Success)
            {
                label4.Content = "Неверно ❌";
                textBox1.Background = new SolidColorBrush(Color.FromRgb(255, 0, 0));
            }

        }

        private void textBox2_TextChanged(object sender, TextChangedEventArgs e)
        {
            string pass = textBox2.Text;
            Regex regex2 = new Regex(@"^[0-9]{2} [0-9]{2} [0-9]{6}$");
            Match match2 = regex2.Match(pass);
            if (match2.Success)
            {
                label5.Content="Верно ✅";
                textBox2.Background = new SolidColorBrush(Color.FromRgb(0, 255, 0));
            }
            else if (!match2.Success)
            {
                label5.Content = "Неверно ❌";
                textBox2.Background = new SolidColorBrush(Color.FromRgb(255, 0, 0));
            }
        }
    }
}

