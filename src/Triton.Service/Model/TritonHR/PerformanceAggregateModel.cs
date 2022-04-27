using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triton.Model.TritonHR
{
    [Table("PerformanceAggregates")]
    public class PerformanceAggregateModel
    {
        [Dapper.Contrib.Extensions.Key]
        public int AggregateID { get; set; }

        [DisplayName("Aggregate Name")]
        [Required(ErrorMessage = "Aggregate Name name is required")]
        [StringLength(80)]
        public string AggregateName { get; set; }
    }
}
