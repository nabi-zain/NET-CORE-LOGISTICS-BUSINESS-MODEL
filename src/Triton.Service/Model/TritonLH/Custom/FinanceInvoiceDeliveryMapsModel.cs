using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Triton.Model.TritonLH.Tables;
using Triton.Model.TritonSecurity.Tables;

namespace Triton.Model.TritonLH.Custom
{
    public class FinanceInvoiceDeliveryMapsModel
    {
        public FinanceInvoiceDeliveryMaps FinanceInvoiceDeliveryMap { get; set; }
        public Deliveries Delivery { get; set; }
        public FinanceInvoices FinanceInvoice { get; set; }
        public Triton.Model.TritonGroup.Tables.Users CreatedByUser { get; set; }
        public Triton.Model.TritonGroup.Tables.Users DeletedByUser { get; set; }
    }

        public class FinanceInvoiceDeliveryMapsEditModel
        {
            public FinanceInvoiceDeliveryMapsModel FinanceInvoiceDeliveryMapModel { get; set; }
       
            public List <Deliveries> Deliveries { get; set; }
            public List<FinanceInvoices> FinanceInvoices { get; set; }
            
        }
  
}

