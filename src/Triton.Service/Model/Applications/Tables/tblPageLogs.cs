using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper.Contrib.Extensions;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Triton.Model.Applications.Tables
{
    [Table("tblPageLogs")]
    public class tblPageLogs
    {
      
        [Dapper.Contrib.Extensions.Key]
        public int PageLogID { get; set; }
        public string Page { get; set; }
        public int UserID { get; set; }
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}" ,ApplyFormatInEditMode=true)]
        public DateTime TimeStamp { get; set; }
        public String Action { get; set; }

        [Required]
        public int? PurchaseOrderID { get; set; }
    }
}
