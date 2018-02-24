using System;
using System.Collections.Generic;

namespace AngularTest.Models.AODB
{
    public partial class OfflineReportTickets
    {
        public int TicketId { get; set; }
        public int UserId { get; set; }
        public string UserEmail { get; set; }
        public string OtherUsersEmails { get; set; }
        public string ReportName { get; set; }
        public string ReportFormat { get; set; }
        public bool FlatReport { get; set; }
        public string Notes { get; set; }
        public string ReferenceId { get; set; }
        public string AttachmentPath { get; set; }
        public short Status { get; set; }
        public DateTime? StatusDateTime { get; set; }
        public int UserTimeZoneId { get; set; }
        public DateTime CreateDateTime { get; set; }
        public string CreateUser { get; set; }
        public DateTime? DeactivateDateTime { get; set; }
        public string DeactivateUser { get; set; }
        public string ReportFilter { get; set; }
        public int ClientId { get; set; }
        public int Dbid { get; set; }
        public string OutputMessage { get; set; }
        public int LanguageCode { get; set; }
        public string ReportFilterHash { get; set; }
    }
}
