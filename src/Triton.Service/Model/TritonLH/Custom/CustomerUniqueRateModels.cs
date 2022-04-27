using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Triton.Model.TritonLH.Tables;

namespace Triton.Model.TritonLH.Custom
{
    public class CustomerUniqueRateModels
    {
        public Customers Customers { get; set; }
        public CustomerUniqueRates Rate { get; set; }
        public Triton.Model.TritonGroup.Tables.LookUpCodes TripType { get; set; }
        public Triton.Model.TritonGroup.Tables.LookUpCodes LineHaulTrailerType { get; set; }
        public Triton.Model.TritonGroup.Tables.RateAreas FromRateArea { get; set; }
        public Triton.Model.TritonGroup.Tables.RateAreas ToRateArea { get; set; }
    }

    public class CustomerUniqueRateCreateModels
    {
        public CustomerUniqueRates Rate { get; set; }
        public List<Triton.Model.TritonGroup.Tables.LookUpCodes> TripTypes { get; set; }
        public List<Triton.Model.TritonGroup.Tables.LookUpCodes> LineHaulTrailerTypes { get; set; }
        public List<Triton.Model.TritonGroup.Tables.RateAreas> RateAreas { get; set; }
        public Customers Customers { get; set; }

        public decimal CurrentFuelPrice { get; set; }
    }

   
}
