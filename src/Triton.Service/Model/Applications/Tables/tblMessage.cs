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
    [Table("tblMessage")]
   public class tblMessage
    {
        [Dapper.Contrib.Extensions.Key]
        public  int MessageID { get; set; }
        [DisplayName("PurchaseOrder")]
        public  int PurchaseOrderID { get; set; }

        public  int CreatorID { get; set; }

        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}" ,ApplyFormatInEditMode=true)]
        public  DateTime TimeStamp { get; set; }

        public  String ToRecipients { get; set; }

        public  String CCRecipients { get; set; }

        [Required]
        [DisplayName("Subject")]
        public  String Subject { get; set; }

        [Required]
        [DisplayName("Message")]
        public  String message { get; set; }

        [Required]
        public  int RelatedMessageID { get; set; }

        [Required]
        public  int ParentMessageID { get; set; }

    }
}
