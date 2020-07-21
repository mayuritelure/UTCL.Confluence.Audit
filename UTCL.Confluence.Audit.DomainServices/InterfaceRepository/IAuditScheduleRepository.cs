using System;
using System.Collections.Generic;
using System.Text;
using UTCL.Confluence.Audit.DomainServices.ServiceEntities;

namespace UTCL.Confluence.Audit.DomainServices.InterfaceRepository
{
    public interface IAuditScheduleRepository
    {
      
        public AuditScheduleServiceModel CreateAuditSchedule(AuditScheduleServiceModel audit_service);
    }
}
