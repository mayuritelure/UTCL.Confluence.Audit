using System;
using System.Collections.Generic;
using System.Text;
using UTCL.Confluence.Audit.DTO;

namespace UTCL.Confluence.Audit.DomainServices.ServiceEntities
{
    public class AuditScheduleServiceModel
    {
        public AuditScheduleServiceModel(AuditScheduleDTO auditSchedule_DTO)
        {
            this.Id = auditSchedule_DTO.Id;
            this.AuditArea = auditSchedule_DTO.AuditArea;
            this.Team = auditSchedule_DTO.Team;
            this.Month = auditSchedule_DTO.Month;
            this.UnitName = auditSchedule_DTO.UnitName;
            this.UnitId = auditSchedule_DTO.UnitId;
            this.AuditStatus = auditSchedule_DTO.AuditStatus;
            this.Modified = auditSchedule_DTO.Modified;
            this.Created = auditSchedule_DTO.Created;
            this.Title = auditSchedule_DTO.Title;
            this.Auditor = auditSchedule_DTO.Auditor;
            this.StartDate = auditSchedule_DTO.StartDate;
            this.EndDate = auditSchedule_DTO.EndDate;
            this.AuditType = auditSchedule_DTO.AuditType;
            this.Level = auditSchedule_DTO.Level;
            this.FiscalYear = auditSchedule_DTO.FiscalYear;
            this.AuditorCommnet = auditSchedule_DTO.AuditorCommnet;
            this.AuditeeCommnet = auditSchedule_DTO.AuditeeCommnet;
            this.AuditorDecision = auditSchedule_DTO.AuditorDecision;
            this.AuditeeDecission = auditSchedule_DTO.AuditeeDecission;
            this.AuditZone = auditSchedule_DTO.AuditZone;
            this.PageState = auditSchedule_DTO.PageState;
            this.TestRole = auditSchedule_DTO.TestRole;
            this.CreatedBy = auditSchedule_DTO.CreatedBy;
            this.ModifiedBy = auditSchedule_DTO.ModifiedBy;
            this.AuditCategory = auditSchedule_DTO.AuditCategory;
            this.AuditCategoryAuditCatagoryName = auditSchedule_DTO.AuditCategoryAuditCatagoryName;
            this.Section = auditSchedule_DTO.Section;
            this.PersonnelInteractedWith = auditSchedule_DTO.PersonnelInteractedWith;
            this.TotalScore = auditSchedule_DTO.TotalScore;
        }
        public int? Id { get; set; }
        public string AuditArea { get; set; }
        public string Team { get; set; }
        public string Month { get; set; }
        public string UnitName { get; set; }
        public string UnitId { get; set; }
        public string AuditStatus { get; set; }
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
