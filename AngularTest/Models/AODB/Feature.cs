using System;
using System.Collections.Generic;

namespace AngularTest.Models.AODB
{
    public partial class Feature
    {
        public Feature()
        {
            FeatureClient = new HashSet<FeatureClient>();
            FeatureConfig = new HashSet<FeatureConfig>();
            FeatureConfigurationAttribute = new HashSet<FeatureConfigurationAttribute>();
        }

        public int FeatureId { get; set; }
        public string Name { get; set; }
        public bool Active { get; set; }
        public DateTime CreateDateTime { get; set; }
        public string CreateUser { get; set; }

        public ICollection<FeatureClient> FeatureClient { get; set; }
        public ICollection<FeatureConfig> FeatureConfig { get; set; }
        public ICollection<FeatureConfigurationAttribute> FeatureConfigurationAttribute { get; set; }
    }
}
