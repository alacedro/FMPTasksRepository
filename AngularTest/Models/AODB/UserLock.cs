using System;
using System.Collections.Generic;

namespace AngularTest.Models.AODB
{
    public partial class UserLock
    {
        public int LockUserId { get; set; }
        public int UserId { get; set; }
        public bool IsLocked { get; set; }
        public DateTime LastUpdate { get; set; }
    }
}
