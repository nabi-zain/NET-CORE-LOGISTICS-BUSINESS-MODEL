using Dapper.Contrib.Extensions;
using System;

namespace Triton.Model.CRM.Tables
{
    [Table("SubContractors")]
    public class SubContractors
    {
        [Key]
        public int SubContractorID { get; set; }
        public String SubContractorCode { get; set; }
        public String SubContractorName { get; set; }
    }
}

