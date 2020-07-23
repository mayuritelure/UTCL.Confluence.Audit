using System;
using System.Collections.Generic;

namespace UTCL.Confluence.Audit.DataEntities
{
    public partial class _5sauditorReviewDetails
    {
        public int? Id { get; set; }
        public string AuditId { get; set; }
        public string QuestionId { get; set; }
        public string AssessmentQuestion { get; set; }
        public int? ObtainedScore { get; set; }
        public string TitleTitle { get; set; }
        public DateTime? Modified { get; set; }
        public DateTime? Created { get; set; }
        public string CreatedBy { get; set; }
        public string ModifiedBy { get; set; }
        public string Version { get; set; }
        public bool? Attachments { get; set; }
    }
}
