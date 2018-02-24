using System;
using System.Collections.Generic;

namespace AngularTest.Models.AODB
{
    public partial class UserClient
    {
        public int UserClientId { get; set; }
        public int UserId { get; set; }
        public int ClientId { get; set; }
        public int UserLanguageId { get; set; }
        public int LanguageId { get; set; }
        public int? ClientRoleId { get; set; }
        public decimal? SpendAuthority { get; set; }
        public DateTime? DeactivateDateTime { get; set; }
        public string DeactivateUser { get; set; }
        public DateTime CreateDateTime { get; set; }
        public string CreateUser { get; set; }
        public int? PreviousRecordId { get; set; }
        public string EmployeeId { get; set; }

        public Client Client { get; set; }
        public User User { get; set; }
    }
}
