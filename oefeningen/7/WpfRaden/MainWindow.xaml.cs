using System;
using System.Windows;
using System.Windows.Controls;

namespace WpfRaden
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int getal;
        int pogingenOver = 3;

        public MainWindow()
        {
            InitializeComponent();
            Random rnd = new Random();
            getal = rnd.Next(1, 11);
        }

        private void btnCheck_Click(object sender, RoutedEventArgs e)
        {
            pogingenOver--;
            int gok = Convert.ToInt32(txtGok.Text);
            if (gok == getal)
            {
                lblPogingen.Content = "Gewonnen!";
                btnCheck.IsEnabled = false;
            }
            else if (gok < getal)
            {
                lblPogingen.Content = $"Te laag! Je hebt nog {pogingenOver} pogingen over";
            }
            else {
                lblPogingen.Content = $"Te Hoog! Je hebt nog {pogingenOver} pogingen over";
            }

            btnCheck.IsEnabled = (pogingenOver != 0);
        }

        private void txtGok_TextChanged(object sender, TextChangedEventArgs e)
        {
            btnCheck.IsEnabled = txtGok.Text != "";
        }

        
    }
}
