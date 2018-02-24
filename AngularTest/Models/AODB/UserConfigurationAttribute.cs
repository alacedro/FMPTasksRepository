using System;
using System.Collections.Generic;

namespace AngularTest.Models.AODB
{
    public partial class UserConfigurationAttribute
    {
        public int UserConfigurationAttributeId { get; set; }
        public int UserId { get; set; }
        public int ConfigurationAttributeId { get; set; }
        public int ConfigurationAttributeValueId { get; set; }

        public ConfigurationAttribute ConfigurationAttribute { get; set; }
        public ConfigurationAttributeValue ConfigurationAttributeValue { get; set; }
        public User User { get; set; }
    }
}
