using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media.Imaging;
using System.Windows.Threading;

namespace WpfLandenRaden
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private List<string> countries = new List<string> { "Nieuw-Zeeland", "Finland", "Argentina", "Marokko", "Japan" };
        private Queue<string> shuffledCountries = new Queue<string>();
        private DispatcherTimer timer = new DispatcherTimer();
        private Stopwatch stopwatch = new Stopwatch();
        private List<double> responseTimes = new List<double>();
        private int correctGuesses = 0;

        public MainWindow()
        {
            InitializeComponent();
            timer.Interval = TimeSpan.FromSeconds(3);
            timer.Tick += Timer_Tick;
            ShuffleCountries();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            ShowNextCountry();
        }

        private void StartButton_Click(object sender, RoutedEventArgs e)
        {
            instructionLabel.Visibility = Visibility.Collapsed;
            startButton.IsEnabled = false;
            ShowNextCountry();
            timer.Start();
        }

        private void ShowNextCountry()
        {
            if (shuffledCountries.Any())
            {
                string nextCountry = shuffledCountries.Dequeue();
                countryLabel.Content = nextCountry;
                stopwatch.Restart();
            }
            else
            {
                timer.Stop();
                DisplayResults();
            }
        }

        private void Image_MouseUp(object sender, MouseButtonEventArgs e)
        {
            Image clickedImage = sender as Image;
            string clickedCountry = clickedImage.Tag.ToString();
            string selectedCountry = countryLabel.Content.ToString();

            if (clickedCountry == selectedCountry)
            {
                resultLabel.Content = "Juist!";
                PlaySound("right.wav");
                correctGuesses++;
            }
            else
            {
                resultLabel.Content = "Fout!";
                PlaySound("wrong.wav");
            }

            double elapsedSeconds = stopwatch.Elapsed.TotalSeconds;
            responseTimes.Add(elapsedSeconds);
            ShowNextCountry();
        }

        private void DisplayResults()
        {
            double averageResponseTime = responseTimes.Count > 0 ? responseTimes.Average() : 0;
            resultLabel.Content = $"Aantal correcte antwoorden: {correctGuesses}\nGemiddelde antwoordtijd: {averageResponseTime:F2} seconden";
            instructionLabel.Visibility = Visibility.Visible;
            instructionLabel.Content = "Raad zo snel mogelijk alle landen! Ben je klaar?";
            startButton.IsEnabled = true;
        }

        private void ShuffleCountries()
        {
            Random random = new Random();
            foreach (var country in countries.OrderBy(x => random.Next()))
            {
                shuffledCountries.Enqueue(country);
            }
        }
    }
}
