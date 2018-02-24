using System;
using System.Collections.Generic;

namespace AngularTest.Models.AODB
{
    public partial class XmlvendorConfig
    {
        public int XmlvendorConfigId { get; set; }
        public int ClientId { get; set; }
        public int VendorId { get; set; }
        public bool? Active { get; set; }
        public int XmlLogTypeId { get; set; }
        public string TargetUrl { get; set; }
        public string AuthenticationUserName { get; set; }
        public string AuthenticationPin { get; set; }
        public string FtpHost { get; set; }
        public string FtpUser { get; set; }
        public string FtpPassword { get; set; }
        public string FtpPort { get; set; }
        public DateTime CreateDateTime { get; set; }
        public string CreateUser { get; set; }
        public string FtpRootPath { get; set; }
        public string FtpFolder { get; set; }

        public Client Client { get; set; }
        public Vendor Vendor { get; set; }
        public XmllogType XmlLogType { get; set; }
    }
}
