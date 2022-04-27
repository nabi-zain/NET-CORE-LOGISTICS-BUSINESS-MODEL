using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triton.Model.TritonExpress.Tables
{
      [Table("Packaging")]
 public class PackagingModel
    {
     [Dapper.Contrib.Extensions.Key] //Packaging Table unique identifier
     public int PackagingID { get; set; }
     [Required(ErrorMessage = "Packaging Value is required!")] //Field validation message
     public string Packaging { get; set; }
    }
}
