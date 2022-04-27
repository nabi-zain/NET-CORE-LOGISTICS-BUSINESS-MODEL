using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triton.Model.TritonExpress.Tables
{
     [Table("DiscrepancySources")]
 public class DiscrepancySourceModel
    {
    
        [Dapper.Contrib.Extensions.Key] // Discrepancy Sources Table unique identifier
     public int DiscrepancySourceID { get; set; }
    
        [Required(ErrorMessage = "Discrepancy Source Value is required")] // Field validation message
        
        public string DiscrepancySource { get; set; }
    }
}
