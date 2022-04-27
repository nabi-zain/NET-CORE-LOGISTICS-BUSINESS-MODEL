using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper.Contrib.Extensions;

using System.ComponentModel.DataAnnotations;

namespace Triton.Model.Applications.Tables
{
    [Table("tblPurchaseOrderAudit")]
    public class tblPurchaseOrderAudit
    {
      
        [Dapper.Contrib.Extensions.Key]
        public int AuditID { get; set; }
        [Required]
        public int PurchaseOrderID { get; set; }

        public int AuditEventTypeID { get; set; }

        public DateTime AuditDate { get; set; }
        [Required]
        public string UserName { get; set; }

        public string AuditDetails { get; set; }


    }

}