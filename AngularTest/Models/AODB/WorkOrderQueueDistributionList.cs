using System;
using System.Collections.Generic;

namespace AngularTest.Models.AODB
{
    public partial class WorkOrderQueueDistributionList
    {
        public WorkOrderQueueDistributionList()
        {
            WorkOrderQueueDistributionAddress = new HashSet<WorkOrderQueueDistributionAddress>();
            WorkOrderQueueNotificationWorkOrderQueueDistributionList = new HashSet<WorkOrderQueueNotificationWorkOrderQueueDistributionList>();
        }

        public int WorkOrderQueueDistributionListId { get; set; }
        public string Name { get; set; }
        public int WorkOrderQueueCommunicationChannelId { get; set; }
        public DateTime CreateDateTime { get; set; }
        public string CreateUser { get; set; }
        public DateTime? ModifiedDateTime { get; set; }
        public string ModifiedUser { get; set; }
        public DateTime? DeactivateDateTime { get; set; }
        public string DeactivateUser { get; set; }
        public int? PreviousRecordId { get; set; }

        public WorkOrderQueueCommunicationChannel WorkOrderQueueCommunicationChannel { get; set; }
        public ICollection<WorkOrderQueueDistributionAddress> WorkOrderQueueDistributionAddress { get; set; }
        public ICollection<WorkOrderQueueNotificationWorkOrderQueueDistributionList> WorkOrderQueueNotificationWorkOrderQueueDistributionList { get; set; }
    }
}
