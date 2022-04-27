
using Triton.Model.Applications.Tables;

namespace Triton.Model.Applications.Custom
{
  public  class tblPOBatchHeaderModel
    {
        public tblPOBatchHeader BatchHeader { get; set; }
        public tblUsers CreatedBy { get; set; }
        public tblStatus Status { get; set; }
        public tblUsers User { get; set; }
    }
}
