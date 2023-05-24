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

namespace Zadanie2
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
                int n = Convert.ToInt32(TbNumberA.Text);
                int n1 = Convert.ToInt32(TbNumberB.Text);
                int n2 = Convert.ToInt32(TbNumberC.Text);
                double z = f1(n) / 2 + f1(n1) / 2 - f1(n2) / 2;
                TextBlockAnswer.Text = $"Ответ:\nЗначение выражения: {z:f2}";
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
        public static double f1(int N)
        {
            if (N < 0)
            {
                return 0;
            }
            double s = Math.Sqrt(N) + N;
            return s;
        }
    }
}
