using System;
using System.Collections.Generic;

namespace AngularTest.Models.AODB
{
    public partial class PartCategory
    {
        public int CategoryId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string CreateUser { get; set; }
        public DateTime CreateDateTime { get; set; }
        public string DeactivateUser { get; set; }
        public DateTime? DeactivateDateTime { get; set; }
        public int? PreviousRecord { get; set; }
    }
}
