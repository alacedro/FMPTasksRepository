using System;
using System.Collections.Generic;

namespace AngularTest.Models.AODB
{
    public partial class TranslationLookUps
    {
        public int TranslationsId { get; set; }
        public string TableName { get; set; }
        public string ColumnName { get; set; }
        public int SourceId { get; set; }
        public string LanguageCode { get; set; }
        public string Translation { get; set; }
        public DateTime? DeactivateDateTime { get; set; }
        public string DeactivateUser { get; set; }
        public DateTime CreateDateTime { get; set; }
        public string CreateUser { get; set; }
    }
}
