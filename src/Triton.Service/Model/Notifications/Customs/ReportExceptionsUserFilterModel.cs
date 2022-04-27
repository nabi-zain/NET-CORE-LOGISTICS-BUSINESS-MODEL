using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Triton.Model.Notifications.Tables;

namespace Triton.Model.Notifications.Customs
{
   public class ReportExceptionsUserFiltersModel

    {
        public ReportExceptionsUserFilters ReportExceptionsUserFilters { get; set; }
        public Triton.Model.TritonSecurity.Tables.Users Users { get; set; }
        public Triton.Model.TritonSecurity.Tables.Branches Branches { get; set; }
        public Triton.Model.TritonSecurity.Tables.Departments Departments { get; set; }
        public Triton.Model.TritonSecurity.Tables.Companys Companys { get; set; }
    } 
}
