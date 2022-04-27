using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Triton.Service.Model.CRM.Tables
{
    [Table("CustomerReport")]
    public class CustomerReport
    {
        [Key]
        public int CustomerReportID { get; set; }
        public int CustomerID { get; set; }
        public DateTime Time { get; set; }
    }
}
