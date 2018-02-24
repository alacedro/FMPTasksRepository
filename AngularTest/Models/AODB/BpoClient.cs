using System;
using System.Collections.Generic;

namespace AngularTest.Models.AODB
{
    public partial class BpoClient
    {
        public BpoClient()
        {
            BpoVariableValue = new HashSet<BpoVariableValue>();
        }

        public int BpoClientId { get; set; }
        public int ClientId { get; set; }
        public string Name { get; set; }
        public int ClientVersion { get; set; }
        public string Fmp1Server { get; set; }
        public string Fmp1Database { get; set; }
        public bool IntegratedSecurity { get; set; }
        public string Observation { get; set; }
        public string ZendeskTag { get; set; }
        public DateTime CreateDateTime { get; set; }
        public string CreateUser { get; set; }
        public DateTime? DeactivateDateTime { get; set; }
        public string DeactivateUser { get; set; }

        public ICollection<BpoVariableValue> BpoVariableValue { get; set; }
    }
}
