using System;
using System.Collections.Generic;

namespace AngularTest.Models.AODB
{
    public partial class ApiAuthorization
    {
        public ApiAuthorization()
        {
            ApiUsage = new HashSet<ApiUsage>();
        }

        public int ApiAuthorizationId { get; set; }
        public string AuthorizationToken { get; set; }
        public string SourceDomain { get; set; }
        public int ApiAccessLevelId { get; set; }
        public DateTime? DeactivateDateTime { get; set; }
        public string DeactivateUser { get; set; }
        public DateTime CreateDateTime { get; set; }
        public string CreateUser { get; set; }
        public int? PreviousRecordId { get; set; }
        public int ApiApplicationType { get; set; }
        public int? MaxCallPerDay { get; set; }

        public ApiAccessLevel ApiAccessLevel { get; set; }
        public ICollection<ApiUsage> ApiUsage { get; set; }
    }
}
