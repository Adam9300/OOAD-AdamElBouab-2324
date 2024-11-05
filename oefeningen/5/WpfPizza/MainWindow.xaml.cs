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

namespace WpfPizza
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
        private void rbnPizza1_Checked(object sender, RoutedEventArgs e)
        {
            txtPizza.Text = "Tomatensaus, mozzarella & oregano";
            imgPizza.Source = new BitmapImage(new Uri("Images/spicy.png", UriKind.Relative));
        }

        private void rbnPizza2_Checked(object sender, RoutedEventArgs e)
        {
            txtPizza.Text = "Tomatensaus, mozzarella, gegrilde ham & champignons";
            imgPizza.Source = new BitmapImage(new Uri("Images/seizoenen.png", UriKind.Relative));
        }

        private void rbnPizza3_Checked(object sender, RoutedEventArgs e)
        {
            txtPizza.Text = "Tomatensaus, mozzarella, rode ui, kip, paprika, pepperoni & spaanse pepers";
            imgPizza.Source = new BitmapImage(new Uri("Images/hawai.png", UriKind.Relative));
        }
        


    }
}
