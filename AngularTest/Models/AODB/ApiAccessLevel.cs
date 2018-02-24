using System;
using System.Collections.Generic;

namespace AngularTest.Models.AODB
{
    public partial class ApiAccessLevel
    {
        public ApiAccessLevel()
        {
            ApiAuthorization = new HashSet<ApiAuthorization>();
        }

        public int ApiAccessLevelId { get; set; }
        public string Description { get; set; }
        public int Rank { get; set; }

        public ICollection<ApiAuthorization> ApiAuthorization { get; set; }
    }
}
