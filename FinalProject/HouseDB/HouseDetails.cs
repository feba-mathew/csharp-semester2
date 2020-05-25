using System;
using System.Collections.Generic;

namespace HouseDB
{
    public partial class House
    {
        public int HouseId { get; set; }
        public string HouseAddress { get; set; }
        public string ZipCode { get; set; }
        public string LotSize { get; set; }
        public int MarketValue { get; set; }
        public DateTime BuiltDate { get; set; }
        public int? DaysInMarket { get; set; }
        public string AgentName { get; set; }
        public string AgentEmail { get; set; }
        public string AgentPhoneNumber { get; set; }
        public string Notes { get; set; }
    }
}
