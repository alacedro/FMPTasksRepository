using System;
using System.Collections.Generic;

namespace AngularTest.Models.AODB
{
    public partial class WorkOrderFields
    {
        public WorkOrderFields()
        {
            HiddenWorkOrderFields = new HashSet<HiddenWorkOrderFields>();
            WorkOrderFieldSecurity = new HashSet<WorkOrderFieldSecurity>();
        }

        public int WorkOrderFieldId { get; set; }
        public string Name { get; set; }
        public string Descriptions { get; set; }
        public DateTime? DeactivateDateTime { get; set; }
        public string DeactivateUser { get; set; }
        public DateTime CreateDateTime { get; set; }
        public string CreateUser { get; set; }

        public ICollection<HiddenWorkOrderFields> HiddenWorkOrderFields { get; set; }
        public ICollection<WorkOrderFieldSecurity> WorkOrderFieldSecurity { get; set; }
    }
}
