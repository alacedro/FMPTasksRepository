using System;
using System.Collections.Generic;

namespace AngularTest.Models.AODB
{
    public partial class FeatureClient
    {
        public int FeatureClientId { get; set; }
        public int ClientId { get; set; }
        public int FeatureId { get; set; }
        public bool Active { get; set; }
        public DateTime CreateDateTime { get; set; }
        public string CreateUser { get; set; }

        public Client Client { get; set; }
        public Feature Feature { get; set; }
    }
}
