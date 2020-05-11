using System.Windows;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace FinalProject
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
            var context = new db_houseDetailsContext();
            context.House.Load();
            uxList.ItemsSource = context.House.Local.ToObservableCollection();



            
        }
    }
}
