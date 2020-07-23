using System;
using System.Collections.Generic;

namespace UTCL.Confluence.Audit.DataEntities
{
    public partial class BceauditReviewComments
    {
        public int? Id { get; set; }
        public string AuditId { get; set; }
        public string Ofi { get; set; }
        public string Strength { get; set; }
        public string Title { get; set; }
        public string ReviewItemId { get; set; }
        public string CreatedBy { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? Modified { get; set; }
        public DateTime? Created { get; set; }
        public string NewActionPlanUrl { get; set; }
        public string SystemStrength { get; set; }
        public string SystemOfi { get; set; }
        public string BehaviourStrength { get; set; }
        public string BehaviourOfi { get; set; }
        public string PhysicalStrength { get; set; }
        public string PhysicalOfi { get; set; }
    }
}
