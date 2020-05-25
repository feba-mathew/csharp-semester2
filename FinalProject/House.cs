using System;
using System.Collections.Generic;

namespace FinalProject
{
    public partial class HouseDetails
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
}
