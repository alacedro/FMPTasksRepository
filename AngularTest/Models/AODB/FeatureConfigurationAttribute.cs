using System;
using System.Collections.Generic;

namespace AngularTest.Models.AODB
{
    public partial class FeatureConfigurationAttribute
    {
        public int FeatureId { get; set; }
        public int ConfigurationAttributeId { get; set; }

        public ConfigurationAttribute ConfigurationAttribute { get; set; }
        public Feature Feature { get; set; }
    }
}
