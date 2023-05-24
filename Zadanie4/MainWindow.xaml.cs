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

namespace Zadanie4
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
                int a = Convert.ToInt32(TbNumberA.Text);
                int b = Convert.ToInt32(TbNumberB.Text);
                int h = Convert.ToInt32(TbNumberH.Text);
                double X = Convert.ToDouble(TbNumberX.Text);
                double Y = Tas(a, b, h, X);
                TextBlockAnswer.Text = $"Ответ:\nЗначение выражения: {Y:f2}";
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
        public static double Tas(int A, int B, int n, double x)
        {
            double res = 0;
            for (int i = A; i <= B; i += n)
            {
                if (x < 0)
                {
                    res = -4;
                }
                else if (x >= 1)
                {
                    res = 2;
                }
                else { res = Math.Pow(x, 2); }
            }
            return res;
        }
    }
}
