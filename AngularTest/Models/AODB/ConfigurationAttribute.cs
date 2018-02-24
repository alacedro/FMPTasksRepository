using System;
using System.Collections.Generic;

namespace AngularTest.Models.AODB
{
    public partial class ConfigurationAttribute
    {
        public ConfigurationAttribute()
        {
            ClientConfigurationAttribute = new HashSet<ClientConfigurationAttribute>();
            ConfigurationAttributeValue = new HashSet<ConfigurationAttributeValue>();
            FeatureConfigurationAttribute = new HashSet<FeatureConfigurationAttribute>();
            RoleConfigurationAttribute = new HashSet<RoleConfigurationAttribute>();
            UserConfigurationAttribute = new HashSet<UserConfigurationAttribute>();
        }

        public int ConfigurationAttributeId { get; set; }
        public string Description { get; set; }

        public ICollection<ClientConfigurationAttribute> ClientConfigurationAttribute { get; set; }
        public ICollection<ConfigurationAttributeValue> ConfigurationAttributeValue { get; set; }
        public ICollection<FeatureConfigurationAttribute> FeatureConfigurationAttribute { get; set; }
        public ICollection<RoleConfigurationAttribute> RoleConfigurationAttribute { get; set; }
        public ICollection<UserConfigurationAttribute> UserConfigurationAttribute { get; set; }
    }
}
