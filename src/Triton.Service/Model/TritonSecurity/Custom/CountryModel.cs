using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Triton.Model.TritonSecurity.Tables;

namespace Triton.Model.TritonSecurity.Custom
{
    public class CountryModel
    {
        public Countrys Countrys { get; set; }
    }

    public class CountryEditModel
    {
        public CountryModel CountryModel { get; set; }
        public Countrys Countrys { get; set; }
    }
}
