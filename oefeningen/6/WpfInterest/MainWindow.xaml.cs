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

namespace WpfInterest
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
            double start = Convert.ToDouble(txtStartbedrag.Text);
            double interest = Convert.ToDouble(txtInterest.Text) / 100;
            int periode = Convert.ToInt32(sldPeriode.Value);

            double waarde = start * Math.Pow((1 + interest), periode);
            waarde = Math.Round(waarde, 2);

            lblToekomstigeWaarde.Content = $"De waarde na {periode} jaar bedraagt €{waarde}";
        }

        private void sldPeriode_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            lblPeriode.Content = $"{sldPeriode.Value} jaar";
        }
    }
}
