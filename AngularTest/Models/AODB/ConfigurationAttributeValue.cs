using System;
using System.Collections.Generic;

namespace AngularTest.Models.AODB
{
    public partial class ConfigurationAttributeValue
    {
        public ConfigurationAttributeValue()
        {
            RoleConfigurationAttribute = new HashSet<RoleConfigurationAttribute>();
            UserConfigurationAttribute = new HashSet<UserConfigurationAttribute>();
        }

        public int ConfigurationAttributeValueId { get; set; }
        public int ConfigurationAttributeId { get; set; }
        public string Value { get; set; }

        public ConfigurationAttribute ConfigurationAttribute { get; set; }
        public ICollection<RoleConfigurationAttribute> RoleConfigurationAttribute { get; set; }
        public ICollection<UserConfigurationAttribute> UserConfigurationAttribute { get; set; }
    }
}
