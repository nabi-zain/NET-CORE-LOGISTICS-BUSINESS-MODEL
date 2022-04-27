using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Triton.Model.TritonSecurity.Tables
{
    [Table("Roles")]
  public  class Roles
    {
        [Key]
        public int RoleID { get; set; }
        public string UserID { get; set; }
        public int SystemID { get; set; }
        public int RoleLevelID { get; set; }
        public string RoleName { get; set; }
        public string Description { get; set; }
        public string Active { get; set; }
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd HH:mm }"  ,ApplyFormatInEditMode=true)]
        public DateTime TimedateStamp { get; set; }

    }
}
