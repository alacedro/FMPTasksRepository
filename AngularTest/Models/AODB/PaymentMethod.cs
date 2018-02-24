using System;
using System.Collections.Generic;

namespace AngularTest.Models.AODB
{
    public partial class PaymentMethod
    {
        public PaymentMethod()
        {
            Vendor = new HashSet<Vendor>();
        }

        public int PaymentMethodId { get; set; }
        public string Method { get; set; }
        public string Description { get; set; }
        public DateTime? DeactivateDateTime { get; set; }
        public string DeactivateUser { get; set; }
        public DateTime CreateDateTime { get; set; }
        public string CreateUser { get; set; }

        public ICollection<Vendor> Vendor { get; set; }
    }
}
