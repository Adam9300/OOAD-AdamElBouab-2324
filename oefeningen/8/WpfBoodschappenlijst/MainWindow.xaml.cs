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

namespace WpfBoodschappenlijst
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

        private void lstProducts_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string geselecteerd = "";

            // verzameling elementen overlopen: SelectedItems is verzameling van ListBoxItem
            foreach (ListBoxItem item in lstProducts.SelectedItems)
            {
                string inhoud = Convert.ToString(item.Content);
                geselecteerd += " " + inhoud;
            }
            lblGeselecteerd.Content = "Je selecteerde: " + geselecteerd;
        }
    }
}
