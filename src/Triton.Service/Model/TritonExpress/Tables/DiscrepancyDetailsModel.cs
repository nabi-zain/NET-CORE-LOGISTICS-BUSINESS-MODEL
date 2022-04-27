using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triton.Model.TritonExpress.Tables
{
     [Table("DiscrepancyDetails")]
    public class DiscrepancyDetailsModel
    {
        [Dapper.Contrib.Extensions.Key]  // Discrepancy Details Table identifier
        public Int64 DiscrepancyDetailsID { get; set; }
        [Required(ErrorMessage = "DiscrepancyID Value is required!")] // Field validation message
        public Int64 DiscrepancyID { get; set; }
        [Required(ErrorMessage = "Discrepancy StatusID Value is required!")] // Field validation message
        public int StatusID { get; set; }
        [Required(ErrorMessage = "Remarks Value is required!")] // Field validation message
        public string Remarks { get; set; }
        [Required(ErrorMessage = "UserID Value is required!")] // Field validation message
        public int UserID { get; set; }
        [Required(ErrorMessage = "Discrepancy Date Updated Value is required!")] // Field validation message
        public DateTime DateUpdated { get; set; }

        [DisplayName("User")]
        [Write(false)]
        [Computed]
         public string Name { get; set; }
    }
}
