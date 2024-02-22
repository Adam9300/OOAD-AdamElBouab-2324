using System.Windows;
using System;



namespace WpfComplexityAnalysis
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Analyseer_Click(object sender, RoutedEventArgs e)
        {
            string woord = inputTextBox.Text.Trim();

            if (!string.IsNullOrEmpty(woord))
            {
                int aantalKarakters = woord.Length;
                int aantalLettergrepen = AantalLettergrepen(woord);
                double complexiteit = Complexiteit(woord);

                resultTextBlock1.Text = $"Aantal karakters: {aantalKarakters}";
                resultTextBlock2.Text = $"Aantal lettergrepen: {aantalLettergrepen}";
                resultTextBlock3.Text = $"Complexiteit: {Math.Round(complexiteit, 1):F1}";
            }
            else
            {
                MessageBox.Show("Voer een woord in.", "Waarschuwing", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

        private bool IsKlinker(char letter)
        {
            return "aeiouy".Contains(char.ToLower(letter).ToString());
        }

        private int AantalLettergrepen(string woord)
        {
            int count = 0;
            for (int i = 0; i < woord.Length; i++)
            {
                if (IsKlinker(woord[i]) && (i == 0 || !IsKlinker(woord[i - 1])))
                {
                    count++;
                }
            }
            return count;
        }

        private double Complexiteit(string woord)
        {
            double complexity = woord.Length / 3.0 + AantalLettergrepen(woord);

            int additionalComplexity = 0;
            foreach (char letter in woord)
            {
                if (letter == 'q' || letter == 'x' || letter == 'y')
                {
                    additionalComplexity++;
                }
            }

            return Math.Round(complexity + additionalComplexity, 1);
        }

        private void inputTextBox_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {

        }
    }
}