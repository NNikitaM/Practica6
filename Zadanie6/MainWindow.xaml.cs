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

namespace Zadanie6
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
        private void BtnCancelClick(object sender, RoutedEventArgs e)
        {
            Close();
        }
        private void BtnOKClick(object sender, RoutedEventArgs e)
        {
            try
            {
                int N1 = Convert.ToInt32(TbNumberA.Text);
                int N2 = Convert.ToInt32(TbNumberB.Text);
                int N3 = Convert.ToInt32(TbNumberC.Text);
                int N4 = Convert.ToInt32(TbNumberD.Text);
                int N5 = Convert.ToInt32(TbNumberE.Text);
                double[] N = { Fib(N1), Fib(N2), Fib(N3), Fib(N4), Fib(N5) };
                TextBlockAnswer.Text = $"Ответ:\nПять чисел Фибоначчи:\n{N[0]}" + $"\n{N[1]}" + $"\n{N[2]}" + $"\n{N[3]}" + $"\n{N[4]}";
            }
            catch (FormatException)
            {
                MessageBox.Show("Введены не корректные данные");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public static int Fib(int n)
        {
            if (n == 1 || n == 2)
            {
                return 1;
            }
            else
            {
                int fib1 = 1, fib2 = 1, fibonacci = 0;
                for (int i = 3; i <= n; i++)
                {
                    fibonacci = fib1 + fib2;
                    fib1 = fib2;
                    fib2 = fibonacci;
                }
                return fibonacci;
            }
        }
    }
}
