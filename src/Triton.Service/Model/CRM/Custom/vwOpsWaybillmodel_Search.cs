using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using  Triton.Model.CRM.Tables;
using  Triton.Model.TritonOps.Tables;
using  Triton.Model.TritonStaging.Tables;

namespace  Triton.Model.CRM.Custom
{
    public class vwOpsWaybillmodel_Search
    {
        public List<Waybills> Waybills { get; set; }
        public List<Customers> Customers { get; set; }
        public List<WaybillTrackandTraces> WaybillTrackandTraces { get; set; }
        public List<WaybillOpsNotes> WaybillOpsNotes { get; set; }
        public List<CustomerSpecialArangements> CustomerSpecialArangements { get; set; }
        public List<WaybillSurchargeMaps> WaybillSurchargeMaps { get; set; }
        public List<CustomerSiteMaps> CustomerSiteMaps { get; set; }
        public List<Sites> Sites { get; set; }
        public List<Invoices> Invoices { get; set; }
        public List<FMOEndorsements> FmoEndorsements { get; set; }
        public List<WaybillSurcharges> WaybillSurcharges { get; set; }
        public List<Collections> Collections { get; set; }
        public List<WayBillStatuss> WayBillStatuss { get; set; }
        public List<Manifests> Manifests { get; set; }
        public List<TritonOps.Tables.NoteTypes> NoteTypes { get; set; }
    }
}
