using System;
using System.Collections.Generic;

namespace AngularTest.Models.AODB
{
    public partial class LoginType
    {
        public LoginType()
        {
            User = new HashSet<User>();
        }

        public int LoginTypeId { get; set; }
        public string Name { get; set; }
        public string ScreenUrl { get; set; }
        public int LanguageId { get; set; }
        public DateTime? DeactivateDateTime { get; set; }
        public string DeactivateUser { get; set; }
        public DateTime CreateDateTime { get; set; }
        public string CreateUser { get; set; }
        public int? PreviousRecordId { get; set; }

        public ICollection<User> User { get; set; }
    }
}
