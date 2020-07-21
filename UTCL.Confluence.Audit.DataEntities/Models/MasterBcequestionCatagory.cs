using System;
using System.Collections.Generic;

namespace UTCL.Confluence.Audit.DataEntities.Models
{
    public partial class MasterBcequestionCatagory
    {
        public int? Id { get; set; }
        public double? CatagoryId { get; set; }
        public string CatagoryName { get; set; }
        public string ActivationFlag { get; set; }
        public double? CategoryQuestionCount { get; set; }
        public string Title { get; set; }
        public DateTime? Modified { get; set; }
        public DateTime? Created { get; set; }
        public string CreatedBy { get; set; }
        public string ModifiedBy { get; set; }
    }
}
