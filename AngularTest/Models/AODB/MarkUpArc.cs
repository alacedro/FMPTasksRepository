using System;
using System.Collections.Generic;

namespace AngularTest.Models.AODB
{
    public partial class MarkUpArc
    {
        public int Id { get; set; }
        public int? LineItemTypeId { get; set; }
        public int? RequestTypeId { get; set; }
        public int? RateType { get; set; }
        public decimal? Rate { get; set; }
        public decimal? OvertimeRate { get; set; }
        public decimal? OverheadnProfit { get; set; }
        public decimal? EmgRate { get; set; }
        public decimal? AhRate { get; set; }
        public decimal? P2rate { get; set; }
        public decimal? P4rate { get; set; }
        public decimal? P8rate { get; set; }
        public decimal? TripCharge { get; set; }
        public decimal? LowerCost { get; set; }
        public decimal? HigherCost { get; set; }
        public int? LocationId { get; set; }
        public bool? TaxExempt { get; set; }
        public string ClientAbbrev { get; set; }
        public int? ClientId { get; set; }
        public DateTime? DeactivateDateTime { get; set; }
        public string DeactivateUser { get; set; }
        public DateTime CreateDateTime { get; set; }
        public string CreateUser { get; set; }
        public int? PreviousRecordId { get; set; }
    }
}
