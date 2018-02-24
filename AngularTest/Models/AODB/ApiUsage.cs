using System;
using System.Collections.Generic;

namespace AngularTest.Models.AODB
{
    public partial class ApiUsage
    {
        public int ApiUsageId { get; set; }
        public int ApiAuthorizationId { get; set; }
        public DateTime Date { get; set; }
        public string ApiName { get; set; }
        public string ActionName { get; set; }
        public string ActingDomain { get; set; }
        public int Calls { get; set; }

        public ApiAuthorization ApiAuthorization { get; set; }
    }
}
