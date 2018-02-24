using System;
using System.Collections.Generic;

namespace AngularTest.Models.AODB
{
    public partial class AlertNotificationTemplatesByRulesConfig
    {
        public int AlertNotificationTemplatesByRulesConfigId { get; set; }
        public int AlertNotificationTemplateId { get; set; }
        public int AlertRuleId { get; set; }
        public DateTime? DeactivateDateTime { get; set; }
        public DateTime CreateDateTime { get; set; }
        public string CreateUser { get; set; }

        public AlertNotificationTemplate AlertNotificationTemplate { get; set; }
        public AlertNotificationRules AlertRule { get; set; }
    }
}
