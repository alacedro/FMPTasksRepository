using System;
using System.Collections.Generic;

namespace AngularTest.Models.AODB
{
    public partial class Survey
    {
        public int SurveyId { get; set; }
        public int ClientId { get; set; }
        public int? LanguageId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime? DeactivateDateTime { get; set; }
        public string DeactivateUser { get; set; }
        public DateTime CreateDateTime { get; set; }
        public string CreateUser { get; set; }
        public int? PreviousRecordId { get; set; }
        public int Frequency { get; set; }
        public int SurveyFrequencyTypeId { get; set; }

        public Client Client { get; set; }
        public SurveyFrequencyType SurveyFrequencyType { get; set; }
    }
}
