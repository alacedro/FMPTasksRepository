using System;
using System.Collections.Generic;

namespace AngularTest.Models.AODB
{
    public partial class ApplicationError
    {
        public int ExceptionId { get; set; }
        public int? ApplicationTypeId { get; set; }
        public string Message { get; set; }
        public string Stack { get; set; }
        public DateTime? CreateDate { get; set; }
        public string CreatedBy { get; set; }
        public string ExceptionNumber { get; set; }
        public string ServerIp { get; set; }
        public int? NotificationStatus { get; set; }
        public string ObjectData { get; set; }
        public string ApplicationName { get; set; }

        public ApplicationType ApplicationType { get; set; }
    }
}
