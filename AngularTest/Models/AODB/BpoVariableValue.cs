using System;
using System.Collections.Generic;

namespace AngularTest.Models.AODB
{
    public partial class BpoVariableValue
    {
        public int BpoVariableValueId { get; set; }
        public int BpoVariableCategoryId { get; set; }
        public int? BpoClientId { get; set; }
        public string ValueCode { get; set; }
        public string Description { get; set; }
        public string Value { get; set; }
        public string DataType { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime? ModifyDate { get; set; }
        public DateTime? DeactivateDate { get; set; }

        public BpoClient BpoClient { get; set; }
        public BpoVariableCategory BpoVariableCategory { get; set; }
    }
}
