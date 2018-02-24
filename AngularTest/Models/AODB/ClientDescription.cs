using System;
using System.Collections.Generic;

namespace AngularTest.Models.AODB
{
    public partial class ClientDescription
    {
        public int ClientDescriptionId { get; set; }
        public string Description { get; set; }
        public int ClientId { get; set; }
        public DateTime CreateDateTime { get; set; }
        public string CreateUser { get; set; }
        public DateTime? ModifyDateTime { get; set; }
        public string ModifyUser { get; set; }
        public DateTime? DeactivateDateTime { get; set; }
        public string DeactivateUser { get; set; }
        public int? PreviousRecordId { get; set; }

        public Client Client { get; set; }
    }
}
