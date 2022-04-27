using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triton.Model.Applications.Tables
{
    [Table("tblPObatchHeader")]
    public class tblPOBatchHeader
    {
        [Key]
        public int BatchHeaderID { get; set; }


        public string Description { get; set; }

        public string Comments { get; set; }

        [DisplayName("File Used For Import")]
        public string FileUsedForImport { get; set; }


        [DisplayName("Created By Date Time")]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd,0 hh:mm , }" ,ApplyFormatInEditMode=true)]
        public DateTime CreatedByDateTime { get; set; }

        [DisplayName("Created By")]
        public int CreatedByID { get; set; }
    }
}
