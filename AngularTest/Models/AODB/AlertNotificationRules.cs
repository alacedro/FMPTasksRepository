using System;
using System.Collections.Generic;

namespace AngularTest.Models.AODB
{
    public partial class AlertNotificationRules
    {
        public AlertNotificationRules()
        {
            AlertNotificationTemplatesByRulesConfig = new HashSet<AlertNotificationTemplatesByRulesConfig>();
        }

        public int AlertRuleId { get; set; }
        public string RuleName { get; set; }
        public string RuleMessage { get; set; }
        public DateTime? DeactiveDateTime { get; set; }
        public DateTime CreateDateTime { get; set; }
        public string CreatedUser { get; set; }

        public ICollection<AlertNotificationTemplatesByRulesConfig> AlertNotificationTemplatesByRulesConfig { get; set; }
    }
}
