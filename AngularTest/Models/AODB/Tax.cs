using System;
using System.Collections.Generic;

namespace AngularTest.Models.AODB
{
    public partial class Tax
    {
        public int Id { get; set; }
        public int StateId { get; set; }
        public string ZipCode { get; set; }
        public decimal? StateSalesTax { get; set; }
        public decimal? CombinedSalesTax { get; set; }
        public decimal? StateUseTax { get; set; }
        public decimal? CombinedUseTax { get; set; }
        public DateTime EffectiveDate { get; set; }

        public State State { get; set; }
    }
}
