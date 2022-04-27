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
    [Table(" ExceptionScheduleResults")]
   public class ExceptionScheduleResults
    {
        [Key]
        public int ExceptionScheduleResultID { get; set; }
        [DisplayName("Execption Log")]
        public int ExceptionLogID { get; set; }
        [DisplayName("Execption Schedule")]
        public int ExceptionScheduleID { get; set; }
        public int PriKeyRecordID { get; set; }
        [DisplayName("Table Name")]
        public string TableName { get; set; }
        [DisplayName("Exception")]
        public int ExceptionID { get; set; }

    }
}
