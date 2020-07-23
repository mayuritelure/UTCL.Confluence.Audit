using Microsoft.Extensions.Caching.Distributed;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Text;
using UTCL.Confluence.Audit.DomainServices.Interface;
using UTCL.Confluence.Audit.DomainServices.InterfaceRepository;
using UTCL.Confluence.Audit.DomainServices.ServiceEntities;
using UTCL.Confluence.Audit.DTO;
using UTCL.Confluence.Common.Cache;

namespace UTCL.Confluence.Audit.DomainServices.Class
{
    public class AuditScheduleService : IAuditScheduleService
    {
        private IAuditScheduleRepository _auditScheduleRepository = null;
        private readonly ILogger _logger;
        private ICache _cache;
        private IDistributedCache _DistributedCache;

        public AuditScheduleService(IAuditScheduleRepository auditScheduleRepository, ILogger<AuditScheduleService> logger, ICache cache, IDistributedCache DistributedCache)
        {
            _auditScheduleRepository = auditScheduleRepository;
            _logger = logger;
            _cache = cache;
            _DistributedCache = DistributedCache;
        }

        public AuditScheduleServiceModel CreateAuditSchedule(AuditScheduleDTO audit_DTO)
        {
            try
            {
                _logger.LogInformation("OPL Service Started. Executed : CreateOPL");
                AuditScheduleServiceModel auditService = null;
                var auditSchedule = new AuditScheduleServiceModel(audit_DTO);
                if (auditSchedule.ActionPerformed.ToUpper() == "SUBMIT")
                {
                    DateTime currentDate = DateTime.Today;

                    // Create title for Audit
                    audit_DTO.Title = CreateTitle(auditSchedule.UnitName, auditSchedule.AuditCategory);
                    audit_DTO.AuditStatus = "Audit Submitted";

                }
                else
                {
                    audit_DTO.AuditStatus = "Audit Drafted";

                }
                audit_DTO.Created = DateTime.Now;
                var audit_ServiceModel = new AuditScheduleServiceModel(audit_DTO);
                auditService = _auditScheduleRepository.CreateAuditSchedule(audit_ServiceModel);
                _logger.LogInformation("OPL Service Ended. Executed : CreateOPL");
                return auditService;

            }
            catch (Exception ex)
            { throw ex; }
        }

        public int GetAuditScheduleCount(string month, string year, string status, string accountName, string role, string userName, string unitId,string SystemLevel)
        {
            try
            {
                _logger.LogInformation("OPL Started. Executed : GetOPLCount");
                var CachingData = _cache.GetCache("GetOPLCount", _DistributedCache);
                int GetOPLCount = 0;
                if (CachingData != null && CachingData != "")
                {
                    GetOPLCount = Convert.ToInt32(CachingData);
                }
                else
                {
                    GetOPLCount = _auditScheduleRepository.GetAuditScheduleCount(month, year, status, accountName, role, userName, unitId, SystemLevel);
                    _cache.SetCache("GetOPLCount", GetOPLCount, _DistributedCache);
                }

                _logger.LogInformation("OPL Service Ended. Executed : GetOPLCount");
                return GetOPLCount;
            }
            catch (Exception)
            { throw; }

        }

        public List<AuditScheduleServiceModel> GetScheduleAuditFilter(string month, string year, string status, string accountName, string role, string userName, string unitId,string SystemLevel, int pageSize, int pageNumber)
        {
            try
            {
                _logger.LogInformation("OPL Service Started. Executed : FilterOPL");
                var auditDomainModels = new List<AuditScheduleServiceModel>();
                var auditDTOList = new List<AuditScheduleDTO>();


                 auditDomainModels = _auditScheduleRepository.GetScheduleAuditFilter(month, year, status, accountName, role, userName, unitId, SystemLevel, pageSize, pageNumber);
                   
                _logger.LogInformation("OPL Service Ended. Executed : FilterOPL");

                return auditDomainModels;
            }
            catch (Exception)
            { throw; }

        }


        private string CreateTitle(string UnitName, string AuditCategory)
        {
            try
            {
                _logger.LogInformation("OPL Service Started. Executed : CreateOPL_Code");

                DateTime currentDate = DateTime.Today;
                string title = UnitName + AuditCategory + currentDate;
                return title;
            }
            catch (Exception ex)
            { throw ex; }

        }


    }
}
