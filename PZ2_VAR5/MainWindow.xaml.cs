using PZ2_VAR5.pages;
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

namespace PZ2_VAR5
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
        private void btnTask1_Click(object sender, RoutedEventArgs e) { FrmMain.Navigate(new Task1Page()); }
        private void btnTask2_Click(object sender, RoutedEventArgs e) { FrmMain.Navigate(new Task2Page()); }
        private void btnTask3_Click(object sender, RoutedEventArgs e) { FrmMain.Navigate(new Task3Page()); }
        private void btnTask4_Click(object sender, RoutedEventArgs e) { FrmMain.Navigate(new Task4Page()); }
        private void btnTask5_Click(object sender, RoutedEventArgs e) { FrmMain.Navigate(new Task5Page()); }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            FrmMain.Content = null;
        }

        private void FrmMain_ContentRendered(object sender, EventArgs e)
        {
            if (FrmMain.Content != null)
            {
                btnBack.Visibility = Visibility.Visible;
                spMenu.Visibility = Visibility.Collapsed;
            }
            else
            {
                btnBack.Visibility = Visibility.Collapsed;
                spMenu.Visibility = Visibility.Visible;
            }
        }
    }
}

