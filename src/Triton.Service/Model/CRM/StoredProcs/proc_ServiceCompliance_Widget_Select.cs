using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triton.Model.CRM.StoredProcs
{
    public class proc_ServiceCompliance_Widget_Select
    {
        public int CurrentYear { get; set; }

        public int CurrentMonth { get; set; }

        public int FailedDeliveries { get; set; }

        public int TotalDeliveries { get; set; }

        public int TotalCollections { get; set; }

        public int MissedCollections { get; set; }

        public decimal CollectionPerc { get; set; }

        public decimal? Claims { get; set; }

        public int? Accidents { get; set; }
    }
}