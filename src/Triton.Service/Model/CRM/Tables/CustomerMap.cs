using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Dapper.Contrib.Extensions;

namespace Triton.Model.CRM.Tables
{
    [Table("CustomerMap")]
    public class CustomerMap
    {
        [Dapper.Contrib.Extensions.Key] public int CustomerMapID { get; set; }
        [Required] public int PrimaryCustomerID { get; set; }
        [Required] public int LinkedCustomerID { get; set; }
        [Required] public DateTime CreatedOn { get; set; }
        [Required] public int CreatedByUserID { get; set; }

        public DateTime? DeletedOn { get; set; }
        public int? DeletedByUserID { get; set; }
    }
}
