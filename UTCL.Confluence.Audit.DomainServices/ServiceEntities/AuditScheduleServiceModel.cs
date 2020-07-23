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
            this.ActionPerformed = auditSchedule_DTO.ActionPerformed;
            this.Department = auditSchedule_DTO.Department;
            this.AuditorFor = auditSchedule_DTO.AuditorFor;
            this.AuditFrequency = auditSchedule_DTO.AuditFrequency;
        }
        public int? Id { get; private set; }
        public string AuditArea { get; private set; }
        public string Team { get; private set; }
        public string Month { get; private set; }
        public string UnitName { get; private set; }
        public string UnitId { get; private set; }
        public string AuditStatus { get; private set; }
        public DateTime? Modified { get; private set; }
        public DateTime? Created { get; private set; }
        public string Title { get; private set; }
        public string Auditor { get; private set; }
        public DateTime? StartDate { get; private set; }
        public DateTime? EndDate { get; private set; }
        public string AuditType { get; private set; }
        public string Level { get; private set; }
        public string FiscalYear { get; private set; }
        public string AuditorCommnet { get; private set; }
        public string AuditeeCommnet { get; private set; }
        public string AuditorDecision { get; private set; }
        public string AuditeeDecission { get; private set; }
        public string AuditZone { get; private set; }
        public string PageState { get; private set; }
        public string CurrentUserName { get; private set; }
        public string TestRole { get; private set; }
        public string CreatedBy { get; private set; }
        public string ModifiedBy { get; private set; }
        public string AuditCategory { get; private set; }
        public string AuditCategoryAuditCatagoryName { get; private set; }
        public string Section { get; private set; }
        public string PersonnelInteractedWith { get; private set; }
        public string TotalScore { get; private set; }
        public string ActionPerformed { get; private set; }
        public string Department { get; private set; }
        public string AuditorFor { get; set; }
        public string AuditFrequency { get; set; }
    }
}
