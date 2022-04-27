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
    [Table("ReportExceptionUserMaps")]
   public class ReportExceptionUserMaps

    {
        [Key]
        public int ReportExceptionUserMapID { get; set; }
        [DisplayName("Report Exception")]
        public int ReportExceptionID { get; set; }
        public int UserID { get; set; }
        public string Active { get; set; }

    }
}
