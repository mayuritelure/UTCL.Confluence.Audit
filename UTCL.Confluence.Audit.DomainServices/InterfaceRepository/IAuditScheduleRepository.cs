using System;
using System.Collections.Generic;
using System.Text;
using UTCL.Confluence.Audit.DomainServices.ServiceEntities;

namespace UTCL.Confluence.Audit.DomainServices.InterfaceRepository
{
    public interface IAuditScheduleRepository
    {
        int GetAuditScheduleCount(string month, string year, string status, string accountName, string role, string userName, string unitId,string SystemLevel);

        List<AuditScheduleServiceModel> GetScheduleAuditFilter(string month, string year, string status, string accountName, string role, string userName, string unitId, string SystemLevel, int pageSize, int pageNumber);

        public AuditScheduleServiceModel CreateAuditSchedule(AuditScheduleServiceModel audit_service);

        
    }
}
