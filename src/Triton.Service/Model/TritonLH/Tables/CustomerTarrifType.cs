using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using Dapper.Contrib.Extensions;

namespace Triton.Model.TritonLH.Tables
{
    [Table("CustomerTarrifType")]
    public class CustomerTarrifType
    {
        [Key]
        public int CustomerTarrifTypeID { get; set; }
        public int CustomerID { get; set; }
        public int TarrifTypeLCID { get; set; }
        public DateTime CreatedOn { get; set; }
        public int CreatedByUserID { get; set; }
        public DateTime? DeletedOn { get; set; }
        public int? DeletedByUserID { get; set; }
    }
}
