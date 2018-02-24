using System;
using System.Collections.Generic;

namespace AngularTest.Models.AODB
{
    public partial class FormControl
    {
        public int ControlId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string PageDescription { get; set; }
        public string FilePath { get; set; }
        public DateTime CreateDateTime { get; set; }
        public string CreateUser { get; set; }
        public DateTime? DeactivateDateTime { get; set; }
        public string DeactivateUser { get; set; }
        public string ControlCategory { get; set; }
    }
}
