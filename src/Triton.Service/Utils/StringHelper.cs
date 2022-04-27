namespace Triton.Service.Utils
{
    public static class StringHelper
    {

        /// <summary>
        /// Html helpers
        /// </summary>
        public static class Html
        {
            //HTML
            public const string Danger = "danger";
            public const string Dark = "dark";
            public const string Info = "info";
            public const string Light = "light";
            public const string Primary = "primary";
            public const string Secondary = "secondary";
            public const string Success = "success";
            public const string Warning = "warning";
            public const string FailedIcon = "fad fa-times-circle text-danger";
            public const string SuccessIcon = "fad fa-check-circle text-success";
            public const string UpdateRecordSuccessMessage = "The record was successfully updated";
            public const string DeleteRecordSuccessMessage = "The record was successfully deleted";
            public const string SaveRecordSuccessMessage = "The record was successfully saved";
            public const string UpdateRecordFailedMessage = "The record failed to update";
            public const string UpdateRecordSuccessTitle = "Update successful";
            public const string UpdateRecordFailedTitle = "Update failed";
            public const string SaveRecordSuccessTitle = "Save successful";
            public const string DeleteRecordSuccessTitle = "Delete successful";
            public const string UserNameErrorMessage = "Username already exists";
            public const string EmailAddressErrorMessage = "Email address already exists";
            public const string VehicleRegExistMessage = "Vehicle registration already exist";
        }

        /// <summary>
        /// Global helpers
        /// </summary>
        public static class Globals
        {
            public const string OldApiDeprecated = "oldApi_deprecated";
        }

        /// <summary>
        /// Freight helpers
        /// </summary>
        public static class Freightware
        {
            public const string FreightWare = "Freightware";
            public const string InUserid = "InUserid";
            public const string InPassword = "InPassword";
            public const string InRequestCtr = "InRequestCtr";
        }


        /// <summary>
        /// Http helpers
        /// </summary>
        public static class Http
        {
            public const string Get = "Get";
            public const string Post = "Post";
            public const string Put = "Put";
        }

        /// <summary>
        /// WebApi helpers
        /// </summary>
        public static class WebApi
        {
            public const string WebApiUrl = "WebApiUrl";
            public const string V1 = "v1";
            public const string V2 = "v2";
        }

        /// <summary>
        /// Type helpers
        /// </summary>
        public static class Types
        {
            public const string NoRecords = "No Records";
            public const string UpdateSuccess = "Update Success";
            public const string UpdateFailed = "Update Failed";
            public const string SaveSuccess = "Saved Successfully";
            public const string SaveFailed = "Save Failed";
            public const string DeleteSuccess = "Deleted Successfully";
            public const string DeleteFailed = "Delete Failed";
            public const string EmailSuccess = "Email sent successfully";
        }

        /// <summary>
        /// All Databases found in SQL Server
        /// </summary>
        public static class Database
        {
            public const string Applications = "Applications";
            public const string Crm = "CRM";
            public const string CrmScs = "CRMSCS";
            public const string Incidents = "Incidents";
            public const string LeaveManagement = "LeaveManagement";
            public const string MtnSms = "MTNSMS";
            public const string NoCommerce = "NoCommerce";
            public const string Notifications = "Notifications";
            public const string TritonBlobs = "TritonBlobs";
            public const string TritonDiscrepancyClaims = "TritonDiscrepancyClaims";
            public const string TritonDriveCam = "TritonDrivecam";
            public const string TritonExpress = "TritonExpress";
            public const string TritonFuel = "TritonFuel";
            public const string TritonGroup = "TritonGroup";
            public const string TritonInternalOrders = "TritonInternalOrders";
            public const string TritonLh = "TritonLH";
            public const string TritonOps = "TritonOps";
            public const string TritonSecurity = "TritonSecurity";
            public const string TritonStaging = "TritonStaging";
            public const string TritonVehicles = "TritonVehicles";
        }

        /// <summary>
        /// References to the controllers on the WebApi
        /// </summary>
        public static class Controllers
        {
            // Controller
            public const string Branch = "Branch";
            public const string BusinessOnline = "BusinessOnline";
            public const string Customer = "Customer";
            public const string Countrys = "Country";
            public const string CountryCurrencySpots = "CountryCurrencySpots";
            public const string Edocs = "eDocs";
            public const string Employee = "Employee";
            public const string Freightware = "Freightware";
            public const string FreightwareUAT = "Freightware/UAT";
            public const string FuelSurchargeClass = "FuelSurchargeClass";
            public const string Questionnaire = "Questionnaire";
            public const string Quotes = "Customer/Quotations";
            public const string Roles = "Roles";
            public const string TritonGroupCustom = "TritonGroupCustom";
            public const string TritonGroupStoredProcs = "TritonGroupStoredProcs";
            public const string TransportTypes = "TransportTypes";
            public const string Waybills = "Waybills";
            public const string WaybillTandT = "WaybillTrackandTraces";
            public const string WaybillQuery = "WaybillQuery";
            public const string WaybillQueryMaster = "WaybillQueryMaster";
            public const string Users = "User";
            public const string UserMap = "UserMap";
            public const string UserRoles = "UserRoles";
            public const string Collection = "Collection";
            public const string Invoices = "Customer/Invoice";
            public const string VwOpsWaybills = "vwOpsWaybills";
            public const string Insurance = "Insurance";
            public const string ReportManager = "ReportManager";            
        }
    }
}
