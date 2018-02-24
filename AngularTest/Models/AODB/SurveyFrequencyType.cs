using System;
using System.Collections.Generic;

namespace AngularTest.Models.AODB
{
    public partial class SurveyFrequencyType
    {
        public SurveyFrequencyType()
        {
            Survey = new HashSet<Survey>();
        }

        public int SurveyFrequencyTypeId { get; set; }
        public string SurveyFrequencyTypeName { get; set; }

        public ICollection<Survey> Survey { get; set; }
    }
}
