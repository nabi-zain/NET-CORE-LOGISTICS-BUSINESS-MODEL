using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triton.Model.TritonExpress.Tables
{
   public class ClamsModel
    {


        public  int Claimno { get; set; }
        public  int Discrepancyid { get; set; }
        public string Nameofcompany { get; set; }
        public  DateTime? Datecollected { get; set; }
        public  DateTime? Datedelivered { get; set; }
        public  string Sender { get; set; }
        public string Receiver { get; set; }
        public int? Waybillquantity { get; set; }
        public int? Claimquantity { get; set; }
        public int? Packagingid { get; set; }
        public int? Commodityid { get; set; }
        public string Contents { get; set; }
        public string Claimdescription { get; set; }
        public int? Insurance { get; set; }
        public decimal? Consignmentvalue { get; set; }
        public decimal? Amountclaimed { get; set; }
        public string Accountnumber { get; set; }
        public string Nameofaccount { get; set; }
        public bool Waybill { get; set; }
        public bool Taxinvoice { get; set; }
        public bool Claimform { get; set; }
        public int? Userid { get; set; }
        public string Branchinvestigating { get; set; }
        public DateTime? Datecaptured { get; set; }
        public string Clientemailaddress { get; set; }

    }
}
