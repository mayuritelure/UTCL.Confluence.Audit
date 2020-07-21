using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Text;
using UTCL.Confluence.Audit.DataEntities.Models;
using UTCL.Confluence.Audit.DomainServices.InterfaceRepository;
using UTCL.Confluence.Audit.DomainServices.ServiceEntities;
using UTCL.Confluence.Audit.DTO;

namespace UTCL.Confluence.Audit.Repositories.Class
{
    public class AuditScheduleRepository: IAuditScheduleRepository
    {
        private utclconfluencesqldbauditdevContext _utclconfluencesqldbauditdevContext = new utclconfluencesqldbauditdevContext();
        private DataEntities.Models.AuditScheduleData _auditSchedule;
       
        private readonly ILogger _logger;
        public AuditScheduleRepository(ILogger<AuditScheduleRepository> logger, utclconfluencesqldbauditdevContext utclconfluencesqldbauditdevContext)
        {
            _logger = logger;
            _utclconfluencesqldbauditdevContext = utclconfluencesqldbauditdevContext;
        }

        public AuditScheduleServiceModel CreateAuditSchedule(AuditScheduleServiceModel audit_Service)
        {
            try
            {
                _logger.LogInformation("OPL Repository Started. Executed : CreateOPL");
                _auditSchedule = ServiceToModelMapper(audit_Service);

                if (_auditSchedule.Id == 0)
                {
                    _utclconfluencesqldbauditdevContext.AuditScheduleData.Add(_auditSchedule);
                    _utclconfluencesqldbauditdevContext.SaveChanges();
                }
                else
                {
                    _utclconfluencesqldbauditdevContext.AuditScheduleData.Update(_auditSchedule);
                    _utclconfluencesqldbauditdevContext.SaveChanges();
                }

                var audit_DTO = RepositoryToDTOMapper(_auditSchedule);
                var auditServiceModel = new AuditScheduleServiceModel(audit_DTO);
                _logger.LogInformation("OPL Repository  Ended. Executed : CreateOPL");
                return auditServiceModel;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        private DataEntities.Models.AuditScheduleData ServiceToModelMapper(AuditScheduleServiceModel auditServiceModel)
        {
            try
            {
                _logger.LogInformation("OPL Repository  Started. Executed : ServiceToModelMapper");
                var _audit_model = new DataEntities.Models.AuditScheduleData();

                _audit_model.Id = auditServiceModel.Id;
                _audit_model.AuditArea = auditServiceModel.AuditArea;
                _audit_model.Team = auditServiceModel.Team;
                _audit_model.Month = auditServiceModel.Month;
                _audit_model.UnitName = auditServiceModel.UnitName;
                _audit_model.UnitId = auditServiceModel.UnitId;
                _audit_model.AuditStatus = auditServiceModel.AuditStatus;
                _audit_model.Modified = auditServiceModel.Modified;
                _audit_model.Created = auditServiceModel.Created;
                _audit_model.Title = auditServiceModel.Title;
                _audit_model.Auditor = auditServiceModel.Auditor;
                _audit_model.StartDate = auditServiceModel.StartDate;
                _audit_model.EndDate = auditServiceModel.EndDate;
                _audit_model.AuditType = auditServiceModel.AuditType;
                _audit_model.Level = auditServiceModel.Level;
                _audit_model.FiscalYear = auditServiceModel.FiscalYear;
                _audit_model.AuditorCommnet = auditServiceModel.AuditorCommnet;
                _audit_model.AuditeeCommnet = auditServiceModel.AuditeeCommnet;
                _audit_model.AuditorDecision = auditServiceModel.AuditorDecision;
                _audit_model.AuditeeDecission = auditServiceModel.AuditeeDecission;
                _audit_model.AuditZone = auditServiceModel.AuditZone;
                _audit_model.PageState = auditServiceModel.PageState;
                _audit_model.TestRole = auditServiceModel.TestRole;
                _audit_model.CreatedBy = auditServiceModel.CreatedBy;
                _audit_model.ModifiedBy = auditServiceModel.ModifiedBy;
                _audit_model.AuditCategory = auditServiceModel.AuditCategory;
                _audit_model.AuditCategoryAuditCatagoryName = auditServiceModel.AuditCategoryAuditCatagoryName;
                _audit_model.Section = auditServiceModel.Section;
                _audit_model.PersonnelInteractedWith = auditServiceModel.PersonnelInteractedWith;
                _audit_model.TotalScore = auditServiceModel.TotalScore;

                _logger.LogInformation("OPL Repository  Ended. Executed : ServiceToModelMapper");
                return _audit_model;
            }
            catch (Exception ex)
            {

                throw ex;
            }


        }

        private AuditScheduleDTO RepositoryToDTOMapper(DataEntities.Models.AuditScheduleData audit_DE)
        {
            try
            {
                _logger.LogInformation("OPL Repository  Started. Executed : RepositoryToDTOMapper");
                var audit_DTO = new AuditScheduleDTO();

                audit_DTO.Id = audit_DE.Id;
                audit_DTO.AuditArea = audit_DE.AuditArea;
                audit_DTO.Team = audit_DE.Team;
                audit_DTO.Month = audit_DE.Month;
                audit_DTO.UnitName = audit_DE.UnitName;
                audit_DTO.UnitId = audit_DE.UnitId;
                audit_DTO.AuditStatus = audit_DE.AuditStatus;
                audit_DTO.Modified = audit_DE.Modified;
                audit_DTO.Created = audit_DE.Created;
                audit_DTO.Title = audit_DE.Title;
                audit_DTO.Auditor = audit_DE.Auditor;
                audit_DTO.StartDate = audit_DE.StartDate;
                audit_DTO.EndDate = audit_DE.EndDate;
                audit_DTO.AuditType = audit_DE.AuditType;
                audit_DTO.Level = audit_DE.Level;
                audit_DTO.FiscalYear = audit_DE.FiscalYear;
                audit_DTO.AuditorCommnet = audit_DE.AuditorCommnet;
                audit_DTO.AuditeeCommnet = audit_DE.AuditeeCommnet;
                audit_DTO.AuditorDecision = audit_DE.AuditorDecision;
                audit_DTO.AuditeeDecission = audit_DE.AuditeeDecission;
                audit_DTO.AuditZone = audit_DE.AuditZone;
                audit_DTO.PageState = audit_DE.PageState;
                audit_DTO.TestRole = audit_DE.TestRole;
                audit_DTO.CreatedBy = audit_DE.CreatedBy;
                audit_DTO.ModifiedBy = audit_DE.ModifiedBy;
                audit_DTO.AuditCategory = audit_DE.AuditCategory;
                audit_DTO.AuditCategoryAuditCatagoryName = audit_DE.AuditCategoryAuditCatagoryName;
                audit_DTO.Section = audit_DE.Section;
                audit_DTO.PersonnelInteractedWith = audit_DE.PersonnelInteractedWith;
                audit_DTO.TotalScore = audit_DE.TotalScore;

                _logger.LogInformation("OPL Repository  Ended. Executed : RepositoryToDTOMapper");
                return audit_DTO;


            }
            catch (Exception ex)
            {

                throw ex;
            }



        }
    }
}
