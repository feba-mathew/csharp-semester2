using HouseApp.Models;
using System;
using System.Windows;
using System.Text.RegularExpressions;

namespace HouseApp
{
    /// <summary>
    /// Interaction logic for HouseWindow.xaml
    /// </summary>
    public partial class HouseWindow : Window
    {
        public HouseWindow()
        {
            InitializeComponent();

            // Don't show this window in the task bar
            ShowInTaskbar = false;
        }

        public HouseModel House { get; set; }

        private void uxSubmit_Click(object sender, RoutedEventArgs e)
        {
            if (!ValidateEntries())
                return;

            House.Address = uxAddress.Text;
            House.ZipCode = uxZipCode.Text;
            House.LotSize = uxLotSize.Text;
            House.MarketValue = int.Parse(uxMarketValue.Text);
            House.DaysInMarket = int.Parse(uxDaysInMarket.Text);
            House.AgentName = uxAgentName.Text;
            House.AgentPhoneNumber = uxAgentPhoneNumber.Text;
            House.AgentEmailId = uxAgentEmailID.Text;
            House.Notes = uxNotes.Text;
            House.BuiltDate = DateTime.Parse(uxBuiltDate.Text);

            // This is the return value of ShowDialog( ) below
            DialogResult = true;
            Close();
        }

        private bool ValidateEntries()
        {
            string errorMessage = "";

            // Validate Required Fields
            if(uxAddress.Text.Length == 0)
            {
                errorMessage += "\n" + "Address cannot be empty";
            }
            if(uxZipCode.Text.Length == 0)
            {
                errorMessage += "\n" + "Zipcode cannot be empty";
            }
            if (uxAgentName.Text.Length == 0)
            {
                errorMessage += "\n" + "Agent Name cannot be empty";
            }
            if (uxAgentPhoneNumber.Text.Length == 0)
            {
                errorMessage += "\n" + "Agent Phone Number cannot be empty";
            }
            if (uxBuiltDate.Text.Length == 0)
            {
                errorMessage += "\n" + "Built Date cannot be empty";
            }

            if(errorMessage.Length > 0)
            {
                MessageBox.Show(errorMessage, "Required Fields", MessageBoxButton.OK);
                return false;
            }

            // Required Fields have been entered correctly

            // Validate Content
            if (!int.TryParse(uxZipCode.Text, out int zipCode))
            {
                errorMessage += "\n" + "Zip Code must be numeric";
            }
           
            if(uxAgentEmailID.Text.Length > 0)
            {
                try
                {
                    var addr = new System.Net.Mail.MailAddress(uxAgentEmailID.Text);
                }
                catch 
                { 
                    errorMessage += "\n" + "Agent E-mail ID not in correct format";
                }
            }

            if (errorMessage.Length > 0)
            {
                MessageBox.Show(errorMessage, "Content Validation", MessageBoxButton.OK);
                return false;
            }

            return errorMessage.Length == 0;

        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            if (House != null)
            {
                uxAddress.Text = House.Address;
                uxZipCode.Text = House.ZipCode;
                uxLotSize.Text = House.LotSize;
                uxDaysInMarket.Text = House.DaysInMarket.ToString();
                uxMarketValueSlider.Value = House.MarketValue;
                uxAgentName.Text = House.AgentName;
                uxAgentPhoneNumber.Text = House.AgentPhoneNumber.ToString();
                uxAgentEmailID.Text = House.AgentEmailId;
                uxNotes.Text = House.Notes;
                uxBuiltDate.Text = House.BuiltDate.ToString(); 
                uxSubmit.Content = "Update";
            }
            else
            {
                House = new HouseModel();
            }

            uxGrid.DataContext = House;
        }

        private void uxCancel_Click(object sender, RoutedEventArgs e)
        {
            // This is the return value of ShowDialog( ) below
            DialogResult = false;
            Close();
        }
    }
}