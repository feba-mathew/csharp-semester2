// Homework 1

using System;
using System.Windows;

namespace HelloWorld
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            //Ex:1
            WindowState = WindowState.Maximized;
            uxName.Focus();
        }

        private void uxSubmit_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Submitting password:" + uxPassword.Text);
        }

        private void dataChanged(object sender, EventArgs e)
        {
            if (uxName.Text.Length == 0 || uxPassword.Text.Length == 0)
            {
                uxSubmit.IsEnabled = false;
            }
            else if (uxName.Text.Length != 0 && uxPassword.Text.Length != 0)
            {
                uxSubmit.IsEnabled = true;
            }
        }
    }
}
