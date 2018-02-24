using System;
using System.Collections.Generic;

namespace AngularTest.Models.AODB
{
    public partial class EmailCommentConfiguration
    {
        public int EmailCommentConfigurationId { get; set; }
        public string EmailAddress { get; set; }
        public string EmailPassword { get; set; }
        public int? EmailUniqueId { get; set; }
        public DateTime CreateDateTime { get; set; }
        public string CreateUser { get; set; }
        public DateTime? DeactivateDateTime { get; set; }
        public string DeactivateUser { get; set; }
        public bool LogSubjectParsingIssues { get; set; }
        public bool LogAttachmentIssues { get; set; }
    }
}
