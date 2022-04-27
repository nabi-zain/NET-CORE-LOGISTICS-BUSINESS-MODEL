using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triton.Model.TritonOps.StoredProcs
{
    public class proc_Drivecams_By_BranchID_And_StageID_Select
    {
        public long DriveCamID { get; set; }

        public string Driver { get; set; }

        public string Vehicle { get; set; }

        public int? EmployeeID { get; set; }

        public int? VehicleID { get; set; }

        public string Behaviours { get; set; }

        public DateTime EventDateStamp { get; set; }

        public string EventTime { get; set; }

        public string EventNumber { get; set; }

        public string EventUrl { get; set; }

        public int EventScore { get; set; }

        public string BranchName { get; set; }

        public string Collision { get; set; }

        public string Excluded { get; set; }

        public DateTime WorkDate { get; set; }
    }
}