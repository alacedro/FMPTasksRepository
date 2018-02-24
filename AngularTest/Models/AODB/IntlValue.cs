using System;
using System.Collections.Generic;

namespace AngularTest.Models.AODB
{
    public partial class IntlValue
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Value { get; set; }
        public string Culture { get; set; }
        public string FileName { get; set; }
        public string FilePath { get; set; }
    }
}
