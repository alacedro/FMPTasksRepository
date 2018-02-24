using System;
using System.Collections.Generic;

namespace AngularTest.Models.AODB
{
    public partial class RejectReasonType
    {
        public int RejectReasonTypeId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool RequiresComment { get; set; }
        public DateTime CreateDateTime { get; set; }
        public string CreateUser { get; set; }
        public DateTime? ModifiedDateTime { get; set; }
        public string ModifiedUser { get; set; }
        public DateTime? DeactivateDateTime { get; set; }
        public string DeactivateUser { get; set; }
        public int? PreviousRecordId { get; set; }
    }
}
