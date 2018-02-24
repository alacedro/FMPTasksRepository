using System;
using System.Collections.Generic;

namespace AngularTest.Models.AODB
{
    public partial class ImportClientUsers
    {
        public int IdKey { get; set; }
        public string UserName { get; set; }
        public string ExternalPassword { get; set; }
        public short Status { get; set; }
        public DateTime? StatusDateTime { get; set; }
        public short ProcessId { get; set; }
    }
}
