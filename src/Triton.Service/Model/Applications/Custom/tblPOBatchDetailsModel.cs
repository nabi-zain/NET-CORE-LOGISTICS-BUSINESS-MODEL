
using Triton.Model.Applications.Tables;

namespace Triton.Model.Applications.Custom
{
    public class tblPOBatchDetailsModel 
    {
         public   tblPOBatchDetails BatchDetails { get; set; }
         public tblPOBatchHeader Batchheader { get; set; }
    public tblStatus Status { get; set; }
    }
}