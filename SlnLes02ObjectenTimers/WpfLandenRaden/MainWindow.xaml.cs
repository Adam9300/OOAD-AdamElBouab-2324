using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace WpfLandenRaden
{
    public partial class MainWindow : Window
    {
        private List<string> countries = new List<string> { "Argentina", "Finland", "Japan", "Marokko", "Nieuw-Zeeland" };
        private Random random = new Random();

        private void StartGame()
        {
            instructionLabel.Visibility = Visibility.Collapsed;
            ShuffleList(countries); // Schud de lijst met landnamen
            countryLabel.Content = "Klaar om te raden!";
            StartNextRound();
        }

        private void StartNextRound()
        {
            if (countries.Any())
            {
                string selectedCountry = countries.First();
                countries.RemoveAt(0);

                countryLabel.Content = selectedCountry;
            }
            else
            {
                countryLabel.Content = "Spel voorbij!";
            }

            resultLabel.Content = "";
        }

        private void Image_MouseUp(object sender, MouseButtonEventArgs e)
        {
            Image clickedImage = sender as Image;
            string clickedLand = clickedImage.Tag.ToString();
            string selectedCountry = countryLabel.Content.ToString();

            if (clickedLand == selectedCountry)
            {
                resultLabel.Content = "Juist!";
                PlaySound("Sounds/wright.wav");
            }
            else
            {
                resultLabel.Content = "Fout!";
                PlaySound("C:\\Users\\Adam\\Desktop\\GitHub\\OOAD-AdamElBouab-2324\\SlnLes02ObjectenTimers\\WpfLandenRaden\\Sounds\\wrong.wav");

            }

            StartNextRound();
        }

        private void ShuffleList<T>(List<T> list)
        {
            int n = list.Count;
            while (n > 1)
            {
                n--;
                int k = random.Next(n + 1);
                T value = list[k];
                list[k] = list[n];
                list[n] = value;
            }
        }
    }