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

namespace WpfApp1
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Вы нажали кнопку!", Name = "НЯЯЯЯ", MessageBoxButton.YesNo, MessageBoxImage.Error );
            Twowindow twowindow = new Twowindow();
            twowindow.Show();
            this.Close();
        }

        private void Button_MouseEnter(object sender, MouseEventArgs e)
        {
            post.Background = Brushes.Red;
        }

        private void post_MouseLeave(object sender, MouseEventArgs e)
        {
            post.Background = Brushes.Purple;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            label.Content = "Hello!";
        }

        private void del_Click(object sender, RoutedEventArgs e)
        {
            grid.Visibility = Visibility.Hidden;
            put.Visibility = Visibility.Hidden;
            post.Visibility = Visibility.Hidden;
            del.Visibility = Visibility.Hidden;
        }
    }
}
