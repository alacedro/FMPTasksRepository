using System;
using System.Collections.Generic;

namespace AngularTest.Models.AODB
{
    public partial class ErrorLog
    {
        public int ErrorLogId { get; set; }
        public DateTime TimeStamp { get; set; }
        public int DateKey { get; set; }
        public string Dbname { get; set; }
        public string ProcName { get; set; }
        public string ProcParams { get; set; }
        public int? ErrorLine { get; set; }
        public string ErrorMessage { get; set; }
        public int? ErrorNumber { get; set; }
        public int? ErrorState { get; set; }
        public int? ErrorSeverity { get; set; }
        public int? Spid { get; set; }
        public string SystemUser { get; set; }
    }
}
