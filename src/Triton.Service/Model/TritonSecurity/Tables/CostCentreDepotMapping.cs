using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triton.Model.TritonSecurity.Tables
{
    [Table("CostCentreDepotMapping")]
    public class CostCentreDepotMapping
    {
        [Key]
        public int CostCentreDepotMappingID { get; set; }
        public int CostCentreID { get; set; }
        public int DepotID { get; set; }
        [DisplayName("Cost Centre Depot Active")]
        public string  CostCentreDepotActive{get;set;}
    }
}
