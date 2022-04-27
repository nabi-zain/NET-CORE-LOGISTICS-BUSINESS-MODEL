using System.Collections.Generic;
using Triton.Model.TritonGroup.Tables;
using Triton.Model.TritonOps.Tables;
using LookUpCodes = Triton.Model.TritonGroup.Tables.LookUpCodes;

namespace Triton.Model.TritonOps.Custom
{
    public class EmployeeGiftsModel
    {
        public List<LookUpCodes> LookUpCodes { get; set; }
        public EmployeeGifts EmployeeGifts { get; set; }
    }
}
