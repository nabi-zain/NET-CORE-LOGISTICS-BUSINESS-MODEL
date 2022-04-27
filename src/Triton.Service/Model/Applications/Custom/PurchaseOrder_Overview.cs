using System;
using System.Collections.Generic;
using Triton.Model.CRM.Tables;
using Triton.Service.Model.Applications.StoredProcs;
using Triton.Service.Model.Applications.Tables;
using LookUpCodes = Triton.Model.TritonGroup.Tables.LookUpCodes;
using Users = Triton.Model.TritonSecurity.Tables.Users;

namespace Triton.Service.Model.Applications.Custom
{
    public class PurchaseOrder_Overview
    {
        public List<proc_AgentIssues_Tab> AgentIssueTabs { get; set; }
        public List<proc_Supplier_Tab> SupplierTabs { get; set; }
        public List<RoadFreightAgentModel> RoadFreightAgent { get; set; }
        public List<Users> Users { get; set; }
        public string SelectedDate { get; set; }
        public int ActiveTab { get; set; }
        public int SelectedUser { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string FilterDate { get; set; }
        public int LookUpCodeID { get; set; }
        public string FileDescription { get; set; }
        public int Active_Supplier_Tab { get; set; }
        public string DeleteDateRange { get; set; }
        public string ErrorMessage { get; set; }
    }

    public class RoadFreightAgentCount
    {
        public string TabName { get; set; }
        public int TabCount { get; set; }
    }

    public class RoadFreightAgentComplexModel
    {
        public RoadFreightAgent RoadFreightAgent { get; set; }
        public LookUpCodes Status { get; set; }
        public LookUpCodes Reason { get; set; }
        public Users Users { get; set; }
        public Waybills Waybills { get; set; }
        public RateAreas FromRateArea { get; set; }
        public RateAreas ToRateArea { get; set; }
        public List<proc_AgentIssues_Tab> AgentIssueTabs { get; set; }
        public string SelectedDate { get; set; }
        public int ActiveTab { get; set; }
        public int SelectedUser { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string FilterDate { get; set; }
        public int LookUpCodeID { get; set; }
        public string Comment { get; set; }
        public RoadFreightAgentCount RoadFreightAgentCount { get; set; }
    }

    public class RoadFreightAgentCategory
    {
        public int SupplierID { get; set; }
        public string SupplierName { get; set; }
        public string VendorID { get; set; }
        public string CategoryName { get; set; }
        public int WaybillCount { get; set; }
        public decimal Total { get; set; }
        public int Sequence { get; set; }
    }
}
