using System;
using System.Collections.Generic;

namespace AngularTest.Models.AODB
{
    public partial class AvalaraConfiguration
    {
        public int AvalaraConfigurationId { get; set; }
        public string BaseUri { get; set; }
        public string Token { get; set; }
        public DateTime CreateDateTime { get; set; }
        public string CreateUser { get; set; }
        public DateTime? ModifiedDateTime { get; set; }
        public string ModifiedUser { get; set; }
        public DateTime? DeactivateDateTime { get; set; }
        public string DeactivateUser { get; set; }
        public int? PreviousRecordId { get; set; }
    }
}
