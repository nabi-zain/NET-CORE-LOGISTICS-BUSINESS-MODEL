using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triton.Model.TritonGroup.Custom
{
    public class RateAreaModels
    {
        public Triton.Model.TritonGroup.Tables.RateAreas RateArea { get; set; }
        public Triton.Model.TritonGroup.Tables.Users User { get; set; }
        public Triton.Model.TritonGroup.Tables.RateAreas MainRateArea { get; set; }
        public Triton.Model.TritonGroup.Tables.RateAreas RingRateArea { get; set; }
        public List<Triton.Model.TritonGroup.Tables.RateAreas> RateAreaList { get; set; }
    }

    public class RateAreaCreateModels
    {
        public Triton.Model.TritonGroup.Tables.RateAreas RateArea { get; set; }
        public List<Triton.Model.TritonGroup.Tables.RateAreas> RateAreaList { get; set; }
    }
}
