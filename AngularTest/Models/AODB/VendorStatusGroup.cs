﻿using System;
using System.Collections.Generic;

namespace AngularTest.Models.AODB
{
    public partial class VendorStatusGroup
    {
        public VendorStatusGroup()
        {
            VendorStatusGroupMapping = new HashSet<VendorStatusGroupMapping>();
        }

        public int VendorStatusGroupId { get; set; }
        public string Name { get; set; }
        public string DisplayText { get; set; }
        public DateTime? DeactivateDateTime { get; set; }
        public string DeactivateUser { get; set; }
        public DateTime CreateDateTime { get; set; }
        public string CreateUser { get; set; }
        public int? PreviousRecordId { get; set; }

        public ICollection<VendorStatusGroupMapping> VendorStatusGroupMapping { get; set; }
    }
}
