using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Triton.Model.Applications.Tables;
using Triton.Model.LeaveManagement.Tables;
using Triton.Model.TritonGroup.Tables;
using Triton.Model.TritonLH.StoredProcs;
using Triton.Model.TritonLH.Tables;
using Triton.Model.TritonLH.Views;
using Triton.Model.TritonVehicles.Tables;
using Triton.Model.TritonVehicles.Views;

namespace Triton.Model.TritonLH.Custom
{
    public class DeliveriesCreateModels
    {
        #region Properties

        public List<Triton.Model.TritonLH.Tables.Customers> Customers { get; set; }

        public List<Employees> Employees { get; set; }
        public List<TritonGroup.Tables.LookUpCodes> TripTypeLCID { get; set; }
        public VehicleRegMaps VehicleRegMaps { get; set; }
        public List<TritonGroup.Tables.LookUpCodes> TarrifType { get; set; }
        public List<TritonGroup.Tables.LookUpCodes> TripDeliveryTypes { get; set; }
        public List<TritonGroup.Tables.LookUpCodes> LineHaulTrailerType { get; set; }

        #endregion Properties
    }

    public class CustomerExternalCreateModels
    {
        #region Properties
        public Triton.Model.TritonLH.Tables.Customers Customers { get; set; }
        public List<CustomerAdditionalContacts> CustomerAdditionalContacts { get; set; }
        public List<TritonGroup.Tables.LookUpCodes> TripTypeLCID { get; set; }
        //public VehicleRegMaps VehicleRegMaps { get; set; }
        public LookUpCodes TarrifType { get; set; }
        public List<Sites> Sites { get; set; }

        #endregion Properties
    }

    public class DeliveriesManageVehiclesModel
    {
        #region Properties

        public List<DeliveriesModels> Deliveries { get; set; }
        public List<DeliveriesScheduledDateVehicleCount> ScheduledDateVehicles { get; set; }

        #endregion Properties
    }

    public class DeliveriesModels
    {
        #region Properties

        public CurrentVehicles CurrentVehicles { get; set; }

        public List<Tables.Customers> ListCustomers { get; set; }
        public Tables.Customers Customers { get; set; }
        public Deliveries Deliveries { get; set; }
        public Uploader EmployeeImages { get; set; }
        public Employees Employees { get; set; }
        public Sites FromSite { get; set; }

        public SubContractorRequests SubContractorRequests { get; set; }
        public Sites ToSite { get; set; }

        public TritonGroup.Tables.Users Users { get; set; }

        //public BaseVehicleImages VehicleImages { get; set; }
        public VehicleImages VehicleImages { get; set; }

        public VehicleRegMaps VehicleRegMaps { get; set; }
        public Vehicles Vehicles { get; set; }

        public string CurrentTab { get; set; }

        public DeliveriesSchedules DeliveriesSchedules { get; set; }
        public TripDelivery TripDelivery { get; set; }
        public Invoices Invoices { get; set; }
        public List<vw_Deliveries> RecentDeliveries { get; set; }
        public List<vw_Deliveries> DeliveriesResult { get; set; }
        public bool DelResult { get; set; }
        public List<LookUpCodes> Lookupcodes { get; set; }
        public List<LookUpCodes> ListLookUpCodes{ get; set; }
        public LookUpCodeCategorySystemMaps LookUpCodeCategorySystemMaps { get; set; }
       



        #endregion Properties
    }
    
    public class DeliveriesScheduledDateVehicleCount
    {
        #region Properties

        public DateTime ScheduledDate { get; set; }

        public int VehicleCount { get; set; }

        public int VehicleTotal { get; set; }

        #endregion Properties
    }

    public class DeliveriesWithDeliveriesSubContractors
    {
        #region Properties

        public Deliveries Deliveries { get; set; }
        public SubContractorRequests SubContractorRequests { get; set; }
        public DeliveriesSchedules DeliveriesSchedules { get; set; }
        public DeliveriesPallets DeliveriesPallets { get; set; }
        public DeliveriesVehicles DeliveriesVehicles { get; set; }
        public Invoices Invoices { get; set; }
        public DeliverySite DeliverySite { get; set; }

        public List<DocumentRepositories> DocumentRepositories { get; set; }

        #endregion Properties
    }

    public class DeliveriesWithWorkFlowManager
    {
        #region Properties

        //public Deliveries Deliveries { get; set; }
        //public Triton.Model.TritonLH.Tables.Customers Customers { get; set; }
        //public TritonGroup.Tables.Users Users { get; set; }
        //public Sites FromSite { get; set; }
        //public Sites ToSite { get; set; }
        public vw_Deliveries Deliveries { get; set; }
        public TritonGroup.Tables.WorkFlowManager WorkFlowManager { get; set; }
        public SubContractorRequests SubContractorRequests { get; set; }
        public tblMasterSuppliers tblMasterSuppliers { get; set; }

        public List<WorkflowTasks> WorkflowTasks { get; set; }

        public DeliveriesSubContractors DeliveriesSubContractors { get; set; }

        public List<WorkFlowStages> WorkFlowStages { get; set; }

        public DeliveriesVehicles DeliveriesVehicles { get; set; }

        #endregion Properties
    }

    public class DeliverySales
    {
        #region Properties

        [DataType(DataType.Currency)]
        public Decimal Total { get; set; }

        public String MonthYear { get; set; }
        public int CustomerID { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public bool? CustomerExternal  { get; set; }

        #endregion
    }

    public class DeliverySalesGraph
    {
        #region Properties
        public String MonthYear { get; set; }
        public Decimal Total { get; set; }
        #endregion
    }

    public class DeliveriesComplexModel
    {
        #region Properties

        public Deliveries Deliveries { get; set; }
        public DeliveriesPallets DeliveriesPallets { get; set; }
        public DeliveriesSchedules DeliveriesSchedules { get; set; }
        public Invoices Invoices { get; set; }
        public DeliveriesNotes DeliveriesNotes { get; set; }
        public DeliveriesLegs DeliveriesLegs { get; set; }
        public TripDelivery TripDelivery { get; set; }
        public DeliveriesVehicles DeliveriesVehicles { get; set; }

        public TritonGroup.Tables.LookUpCodes FinancialStatus { get; set; }

        #endregion Properties
    }

    public class DeliveriesDashboard
    {
        public List<proc_DeliveriesVehicles_VehicleMonthlySummary_Select> VehicleSummary { get; set; }
        public List<proc_Deliveries_Debriefing_Summary> TritonDebriefing { get; set; }
        public List<proc_Deliveries_Debriefing_Summary> SubbyDebriefing { get; set; }
        public List<proc_Deliveries_TotalExVAT_Revenue_Select> Revenue { get; set; }
        public List<proc_Deliveries_Not_Assigned> DeliveriesNotAssigned { get; set; }
    }


    public class DeliveriesSalesSiteMonthDashboard
    {
        public String SiteCustomerName { get; set; }
        public int FromSiteID { get; set; }
        public decimal TotalExVAT { get; set; }

    }



    public class DeliveriesDebriefingModel
    { 
        public Deliveries Deliveries { get; set; }        
        public DeliveriesSchedules DeliveriesSchedules { get; set; }
        public DeliveriesVehicles DeliveriesVehicles { get; set; }       
    }

}