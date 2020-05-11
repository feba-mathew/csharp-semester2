using HouseApp.Models;
using System.Linq;
using System.Windows;

namespace HouseApp
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            LoadContacts();
        }

        private void LoadContacts()
        {
            var contacts = App.HouseRepository.GetAll();

            uxHouseList.ItemsSource = contacts
                .Select(t => HouseModel.ToModel(t))
                .ToList();

            // OR
            //var uiContactModelList = new List<ContactModel>();
            //foreach (var repositoryContactModel in contacts)
            //{
            //    This is the .Select(t => ... )
            //    var uiContactModel = ContactModel.ToModel(repositoryContactModel);
            //
            //    uiContactModelList.Add(uiContactModel);
            //}

            //uxContactList.ItemsSource = uiContactModelList;
        }

        private void uxFileNew_Click(object sender, RoutedEventArgs e)
        {
            var window = new HouseWindow();

            if (window.ShowDialog() == true)
            {
                var uiHouseModel = window.House;

                var repositoryhouseModel = uiHouseModel.ToRepositoryModel();

                App.HouseRepository.Add(repositoryhouseModel);

                // OR
                //App.ContactRepository.Add(window.Contact.ToRepositoryModel());

                LoadContacts();
            }
        }

        private void uxFileChange_Click(object sender, RoutedEventArgs e)
        {
        }

        private void uxFileDelete_Click(object sender, RoutedEventArgs e)
        {
        }
    }
}