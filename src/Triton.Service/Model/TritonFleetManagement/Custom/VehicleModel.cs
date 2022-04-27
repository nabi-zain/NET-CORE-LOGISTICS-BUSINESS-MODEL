using System;
using System.Collections.Generic;
using System.Text;
using Triton.Model.TritonGroup.Tables;
using Triton.Service.Model.TritonFleetManagement.Tables;
using Users = Triton.Model.TritonSecurity.Tables.Users;

namespace Triton.Service.Model.TritonFleetManagement.Custom
{
    public class VehicleModel
    {
        public Customer Customer { get; set; }
        public Vehicle Vehicles { get; set; }
        public License Licenses { get; set; }
        public TailLiftService TailLiftServices { get; set; }
        public Users Users { get; set; }
        public LookUpCodes LookUpCodes { get; set; }
    }
}
