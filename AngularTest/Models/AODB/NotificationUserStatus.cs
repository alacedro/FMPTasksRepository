using System;
using System.Collections.Generic;

namespace AngularTest.Models.AODB
{
    public partial class NotificationUserStatus
    {
        public int NotificationUserStatus1 { get; set; }
        public int UserId { get; set; }
        public int StatusId { get; set; }
        public int LanguageId { get; set; }
        public DateTime? DeactivateDateTime { get; set; }
        public string DeactivateUser { get; set; }
        public DateTime CreateDateTime { get; set; }
        public string CreateUser { get; set; }
        public int? PreviousRecordId { get; set; }
    }
}
