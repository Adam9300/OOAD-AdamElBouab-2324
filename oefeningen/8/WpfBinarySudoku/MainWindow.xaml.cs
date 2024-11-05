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

namespace WpfBinarySudoku
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
        private void btnCheck_Click(object sender, RoutedEventArgs e)
        {
            // build message
            string message = "";

            // check board
            int numEmpty = 0;
            int numNonOneZero = 0;
            foreach (TextBox box in grdGame.Children)
            {
                // reset background color
                box.Background = Brushes.White;

                // check empty
                if (box.Text == "")
                {
                    box.Background = Brushes.LightCoral;
                    numEmpty++;
                }

                // check illegal entries
                if (box.Text != "" && box.Text != "0" && box.Text != "1")
                {
                    box.Background = Brushes.LightPink;
                    numNonOneZero++;
                }
            }
            if (numEmpty > 0)
            {
                message += numEmpty + " cellen zijn nog niet ingevuld!" + Environment.NewLine;
            }
            if (numNonOneZero > 0)
            {
                message += numNonOneZero + " cellen bevatten een illegale waarde!" + Environment.NewLine;
            }

            // show message
            MessageBox.Show(message);
        }
    }
}
