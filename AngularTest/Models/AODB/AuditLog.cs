using System;
using System.Collections.Generic;

namespace AngularTest.Models.AODB
{
    public partial class AuditLog
    {
        public int AuditLogId { get; set; }
        public string Command { get; set; }
        public DateTime? PostTime { get; set; }
        public string DbNme { get; set; }
        public string EventType { get; set; }
        public string HostName { get; set; }
        public string LoginName { get; set; }
    }
}
