using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triton.Model.Applications.Tables
{
    [Table("tblGroupApproval")]
    public class tblGroupApproval
    {
        [Key]
        public int GroupApprovalID { get; set; }


        public string GroupName { get; set; }

        public string Descripition { get; set; }

        public int GroupStatus { get; set; }

            [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}" ,ApplyFormatInEditMode=true)]

        public DateTime ChangeDate { get; set; }

        public int ChangedUserID { get; set; }

    }
}
