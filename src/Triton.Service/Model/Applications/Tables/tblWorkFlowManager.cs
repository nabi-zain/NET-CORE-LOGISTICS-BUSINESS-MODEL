using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triton.Model.Applications.Tables
{
    [Table("tblWorkFlowManager")]
     public class tblWorkFlowManager
    {
        [System.ComponentModel.DataAnnotations.Key]
        public int WorkID { get; set; }
       [Required]
        public string  WorkFlowID {get;set;}
        [Required]
        public string RecoredID { get; set; }
        [Required]
        public string StagesID { get; set; }
        [Required]
        [DisplayName("Assigned To")]
        public string AssignedToID { get; set; }
        [Required]
        public string TaskID { get; set; }
        [Required]
        public string UserID { get; set; }
        [Required]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}" ,ApplyFormatInEditMode=true)]
        public DateTime WorkDate { get; set; }
        [Required]
        public string Comments { get; set; }
        [Required]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}" ,ApplyFormatInEditMode=true)]
        public DateTime CreatedDate { get; set; }

    }
}
