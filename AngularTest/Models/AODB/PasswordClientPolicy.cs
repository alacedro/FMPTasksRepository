using System;
using System.Collections.Generic;

namespace AngularTest.Models.AODB
{
    public partial class PasswordClientPolicy
    {
        public int PasswordPolicyId { get; set; }
        public int ClientId { get; set; }
        public DateTime? DeactivateDateTime { get; set; }
        public string DeactivateUser { get; set; }
        public int PasswordExpirationDays { get; set; }
        public int PasswordMinLength { get; set; }
        public string PasswordStrenghtRegEx { get; set; }
        public int? PasswordWrongMaxAttempts { get; set; }
        public string Domain { get; set; }
        public bool? AllowCheckPasswordExpiration { get; set; }
        public bool? AllowCheckPasswordStrength { get; set; }
        public bool? AllowUserLock { get; set; }
    }
}
