using System;
using System.Collections.Generic;

namespace AngularTest.Models.AODB
{
    public partial class IntlFile
    {
        public int Id { get; set; }
        public string FileName { get; set; }
        public string FilePath { get; set; }
        public string ResourceName { get; set; }
        public string ResourcePath { get; set; }
        public string Culture { get; set; }
    }
}
