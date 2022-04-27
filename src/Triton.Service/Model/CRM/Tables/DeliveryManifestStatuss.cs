using System;
using Dapper.Contrib.Extensions;

namespace Triton.Model.CRM.Tables
{
    [Table("DeliveryManifestStatuss")]
    public class DeliveryManifestStatuss
    {

        [Key]
        public virtual int DeliveryManifestStatusID { get; set; }
        public virtual int StatusNo { get; set; }
        public virtual String Description { get; set; }
    }
}

