using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace Triton.Model.TritonOps.Tables
{
    [Table("CheckListItems")]
    public class CheckListItems
    {
        public int ItemID { get; set; }
        public string Description { get; set; }
        public int CreatedByUserID { get; set; }
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}", ApplyFormatInEditMode = true)]
        public DateTime CreatedOn { get; set; }
        public int DeletedByUserID { get; set; }
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}", ApplyFormatInEditMode = true)]
        public DateTime DeletedOn { get; set; }
        public int Amount { get; set; }

    }
}
