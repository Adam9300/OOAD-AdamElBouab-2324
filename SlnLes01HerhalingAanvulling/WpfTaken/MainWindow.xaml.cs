using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace TaskManagerApp
{
    public partial class MainWindow : Window
    {
        private Stack<ListBoxItem> deletedItems = new Stack<ListBoxItem>();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            string taskDescription = TaakTextB.Text;
            if (!string.IsNullOrWhiteSpace(taskDescription))
            {
                ListBoxItem item = new ListBoxItem();
                item.Content = $"{taskDescription} (deadline: {DeadlineDatePicker.SelectedDate?.ToString("dd/MM/yyyy")}; door: {GetSelectedAssignee()})";
                item.Background = GetPriorityColor();
                TaskListBox.Items.Add(item);
                TaakTextB.Clear();
                CheckForm();
            }
        }

        private void RemoveButton_Click(object sender, RoutedEventArgs e)
        {
            if (TaskListBox.SelectedItem != null)
            {
                ListBoxItem selectedItem = (ListBoxItem)TaskListBox.SelectedItem;
                TaskListBox.Items.Remove(selectedItem);
                deletedItems.Push(selectedItem);
                CheckForm();
            }
        }

        private void RestoreButton_Click(object sender, RoutedEventArgs e)
        {
            if (deletedItems.Count > 0)
            {
                ListBoxItem itemToRestore = deletedItems.Pop();
                TaskListBox.Items.Add(itemToRestore);
                CheckForm();
            }
        }


        private void CheckForm()
        {
            bool isTaskEmpty = string.IsNullOrWhiteSpace(TaakTextB.text);
            bool isPrioritySelected = PrioriteitComboBox.SelectedItem != null;
            bool isDeadlineSelected = DeadlineDatePicker.SelectedDate != null;
            bool isAtLeastOneAssigned = AdamRadioButton.IsChecked == true || BilalRadioButton.IsChecked == true || ChelseyRadioButton.IsChecked == true;

            if (!isTaskEmpty && isPrioritySelected && isDeadlineSelected && isAtLeastOneAssigned)
            {
                // Geen foutmelding dan leeg maken
                AddButton.IsEnabled = true;
                TaakErrorTextBlock.Text = "";
            }
            else
            {
                AddButton.IsEnabled = false; 

                // Toon foutmeldingen afhankelijk van de ontbrekende gegevens
                if (!isDeadlineSelected)
                {
                    TaakErrorTextBlock.Text = "Gelieve een deadline te kizenen";
                    TaakErrorTextBlock.Text = "Gelieve een uitvoerder te kiezen";
                }



                // Schakel de verwijder-en herstelknoppen in of uit op basis van de geselecteerde items
                RemoveButton.IsEnabled = TaskListBox.SelectedItem != null;
                RestoreButton.IsEnabled = deletedItems.Count > 0;
            }

            private SolidColorBrush GetPriorityColor()
            {
                string priority = ((ComboBoxItem)PrioriteitComboBox.SelectedItem).Content.ToString().ToLower();
                switch (priority)
                {
                    case "laag":
                        return Brushes.LightGreen;
                    case "gemiddeld":
                        return Brushes.Orange;
                    case "hoog":
                        return Brushes.Red;
                    default:
                        return Brushes.White; // Standaardkleur 
                }



                private string GetSelectedAssignee()
            {
                if (AdamRadioButton.IsChecked == true)
                    return "Adam";
                else if (BilalRadioButton.IsChecked == true)
                    return "Bilal";
                else if (ChelseyRadioButton.IsChecked == true)
                    return "Chelsey";
               
            }
        }
    }