using System;
using System.Collections.Generic;
using System.Text;
using UTCL.Confluence.Audit.DomainServices.ServiceEntities;
using UTCL.Confluence.Audit.DTO;

namespace UTCL.Confluence.Audit.DomainServices.Interface
{
    public interface IAuditScheduleService
    {
         public AuditScheduleServiceModel CreateAuditSchedule(AuditScheduleDTO audit_DTO); 
    }
}
