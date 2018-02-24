using System;
using System.Collections.Generic;

namespace AngularTest.Models.AODB
{
    public partial class Dninumber
    {
        public int DninumberId { get; set; }
        public int ClientId { get; set; }
        public string Dnis { get; set; }
        public bool IsServiceChannel { get; set; }
        public DateTime CreateDateTime { get; set; }
        public string CreateUser { get; set; }
        public DateTime? DeactivateDateTime { get; set; }
        public string DeactivateUser { get; set; }

        public Client Client { get; set; }
    }
}
