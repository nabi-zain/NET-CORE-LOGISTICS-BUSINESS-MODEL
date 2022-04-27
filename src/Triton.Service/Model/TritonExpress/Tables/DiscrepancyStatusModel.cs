using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triton.Model.TritonExpress.Tables
{
     [Table("DiscrepancyStatus")]
    public class DiscrepancyStatusModel
    {
        [Dapper.Contrib.Extensions.Key]  // Discrepancy Status Table unique identifier
        public int StatusID { get; set; }
        [Required(ErrorMessage = "Status Description Value is required!")] //Field validation message
        public string Description { get; set; }
    }
}
