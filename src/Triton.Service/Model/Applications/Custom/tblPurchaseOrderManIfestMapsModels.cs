using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Triton.Model.Applications.Tables;
using Triton.Model.CRM.Custom;

namespace Triton.Model.Applications.Custom
{
    public class tblPurchaseOrderManIfestMapsModels
    {
        public tblPurchaseOrderManifestMaps PurchaseOrderManifestMap { get; set; }
        public tblPurchaseOrders PurchaseOrder { get; set; }
        public tblPurchaseOrderManifestMaps ManifestModel { get; set; }
    }
}
