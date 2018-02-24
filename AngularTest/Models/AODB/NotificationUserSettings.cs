using System;
using System.Collections.Generic;

namespace AngularTest.Models.AODB
{
    public partial class NotificationUserSettings
    {
        public int NotificationUserSettingsId { get; set; }
        public int UserId { get; set; }
        public int SendSetting { get; set; }
        public int HotlistSendsetting { get; set; }
        public bool NotifyOnStatus { get; set; }
        public bool NotifyOnTargetStartDateTime { get; set; }
        public bool NotifyOnScheduledStartDateTime { get; set; }
        public bool NotifyOnDne { get; set; }
        public bool NotifyOnPublicComment { get; set; }
        public bool NotifyOnInternalComment { get; set; }
        public bool NotifyOnPrivateComment { get; set; }
        public bool NotifyOnPublicCommentHotlist { get; set; }
        public bool NotifyOnInternalCommentHotlist { get; set; }
        public bool NotifyOnPrivateCommentHotlist { get; set; }
        public int LanguageId { get; set; }
        public DateTime? DeactivateDateTime { get; set; }
        public string DeactivateUser { get; set; }
        public DateTime CreateDateTime { get; set; }
        public string CreateUser { get; set; }
        public int? PreviousRecordId { get; set; }
    }
}
