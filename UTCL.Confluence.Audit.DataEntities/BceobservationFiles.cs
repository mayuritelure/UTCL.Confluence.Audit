using System;
using System.Collections.Generic;

namespace UTCL.Confluence.Audit.DataEntities
{
    public partial class BceobservationFiles
    {
        public int? Id { get; set; }
        public string CategoryId { get; set; }
        public string AuditId { get; set; }
        public string OfiFile { get; set; }
        public string StrengthFile { get; set; }
        public string TitleTitle { get; set; }
        public DateTime? Modified { get; set; }
        public DateTime? Created { get; set; }
        public string CreatedBy { get; set; }
        public string ModifiedBy { get; set; }
    }
}
