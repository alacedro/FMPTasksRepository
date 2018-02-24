using System;
using System.Collections.Generic;

namespace AngularTest.Models.AODB
{
    public partial class ScreenItemSecurity
    {
        public int ScreenItemSecurityId { get; set; }
        public int ScreenItemId { get; set; }
        public int? RoleId { get; set; }
        public int? UserId { get; set; }
        public bool? State { get; set; }
        public DateTime? DeactivateDateTime { get; set; }
        public string DeactivateUser { get; set; }
        public DateTime CreateDateTime { get; set; }
        public string CreateUser { get; set; }

        public SecurityRole Role { get; set; }
        public ScreenItems ScreenItem { get; set; }
    }
}
