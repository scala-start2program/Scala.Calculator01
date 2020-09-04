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

namespace Scala.Calculator01.WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            double number1;
            double number2;
            double.TryParse(txtNumber1.Text, out number1);
            double.TryParse(txtNumber2.Text, out number2);
            lblResult.Content = number1 + number2;
        }

        private void btnSubtract_Click(object sender, RoutedEventArgs e)
        {
            double number1;
            double number2;
            double.TryParse(txtNumber1.Text, out number1);
            double.TryParse(txtNumber2.Text, out number2);
            lblResult.Content = number1 - number2;
        }

        private void btnMultiply_Click(object sender, RoutedEventArgs e)
        {
            double number1;
            double number2;
            double.TryParse(txtNumber1.Text, out number1);
            double.TryParse(txtNumber2.Text, out number2);
            lblResult.Content = number1 * number2;
        }

        private void btnDivide_Click(object sender, RoutedEventArgs e)
        {
            double number1;
            double number2;
            double.TryParse(txtNumber1.Text, out number1);
            double.TryParse(txtNumber2.Text, out number2);
            lblResult.Content = (number1 / number2).ToString("#,##0.00");
        }

        private void btnModulus_Click(object sender, RoutedEventArgs e)
        {
            int number1;
            int number2;
            int.TryParse(txtNumber1.Text, out number1);
            int.TryParse(txtNumber2.Text, out number2);
            lblResult.Content = number1 % number2;

        }
    }
}
