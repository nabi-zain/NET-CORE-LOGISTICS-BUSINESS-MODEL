using Dapper.Contrib.Extensions;
using System;

namespace Triton.Model.CRM.Tables
{
    [Table("DeliveryManifestLineItemStatuss")]
    public class DeliveryManifestLineItemStatuss
    {

        [Key]
        public  int DeliveryManifestLineItemStatusID { get; set; }
        public  int StatusNo { get; set; }
        public  String Description { get; set; }

    }
}

