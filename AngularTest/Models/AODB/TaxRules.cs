using System;
using System.Collections.Generic;

namespace AngularTest.Models.AODB
{
    public partial class TaxRules
    {
        public int Id { get; set; }
        public int StateId { get; set; }
        public int LineItemTypeId { get; set; }
        public bool Enabled { get; set; }

        public LineItemType LineItemType { get; set; }
        public State State { get; set; }
    }
}
