using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Triton.Model.TritonSecurity.Tables;
namespace Triton.Model.TritonSecurity.Custom
{
    public class CountryCurrencySpotsModel
    {
        public CountryCurrencySpots CountryCurrencySpots { get; set; }
        public Countrys Countrys { get; set; }

    }

    public class CountryCurrencySpotEditModel
    {
        public CountryCurrencySpotsModel CountryCurrencySpotsModel { get; set; }
        public List<CountryCurrencySpots> CountryCurrencySpotses { get; set; }
        public List<Countrys> Countryses { get; set; }
    }
}

