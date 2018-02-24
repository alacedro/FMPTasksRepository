using System;
using System.Collections.Generic;

namespace AngularTest.Models.AODB
{
    public partial class ControlType
    {
        public ControlType()
        {
            Control = new HashSet<Control>();
        }

        public int ControlTypeId { get; set; }
        public int? LanguageId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public ICollection<Control> Control { get; set; }
    }
}
