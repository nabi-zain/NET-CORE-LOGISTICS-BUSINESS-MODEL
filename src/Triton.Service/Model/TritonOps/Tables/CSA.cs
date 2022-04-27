using Dapper.Contrib.Extensions;
using System;


namespace Triton.Model.TritonOps.Tables
{
    [Table("CSA")]
    public class CSA
    {
        [Key]
        public int CSAID { get; set; }
        public int CustomerID { get; set; }
        public int UserID { get; set; }
        public bool OtherCustomers { get; set; }
        public bool Active { get; set; }
    }
}
