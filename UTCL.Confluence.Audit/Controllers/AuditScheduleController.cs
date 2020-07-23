using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using UTCL.Confluence.Audit.DomainServices.Interface;
using UTCL.Confluence.Audit.DomainServices.ServiceEntities;
using UTCL.Confluence.Audit.DTO;

namespace UTCL.Confluence.Audit.APIControllers.Controllers
{
    [Authorize]
    [ApiController]
    [Route("teamactivities/[controller]")]
    public class AuditScheduleController : Controller
    {

        private IAuditScheduleService _auditScheduleService;
        private readonly ILogger _logger;

        public AuditScheduleController(IConfiguration configuration, IAuditScheduleService auditScheduleService, ILogger<AuditScheduleController> logger)
        {
            _auditScheduleService = auditScheduleService;
            _logger = logger;
            Configuration = configuration;
        }
        public IConfiguration Configuration { get; }

        [HttpGet]
        [Route("GetAuditScheduleCount/{month}/{year}/{status}")]
        public int GetAuditScheduleCount(string month, string year, string status, [FromQuery] string accountName, [FromQuery] string role, [FromQuery] string userName, [FromQuery] string unitId, [FromQuery] string SystemLevel)
        {
            _logger.LogInformation("OPL Controller Started. Executed : GetOPLCount");
            int auditAllRecordsCount = _auditScheduleService.GetAuditScheduleCount(month, year, status, accountName, role, userName, unitId, SystemLevel);
            _logger.LogInformation("OPL Controller Ended. Executed : GetOPLCount");
            return auditAllRecordsCount;

        }

        [HttpGet]
        [Route("GetScheduleAuditFilter/{month}/{year}/{status}/{pageSize}/{pageNumber}")]
        public List<AuditScheduleDTO> GetScheduleAuditFilter(string month, string year, string status, int pageSize, int pageNumber, [FromQuery] string accountName, [FromQuery] string role, [FromQuery] string userName, [FromQuery] string unitId,[FromQuery] string SystemLevel)
        {

            try
            {
                _logger.LogInformation("Good To Find Controller Started. Executed : FilterGoodToFind");
                List<AuditScheduleDTO> auditScheduleDTOList = new List<AuditScheduleDTO>();
                var audit_List = _auditScheduleService.GetScheduleAuditFilter(month, year, status, accountName, role, userName, unitId, SystemLevel, pageSize, pageNumber);

                foreach (var audit in audit_List)
                {
                    auditScheduleDTOList.Add(ServiceToDTOMapper(audit));
                }
                _logger.LogInformation("Good To Find Controller Ended. Executed : FilterGoodToFind");
                return auditScheduleDTOList;
            }
            catch (Exception ex)
            { throw ex; }

        }

        [HttpPost]
        [Route("CreateAuditSchedule")]
        public AuditScheduleDTO CreateAuditSchedule([FromBody] AuditScheduleDTO audit_DTO)
        {
            try
            {
                _logger.LogInformation("OPL Controller Started. Executed : CreateOPL");
                AuditScheduleServiceModel audit_DomainModel = _auditScheduleService.CreateAuditSchedule(audit_DTO);
                AuditScheduleDTO oplDTOreturnVal = ServiceToDTOMapper(audit_DomainModel);
                _logger.LogInformation("OPL Controller Ended. Executed : CreateOPL");
                return oplDTOreturnVal;
            }
            catch (Exception)
            { throw; }

        }

       


        private AuditScheduleDTO ServiceToDTOMapper(AuditScheduleServiceModel auditScheduleservice_model)
        {
            try
            {
                _logger.LogInformation("OPL Controller Started. Executed : ServiceToDTOMapper");
                var auditSchedule_DTO = new AuditScheduleDTO();

                auditSchedule_DTO.Id = auditScheduleservice_model.Id;
                auditSchedule_DTO.AuditArea = auditScheduleservice_model.AuditArea;
                auditSchedule_DTO.Team = auditScheduleservice_model.Team;
                auditSchedule_DTO.Month = auditScheduleservice_model.Month;
                auditSchedule_DTO.UnitName = auditScheduleservice_model.UnitName;
                auditSchedule_DTO.UnitId = auditScheduleservice_model.UnitId;
                auditSchedule_DTO.AuditStatus = auditScheduleservice_model.AuditStatus;
                auditSchedule_DTO.Modified = auditScheduleservice_model.Modified;
                auditSchedule_DTO.Created = auditScheduleservice_model.Created;
                auditSchedule_DTO.Title = auditScheduleservice_model.Title;
                auditSchedule_DTO.Auditor = auditScheduleservice_model.Auditor;
                auditSchedule_DTO.StartDate = auditScheduleservice_model.StartDate;
                auditSchedule_DTO.EndDate = auditScheduleservice_model.EndDate;
                auditSchedule_DTO.AuditType = auditScheduleservice_model.AuditType;
                auditSchedule_DTO.Level = auditScheduleservice_model.Level;
                auditSchedule_DTO.FiscalYear = auditScheduleservice_model.FiscalYear;
                auditSchedule_DTO.AuditorCommnet = auditScheduleservice_model.AuditorCommnet;
                auditSchedule_DTO.AuditeeCommnet = auditScheduleservice_model.AuditeeCommnet;
                auditSchedule_DTO.AuditorDecision = auditScheduleservice_model.AuditorDecision;
                auditSchedule_DTO.AuditeeDecission = auditScheduleservice_model.AuditeeDecission;
                auditSchedule_DTO.AuditZone = auditScheduleservice_model.AuditZone;
                auditSchedule_DTO.PageState = auditScheduleservice_model.PageState;
                auditSchedule_DTO.TestRole = auditScheduleservice_model.TestRole;
                auditSchedule_DTO.CreatedBy = auditScheduleservice_model.CreatedBy;
                auditSchedule_DTO.ModifiedBy = auditScheduleservice_model.ModifiedBy;
                auditSchedule_DTO.AuditCategory = auditScheduleservice_model.AuditCategory;
                auditSchedule_DTO.AuditCategoryAuditCatagoryName = auditScheduleservice_model.AuditCategoryAuditCatagoryName;
                auditSchedule_DTO.Section = auditScheduleservice_model.Section;
                auditSchedule_DTO.PersonnelInteractedWith = auditScheduleservice_model.PersonnelInteractedWith;
                auditSchedule_DTO.TotalScore = auditScheduleservice_model.TotalScore;

                return auditSchedule_DTO;
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }

              

    }
}