
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;


namespace Homework3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            uxSubmit.IsEnabled = false;
        }

        private void uxName_TextChanged(object sender, TextChangedEventArgs e)
        {
            // Create string variables that contain the patterns   
            string zipCodePatternUS = @"^[0-9]{5}(?:-[0-9]{4})?$";
            string zipCodePatternCanadian = @"^(?!.*[DFIOQU])[A-VXY][0-9][A-Z] ?[0-9][A-Z][0-9]$";

            bool isZipValid = Regex.IsMatch(uxName.Text, zipCodePatternUS) || Regex.IsMatch(uxName.Text, zipCodePatternCanadian);

            if(isZipValid)
            {
                uxSubmit.IsEnabled = true;
            }
            else
            {
                uxSubmit.IsEnabled = false;
            }
           
        }
    }
}
