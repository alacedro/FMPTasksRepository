using System;
using System.Collections.Generic;

namespace AngularTest.Models.AODB
{
    public partial class FinanceValidationParameters
    {
        public int FinanceValidationParametersId { get; set; }
        public int ClientId { get; set; }
        public decimal TextSearchTolerance { get; set; }
        public int InvoiceSearchDayFrame { get; set; }
        public int RecordsToEvaluate { get; set; }
        public int StandardDeviationComparisonLowerRange { get; set; }
        public int StandardDeviationComparisonUpperRange { get; set; }
        public bool IncludeAllClientsData { get; set; }
        public int InitialPopulationToConsider { get; set; }
        public DateTime? DeactivateDateTime { get; set; }
        public string DeactivateUser { get; set; }
        public DateTime? ModifiedDateTime { get; set; }
        public string ModifiedUser { get; set; }
        public DateTime CreateDateTime { get; set; }
        public string CreateUser { get; set; }
        public int? PreviousRecordId { get; set; }

        public Client Client { get; set; }
    }
}
