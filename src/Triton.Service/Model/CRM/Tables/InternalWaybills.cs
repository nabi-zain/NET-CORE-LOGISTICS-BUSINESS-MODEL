 using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triton.Model.CRM.Tables
{
    [Table("InternalWaybills")]
    public class InternalWaybills
    {
        [Key]
      
        public long InternalWaybillID { get; set; }
        public long WaybillID { get; set; }
        [Computed]
        public string ReferenceNo { get; set; }
        public long CreatedByGroupUserID { get; set; }
        public DateTime CreatedOn { get; set; }
        public long CreatedByUserID { get; set; }
        [Computed]
        public string Pin { get; set; }

        public string SenderContact { get; set; }
        public string SenderTel { get; set; }
        public string SenderCell { get; set; }
        public string SenderEmail { get; set; }
        public string ReceiverContact { get; set; }
        public string ReceiverTel { get; set; }
        public string ReceiverCell { get; set; }
        public string ReceiverEmail { get; set; }

    }
}

