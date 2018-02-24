using System;
using System.Collections.Generic;

namespace AngularTest.Models.AODB
{
    public partial class RoleConfigurationAttribute
    {
        public int RoleConfigurationAttributeId { get; set; }
        public int SecurityRoleId { get; set; }
        public int ConfigurationAttributeId { get; set; }
        public int ConfigurationAttributeValueId { get; set; }

        public ConfigurationAttribute ConfigurationAttribute { get; set; }
        public ConfigurationAttributeValue ConfigurationAttributeValue { get; set; }
        public SecurityRole SecurityRole { get; set; }
    }
}
