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
                var opl = new AuditScheduleServiceModel(audit_DTO);

                audit_DTO.Created = DateTime.Now;
                var audit_ServiceModel = new AuditScheduleServiceModel(audit_DTO);
                auditService = _auditScheduleRepository.CreateAuditSchedule(audit_ServiceModel);
                _logger.LogInformation("OPL Service Ended. Executed : CreateOPL");
                return auditService;

            }
            catch (Exception ex)
            { throw ex; }
        }


    }
}
