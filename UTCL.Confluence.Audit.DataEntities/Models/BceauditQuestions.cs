using System;
using System.Collections.Generic;

namespace UTCL.Confluence.Audit.DataEntities.Models
{
    public partial class BceauditQuestions
    {
        public int? Id { get; set; }
        public string Items { get; set; }
        public double? SrNo { get; set; }
        public string PhysicalCondition { get; set; }
        public string System { get; set; }
        public string Behavior { get; set; }
        public string Catagory { get; set; }
        public string ActivationFlag { get; set; }
        public string CatagoryId { get; set; }
        public DateTime? Modified { get; set; }
        public DateTime? Created { get; set; }
        public string CreatedBy { get; set; }
        public string ModifiedBy { get; set; }
    }
}
