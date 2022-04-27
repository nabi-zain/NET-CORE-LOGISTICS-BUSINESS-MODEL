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
    [Table("ReportUserParameterMaps")]
   public class ReportUserParameterMaps
    {
        [Key]
        public int ReportUserParameterMapID { get; set; }
        public int ReportID { get; set; }
        [Required]
        public int UserID { get; set; }
        [DisplayName("Report Parameter")]
        public int ReportParameterID { get; set; }
        public string Value { get; set; }

    }
    }

