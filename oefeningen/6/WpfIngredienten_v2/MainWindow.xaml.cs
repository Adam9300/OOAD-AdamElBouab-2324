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

namespace WpfIngredienten_v2
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int aantalPersonen = Convert.ToInt32(cboAantalPersonen.Text);
            double hoeveelh1 = Convert.ToDouble(txtHoeveelheid1.Text);
            double hoeveelh2 = Convert.ToDouble(txtHoeveelheid2.Text);
            double hoeveelh3 = Convert.ToDouble(txtHoeveelheid3.Text);
            double hoeveelh4 = Convert.ToDouble(txtHoeveelheid4.Text);

            string boodschappen = $"- {aantalPersonen * hoeveelh1} {cboEenheid1.Text} {txtIngredient1.Text}{Environment.NewLine}";
            boodschappen += $"- {aantalPersonen * hoeveelh2} {cboEenheid2.Text} {txtIngredient2.Text}{Environment.NewLine}";
            boodschappen += $"- {aantalPersonen * hoeveelh3} {cboEenheid3.Text} {txtIngredient3.Text}{Environment.NewLine}";
            boodschappen += $"- {aantalPersonen * hoeveelh4} {cboEenheid4.Text} {txtIngredient4.Text}";

            txtBoodschappenlijst.Text = boodschappen;
        }
    }
}
