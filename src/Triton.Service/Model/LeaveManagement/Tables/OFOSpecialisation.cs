using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Triton.Service.Model.LeaveManagement.Tables
{
    [Table("OFOSpecialisation")]
    public class OFOSpecialisation
    {
        [Dapper.Contrib.Extensions.Key]
        public int OFOSpecializationID { get; set; }
        public int OFOCodeID { get; set; }
        public string Description { get; set; }
        public DateTime CreatedOn { get; set; }
        public int CreatedByUserID { get; set; }
        public DateTime? DeletedOn { get; set; }
        public int? DeletedByUserID { get; set; }
    }
}
