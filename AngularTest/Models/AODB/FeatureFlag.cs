using System;
using System.Collections.Generic;

namespace AngularTest.Models.AODB
{
    public partial class FeatureFlag
    {
        public FeatureFlag()
        {
            FeatureConfig = new HashSet<FeatureConfig>();
        }

        public int FeatureFlagId { get; set; }
        public string FlagName { get; set; }
        public DateTime CreateDateTime { get; set; }
        public string CreateUser { get; set; }
        public int FlagDefaultValue { get; set; }

        public ICollection<FeatureConfig> FeatureConfig { get; set; }
    }
}
