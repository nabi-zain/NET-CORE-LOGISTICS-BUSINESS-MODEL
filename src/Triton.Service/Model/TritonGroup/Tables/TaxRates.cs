using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triton.Model.TritonGroup.Tables
{
    [Table("TaxRates")]
    public class TaxRates
    {
        [Dapper.Contrib.Extensions.Key]
        public int TaxRateID { get; set; }
        public string TaxName { get; set; }
        public string TaxDescriptor { get; set; }
        [DisplayName("County")]
        public int CountryID { get; set; }
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}", ApplyFormatInEditMode = true)]
        public DateTime DateEffectiveFrom { get; set; }
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}", ApplyFormatInEditMode = true)]
        public DateTime? DateEffectiveTo { get; set; }
        public Decimal Rate { get; set; }
        public int CreatedByUserID { get; set; }
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd HH:mm}", ApplyFormatInEditMode = true)]
        public DateTime CreatedOn { get; set; }
        public int DeletedByUserID { get; set; }
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd HH:mm }", ApplyFormatInEditMode = true)]
        public DateTime? DeleteOn { get; set; }

    }
}
