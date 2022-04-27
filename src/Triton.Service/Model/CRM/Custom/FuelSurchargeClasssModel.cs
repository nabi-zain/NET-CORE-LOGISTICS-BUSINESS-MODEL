using System;
using System.Collections.Generic;
using Triton.Model.CRM.Tables;

namespace Triton.Service.Model.CRM.Custom
{
    public class FuelSurchargeClasssModel
    {
        public List<FuelSurchargeClasss> FuelSurchargeClasss { get; set; }
        public DateTime SelectedDate { get; set; }
    }
}
