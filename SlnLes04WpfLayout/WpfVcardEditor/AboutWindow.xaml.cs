﻿    using System.Windows;

    namespace about
    {
        public partial class AboutWindow : Window
        {
            public AboutWindow()
            {
                InitializeComponent();
            }

            private void Close_Click(object sender, RoutedEventArgs e)
            {
                Close(); 
            }
        }
    }
