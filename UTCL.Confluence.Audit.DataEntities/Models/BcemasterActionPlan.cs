using System;
using System.Collections.Generic;

namespace UTCL.Confluence.Audit.DataEntities.Models
{
    public partial class BcemasterActionPlan
    {
        public int? Id { get; set; }
        public string Predecessors { get; set; }
        public string Priority { get; set; }
        public string Status { get; set; }
        public double? Complete { get; set; }
        public string AssignedTo { get; set; }
        public DateTime? DueDate { get; set; }
        public string AuditId { get; set; }
        public string RequiredActivity { get; set; }
        public string QueryString { get; set; }
        public string Ofi { get; set; }
        public string Strength { get; set; }
        public string Outcome { get; set; }
        public string Team { get; set; }
        public string Auditor { get; set; }
        public string ReviewCommentId { get; set; }
        public DateTime? CompletionDate { get; set; }
        public string Title { get; set; }
        public string TaskGroup { get; set; }
        public string Description { get; set; }
        public DateTime? StartDate { get; set; }
        public string CreatedBy { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? Modified { get; set; }
        public DateTime? Created { get; set; }
        public string ActionTaken { get; set; }
        public string PhysicalOfi { get; set; }
        public string SystemOfi { get; set; }
        public string BehaviourOfi { get; set; }
        public string PhysicalStrength { get; set; }
        public string SystemStrength { get; set; }
        public string BehaviourStrength { get; set; }
    }
}
