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
    /// Логика взаимодействия для Task5Page.xaml
    /// </summary>
    public partial class Task5Page : Page
    {
        public Task5Page()
        {
            InitializeComponent();
        }
        private void btnCalculate_Click(object sender, RoutedEventArgs e)
        {
            if (int.TryParse(tbRows.Text, out int n) && int.TryParse(tbCols.Text, out int m) && n > 0 && m > 0)
            {
                Random rnd = new Random();
                int[,] matrix = new int[n, m];
                int[] flat = new int[n * m];

                int minVal = int.MaxValue;
                int maxVal = int.MinValue;

                int index = 0;
                StringBuilder sbOriginal = new StringBuilder();
                sbOriginal.AppendLine("Исходный массив:");

                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < m; j++)
                    {
                        int val = rnd.Next(-10, 11);
                        matrix[i, j] = val;
                        flat[index++] = val;

                        if (val < minVal) minVal = val;
                        if (val > maxVal) maxVal = val;

                        sbOriginal.Append($"{val,5} ");
                    }
                    sbOriginal.AppendLine();
                }

                int[] asc = (int[])flat.Clone();
                Array.Sort(asc);

                int[] desc = (int[])flat.Clone();
                Array.Sort(desc);
                Array.Reverse(desc);

                StringBuilder sbResult = new StringBuilder();
                sbResult.AppendLine(sbOriginal.ToString());
                sbResult.AppendLine($"Минимальный элемент: {minVal}");
                sbResult.AppendLine($"Максимальный элемент: {maxVal}");
                sbResult.AppendLine();

                sbResult.AppendLine("Массив, отсортированный по возрастанию:");
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < m; j++)
                    {
                        sbResult.Append($"{asc[i * m + j],5} ");
                    }
                    sbResult.AppendLine();
                }

                sbResult.AppendLine();
                sbResult.AppendLine("Массив, отсортированный по убыванию:");
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < m; j++)
                    {
                        sbResult.Append($"{desc[i * m + j],5} ");
                    }
                    sbResult.AppendLine();
                }

                tbResult.Text = sbResult.ToString();
            }
            else
            {
                MessageBox.Show("Введите корректные положительные целые числа для строк (N) и столбцов (M)!");
            }
        }
    }
}