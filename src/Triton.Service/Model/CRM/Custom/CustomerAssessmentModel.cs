using System;
using System.Collections.Generic;
using System.Text;

namespace Triton.Service.Model.CRM.Custom
{
    public class CustomerAssessmentModel
    {
        public decimal SalesIncFuel { get; set; }
        public decimal SalesExFuel { get; set; }
        public decimal ExVat { get; set; }
        public int NoofWaybills { get; set; }
        public decimal NoOfParcels { get; set; }
        public decimal ActualTotal { get; set; }
        public decimal VolumetricTotal { get; set; }
        public decimal ChargableTotal { get; set; }
        public decimal TotalBilling { get; set; }
        public decimal AvgNoDeliveries { get; set; }
        public decimal AvgNoParcels { get; set; }
        public decimal Swat { get; set; }
        public decimal Compliance { get; set; }
        public decimal AvgDelMainCenterActual { get; set; }
        public decimal AvgDelMainCenterVolumetric { get; set; }
        public decimal AvgDelMainCenterChargeable { get; set; }
        public decimal AvgDelOutlyingCenterChargeable { get; set; }
        public decimal PercDelMainCenter { get; set; }
        public decimal PercDelOutCenter { get; set; }
        public decimal AvgInvValue { get; set; }
        public decimal AvgCentsperKG { get; set; }
    }
}
