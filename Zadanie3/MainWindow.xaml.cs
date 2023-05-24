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

namespace Zadanie3
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
                double A = Convert.ToDouble(TbNumberA.Text);
                double B = Convert.ToDouble(TbNumberB.Text);
                string C = Gipotenuza(A, B);
                double per = 2 * Convert.ToDouble((A + B + C));
                TextBlockAnswer.Text = $"Ответ:\nПериметр фигуры: {per:f2}";
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
        public static string Gipotenuza(double a, double b)
        {
            double c = 0;
            if (a + b < 0)
            {
                c = 0;
            }
            else if (a > b && a > 0 || a < b && b > 0)
            {
                c = Math.Sqrt(a + b);
            }
            else 
            { c = 0; }
            return c.ToString("N2");
        }
    }
}
