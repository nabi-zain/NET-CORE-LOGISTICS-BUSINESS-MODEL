using Triton.Model.TritonGroup.Tables;
using Triton.Service.Model.Applications.Tables;
using Users = Triton.Model.TritonSecurity.Tables.Users;

namespace Triton.Service.Model.Applications.Custom
{
    public class RoadFreightAgentHistoryModel
    {
        public RoadFreightAgentHistory RoadFreightAgentHistory { get; set; }
        public LookUpCodes Categories { get; set; }
        public LookUpCodes Status { get; set; }
        public Users Users { get; set; }
        public int RoadFreightAgentID { get; set; }
    }
}
