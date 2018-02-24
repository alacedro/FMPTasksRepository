using System;
using System.Collections.Generic;

namespace AngularTest.Models.AODB
{
    public partial class PasswordHistory
    {
        public int PasswordHistoryId { get; set; }
        public int UserId { get; set; }
        public string Password { get; set; }
        public DateTime CreateDateTime { get; set; }

        public User User { get; set; }
    }
}
