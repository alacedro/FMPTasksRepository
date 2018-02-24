using System;
using System.Collections.Generic;

namespace AngularTest.Models.AODB
{
    public partial class MarkUpRateType
    {
        public MarkUpRateType()
        {
            MarkUp = new HashSet<MarkUp>();
        }

        public int Id { get; set; }
        public string Value { get; set; }

        public ICollection<MarkUp> MarkUp { get; set; }
    }
}
