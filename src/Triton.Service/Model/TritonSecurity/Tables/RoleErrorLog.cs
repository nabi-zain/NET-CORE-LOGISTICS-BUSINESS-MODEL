using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Triton.Model.TritonSecurity.Tables
{
    [Table("RoleErrorLog")]
   public class RoleErrorLog
    {
        [Key]
        public int ErrorLogID { get; set; }
        public string UserID { get; set; }
        public string ErrorPage { get; set; }
        [Required]
        public string Error01 { get; set; }
        [Required]
        public string Error02 { get; set; }
        [Required]
        public string Error03 { get; set; }
        [Required]
        public string Error04 { get; set; }
        [Required]
        public string Error05 { get; set; }
        [Required]
        public string Error06 { get; set; }
        [Required]
        public string Error07 { get; set; }
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd HH:mm }"  ,ApplyFormatInEditMode=true)]
        public string TimeDateStamp { get; set; }

    }
}
