using System.ComponentModel.DataAnnotations;
using Triton.Model.CRM.Tables;

namespace Triton.Model.CRM.Custom
{
    public class WaybillQuery_Waybills_Model
    {
        public WaybillQuery WaybillQuery { get; set; }

        public Waybills Waybills { get; set; }

        public Sites ReceiverSites { get; set; }
        public WayBillStatuss WayBillStatuss { get; set; }
        public LookUpCodes LoookUpCodes { get; set; }
    }

    public class WaybillQueryMaster_Waybills_Model
    {
        public WaybillQueryMaster WaybillQueryMaster { get; set; }

        public Waybills Waybills { get; set; }

        public Sites ReceiverSites { get; set; }
        public WayBillStatuss WayBillStatuss { get; set; }
        public LookUpCodes LoookUpCodes { get; set; }
    }

    public class WaybillQueryMasterInsertModel
    {
        [Required] public long WaybillId { get; set; }
        [Required] public int UserId { get; set; }
        [Required] public string Query { get; set; }
        [Required] public int QueryStatusLcid { get; set; }
        [Required] public int CreatedByUserId { get; set; }
        public string Resolution { get; set; }
        public int? SystemId { get; set; }
    }
}
