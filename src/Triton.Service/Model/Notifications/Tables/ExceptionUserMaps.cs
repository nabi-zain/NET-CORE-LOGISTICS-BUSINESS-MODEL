using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triton.Model.Notifications.Tables
{
    [Table("ExceptioUserMap")]
    public class ExceptionUserMaps
    {
        [Key]
        public int ExceptionUserMapID { get; set; }

        [DisplayName("Exception Schedule")]
        public int ExceptionScheduleID {get;set;}
        [DisplayName("User")]
        public int UserID { get; set; }
        [DisplayName("Exception")]
        [Required]
        public int ExceptionID { get; set; }

    }
}
