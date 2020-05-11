using HouseApp.Models;
using System;
using System.Windows;

namespace HouseApp
{
    /// <summary>
    /// Interaction logic for ContactWindow.xaml
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
            House = new HouseModel();

            House.Address = uxAddress.Text;
            House.MarketValue = int.Parse(uxMarketValue.Text);
            House.DaysInMarket = int.Parse(uxDaysInMarket.Text);
            House.AgentName = uxAgentName.Text;
            House.AgentPhoneNumber = uxAgentPhoneNumber.Text;
            House.AgentEmailId = uxAgentEmailID.Text;
            House.Notes = uxNotes.Text;
            House.BuiltDate = DateTime.UtcNow;

            // This is the return value of ShowDialog( ) below
            DialogResult = true;
            Close();
        }

        private void uxCancel_Click(object sender, RoutedEventArgs e)
        {
            // This is the return value of ShowDialog( ) below
            DialogResult = false;
            Close();
        }
    }
}