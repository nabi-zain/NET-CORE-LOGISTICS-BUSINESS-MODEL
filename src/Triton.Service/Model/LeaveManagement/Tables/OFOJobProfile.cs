using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Triton.Service.Model.LeaveManagement.Tables
{
    [Table("OFOJobProfile")]
    public class OFOJobProfile
    {
        [Dapper.Contrib.Extensions.Key]
        public int OFOJobProfileID { get; set; }
        public int OFOSpecialisationID { get; set; }
        public int JobProfileID { get; set; }
        public int OFOCodeID { get; set; }
        public DateTime CreatedOn { get; set; }
        public int CreatedByUserID { get; set; }
        public DateTime? DeletedOn { get; set; }
        public int? DeletedByUserID { get; set; }
    }
}
