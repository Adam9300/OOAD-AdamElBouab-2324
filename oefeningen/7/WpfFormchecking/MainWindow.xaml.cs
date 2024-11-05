using System.Windows;

namespace WpfFormchecking
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

        private void btnSend_Click(object sender, RoutedEventArgs e)
        {
            // aantal fouten
            int aantalFouten = 0;

            // wis foutmeldingen
            lblMessageName.Content = "";
            lblMessageEmail.Content = "";
            lblMessageGeboorte.Content = "";
            lblMessageProfiel.Content = "";
            lblMessagePaswoord.Content = "";
            lblMessageGeslacht.Content = "";
            lblMessageInteresses.Content = "";

            // check formulier
            if (txtNaam.Text == "")
            {
                lblMessageName.Content = "naam moet ingevuld zijn";
                aantalFouten++;
            } 
            if (txtEmail.Text == "")
            {
                lblMessageEmail.Content = "email moet ingevuld zijn";
                aantalFouten++;
            }
            if (datGeboorte.SelectedDate == null)
            {
                lblMessageGeboorte.Content = "datum moet ingevuld zijn";
                aantalFouten++;
            }
            if (lstProfiel.SelectedIndex == -1)
            {
                lblMessageProfiel.Content = "maak een keuze";
                aantalFouten++;
            }
            if (pwdPaswoord.Password == "")
            {
                lblMessagePaswoord.Content = "kies een paswoord";
                aantalFouten++;
            }
            if (rbnMan.IsChecked != true && rbnVrouw.IsChecked != true)
            {
                lblMessageGeslacht.Content = "kies een geslacht";
                aantalFouten++;
            }
            if (chbNetwerken.IsChecked != true && chbProgrammeren.IsChecked != true && chbBusiness.IsChecked != true)
            {
                lblMessageInteresses.Content = "kies minstens één interesse";
                aantalFouten++;
            }
            if (aantalFouten == 0)
            {
                lblNumFouten.Content = "bedankt voor de registratie";
                btnSend.IsEnabled = false;
                btnReset.IsEnabled = false;
            }
            else
            {
                lblNumFouten.Content = $"dit formulier bevat {aantalFouten} fouten";
            }
        }

        private void btnReset_Click(object sender, RoutedEventArgs e)
        {
            // wis foutmeldingen
            lblMessageName.Content = "";
            lblMessageEmail.Content = "";
            lblMessageGeboorte.Content = "";
            lblMessageProfiel.Content = "";
            lblMessagePaswoord.Content = "";
            lblMessageGeslacht.Content = "";
            lblMessageInteresses.Content = "";

            // reset controls
            txtNaam.Text = "";
            txtEmail.Text = "";
            datGeboorte.SelectedDate = null;
            lstProfiel.SelectedIndex = -1;
            pwdPaswoord.Password = "";
            rbnMan.IsChecked = false;
            rbnVrouw.IsChecked = false;
            chbBusiness.IsChecked = false;
            chbNetwerken.IsChecked = false;
            chbProgrammeren.IsChecked = false;

            // wis foutmelding
            lblNumFouten.Content = "";
        }

    }
}
