using System;
using System.Collections.Generic;

namespace AngularTest.Models.AODB
{
    public partial class FeatureConfig
    {
        public int FeatureConfigId { get; set; }
        public int FeatureId { get; set; }
        public int FeatureFlagId { get; set; }
        public int FeatureFlagValue { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }

        public Feature Feature { get; set; }
        public FeatureFlag FeatureFlag { get; set; }
    }
}
