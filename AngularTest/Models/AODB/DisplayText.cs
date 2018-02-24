using System;
using System.Collections.Generic;

namespace AngularTest.Models.AODB
{
    public partial class DisplayText
    {
        public int DisplayTextId { get; set; }
        public int LanguageId { get; set; }
        public int ControlId { get; set; }
        public string Text { get; set; }

        public Control Control { get; set; }
    }
}
