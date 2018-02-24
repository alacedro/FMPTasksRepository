using System;
using System.Collections.Generic;

namespace AngularTest.Models.AODB
{
    public partial class VendorTrade
    {
        public int VendorTradeId { get; set; }
        public int VendorId { get; set; }
        public int TradeId { get; set; }
        public bool IsFromParent { get; set; }
        public DateTime? DeactivateDateTime { get; set; }
        public string DeactivateUser { get; set; }
        public DateTime CreateDateTime { get; set; }
        public string CreateUser { get; set; }

        public Trade Trade { get; set; }
    }
}
