//using Microsoft.Extensions.DependencyInjection;
//using Triton.Interface.BusinessOnline;
//using Triton.Interface.Collection;
//using Triton.Interface.CRM;
//using Triton.Interface.Documents;
//using Triton.Interface.Freightware;
//using Triton.Interface.HR;
//using Triton.Interface.TritonGroup;
//using Triton.Interface.TritonSecurity;
//using Triton.Interface.Waybill;
//using Triton.Service.Branch;
//using Triton.Service.BusinessOnline;
//using Triton.Service.Collection;
//using Triton.Service.CRM;
//using Triton.Service.Documents;
//using Triton.Service.Freightware;
//using Triton.Service.HR;
//using Triton.Service.TritonGroup;
//using Triton.Service.TritonSecurity;
//using Triton.Service.Waybill;

//namespace Triton.Service
//{
//    public class StartupService
//    {
//        /// <summary>
//        /// Service for the websites
//        /// </summary>
//        /// <param name="services"></param>
//        public static void AddService(IServiceCollection services)
//        {
//            // A

//            // B
//            services.AddScoped<IBranches, BranchServices>();
//            services.AddScoped<IBusinessOnline, BusinessOnlineServices>();

//            // C
//            services.AddScoped<ICustomers, CustomerService>();
//            services.AddScoped<ICollection, CollectionService>();
//            services.AddScoped<ICollectionRequest, CollectionService>();
//            services.AddScoped<ICountryCurrencySpots, CountryService>();

//            // D
//            services.AddScoped<IDocuments, DocumentService>();

//            // E
//            services.AddScoped<IEmployee, EmployeeService>();

//            // F
//            services.AddScoped<IFreightware, FreightwareService>();
//            services.AddScoped<IFuelSurchargeClass, FuelSurchargeClassService>();

//            // G

//            // H

//            // I
//            services.AddScoped<IInvoices, InvoiceServices>();
//            services.AddScoped<IInsuranceTypes, InsuranceTypeServices>();
//            // J

//            // K

//            // L

//            // M

//            // N

//            // O

//            // P
//            services.AddScoped<IPostalCodes, PostalCodeService>();

//            // Q
//            services.AddScoped<IQuotes, QuoteService>();
//            services.AddScoped<IQuotesAPI, QuoteService>();
//            services.AddScoped<IQuestionnaire, QuestionnaireService>();

//            // R
//            services.AddScoped<IReportManager, ReportManagerService>();
//            services.AddScoped<IRole, RoleService>();

//            // S
//            services.AddScoped<IStatements,StatementService>();

//            // T
//            services.AddScoped<ITransportTypes, LookupService>();

//            // U
//            services.AddScoped<IUserCustomerMap, UserCustomerMapService>();
//            services.AddScoped<IUserMap, UserMapService>();
//            services.AddScoped<IUser, UserService>();

//            // V

//            // W
//            services.AddScoped<IWaybill, WaybillService>();
//            services.AddScoped<IWaybillAPI, WaybillService>();
//            services.AddScoped<IWaybillTrackandTrace, WaybillTrackandTraceService>();
//            services.AddScoped<IWaybillQueryMaster, WaybillQueryMasterService>();

//            // X

//            // Y

//            // Z
//            services.AddScoped<ICollectionRequestTrackAndTraces, CollectionService>();
//        }
//    }
//}
