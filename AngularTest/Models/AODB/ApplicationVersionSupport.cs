using System;
using System.Collections.Generic;

namespace AngularTest.Models.AODB
{
    public partial class ApplicationVersionSupport
    {
        public int ApplicationVersionSupportId { get; set; }
        public string ApplicationName { get; set; }
        public string Version { get; set; }
        public bool IsCurrentlySupportedByApi { get; set; }
        public DateTime CreateDateTime { get; set; }
        public string CreateUser { get; set; }
        public DateTime? ModifiedDateTime { get; set; }
        public string ModifiedUser { get; set; }
        public DateTime? DeactivateDateTime { get; set; }
        public string DeactivateUser { get; set; }
        public int? PreviousRecordId { get; set; }
    }
}
