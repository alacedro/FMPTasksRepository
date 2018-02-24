using System;
using System.Collections.Generic;

namespace AngularTest.Models.AODB
{
    public partial class QueriesMetrics
    {
        public int QueriesMetricsId { get; set; }
        public string SqlQuery { get; set; }
        public string LinqQuery { get; set; }
        public string FilterDtoxml { get; set; }
    }
}
