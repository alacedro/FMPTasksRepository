using AngularTest.Models.Import;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AngularTest.Models
{
    public class ZohoRecordCollection
    {
        public List<ExteriorServicesSchedule> Exterior_Services_Schedule { get; set; }

        public ZohoRecordCollection()
        {
            Exterior_Services_Schedule = new List<ExteriorServicesSchedule>();
        }
    }
}
