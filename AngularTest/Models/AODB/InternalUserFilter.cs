using System;
using System.Collections.Generic;

namespace AngularTest.Models.AODB
{
    public partial class InternalUserFilter
    {
        public int InternalUserFilterId { get; set; }
        public int UserId { get; set; }
        public int InternalApplicationTypeId { get; set; }
        public string Name { get; set; }
        public string Filter { get; set; }
        public string Sorter { get; set; }

        public InternalApplicationType InternalApplicationType { get; set; }
        public User User { get; set; }
    }
}
