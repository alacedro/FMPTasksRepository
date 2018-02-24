using System;
using System.Collections.Generic;

namespace AngularTest.Models.AODB
{
    public partial class BpoVariableCategory
    {
        public BpoVariableCategory()
        {
            BpoVariableValue = new HashSet<BpoVariableValue>();
        }

        public int BpoVariableCategoryId { get; set; }
        public string CategoryCode { get; set; }
        public string Description { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime? ModifyDate { get; set; }
        public DateTime? DeactivateDate { get; set; }

        public ICollection<BpoVariableValue> BpoVariableValue { get; set; }
    }
}
