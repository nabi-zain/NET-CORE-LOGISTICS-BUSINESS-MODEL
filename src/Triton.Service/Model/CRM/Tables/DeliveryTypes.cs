using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper.Contrib.Extensions;

namespace Triton.Model.CRM.Tables
{
    [Table("DeliveryTypes")]
    public class DeliveryTypes
    {
        [Key]
        public int DeliveryTypeID { get; set; }
        public string Description { get; set; }

    }
}
