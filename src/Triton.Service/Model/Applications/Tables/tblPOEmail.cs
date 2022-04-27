using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper.Contrib.Extensions;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Triton.Model.Applications.Tables
{
    [Table("tblPOEmail")]
    public class tblPOEmail
    {
        [Dapper.Contrib.Extensions.Key]
        public int POEmailID { get; set; }

        [DisplayName("TO")]
        public string ToEmailAddress { get; set; }

        [DisplayName("FROM")]
        public string FromEmailAddress { get; set; }

        [Required]
        public string Body { get; set; }

        [Required]
        public string Subject { get; set; }

        [Required]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}" ,ApplyFormatInEditMode=true)]
        public DateTime CreateDate { get; set; }

        public bool? Processed { get; set; }

        [Required]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}" ,ApplyFormatInEditMode=true)]
        public DateTime? ProcessedOn { get; set; }

        [Required]
        [DisplayName("Process Messages")]
        public string ProcessMessages { get; set; }
    }
}
