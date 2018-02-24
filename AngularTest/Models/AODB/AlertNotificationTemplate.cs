using System;
using System.Collections.Generic;

namespace AngularTest.Models.AODB
{
    public partial class AlertNotificationTemplate
    {
        public AlertNotificationTemplate()
        {
            AlertNotificationTemplatesByRulesConfig = new HashSet<AlertNotificationTemplatesByRulesConfig>();
        }

        public int AlertNotificationTemplateId { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
        public DateTime? DeActivateDateTime { get; set; }
        public DateTime CreatedDateTime { get; set; }
        public string CreatedUser { get; set; }

        public ICollection<AlertNotificationTemplatesByRulesConfig> AlertNotificationTemplatesByRulesConfig { get; set; }
    }
}
