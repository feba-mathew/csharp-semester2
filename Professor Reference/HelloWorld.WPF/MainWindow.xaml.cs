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
using Microsoft.EntityFrameworkCore;

namespace HelloWorld
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Models.User user = new Models.User();

        public MainWindow()
        {
            InitializeComponent();

            uxWindow.DataContext = user;

            // Ex #1
            //WindowState = WindowState.Maximized;

            uxContainer.DataContext = user;

            var sample = new SampleContext();
            sample.User.Load();
            uxList.ItemsSource = sample.User.Local.ToObservableCollection();
        }

        private void uxSubmit_Click(object sender, RoutedEventArgs e)
        {
            int x = 1;
            x = x / 0;

            MessageBox.Show("Submitting password:" + uxPassword.Text);

            var window = new SecondWindow();
            Application.Current.MainWindow = window;
            Close();
            window.Show();
        }
    }
}
