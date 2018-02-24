using System;
using System.Collections.Generic;

namespace AngularTest.Models.AODB
{
    public partial class ControlRole
    {
        public int ControlUserId { get; set; }
        public int ControlId { get; set; }
        public int RoleId { get; set; }
        public int LanguageId { get; set; }
        public bool Read { get; set; }
        public bool Write { get; set; }

        public Control Control { get; set; }
    }
}
