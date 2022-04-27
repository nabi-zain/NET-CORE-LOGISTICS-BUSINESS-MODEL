
using Triton.Model.Applications.Tables;

namespace Triton.Model.Applications.Custom
{
  public class tblGroupApprovalGLCodeModels
    {
        public tblGroupApprovalGLCodes GroupApprovalGLCode { get; set; }
        public tblMasterGLCodes GLCode { get; set; }
        public tblGroupApproval GroupApproval { get; set; }
       
    }
}
