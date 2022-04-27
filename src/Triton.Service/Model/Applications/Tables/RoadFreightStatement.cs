using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Triton.Service.Model.Applications.Tables
{
    [Table("RoadFreightStatement")]
    public class RoadFreightStatement
    {
        [Dapper.Contrib.Extensions.Key]
        public int RoadFreightStatementID { get; set; }
        public string SupplierCode { get; set; }
        public decimal Total { get; set; }
        public int StatementMonth { get; set; }
        public int StatementYear { get; set; }
        public int CreatedByUserID { get; set; }
        public DateTime CreatedOn { get; set; }
        public int? DeletedByUserID { get; set; }
        public DateTime? DeletedOn { get; set; }
    }
}
