using System;
using System.Collections.Generic;

namespace AngularTest.Models.AODB
{
    public partial class EmailDistributionListType
    {
        public int EmailDistributionListTypeId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime CreateDateTime { get; set; }
        public string CreateUser { get; set; }
        public DateTime? ModifiedDateTime { get; set; }
        public string ModifiedUser { get; set; }
        public DateTime? DeactivateDateTime { get; set; }
        public string DeactivateUser { get; set; }
    }
}
