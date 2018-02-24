using System;
using System.Collections.Generic;

namespace AngularTest.Models.AODB
{
    public partial class XmllogType
    {
        public XmllogType()
        {
            Xmllog = new HashSet<Xmllog>();
            XmlvendorConfig = new HashSet<XmlvendorConfig>();
        }

        public int LogTypeId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime CreateDateTime { get; set; }
        public string CreateUser { get; set; }
        public DateTime? DeactivateDateTime { get; set; }

        public ICollection<Xmllog> Xmllog { get; set; }
        public ICollection<XmlvendorConfig> XmlvendorConfig { get; set; }
    }
}
