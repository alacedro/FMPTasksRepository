using System;
using System.Collections.Generic;

namespace AngularTest.Models.AODB
{
    public partial class InvoiceTestType
    {
        public int InvoiceTestTypeId { get; set; }
        public string DisplayName { get; set; }
        public DateTime CreateDateTime { get; set; }
        public string CreateUser { get; set; }
    }
}
