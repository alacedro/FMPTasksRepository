using System;
using System.Collections.Generic;

namespace AngularTest.Models.AODB
{
    public partial class Ssoattribute
    {
        public int SsoattributeId { get; set; }
        public string Name { get; set; }
        public string Value { get; set; }
        public DateTime? DeactivateDateTime { get; set; }
        public string DeactivateUser { get; set; }
        public DateTime CreateDateTime { get; set; }
        public string CreateUser { get; set; }
        public DateTime ModifiedDateTime { get; set; }
        public string ModifiedUser { get; set; }
    }
}
