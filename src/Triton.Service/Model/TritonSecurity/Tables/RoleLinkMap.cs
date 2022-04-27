using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Triton.Model.TritonSecurity.Tables
{
    [Table("RoleLinkMap")]
   public class RoleLinkMap
    {
        [Key]
        public int RoleLinkMapID { get; set; }
        public string UserID { get; set; }
        public int RoleId { get; set; }
        public int RoleID { get; set; }
        public string Active { get; set; }
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}" ,ApplyFormatInEditMode=true)]
        public DateTime TimeDateStamp { get; set; }

    }
}
