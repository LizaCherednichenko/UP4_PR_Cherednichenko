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

        private void MenuItem_Click_5(object sender, RoutedEventArgs e)
        {
            Window Window3G = new Window3G();
            Window3G.Show();
        }

        private void MenuItem_Click_6(object sender, RoutedEventArgs e)
        {
            Window Window4A = new Window4A();
            Window4A.Show();
        }

        private void MenuItem_Click_7(object sender, RoutedEventArgs e)
        {
            Window Window4b = new Window4b();
            Window4b.Show();
        }

        private void MenuItem_Click_8(object sender, RoutedEventArgs e)
        {
            Window Window4V = new Window4V();
            Window4V.Show();
        }

        private void MenuItem_Click_9(object sender, RoutedEventArgs e)
        {
            Window Window4G = new Window4G();
            Window4G.Show();
        }

        private void MenuItem_Click_10(object sender, RoutedEventArgs e)
        {
            Window Window4D = new Window4D();
            Window4D.Show();
        }

        private void MenuItem_Click_11(object sender, RoutedEventArgs e)
        {
            Window Window5A = new Window5A();
            Window5A.Show();
        }

        private void MenuItem_Click_12(object sender, RoutedEventArgs e)
        {
            Window Window5b = new Window5b();
            Window5b.Show();
        }

        private void MenuItem_Click_13(object sender, RoutedEventArgs e)
        {
            Window Window5V = new Window5V();
            Window5V.Show();
        }

        private void MenuItem_Click_14(object sender, RoutedEventArgs e)
        {
            Window Window5G = new Window5G();
            Window5G.Show();
        }

        private void MenuItem_Click_15(object sender, RoutedEventArgs e)
        {
            Window Window5D = new Window5D();
            Window5D.Show();
        }
    }
}
