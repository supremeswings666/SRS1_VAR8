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

namespace PZ2_VAR5.pages
{
    /// <summary>
    /// Логика взаимодействия для Task3Page.xaml
    /// </summary>
    public partial class Task3Page : Page
    {
        public Task3Page()
        {
            InitializeComponent();
        }
        private void btnCalculate_Click(object sender, RoutedEventArgs e)
        {
            string text = tbInput.Text.Trim();
            if (string.IsNullOrEmpty(text))
            {
                MessageBox.Show("Введите координаты точек через пробел!");
                return;
            }

            try
            {
                string[] parts = text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                double[] points = new double[parts.Length];

                for (int i = 0; i < parts.Length; i++)
                {
                    points[i] = double.Parse(parts[i]);
                }

                if (points.Length == 0)
                {
                    MessageBox.Show("Введите хотя бы одну координату!");
                    return;
                }

                double bestPoint = points[0];
                double minSum = double.MaxValue;

                for (int i = 0; i < points.Length; i++)
                {
                    double currentSum = 0;
                    for (int j = 0; j < points.Length; j++)
                    {
                        currentSum += Math.Abs(points[i] - points[j]);
                    }

                    if (currentSum < minSum)
                    {
                        minSum = currentSum;
                        bestPoint = points[i];
                    }
                }

                tbResult.Text = $"Искомая точка: {bestPoint}\nМинимальная сумма расстояний: {minSum}";
            }
            catch
            {
                MessageBox.Show("Ошибка ввода! Вводите только числа через пробел.");
            }
        }
    }
}
