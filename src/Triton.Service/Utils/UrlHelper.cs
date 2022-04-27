using Microsoft.Extensions.Configuration;
using System;

namespace Triton.Service.Utils
{
    public static class UrlHelper
    {
        private static string GetUrl()
        {
#if (DEBUG)
            var config = new ConfigurationBuilder()
                .AddJsonFile("appsettings.Development.json")
                .Build();
#else
            var config =  new ConfigurationBuilder()
                .AddJsonFile("appsettings.json")
                .Build();
#endif
            return config.GetSection("WebApiUrl").GetSection("v1").Value;
        }

        public static class Api
        {
            public static Uri GateWay = new Uri(GetUrl());
            public static Uri TritonApi => new Uri($"{GetUrl()}triton-api/");
            public static Uri SalesApi => new Uri($"{GetUrl()}sales-api/");
            public static Uri TritonApiLegacy => new Uri($"{GetUrl()}triton-api-legacy/");
            public static Uri RatesApi => new Uri($"{GetUrl()}rates-api/");
            public static Uri ClaimsApi => new Uri($"{GetUrl()}claims-api/");
            public static Uri TritonSecurityCommonApi => new Uri($"{GetUrl()}tritonsecurity-api/");
            public static Uri CustomerApi => new Uri($"{GetUrl()}customer-api/");
            public static Uri RecruitmentApi => new Uri($"{GetUrl()}hrm-recruitment-api/");
            public static Uri FleetManagementApi => new Uri($"{GetUrl()}fleetmanagement-api/");
            public static Uri Freightware => new Uri($"{GetUrl()}freightware-api/");
            public static Uri WorkFlowApi => new Uri($"{GetUrl()}workflow-api/");
            public static Uri Waybill => new Uri($"{GetUrl()}waybill-api/");
            public static Uri PurchaseOrderApi => new Uri($"{GetUrl()}purchase-api/");
            public static Uri CrmApi => new Uri($"{GetUrl()}crm-api/");
        }
     
        public static class Controller
        {
            public const string Branch = "Branch/";
            public const string BusinessOnline = "BusinessOnline/";
            public const string Customer = "Customer/";
            public const string Customers = "Customers/";
            public const string Countrys = "Country/";
            public const string CountryCurrencySpots = "CountryCurrencySpots/";
            public const string Edocs = "eDocs/";
            public const string Employee = "Employee/";
            public const string Freightware = "Freightware/";
            public const string FreightwareUAT = "Freightware/UAT/";
            public const string FuelSurchargeClass = "FuelSurchargeClass/";
            public const string Questionnaire = "Questionnaire/";
            public const string Quotes = "Customer/Quotations/";
            public const string Rate = "Rate/";
            public const string RateDirection = "RateDirection/"; 
            public const string Roles = "Roles/";
            public const string TritonGroupCustom = "TritonGroupCustom/";
            public const string TritonGroupStoredProcs = "TritonGroupStoredProcs/";
            public const string TransportTypes = "TransportTypes/";
            public const string Waybills = "Waybills/";
            public const string WaybillTandT = "WaybillTrackandTraces/";
            public const string WaybillQuery = "WaybillQuery/";
            public const string WaybillQueryMaster = "WaybillQueryMaster/";
            public const string Users = "User/";
            public const string UserMap = "UserMap/";
            public const string UserRoles = "UserRoles/";
            public const string Collection = "Collection/";
            public const string Invoices = "Customer/Invoice/";
            public const string VwOpsWaybills = "vwOpsWaybills/";
            public const string Insurance = "Insurance/";
            public const string ReportManager = "ReportManager/";
            public const string CollectionRequests = "CollectionRequests/";
            public const string CollectionManifestLineItems = "CollectionManifestLineItems/";
            public const string CollectionRequestTrackAndTrace = "CollectionRequestTrackAndTrace/";
            public const string CollectionManifests = "CollectionManifests/";
            public const string InsuranceTypes = "InsuranceTypes/";
            public const string Statements = "Statements/";
            public const string PostalCode = "PostalCode/";
            public const string CustomerNotificationMap = "CustomerNotificationMap/";
            public const string CRMDashBoard = "CRMDashBoard/";
            public const string RepCodes = "RepCodes/";
            public const string CustomerAdministrationHistory = "CustomerAdministrationHistory/";
            public const string CustomerAdditionalContacts = "CustomerAdditionalContacts/";
            public const string LookUpcodes = "LookUpcodes";
            public const string LookUpCodeCategories = "LookUpCodeCategories/";
            public const string Leads = "Leads/";
            public const string Claims = "Claims/";
            public const string Departments = "Departments/";
            public const string Vehicle = "Vehicle/";
            public const string RateCycle = "RateCycles/";
            public const string RateIncrease = "RateIncreases/";
            public const string CustomerAnalysis = "CustomerAnalysis/";
            public const string WorkFlowStages = "WorkFlowStages/";
            public const string Bookings = "Bookings/";
            public const string WorkFlowManager = "WorkFlowManager/";
            public const string ScaleHour = "ScaleHour/";
            public const string TFMDashboard = "TFMDashboard/";
            public const string UploadDocument = "UploadDocument/";
            public const string IncreaseDocument = "IncreaseDocument/";
            public const string WorkflowTasks = "WorkflowTasks/";
            public const string FuelSurchargeClasss = "FuelSurchargeClasss/";
            public const string ICCATG = "ICCATG/";
            public const string ARCUS = "ARCUS/";
            public const string ICLOC = "ICLOC/";
            public const string RepTargets = "RepTargets/";
            public const string OESHDT = "OESHDT/";
            public const string UserRoleGroup = "UserRoleGroup/";
            public const string RoleGroup = "RoleGroup/";
            public const string UserBranch = "UserBranch/";
            public const string PostalCodes = "PostalCodes/";
            public const string RoadFreightAgent = "RoadFreightAgent/";
            public const string RoadFreightAgentHistory = "RoadFreightAgentHistory/";
            public const string AllAuthorizedPosts = "AllAuthorizedPosts/";
            public const string Dashboard = "Dashboard/";
            public const string Systems = "Systems/";
            public const string RatesIncreases = "RatesIncreases/";
            public const string RoadFreightStatement = "RoadFreightStatement/";
            public const string Waybill = "Waybill/";
            public const string Provider = "Provider/";
            public const string Course = "Course/";
            public const string EmployeeAdditionalInfo = "EmployeeAdditionalInfo/";
            public const string EmployeeCourseProviderMap = "EmployeeCourseProviderMap/";
            public const string OFOCode = "OFOCode/";
            public const string CustomerServiceAgent = "CustomerServiceAgent/";
            public const string tblMasterSuppliers = "tblMasterSuppliers/";
            public const string CSAAuditNote = "CSAAuditNote/";
            public const string CustomerReport = "CustomerReport/";
            public const string Recruitment = "Recruitment/";
            public const string OFOSpecialization = "OFOSpecialization/";
            public const string OFOJobProfile = "OFOJobProfile/";
            public const string RecruitmentAudit = "RecruitmentAudit/";
            public const string RecruitmentDocument = "RecruitmentDocument/";
        }

        /// <summary>
        /// Parameters that are passed to the WebApi
        /// </summary>
        public static class Parameters
        {
            // Parameters
            public const string CustomerId = "CustomerID";
            public const string DbName = "DBName";
            public const string UserId = "UserID";
            public const string waybillId = "waybillId";
        }
    }
}
