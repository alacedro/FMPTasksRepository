using System;
using System.Collections.Generic;

namespace AngularTest.Models.AODB
{
    public partial class Control
    {
        public Control()
        {
            ControlRole = new HashSet<ControlRole>();
            DisplayText = new HashSet<DisplayText>();
        }

        public int ControlId { get; set; }
        public int PageId { get; set; }
        public int ControlTypeId { get; set; }
        public int LanguageId { get; set; }
        public string Name { get; set; }
        public bool IsRequired { get; set; }

        public ControlType ControlType { get; set; }
        public Page Page { get; set; }
        public ICollection<ControlRole> ControlRole { get; set; }
        public ICollection<DisplayText> DisplayText { get; set; }
    }
}
