using System;
using System.Collections.Generic;

namespace FinalProject
{
    public partial class House
    {
        public int HouseId { get; set; }
        public int HouseNo { get; set; }
        public string Owner { get; set; }
        public int NoOfPreviousOwners { get; set; }
        public double MarketValue { get; set; }
        public int DaysOnMarket { get; set; }
        public DateTime BuiltDate { get; set; }
        public int TotalSqft { get; set; }
    }
}
