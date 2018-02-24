using System;
using System.Collections.Generic;

namespace AngularTest.Models.AODB
{
    public partial class Announcement
    {
        public int AnnouncementId { get; set; }
        public string Title { get; set; }
        public DateTime PostedDate { get; set; }
        public DateTime ExpirationDate { get; set; }
        public string AnnouncementText { get; set; }
        public DateTime? DeactivateDateTime { get; set; }
        public string DeactivateUser { get; set; }
        public DateTime CreateDateTime { get; set; }
        public string CreateUser { get; set; }
        public int? ApplicationTypeId { get; set; }

        public ApplicationType ApplicationType { get; set; }
    }
}
