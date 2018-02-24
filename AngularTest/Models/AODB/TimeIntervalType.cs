using System;
using System.Collections.Generic;

namespace AngularTest.Models.AODB
{
    public partial class TimeIntervalType
    {
        public int TimeIntervalTypeId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedUser { get; set; }
        public DateTime ModifyDate { get; set; }
        public string ModifyUser { get; set; }
        public DateTime? DeactivateDateTime { get; set; }
        public string DeactivateUser { get; set; }
    }
}
