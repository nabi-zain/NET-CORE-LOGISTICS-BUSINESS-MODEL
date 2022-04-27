using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using  Triton.Model.CRM.Tables;

namespace  Triton.Model.CRM.Custom
{
    public class QuoteChargeItem
    {
        public string Value { get; set; }
        public string Description { get; set; }
    }
   
     public class QuoteModels
    {
        public Quotes Quote { get; set; }
        public List<QuoteLines> QuoteLines { get; set; }
        public List<QuoteAdditionals> QuoteAdditionals { get; set; }
        public List<QuoteSundrys> QuoteSundrys { get; set; }
        public List<TransportTypes> TransportTypes { get; set; }

      


        public Decimal TotalSundryCharges
        {
            get
            {
                decimal total = 0M;
                if (QuoteAdditionals!=null && QuoteAdditionals.Count > 0)
                    total = QuoteAdditionals.Sum(m => m.AddCharge.Value);
                if (QuoteSundrys!=null && QuoteSundrys.Count > 0)
                    total += QuoteSundrys.Sum(m => m.SundryCharge.Value);
                return total;
            }

        }

        public List<Customers> AllowedCustomerList { get; set; }

        public string QuoteLineHF { get; set; }

    }

    public class TransportPriceResultModels
    {
        public bool wasSuccesfull { get; set; }
        public Decimal? PriceExVat { get; set; }
        public Decimal? PriceIncVat { get; set; }
        public string ErrorMessage { get; set; }
    }

    public class TransportPriceSubmitModels
    {
        [Required]
        public string SenderSuburb { get; set; }
        [Required]
        public string SenderPostalCode { get; set; }
        [Required]
        public string ReceiverSuburb { get; set; }
        [Required]
        public string ReceiverPostalCode { get; set; }
        public string ServiceType { get; set; } = "T4";
        [Required]
        public List<TransportPriceLineItemModels> Lines { get; set; }
        public string CustCode { get; set; } = "ZZ 10";
    }

    public class TransportPriceLineItemModels
    {
        [Required]
        public int LineMass { get; set; }
        public int LineVol { get; set; } = 1;
        public int LineQty { get; set; } = 1;
        public int LineLength { get; set; } = 1;
        public int LineBreadth { get; set; } = 1;
        public int LineHeight { get; set; } = 1;
        public int TotalParcelNoLength { get; set; } = 20;
        public string Description { get; set; }
        public int? VolWeight { get; set; }
        public int? LineNo { get; set; }
        public List<TransportPriceLineItemParcelModels> Parcels { get; set; } = null;

    }
       public class TransportPriceLineItemParcelModels
    {
        public int ParcelMass { get; set; } = 1;
        public string ParcelNo { get; set; }
        public int ParcelLength { get; set; } = 1;
        public int ParcelBreadth { get; set; } = 1;
        public int ParcelHeight { get; set; } = 1;
    }
    

}
