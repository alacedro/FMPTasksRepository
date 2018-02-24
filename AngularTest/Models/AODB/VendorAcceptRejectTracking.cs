using System;
using System.Collections.Generic;

namespace AngularTest.Models.AODB
{
    public partial class VendorAcceptRejectTracking
    {
        public int VendorAcceptRejectTrackingId { get; set; }
        public int WorkOrderId { get; set; }
        public int VendorId { get; set; }
        public DateTime? AcceptDateTime { get; set; }
        public DateTime? EndDateTime { get; set; }
        public DateTime? RejectDateTime { get; set; }
        public int RejectReasonId { get; set; }
        public string RejectReason { get; set; }
        public DateTime? DeactiveDateTime { get; set; }
        public string DeactivateUser { get; set; }
        public DateTime CreateDateTime { get; set; }
        public string CreatedUser { get; set; }
    }
}
