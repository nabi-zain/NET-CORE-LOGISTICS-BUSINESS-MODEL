using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using KeyAttribute = Dapper.Contrib.Extensions.KeyAttribute;

namespace Triton.Service.Model.TritonFleetManagement.Tables
{
    [Table("CustomerDocument")]
    public class CustomerDocument
    {
        [Key]
        public int CustomerDocumentID { get; set; }
        public int CustomerID { get; set; }
        public int DocumentRepositoryID { get; set; }
        public DateTime CreatedOn { get; set; }
        public int CreatedBy { get; set; }
        public DateTime DeletedOn { get; set; }
        public DateTime DeletedBy { get; set; }
    }
}
