using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triton.Model.TritonExpress.Tables
{
      [Table("DiscrapancyActions")]
    public class DiscrepancyActionModel
    {
         [Dapper.Contrib.Extensions.Key] // Discrepancy Actions Table identifier
        public int ActionID { get; set; }
         [Required(ErrorMessage = "Description Value is required!")] // Field validation message
        public string Description { get; set; }
    }
}
