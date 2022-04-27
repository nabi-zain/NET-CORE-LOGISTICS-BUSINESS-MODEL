using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triton.Model.CRM.Tables
{
    [Table("RateSites")]
    public class RateSites
    {
        [Key]
        public int RateSitesID { get; set; }

        public string Code { get; set; }

        public string Description { get; set; }

        [DisplayName("Order By")]
        public int OrderBy { get; set; }

        [DisplayName("Depot Code")]
        public string DepotCode { get; set; }

        public int RateAreaID { get; set; }

        [DisplayName("Is Cross Border")]
        public int isCrossBorder { get; set; }

        public int BranchID { get; set; }
    }
}
