using System;
using System.Collections.Generic;

namespace AngularTest.Models.AODB
{
    public partial class SecurityRole
    {
        public SecurityRole()
        {
            Attachment = new HashSet<Attachment>();
            RoleConfigurationAttribute = new HashSet<RoleConfigurationAttribute>();
            ScreenItemSecurity = new HashSet<ScreenItemSecurity>();
            User = new HashSet<User>();
            WorkOrderFieldSecurity = new HashSet<WorkOrderFieldSecurity>();
        }

        public int SecurityRoleId { get; set; }
        public int? LanguageId { get; set; }
        public int? Order { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime? DeactivateDateTime { get; set; }
        public string DeactivateUser { get; set; }
        public DateTime CreateDateTime { get; set; }
        public string CreateUser { get; set; }
        public int? PreviousRecordId { get; set; }

        public ICollection<Attachment> Attachment { get; set; }
        public ICollection<RoleConfigurationAttribute> RoleConfigurationAttribute { get; set; }
        public ICollection<ScreenItemSecurity> ScreenItemSecurity { get; set; }
        public ICollection<User> User { get; set; }
        public ICollection<WorkOrderFieldSecurity> WorkOrderFieldSecurity { get; set; }
    }
}
