using System.Collections.Generic;
using Triton.Model.LeaveManagement.Tables;
using Triton.Model.TritonGroup.Tables;
using Triton.Model.TritonSecurity.Tables;
using CheckListModel = Triton.Service.Model.LeaveManagement.Custom.CheckListModel;
using WorkFlowManager = Triton.Model.LeaveManagement.Tables.WorkFlowManager;

namespace Triton.Model.LeaveManagement.Custom
{
    public class recExistingPositionsModel
    {
        public recExistingPositions recExistingPositions { get; set; }
        public recEmployees recEmployees { get; set; }
        public Employees Employees { get; set; }
        public Departments Departments { get; set; }
        public orgOrganogram orgOrganogram { get; set; }
        public orgCompany orgCompany { get; set; }
        public JobProfiles JobProfiles { get; set; }
        public LookUpCodes LookUpCodes { get; set; }
        public List<LookUpCodes> ExistingPositionTypes { get; set; }
        public List<LookUpCodes> TransferPromotionTypes { get; set; }
        public List<LookUpCodes> HRMStatus { get; set; }
        public recExistingPositionsModel recExistingPositionsModels { get; set; }
        public WorkFlowManager WorkFlowManager { get; set; }
        public List<CheckListModel> CheckListsModel { get; set; }
        public int LookupcodeID { get; set; }
        public string SelectExistingPositionType { get; set; }
        public string SelectTransferPromotionType { get; set; }
        public string SelectHRMStatus { get; set; }
        public string ErrorMessage { get; set; }
        public bool ReinstateExistingPosition { get; set; }

    }
}
