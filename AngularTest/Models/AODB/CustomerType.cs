using System;
using System.Collections.Generic;

namespace AngularTest.Models.AODB
{
    public partial class CustomerType
    {
        public CustomerType()
        {
            Client = new HashSet<Client>();
        }

        public int CustomerTypeId { get; set; }
        public string CustomerType1 { get; set; }
        public DateTime CreateDateTime { get; set; }
        public string CreateUser { get; set; }
        public DateTime? ModifyDateTime { get; set; }
        public string ModifyUser { get; set; }
        public DateTime? DeactivateDateTime { get; set; }
        public string DeactivateUser { get; set; }
        public int? PreviousRecordId { get; set; }

        public ICollection<Client> Client { get; set; }
    }
}
