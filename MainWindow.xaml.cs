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

namespace UP4_PR_Cherednichenko
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

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            Window Window1 = new Window1();
            Window1.Show();
        }

        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {
            Window Window2 = new Window2();
            Window2.Show();
        }

        private void MenuItem_Click_2(object sender, RoutedEventArgs e)
        {
            Window Window3A = new Window3A();
            Window3A.Show();
        }

        private void MenuItem_Click_3(object sender, RoutedEventArgs e)
        {
            Window Window3b = new Window3b();
            Window3b.Show();
        }

        private void MenuItem_Click_4(object sender, RoutedEventArgs e)
        {
            Window Window3V = new Window3V();
            Window3V.Show();
        }
    }
}
