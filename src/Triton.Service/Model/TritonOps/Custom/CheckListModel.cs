using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Triton.Model.CRM.Tables;
using Triton.Model.Dashboard;
using Triton.Model.HelpDesk.StoredProcs;
using Triton.Model.LeaveManagement.Tables;

using Triton.Model.TritonOps.Tables;
using Triton.Model.TritonVehicles.Tables;

namespace Triton.Model.TritonOps.Custom
{
    public class CheckListModel
    {
        public CheckList CheckList { get; set; }
        public Employees Employees { get; set; }
        public Routes Routes { get; set; }
        public CheckListDetails CheckListDetail { get; set; }
        public Vehicles Vehicle { get; set; }
        public VehicleBags VehicleBag { get; set; }
        public CheckListDocuments CheckListDocuments { get; set; }
        public CheckListItems CheckListItems { get; set; }
        public TritonGroup.Tables.LookUpCodes LookUpCodes { get; set; }
        public RouteNames RouteNames { get; set; }
        public VehicleRegMaps VehicleRegMaps { get; set; }

    }

    public class CheckListCreateModel
    {
        public CheckListModel CheckListModel { get; set; }
        public List<RouteNames> Routes { get; set; }
        public List<ChecklistCategories> Categories { get; set; }
        public List<VehicleBags> VehicleBags { get; set; }
        public List<Employees> Employeeses { get; set; }
        public List<VehicleRegMaps> VehicleRegMaps { get; set; }
        public List<CheckListItems> CheckListItems { get; set; }
        public CheckListDocuments CheckListDocuments { get; set; }
        public List<TritonGroup.Tables.LookUpCodes> LookUpCodes { get; set; }
        public CheckList checkList { get; set; }
        public List<CheckListDetails> CheckListDeatils {get;set;}
    }
    
}
