using System;
using System.Collections.Generic;

namespace AngularTest.Models.AODB
{
    public partial class VendorMatch
    {
        public int VendorMatchId { get; set; }
        public int ClientId { get; set; }
        public string Pilot2VendorCode { get; set; }
        public string ClientVendorCode { get; set; }
    }
}
