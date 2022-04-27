using System;
using System.Collections.Generic;
using System.Text;
using Triton.Model.HelpDesk.StoredProcs;

namespace Triton.Model.TritonOps.Views
{
    public class Vw_CSAReps
    {
        public int CustomerID { get; set; }
        public int UserID { get; set; }
        public byte Active { get; set; }

    }
}
