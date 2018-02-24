﻿using System;
using System.Collections.Generic;

namespace AngularTest.Models.AODB
{
    public partial class LocationType
    {
        public int LocationTypeId { get; set; }
        public int? LanguageId { get; set; }
        public int? Order { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime? DeactivateDateTime { get; set; }
        public string DeactivateUser { get; set; }
        public DateTime CreateDateTime { get; set; }
        public string CreateUser { get; set; }
        public int? PreviousRecordId { get; set; }
    }
}
