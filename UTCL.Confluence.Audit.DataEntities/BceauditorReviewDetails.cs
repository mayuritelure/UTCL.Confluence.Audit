using System;
using System.Collections.Generic;

namespace UTCL.Confluence.Audit.DataEntities
{
    public partial class BceauditorReviewDetails
    {
        public int? Id { get; set; }
        public string AuditId { get; set; }
        public double? PhysicalConditionScore { get; set; }
        public double? SystemScore { get; set; }
        public double? BehaviourScore { get; set; }
        public string TitleTitle { get; set; }
        public string QuestionId { get; set; }
        public string ContentType { get; set; }
        public DateTime? Modified { get; set; }
        public DateTime? Created { get; set; }
        public string CreatedBy { get; set; }
        public string ModifiedBy { get; set; }
    }
}
