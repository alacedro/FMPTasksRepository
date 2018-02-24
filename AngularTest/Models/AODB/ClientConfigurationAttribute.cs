using System;
using System.Collections.Generic;

namespace AngularTest.Models.AODB
{
    public partial class ClientConfigurationAttribute
    {
        public int ClientConfigurationAttributeId { get; set; }
        public int ClientId { get; set; }
        public int ConfigurationAttributeId { get; set; }
        public string Value { get; set; }

        public Client Client { get; set; }
        public ConfigurationAttribute ConfigurationAttribute { get; set; }
    }
}
