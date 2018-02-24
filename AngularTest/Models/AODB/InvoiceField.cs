using System;
using System.Collections.Generic;

namespace AngularTest.Models.AODB
{
    public partial class InvoiceField
    {
        public int InvoiceFieldId { get; set; }
        public string FieldName { get; set; }
        public DateTime CreateDateTime { get; set; }
        public string CreateUser { get; set; }
        public DateTime? DeactivateDateTime { get; set; }
        public string DeactivateUser { get; set; }
    }
}
