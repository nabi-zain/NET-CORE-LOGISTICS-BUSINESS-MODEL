using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triton.Model.FWWebservice.Custom
{
    public class CustomerPostalCodes
    {
        public string PostalCodeName { get; set; }
        //public string Suburb { get; set; }
        public string PostalCode { get; set; }
    }

    public class FWResponsePacket
    {
        public dynamic DataObject { get; set; }
        public string ReturnCode { get; set; }
        public string ReturnMessage { get; set; }

    }

     public class FWPodDetails
    {
        public string WaybillNo { get; set; }
        public DateTime  PODDateTimeStamp { get; set; }
        public string RecBy { get; set; }
        public string PODDeliveryNo  { get; set; }
        public string NoOfParcels { get; set; }
        public string GrvNo { get; set; }
        public string PodComments { get; set; }

    }

    public class FWIncreaseRatesModel
    {
        public string CustCode { get; set; }
        public DateTime DateEffective { get; set; }
        public string CurrencyCode { get; set; }
        public bool IncMinCharge { get; set; }
        public decimal? MinChargePerc { get; set; }
        public string MinChargePercRound { get; set; }
        public decimal? MinChargeAmt { get; set; }
        public bool IncRate { get; set; }
        public decimal? RatePerc { get; set; }
        public string RatePercRound { get; set; }
        public decimal? RateAmt { get; set; }
        public bool IncFlatRate { get; set; }
        public decimal? FlatRatePerc { get; set; }
        public string FlatRateRound { get; set; }
        public decimal? FlatRateAmt { get; set; }

        public List<string> IncludeServiceTypes { get; set; } = null;
        public List<string> ExcludeServiceTypes { get; set; } = null;
    }
   


}
