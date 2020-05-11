using System.Windows;

namespace HouseApp
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private static HouseRepository.HouseRepository houseRepository;

        static App()
        {
            houseRepository = new HouseRepository.HouseRepository();
        }

        public static HouseRepository.HouseRepository HouseRepository
        {
            get
            {
                return houseRepository;
            }
        }

    }
}
