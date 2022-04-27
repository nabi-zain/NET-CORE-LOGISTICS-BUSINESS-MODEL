using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Triton.Service.Model.CRM.StoredProcs
{
    public class proc_CustomerAnalysis_Insert
    {
        [Required]
        public int CustomerID { get; set; }
        [Required]
        public int UserID { get; set; }
        [Required]
        public bool ProcessCompleted { get; set; }
        public DateTime? DeliveryDate { get; set; }
        [Required]
        public bool HasOpsNote { get; set; }
        public string OpsNote { get; set; }
        [Required]
        public bool isManual { get; set; }
        public int? FinalStageID { get; set; }
        public DateTime? EffectiveDate { get; set; }
        public string Outcome { get; set; }
        [Required]
        public bool ExculdeFromReview { get; set; }
    }
}
