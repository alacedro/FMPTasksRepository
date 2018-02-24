using System;
using System.Collections.Generic;

namespace AngularTest.Models.AODB
{
    public partial class Page
    {
        public Page()
        {
            Control = new HashSet<Control>();
            ScreenItems = new HashSet<ScreenItems>();
        }

        public int PageId { get; set; }
        public int? Order { get; set; }
        public int LanguageId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public ICollection<Control> Control { get; set; }
        public ICollection<ScreenItems> ScreenItems { get; set; }
    }
}
