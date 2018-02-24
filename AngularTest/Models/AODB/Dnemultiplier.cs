using System;
using System.Collections.Generic;

namespace AngularTest.Models.AODB
{
    public partial class Dnemultiplier
    {
        public int DnemutiplierId { get; set; }
        public int DestinationClientId { get; set; }
        public decimal Multiplier { get; set; }
        public string DeactivateUser { get; set; }
        public DateTime? DeactivateDateTime { get; set; }
        public string CreateUser { get; set; }
        public DateTime CreateDateTime { get; set; }
        public string ModifyUser { get; set; }
        public DateTime ModifyDateTime { get; set; }
    }
}
