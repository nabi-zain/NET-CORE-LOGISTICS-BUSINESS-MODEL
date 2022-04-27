using Dapper.Contrib.Extensions;
using System;
using System.ComponentModel;

namespace Triton.Model.CRM.Tables
{
    [Table("DTDRequestLines")]
    public class DTDRequestLines
    {
        [Key]
        public Int64 DTDRequestLineID { get; set; }

        public Int64 DTDRequestID { get; set; }
        public int LineNumber { get; set; }
        public int Qty { get; set; }
        public Decimal Mass { get; set; }
        public Decimal Vol { get; set; }
        public Decimal? VolWeight { get; set; }
        public int Length { get; set; }
        public int Breadth { get; set; }
        public int Height { get; set; }
        public Decimal ChargeUnits { get; set; }
        public Decimal Charge { get; set; }
        public string Description { get; set; }
        public int? DTDRequestExtraID { get; set; }
        [Computed]
        public string AmountString
        { get
            {
                return Charge.ToString("R 0.00");
            }
        }

    }
}