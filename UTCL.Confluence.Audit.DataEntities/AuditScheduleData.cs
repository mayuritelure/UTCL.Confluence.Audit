using System;
using System.Collections.Generic;

namespace UTCL.Confluence.Audit.DataEntities
{
    public partial class AuditScheduleData
    {
        public int Id { get; set; }
        public string AuditArea { get; set; }
        public string Team { get; set; }
        public string Department { get; set; }
        public string Month { get; set; }
        public string UnitName { get; set; }
        public string UnitId { get; set; }
        public string AuditStatus { get; set; }
        public string AuditorFor { get; set; }
        public string AuditFrequency { get; set; }
        public DateTime? Modified { get; set; }
        public DateTime? Created { get; set; }
        public string Title { get; set; }
        public string Auditor { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string AuditType { get; set; }
        public string Level { get; set; }
        public string FiscalYear { get; set; }
        public string AuditorCommnet { get; set; }
        public string AuditeeCommnet { get; set; }
        public string AuditorDecision { get; set; }
        public string AuditeeDecission { get; set; }
        public string AuditZone { get; set; }
        public string PageState { get; set; }
        public string CurrentUserName { get; set; }
        public string TestRole { get; set; }
        public string CreatedBy { get; set; }
        public string ModifiedBy { get; set; }
        public string AuditCategory { get; set; }
        public string AuditCategoryAuditCatagoryName { get; set; }
        public string Section { get; set; }
        public string PersonnelInteractedWith { get; set; }
        public string TotalScore { get; set; }
    }
}
