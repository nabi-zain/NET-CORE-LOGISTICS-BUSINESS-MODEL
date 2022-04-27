using System;
using Dapper.Contrib.Extensions;

namespace Triton.Model.CRM.Tables
{
    [Table("CustomerSms")]
    public class CustomerSms
    {
        [Key]
        public int CustomerSmsID { get; set; }
        public int CustomerID { get; set; }
        public string Message { get; set; }
        public string Mobile { get; set; }
        public DateTime CreatedOn { get; set; }
    }
}
