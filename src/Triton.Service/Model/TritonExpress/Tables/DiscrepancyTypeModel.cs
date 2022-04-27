using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triton.Model.TritonExpress.Tables
{
      [Table("DiscrepancyTypes")]
     public class DiscrepancyTypeModel
    {
          [Dapper.Contrib.Extensions.Key] //Discrepancy Table unique identifier
     public int DiscrepancyTypeID { get; set; }
     [Required(ErrorMessage = "Discrepancy Type Value is required")] //Field validation message
     public string DiscrepancyType { get; set; } 
    }
}
