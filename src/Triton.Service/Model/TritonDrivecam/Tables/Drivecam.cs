using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Triton.Model.TritonDrivecam.Tables
{
    [Table("Drivecams")]
    public class Drivecam
    {
        [Dapper.Contrib.Extensions.Key]

        public long DrivecamID { get; set; }
        public string Driver { get; set; }
        public int EmployeeID { get; set; }
        public string Vehicle { get; set; }
        public int VehicleiD { get; set; }
        public string Behaviours { get; set; }
        public string EventScore { get; set; }
        public string Group { get; set; }
        public string EventDate { get; set; }
        public string EventTime { get; set; }
        public DateTime? EventTimeStamp { get; set; }
        public string EventNumber { get; set; }
        public string EventStatus { get; set; }
        public string EventUrl { get; set; }
        public string Location { get; set; }
        public long VideoBlobID { get; set; }
        public DateTime? EventDateStamp { get; set; }
        public bool Exclude { get; set; }
        public bool isCollision { get; set; }
        public string GPoint { get; set; }
        public int? BranchIDatTime { get; set; }
        public int? AlternativeBranchID { get; set; }
        public int? AccidentID { get; set; }
        public bool wasCounselled { get; set; }

    }
}
