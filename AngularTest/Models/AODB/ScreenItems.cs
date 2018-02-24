using System;
using System.Collections.Generic;

namespace AngularTest.Models.AODB
{
    public partial class ScreenItems
    {
        public ScreenItems()
        {
            ScreenItemSecurity = new HashSet<ScreenItemSecurity>();
        }

        public int ScreenItemId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int? PageId { get; set; }
        public int? Level { get; set; }
        public DateTime? DeactivateDateTime { get; set; }
        public string DeactivateUser { get; set; }
        public DateTime CreateDateTime { get; set; }
        public string CreateUser { get; set; }
        public int? PreviousRecordId { get; set; }

        public Page Page { get; set; }
        public ICollection<ScreenItemSecurity> ScreenItemSecurity { get; set; }
    }
}
