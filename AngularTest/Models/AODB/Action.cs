using System;
using System.Collections.Generic;

namespace AngularTest.Models.AODB
{
    public partial class Action
    {
        public Action()
        {
            ActionSecurityRole = new HashSet<ActionSecurityRole>();
            ActionVendor = new HashSet<ActionVendor>();
        }

        public int ActionId { get; set; }
        public int LanguageId { get; set; }
        public int? WorkOrderStatusId { get; set; }
        public int NextWorkOrderStatusId { get; set; }
        public int Order { get; set; }
        public string Name { get; set; }
        public string DisplayText { get; set; }
        public string Description { get; set; }
        public DateTime? DeactivateDateTime { get; set; }
        public string DeactivateUser { get; set; }
        public DateTime CreateDateTime { get; set; }
        public string CreateUser { get; set; }
        public int? PreviousRecordId { get; set; }
        public int? SecondaryNextWorkOrderStatusId { get; set; }

        public ICollection<ActionSecurityRole> ActionSecurityRole { get; set; }
        public ICollection<ActionVendor> ActionVendor { get; set; }
    }
}
