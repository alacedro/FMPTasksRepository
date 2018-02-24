using System;
using System.Collections.Generic;

namespace AngularTest.Models.AODB
{
    public partial class AutoApprovalServiceConfiguration
    {
        public int AutoApprovalServiceConfigurationId { get; set; }
        public decimal Tolerance { get; set; }
        public DateTime? DeactivateDateTime { get; set; }
        public string DeactivateUser { get; set; }
        public DateTime CreateDateTime { get; set; }
        public string CreateUser { get; set; }
    }
}
