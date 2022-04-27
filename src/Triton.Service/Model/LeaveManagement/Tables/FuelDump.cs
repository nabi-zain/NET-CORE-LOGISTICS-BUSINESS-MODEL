using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper.Contrib.Extensions;

namespace Triton.Model.LeaveManagement.Tables
{
    [Table("FuelDump")]
    public class FuelDump
    {[Key]
        public int ID { get; set; }
        public DateTime? DateDdmmyy { get; set; }
        public string Driver { get; set; }
        public string RegNo { get; set; }
        public string NonTritonRegPvtHiredEtc { get; set; }
        public string VehicleType { get; set; }
        public float? OdometerThisFill { get; set; }
        public float? OdoAtPrevFill { get; set; }
        public string TransactionType { get; set; }
        public string ChargeTo { get; set; }
        public float? PumpReadingBef { get; set; }
        public float? PumpReadingAfter { get; set; }
        public float? CardCashFill { get; set; }
        public float? Litres { get; set; }
        public float? EstCost { get; set; }
        public float? Km { get; set; }
        public float? FuelCons { get; set; }
        public float? TargetCons { get; set; }
        public decimal? RandGainLoss { get; set; }
        public float? TankCapacity { get; set; }
        public float? CapacityError { get; set; }
        public string ConsumException { get; set; }
        public string Comments { get; set; }
        public int? EmployeeID { get; set; }
    }
}
