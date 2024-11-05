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

namespace WpfBMI
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

        private void btnBerekenen_Click(object sender, RoutedEventArgs e)
        {
            double lengte = Convert.ToDouble(txtLengte.Text);
            double gewicht = Convert.ToDouble(txtGewicht.Text);

            double lengteInMeter = lengte / 100;

            double bmi = gewicht / (lengteInMeter * lengteInMeter);
            bmi = Math.Round(bmi, 1);

            lblBMI.Content = bmi;
        }
    }
}
