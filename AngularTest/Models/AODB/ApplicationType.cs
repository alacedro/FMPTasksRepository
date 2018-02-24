using System;
using System.Collections.Generic;

namespace AngularTest.Models.AODB
{
    public partial class ApplicationType
    {
        public ApplicationType()
        {
            Announcement = new HashSet<Announcement>();
            ApplicationError = new HashSet<ApplicationError>();
        }

        public int ApplicationTypeId { get; set; }
        public string Name { get; set; }
        public DateTime CreateDateTime { get; set; }
        public string CreateUser { get; set; }

        public ICollection<Announcement> Announcement { get; set; }
        public ICollection<ApplicationError> ApplicationError { get; set; }
    }
}
