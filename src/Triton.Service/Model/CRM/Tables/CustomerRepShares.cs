using Dapper.Contrib.Extensions;
using System;

namespace Triton.Model.CRM.Tables
{
    [Table("CustomerRepShares")]
    public class CustomerRepShares
    {
        [Key]
        public int CustomerRepShareID { get; set; }
        public int CustomerID { get; set; }
        public int RepCodeID { get; set; }
        public int AllocationPerc { get; set; }
        public int AllocationPercTargetOnly { get; set; }
        public string Reason { get; set; }
        public DateTime DateEffectiveTo { get; set; }
        public DateTime DateEffectiveFrom { get; set; }
        public int CustomerCommisionTypeID { get; set; }
        public int FixedPerc { get; set; }
        public decimal hasFixedPrec { get; set; }
        public byte SpecCommLevel { get; set; }
        public int CommLevel { get; set; }
    }
}
