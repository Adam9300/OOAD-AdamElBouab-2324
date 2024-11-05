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

namespace WpfBieden
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int hoogsteBod = 0;
        string hoogsteBieder;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnBieden_Click(object sender, RoutedEventArgs e)
        {
            int bod = Convert.ToInt32(txtBod.Text);
            string naam = txtNaam.Text;
            if (bod > hoogsteBod)
            {
                lblBericht.Content = $"{naam} heeft met {bod} euro nu het hoogste bod!";
                hoogsteBod = bod;
                hoogsteBieder = naam;
            }
            else
            {
                lblBericht.Content = $"Sorry, {hoogsteBieder} heeft momenteel het hoogste bod.";
            }
            txtNaam.Text = "";
            txtBod.Text = "";
        }
    }
}
