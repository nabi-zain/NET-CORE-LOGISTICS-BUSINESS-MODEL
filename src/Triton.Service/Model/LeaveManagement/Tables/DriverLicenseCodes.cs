using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper.Contrib.Extensions;

namespace Triton.Model.LeaveManagement.Tables
{
    [Table("DriverLicenseCodes")]
    public class DriverLicenseCodes
    {
        [Key]
        public int DriverLicenseCodeID { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
    }
}
