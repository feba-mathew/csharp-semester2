using HouseDB;

namespace HouseRepository
{
    public class DatabaseManager
    {
        private static readonly HousesContext entities;

        // Initialize and open the database connection
        static DatabaseManager()
        {
            entities = new HousesContext();
        }

        // Provide an accessor to the database
        public static HousesContext Instance
        {
            get
            {
                return entities;
            }
        }
    }
}
