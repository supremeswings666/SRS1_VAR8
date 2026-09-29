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
    /// Логика взаимодействия для Task4Page.xaml
    /// </summary>
    public partial class Task4Page : Page
    {
        public Task4Page()
        {
            InitializeComponent();
        }
        private void btnCalculate_Click(object sender, RoutedEventArgs e)
        {
            string text = tbInput.Text.Trim();
            if (string.IsNullOrEmpty(text))
            {
                MessageBox.Show("Введите массив целых чисел через пробел!");
                return;
            }

            try
            {
                string[] parts = text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                int[] arr = new int[parts.Length];

                for (int i = 0; i < parts.Length; i++)
                {
                    arr[i] = int.Parse(parts[i]);
                }

                int firstEvenIdx = -1;
                int lastNegIdx = -1;

                for (int i = 0; i < arr.Length; i++)
                {
                    if (firstEvenIdx == -1 && arr[i] % 2 == 0)
                    {
                        firstEvenIdx = i;
                    }
                    if (arr[i] < 0)
                    {
                        lastNegIdx = i;
                    }
                }

                if (firstEvenIdx == -1)
                {
                    MessageBox.Show("В массиве нет чётных чисел!");
                    return;
                }

                if (lastNegIdx == -1)
                {
                    MessageBox.Show("В массиве нет отрицательных чисел!");
                    return;
                }

                int temp = arr[firstEvenIdx];
                arr[firstEvenIdx] = arr[lastNegIdx];
                arr[lastNegIdx] = temp;

                tbResult.Text = $"Индекс первого чётного: {firstEvenIdx}, индекс последнего отрицательного: {lastNegIdx}\n" +
                                $"Результат перестановки: {string.Join(" ", arr)}";
            }
            catch
            {
                MessageBox.Show("Ошибка ввода! Вводите только целые числа через пробел.");
            }
        }
    }
}
