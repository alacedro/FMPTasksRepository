using System;
using System.Collections.Generic;

namespace AngularTest.Models.AODB
{
    public partial class XmllogArc
    {
        public int XmllogId { get; set; }
        public int? ClientId { get; set; }
        public int? VendorId { get; set; }
        public int? WorkOrderId { get; set; }
        public int? DbId { get; set; }
        public int XmllogTypeId { get; set; }
        public string Xml { get; set; }
        public string XmlResult { get; set; }
        public int Status { get; set; }
        public DateTime CreateDateTime { get; set; }
        public int? ExceptionId { get; set; }
        public int? UserId { get; set; }
        public string UserName { get; set; }
        public string From { get; set; }
        public string To { get; set; }
        public int? RetryCount { get; set; }
        public string TransmittedData { get; set; }
    }
}
