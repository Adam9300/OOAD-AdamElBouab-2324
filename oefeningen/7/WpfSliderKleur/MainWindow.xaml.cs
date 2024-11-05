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

namespace WpfSliderKleur
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            lblWaarde.Foreground = Brushes.Green;
        }

        private void Slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            int waarde = Convert.ToInt32(sld1.Value);
            lblWaarde.Content = waarde;

            //waarde = 60

            if (waarde > 80)
            {
                lblWaarde.Foreground = Brushes.DarkRed;
            }
            else if (waarde > 50)
            {
                lblWaarde.Foreground = Brushes.DarkOrange;
            }
            else if (waarde > 30)
            {
                lblWaarde.Foreground = Brushes.Yellow;
            }
            else
            {
                lblWaarde.Foreground = Brushes.Green;
            }
        }
    }
}
