﻿using System;
using System.Collections.Generic;

namespace AngularTest.Models.AODB
{
    public partial class WorkOrderQueueHierarchyType
    {
        public WorkOrderQueueHierarchyType()
        {
            WorkOrderQueueHierarchy = new HashSet<WorkOrderQueueHierarchy>();
        }

        public int WorkOrderQueueHierarchyTypeId { get; set; }
        public string Name { get; set; }
        public DateTime CreateDateTime { get; set; }
        public string CreateUser { get; set; }
        public DateTime? ModifiedDateTime { get; set; }
        public string ModifiedUser { get; set; }
        public DateTime? DeactivateDateTime { get; set; }
        public string DeactivateUser { get; set; }
        public int? PreviousRecordId { get; set; }

        public ICollection<WorkOrderQueueHierarchy> WorkOrderQueueHierarchy { get; set; }
    }
}
