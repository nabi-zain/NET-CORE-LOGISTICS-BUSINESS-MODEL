using Dapper.Contrib.Extensions;
using System.ComponentModel;

namespace Triton.Model.CRM.Tables
{
    [Table("TransportTypes")]
    public class TransportTypes
    {
        [Dapper.Contrib.Extensions.Key]
        public int TransportTypeID { get; set; }

        [DisplayName("Service Type")]
        public string Description { get; set; }

        [DisplayName("Service Description")]
        public string DeliveryType { get; set; }

        [DisplayName("Service Description")]
        public string ServiceDropDownList { get { return Description.Trim() + " - " + DeliveryType; } }
    }
}
