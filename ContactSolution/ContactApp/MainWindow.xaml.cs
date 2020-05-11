using ContactApp.Models;
using System;
using System.ComponentModel;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;

namespace ContactApp
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
            var contacts = App.ContactRepository.GetAll();

            uxContactList.ItemsSource = contacts
                .Select(repositoryContact => ContactModel.ToModel(repositoryContact))
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
        private GridViewColumnHeader listViewSortCol = null;
        private SortAdorner listViewSortAdorner = null;
        private void GridViewColumnHeader_Click(object sender, RoutedEventArgs e)
        {

            GridViewColumnHeader column = (sender as GridViewColumnHeader);
            string sortBy = column.Tag.ToString();
            if (listViewSortCol != null)
            {
                AdornerLayer.GetAdornerLayer(listViewSortCol).Remove(listViewSortAdorner);
                uxContactList.Items.SortDescriptions.Clear();
            }

            ListSortDirection newDir = ListSortDirection.Ascending;
            if (listViewSortCol == column && listViewSortAdorner.Direction == newDir)
                newDir = ListSortDirection.Descending;

            listViewSortCol = column;
            listViewSortAdorner = new SortAdorner(listViewSortCol, newDir);
            AdornerLayer.GetAdornerLayer(listViewSortCol).Add(listViewSortAdorner);
            uxContactList.Items.SortDescriptions.Add(new SortDescription(sortBy, newDir));
        }
        private void uxFileNew_Click(object sender, RoutedEventArgs e)
        {
            var window = new ContactWindow();

            if (window.ShowDialog() == true)
            {
                var uiContactModel = window.Contact;

                var repositoryContactModel = uiContactModel.ToRepositoryModel();

                App.ContactRepository.Add(repositoryContactModel);

                // OR
                //App.ContactRepository.Add(window.Contact.ToRepositoryModel());

                LoadContacts();
            }
        }
        private ContactModel selectedContact;
        private void uxContactList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            selectedContact = (ContactModel)uxContactList.SelectedValue;
        }
        private void uxFileChange_Click(object sender, RoutedEventArgs e)
        {
            var window = new ContactWindow();
            window.Contact = selectedContact;

            if (window.ShowDialog() == true)
            {
                App.ContactRepository.Update(window.Contact.ToRepositoryModel());
                LoadContacts();
            }
        }

        private void uxFileChange_Loaded(object sender, RoutedEventArgs e)
        {
            uxFileChange.IsEnabled = (selectedContact != null);
            uxContextFileChange.IsEnabled = uxFileChange.IsEnabled;
        }

        private void uxFileDelete_Click(object sender, RoutedEventArgs e)
            {
                App.ContactRepository.Remove(selectedContact.Id);
                selectedContact = null;
                LoadContacts();
            }
         private void uxFileDelete_Loaded(object sender, RoutedEventArgs e)
            {
                uxFileDelete.IsEnabled = (selectedContact != null);
            uxContextFileDelete.IsEnabled = uxFileDelete.IsEnabled;
            }
        

        

      
    }
}