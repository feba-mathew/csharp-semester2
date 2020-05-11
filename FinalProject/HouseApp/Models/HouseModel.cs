using System;
using System.Collections.Generic;
using System.Text;

namespace HouseApp.Models
{
    public class HouseModel
    {
        public int HouseId { get; set; }
        public string Address { get; set; }
        public string LotSize { get; set; }
        public int MarketValue { get; set; }
        public System.DateTime BuiltDate { get; set; }
        public int DaysInMarket { get; set; }
        public string AgentName { get; set; }
        public string AgentPhoneNumber { get; set; }
        public string AgentEmailId { get; set; }
        public string Notes { get; set; }

        public HouseRepository.HouseModel ToRepositoryModel()
        {
            var repositoryModel = new HouseRepository.HouseModel
            {
                HouseId = HouseId,
                Address = Address,
                LotSize = LotSize,
                MarketValue = MarketValue,
                BuiltDate = BuiltDate,
                DaysInMarket = DaysInMarket,
                AgentName = AgentName,
                AgentPhoneNumber = AgentPhoneNumber,
                AgentEmailId = AgentEmailId,
                Notes = Notes
             };

            return repositoryModel;
        }

        public static HouseModel ToModel(HouseRepository.HouseModel respositoryModel)
        {
            var houseModel = new HouseModel
            {
                HouseId = respositoryModel.HouseId,
                Address = respositoryModel.Address,
                LotSize = respositoryModel.LotSize,
                MarketValue = respositoryModel.MarketValue,
                BuiltDate = respositoryModel.BuiltDate,
                DaysInMarket = respositoryModel.DaysInMarket,
                AgentName = respositoryModel.AgentName,
                AgentPhoneNumber = respositoryModel.AgentPhoneNumber,
                AgentEmailId = respositoryModel.AgentEmailId,
                Notes = respositoryModel.Notes
            };

            return houseModel;
        }
    }
}

