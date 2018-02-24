using System;
using System.Collections.Generic;

namespace AngularTest.Models.AODB
{
    public partial class Version
    {
        public int VersionId { get; set; }
        public string WebVersion { get; set; }
        public string Wsfversion { get; set; }
        public string Wsversion { get; set; }
        public string Boversion { get; set; }
        public string Dbfversion { get; set; }
        public string Dbversion { get; set; }
        public string Beversion { get; set; }
        public DateTime CreateDateTime { get; set; }
        public string CreateDateUser { get; set; }
    }
}
