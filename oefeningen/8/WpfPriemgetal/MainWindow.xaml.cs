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

namespace WpfPriemgetal
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

        private void btnControleer_Click(object sender, RoutedEventArgs e)
        {
            int getal = Convert.ToInt32(txtGetal.Text);

            /* OPTIE 1 (met extra if/else)
             * ===========================
            *   bool isPriem = true;
            *   
                if(getal == 1)
                {
                    isPriem = false;
                }
                else
                {
                    for (int i = 2; i < getal; i++)
                    {
                        if (getal % i == 0)
                        {
                            isPriem = false;
                        }
                    }
                }
                */


            int delers = 0;

            for(int i = 1; i <= getal; i++)
            {
                if(getal % i == 0)
                {
                    delers++;
                }
            }
 
            if (delers == 2)
            {
                lblResultaat.Content = $"{getal} is een priemgetal";
                lblResultaat.Foreground = Brushes.Green;
            }
            else
            {
                lblResultaat.Content = $"{getal} is géén priemgetal";
                lblResultaat.Foreground = Brushes.Red;
            }
        }
    }
}
