using Triton.Model.CRM.Tables;
using Triton.Service.Model.Applications.Tables;
using LookUpCodes = Triton.Model.TritonGroup.Tables.LookUpCodes;
using Triton.Model.Applications.Tables;

namespace Triton.Service.Model.Applications.StoredProcs
{
    public class proc_RoadFreightAgent_GetByID
    {
        public RoadFreightAgent RoadFreightAgent { get; set; }
        public Waybills Waybills { get; set; }
        public LookUpCodes Status { get; set; }
        public LookUpCodes Category { get; set; }
        public tblMasterSuppliers Supplier { get; set; }
        
    }
}
