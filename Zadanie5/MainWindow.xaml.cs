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

namespace Zadanie5
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
                double a = Convert.ToDouble(TbNumberA.Text);
                double b = Convert.ToDouble(TbNumberB.Text);
                double c = Convert.ToDouble(TbNumberC.Text);
                double d = Convert.ToDouble(TbNumberD.Text);
                double e1 = Convert.ToDouble(TbNumberE.Text);
                double g = Convert.ToDouble(TbNumberG.Text);
                double f = Convert.ToDouble(TbNumberF.Text);
                double res = Treu(a, b, f) + Treu(g, c, f) + Treu(e1, d, g);
                TextBlockAnswer.Text = $"Ответ:\nЗначение выражения: {res:f2}";
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
        public static double Treu(double x, double y, double z)
        {
            if (x == 0 || y == 0 || z == 0)
            {
                return  0;
            }
            double poluper = (x + y + z) / 2;
            return Math.Sqrt(poluper * (poluper - x) * (poluper - y) * (poluper - z));
        }
    }
}

