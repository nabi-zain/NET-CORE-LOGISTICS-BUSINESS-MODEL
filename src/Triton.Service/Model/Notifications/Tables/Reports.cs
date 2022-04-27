using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triton.Model.Notifications.Tables
{
    [Table("Reports")]
  public  class Reports
    {
        [Key]
        public int ReportID { get; set; }
        [DisplayName("Server name")]
        public string ServerAddress { get; set; }
        public string Name { get; set; }
        public int ReportTypeID { get; set; }
        public int SystemID { get; set; }
        [DisplayName(("Default Format Type"))]
        public int DefaultFormatTypeID { get; set; }
        [Required]
        public string Message { get; set; }
        [DisplayName("Has Store Procedure")]
        public string HasStoreProcedure { get; set; }
        [Required]
        [DisplayName("Store Procedure Name")]
        public string StoreProcedureName { get; set; }
        public string Compression { get; set; }









            
    }
}
