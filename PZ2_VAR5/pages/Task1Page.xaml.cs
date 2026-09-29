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

namespace PZ2_VAR5.pages
{
    /// <summary>
    /// Логика взаимодействия для Task1Page.xaml
    /// </summary>
    public partial class Task1Page : Page
    {
        public Task1Page()
        {
            InitializeComponent();
        }
        private void btnCalculate_Click(object sender, RoutedEventArgs e)
        {
            if (int.TryParse(tbInput.Text, out int n) && n >= -999 && n <= 999)
            {
                if (n == 0)
                {
                    tbResult.Text = "Результат: нулевое число";
                    return;
                }

                string sign = n > 0 ? "положительное" : "отрицательное";
                int absN = Math.Abs(n);
                string digits = "";

                if (absN < 10)
                    digits = "однозначное";
                else if (absN < 100)
                    digits = "двузначное";
                else
                    digits = "трехзначное";

                tbResult.Text = $"Результат: {sign} {digits} число";
            }
            else
            {
                MessageBox.Show("Введите целое число в диапазоне от -999 до 999!");
            }
        }
    }
}

