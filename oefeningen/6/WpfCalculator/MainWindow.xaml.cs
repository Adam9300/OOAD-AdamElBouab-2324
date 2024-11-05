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

namespace WpfCalculator
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

        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            txtOperand.Text = txtOperand.Text + 1;
        }

        private void btn2_Click(object sender, RoutedEventArgs e)
        {
            txtOperand.Text = txtOperand.Text + 2;
        }

        private void btnPlus_Click(object sender, RoutedEventArgs e)
        {
            double result = Convert.ToDouble(lblResult.Content);
            double operand = Convert.ToDouble(txtOperand.Text);
            lblResult.Content = result + operand;
            txtOperand.Text = "";
        }

        private void btn3_Click(object sender, RoutedEventArgs e)
        {
            txtOperand.Text = txtOperand.Text + 3;
        }

        private void btn4_Click(object sender, RoutedEventArgs e)
        {
            txtOperand.Text = txtOperand.Text + 4;

        }

        private void btn5_Click(object sender, RoutedEventArgs e)
        {
            txtOperand.Text = txtOperand.Text + 5;
        }

        private void btn6_Click(object sender, RoutedEventArgs e)
        {
            txtOperand.Text = txtOperand.Text + 6;
        }

        private void btn7_Click(object sender, RoutedEventArgs e)
        {
            txtOperand.Text = txtOperand.Text + 7;
        }

        private void btn8_Click(object sender, RoutedEventArgs e)
        {
            txtOperand.Text = txtOperand.Text + 8;
        }

        private void btn9_Click(object sender, RoutedEventArgs e)
        {
            txtOperand.Text = txtOperand.Text + 9;
        }

        private void btn0_Click(object sender, RoutedEventArgs e)
        {
            txtOperand.Text = txtOperand.Text + 0;
        }

        private void btnCE_Click(object sender, RoutedEventArgs e)
        {
            txtOperand.Text = "";
            lblResult.Content = "0.0";
        }

        private void btnDeling_Click(object sender, RoutedEventArgs e)
        {
            double result = Convert.ToDouble(lblResult.Content);
            double operand = Convert.ToDouble(txtOperand.Text);
            lblResult.Content = result / operand;
            txtOperand.Text = "";
        }

        private void btnMin_Click(object sender, RoutedEventArgs e)
        {
            double result = Convert.ToDouble(lblResult.Content);
            double operand = Convert.ToDouble(txtOperand.Text);
            lblResult.Content = result - operand;
            txtOperand.Text = "";
        }

        private void btnMaal_Click(object sender, RoutedEventArgs e)
        {
            double result = Convert.ToDouble(lblResult.Content);
            double operand = Convert.ToDouble(txtOperand.Text);
            lblResult.Content = result * operand;
            txtOperand.Text = "";
        }

        private void btnDot_Click(object sender, RoutedEventArgs e)
        {
            txtOperand.Text = txtOperand.Text + ",";
        }

        private void btnSqr_Click(object sender, RoutedEventArgs e)
        {
            double operand = Convert.ToDouble(txtOperand.Text);
            lblResult.Content = operand * operand;
            txtOperand.Text = "";
        }

        private void btnSqrt_Click(object sender, RoutedEventArgs e)
        {
            double operand = Convert.ToDouble(txtOperand.Text);
            lblResult.Content = Math.Sqrt(operand);
            txtOperand.Text = "";
        }

        private void btnSin_Click(object sender, RoutedEventArgs e)
        {
            double operand = Convert.ToDouble(txtOperand.Text);
            lblResult.Content = Math.Sin(operand);
            txtOperand.Text = "";
        }

        private void btnRnd_Click(object sender, RoutedEventArgs e)
        {
            Random rnd = new Random();

            int random = rnd.Next(1, 1000);
            lblResult.Content = random;
            txtOperand.Text = "";
        }
    }
}
