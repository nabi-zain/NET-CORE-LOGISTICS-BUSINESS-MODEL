using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Triton.Model.TritonSecurity.Tables
{
    [Table("DeviceUsers")]
    public class DeviceUsers
    {
        [ScaffoldColumn(false)]
        [Required]
        public int DeviceUserID { get; set; }

        [ScaffoldColumn(false)]
        [Required]
        public int EmployeeID { get; set; }

        [DisplayName("Username")]
        [Required]
        public string Username { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [DisplayName("Email Address")]
        public string EmailAddress { get; set; }

        public bool Active { get; set; }

        [ScaffoldColumn(false)]
        public int? CreatedByUserID { get; set; }

        [ScaffoldColumn(false)]        
        public DateTime? CreatedOn { get; set; }

    }
}
