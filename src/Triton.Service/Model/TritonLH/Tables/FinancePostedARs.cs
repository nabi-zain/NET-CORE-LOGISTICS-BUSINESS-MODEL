using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triton.Model.TritonLH.Tables
{
    [Table("FinancePostedARs")]
   public class FinancePostedARs
    {
        [Dapper.Contrib.Extensions.Key]
        public int FinancePostedARID { get; set; }

        [DisplayName("Finance Transaction")]
        public int FinanceTransaction { get; set; }

        [DisplayName("Finance Transaction LC")]
        public int FinanceTransactionTypeLC { get; set; }
        public int Customers { get; set; }

        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd HH:mm }" ,ApplyFormatInEditMode=true)]
        [DisplayName("Created On")]
        public DateTime CreatedOn { get; set; }

        [DisplayName("Created By")]
        public int CreatedByUserID { get; set; }

        [DisplayName("Posted Period")]
        public int PostedPeriod { get; set; }

        [DisplayName("Posted Year ")]
        public int PostedYear { get; set; }


    }
}
