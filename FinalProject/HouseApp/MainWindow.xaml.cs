using HouseApp.Models;
using System.ComponentModel;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;

namespace HouseApp
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            LoadHouses();
        }

        private void LoadHouses()
        {
            var houses = App.HouseRepository.GetAll();

            uxHouseList.ItemsSource = houses
                .Select(t => HouseModel.ToModel(t))
                .ToList();

           
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
                uxHouseList.Items.SortDescriptions.Clear();
            }

            ListSortDirection newDir = ListSortDirection.Ascending;
            if (listViewSortCol == column && listViewSortAdorner.Direction == newDir)
                newDir = ListSortDirection.Descending;

            listViewSortCol = column;
            listViewSortAdorner = new SortAdorner(listViewSortCol, newDir);
            AdornerLayer.GetAdornerLayer(listViewSortCol).Add(listViewSortAdorner);
            uxHouseList.Items.SortDescriptions.Add(new SortDescription(sortBy, newDir));
        }

        private HouseModel selectedHouse;
        private void uxHouseList_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            selectedHouse = (HouseModel)uxHouseList.SelectedValue;
        }
        private void uxFileNew_Click(object sender, RoutedEventArgs e)
        {
            var window = new HouseWindow();

            if (window.ShowDialog() == true)
            {
                var uiHouseModel = window.House;

                var repositoryhouseModel = uiHouseModel.ToRepositoryModel();

                App.HouseRepository.Add(repositoryhouseModel);

                LoadHouses();
            }
        }
        private void updatefile()
        {
            var window = new HouseWindow();
            window.House = selectedHouse;

            if (window.ShowDialog() == true)
            {
                App.HouseRepository.Update(window.House.ToRepositoryModel());
                LoadHouses();
            }
        }

        private void uxHouseList_MouseDoubleClick(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            updatefile();
        }
        private void uxFileChange_Click(object sender, RoutedEventArgs e)
        {
            updatefile();
        }

        private void uxFileChange_Loaded(object sender, RoutedEventArgs e)
        {
            uxFileChange.IsEnabled = (selectedHouse != null);
            uxHouseFileChange.IsEnabled = uxFileChange.IsEnabled;
        }

        private void uxFileDelete_Click(object sender, RoutedEventArgs e)
        {
            App.HouseRepository.Remove(selectedHouse.HouseId);
            selectedHouse = null;
            LoadHouses();
        }

        private void uxFileDelete_Loaded(object sender, RoutedEventArgs e)
        {
            uxFileDelete.IsEnabled = (selectedHouse != null);
            uxHouseFileDelete.IsEnabled = uxFileDelete.IsEnabled;
        }

       
    }
}