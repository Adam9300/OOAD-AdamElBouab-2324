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

namespace WpfIngredienten
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
               

        private void btnMaakLijst_Click(object sender, RoutedEventArgs e)
        {
            int aantalPersonen = Convert.ToInt32(txtAantalPersonen.Text);
            double aantal1 = Convert.ToDouble(txtHoeveelheid1.Text);
            double aantal2 = Convert.ToDouble(txtHoeveelheid2.Text);
            double aantal3 = Convert.ToDouble(txtHoeveelheid3.Text);
            double aantal4 = Convert.ToDouble(txtHoeveelheid4.Text);

            string ingredienten = $"- {aantal1 * aantalPersonen} {txtEenheid1.Text} {txtIngredient1.Text} {Environment.NewLine}";
            ingredienten += $"- {aantal2 * aantalPersonen} {txtEenheid2.Text} {txtIngredient2.Text} {Environment.NewLine}";
            ingredienten += $"- {aantal3 * aantalPersonen} {txtEenheid3.Text} {txtIngredient3.Text} {Environment.NewLine}";
            ingredienten += $"- {aantal4 * aantalPersonen} {txtEenheid4.Text} {txtIngredient4.Text}";

            txtBoodschappenlijst.Text = ingredienten;

        }
    }
}
