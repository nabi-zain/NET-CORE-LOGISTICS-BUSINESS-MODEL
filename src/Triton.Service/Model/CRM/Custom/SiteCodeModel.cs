using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Triton.Model.CRM.Tables;

namespace Triton.Service.Model.CRM.Custom
{
    public class SiteCodeModel :Sites
    {
        public string AccountCode { get; set; }
    }
}
