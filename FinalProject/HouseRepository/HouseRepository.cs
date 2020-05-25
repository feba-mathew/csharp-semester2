using HouseDB;
using System.Collections.Generic;
using System.Linq;

namespace HouseRepository
{
    public class HouseModel
    {
        public int HouseId { get; set; }
        public string Address { get; set; }
        public string ZipCode { get; set; }
        public string LotSize { get; set; }
        public int MarketValue { get; set; }
        public System.DateTime BuiltDate { get; set; }
        public int DaysInMarket { get; set; }
        public string AgentName { get; set; }
        public string AgentPhoneNumber { get; set; }
        public string AgentEmailId { get; set; }
        public string Notes { get; set; }
    }

    public class HouseRepository
    {
        public HouseModel Add(HouseModel houseModel)
        {
            var houseDb = ToDbModel(houseModel);

            DatabaseManager.Instance.HouseDetails.Add(houseDb);
            DatabaseManager.Instance.SaveChanges();

            houseModel = new HouseModel
            {
                HouseId = houseDb.HouseId,
                Address = houseDb.HouseAddress,
                ZipCode = houseDb.ZipCode,
               LotSize = houseDb.LotSize,
               MarketValue = houseDb.MarketValue,
               BuiltDate = houseDb.BuiltDate,
               DaysInMarket = (int)houseDb.DaysInMarket,
               AgentName = houseDb.AgentName,
               AgentPhoneNumber = houseDb.AgentPhoneNumber,
               AgentEmailId = houseDb.AgentEmail,
               Notes = houseDb.Notes

            };
            return houseModel;
        }

        public List<HouseModel> GetAll()
        {
            // Use .Select() to map the database Houses to HouseModel
            var items = DatabaseManager.Instance.HouseDetails
              .Select(t => new HouseModel
              {
                  HouseId = t.HouseId,
                  Address = t.HouseAddress,
                  ZipCode = t.ZipCode,
                  LotSize = t.LotSize,
                  MarketValue = t.MarketValue,
                  BuiltDate = t.BuiltDate,
                  DaysInMarket = (int)t.DaysInMarket,
                  AgentName = t.AgentName,
                  AgentPhoneNumber = t.AgentPhoneNumber,
                  AgentEmailId = t.AgentEmail,
                  Notes = t.Notes
              }).ToList();

            return items;
        }

        public bool Update(HouseModel houseModel)
        {
            var original = DatabaseManager.Instance.HouseDetails.Find(houseModel.HouseId);

            if (original != null)
            {
                DatabaseManager.Instance.Entry(original).CurrentValues.SetValues(ToDbModel(houseModel));
                DatabaseManager.Instance.SaveChanges();
                return true;
            }

            return false;
        }

        public bool Remove(int houseId)
        {
            var items = DatabaseManager.Instance.HouseDetails
                                .Where(t => t.HouseId == houseId);

            if (items.Count() == 0)
            {
                return false;
            }

            DatabaseManager.Instance.HouseDetails.Remove(items.First());
            DatabaseManager.Instance.SaveChanges();

            return true;
        }

        private HouseDetails ToDbModel(HouseModel houseModel)
        {
            var houseDb = new HouseDetails
            {
                HouseId = houseModel.HouseId,
                HouseAddress = houseModel.Address,
                ZipCode = houseModel.ZipCode,
                LotSize = houseModel.LotSize,
                MarketValue = houseModel.MarketValue,
                BuiltDate = houseModel.BuiltDate,
                DaysInMarket = houseModel.DaysInMarket,
                AgentName = houseModel.AgentName,
                AgentPhoneNumber = houseModel.AgentPhoneNumber,
                AgentEmail = houseModel.AgentEmailId,
                Notes = houseModel.Notes
            };

            return houseDb;
        }
    }
}