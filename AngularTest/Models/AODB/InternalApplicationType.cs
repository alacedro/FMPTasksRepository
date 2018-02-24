using System;
using System.Collections.Generic;

namespace AngularTest.Models.AODB
{
    public partial class InternalApplicationType
    {
        public InternalApplicationType()
        {
            InternalUserFilter = new HashSet<InternalUserFilter>();
        }

        public int InternalApplicationTypeId { get; set; }
        public string ApplicationName { get; set; }

        public ICollection<InternalUserFilter> InternalUserFilter { get; set; }
    }
}
