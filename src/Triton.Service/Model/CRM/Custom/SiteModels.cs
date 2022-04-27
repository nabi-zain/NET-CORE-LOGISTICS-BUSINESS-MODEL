using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using  Triton.Model.CRM.Tables;
using  Triton.Model.CRM.Views;
using  Triton.Model.TritonStaging.Tables;
using  Triton.Model.TritonOps.Tables;

namespace  Triton.Model.CRM.Custom
{
    public class SiteGPSEditModels
    {
        public List<Sites> Sites { get; set; }
        public Sites SelectedSite { get; set; }

        public int? CustomerID { get; set; }

        public List<StoredProcs.proc_GetSiteGPS_Waybill_Tracking> Tracking { get; set; }
    }

    public class SiteFWUpdate
    {
        public Sites SelectedSite { get; set; }
        public int CustomerID { get; set; }
    }

}
