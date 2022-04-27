using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triton.Model.TritonExpress.Tables
{
       [Table("Commodities")]
         public class CommodityModel
    {

              
              [Dapper.Contrib.Extensions.Key] // Commodity Table unique identifier
             public int CommodityID { get; set; }
              [Required(ErrorMessage = "Commodity Value is required!")] // Field validation message
             public string Commodity { get; set; }
    }
}
