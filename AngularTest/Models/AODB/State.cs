using System;
using System.Collections.Generic;

namespace AngularTest.Models.AODB
{
    public partial class State
    {
        public State()
        {
            Address = new HashSet<Address>();
            StateTaxType = new HashSet<StateTaxType>();
            Tax = new HashSet<Tax>();
            TaxRules = new HashSet<TaxRules>();
        }

        public int StateId { get; set; }
        public int LanguageId { get; set; }
        public string Name { get; set; }
        public string Abbreviation { get; set; }
        public DateTime? DeactivateDateTime { get; set; }
        public string DeactivateUser { get; set; }
        public DateTime CreateDateTime { get; set; }
        public string CreateUser { get; set; }
        public int? PreviousRecordId { get; set; }

        public ICollection<Address> Address { get; set; }
        public ICollection<StateTaxType> StateTaxType { get; set; }
        public ICollection<Tax> Tax { get; set; }
        public ICollection<TaxRules> TaxRules { get; set; }
    }
}
