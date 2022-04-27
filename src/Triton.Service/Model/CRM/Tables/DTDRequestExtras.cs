using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triton.Model.CRM.Tables
{
    [Table("DTDRequestExtras")]
    public class DTDRequestExtras
    {
        [Dapper.Contrib.Extensions.Key]
        public long DTDRequestExtraID { get; set; }
        [DisplayName("Code")]
        public string ExtraCode { get; set; }
        [DisplayName("Description")]
        public string ExtraDescription { get; set; }
        [DisplayName("Price")]
        public Decimal ExtraPrice { get; set; }
        public DateTime ValidFrom { get; set; }
        public DateTime? ValidTo { get; set; }

        public string DropDownString
        { get
            {
                return ExtraDescription + ExtraPrice.ToString(" + R #.00");
            }
        }

    }
}
