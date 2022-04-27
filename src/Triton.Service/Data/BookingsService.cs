using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Triton.Model.LeaveManagement.Tables;
using Triton.Service.Model.TritonFleetManagement.Custom;
using Triton.Service.Model.TritonFleetManagement.StoredProcs;
using Triton.Service.Model.TritonFleetManagement.Tables;
using Triton.Service.Utils;

namespace Triton.Service.Data
{
    public class BookingsService
    {
        public static async Task<List<BookingsModel>> GetAllBookingsAsync()
        {
            return await RestApiHelper.GetAsync<List<BookingsModel>>(new Uri(UrlHelper.Api.FleetManagementApi, $"Bookings/Bookings"));
        }

        public static async Task<BookingsModel> GetBookingsByIdAsync(int bookingsID)
        {
            return await RestApiHelper.GetAsync<BookingsModel>(new Uri(UrlHelper.Api.FleetManagementApi, $"Bookings/Bookings{bookingsID}"));
        }

        public static async Task<BookingsModel> LookUpCodesAsync(int customerID)
        {
            return await RestApiHelper.GetAsync<BookingsModel>(new Uri(UrlHelper.Api.FleetManagementApi, $"Bookings/Bookings/LookUpCodes?customerID={customerID}"));
        }

        public static async Task<bool> InsertAsync(BookingsModel bookingsModel)
        {
            return await RestApiHelper.InsertAsync(new Uri(UrlHelper.Api.FleetManagementApi, $"Bookings/Bookings"), bookingsModel);
        }


        public static async Task<bool> UpdateAsync(BookingsModel bookingsModel)
        {
            return await RestApiHelper.PutAsync(new Uri(UrlHelper.Api.FleetManagementApi, $"Bookings/Bookings"), bookingsModel);
        }


        public static async Task<bool> DeleteAsync(Bookings bookings)
        {
            return await RestApiHelper.PutAsync(new Uri(UrlHelper.Api.FleetManagementApi, $"Bookings/Bookings/Delete"), bookings);
        }

        public static async Task<List<proc_VendorCodes_String_Agg>> GetVendorCodesPerCustomer()
        {
            return await RestApiHelper.GetAsync<List<proc_VendorCodes_String_Agg>>(new Uri(UrlHelper.Api.FleetManagementApi, $"Bookings/VendorCodesPerCustomer"));
        }

        public static async Task<List<CustomersModels>> GetAllCustomersAsync()
        {
            return await RestApiHelper.GetAsync<List<CustomersModels>>(new Uri(UrlHelper.Api.FleetManagementApi, $"Bookings/GetAllCustomersAsync"));
        }

        public static async Task<List<Employees>> GetAllMechanics()
        {
            return await RestApiHelper.GetAsync<List<Employees>>(new Uri(UrlHelper.Api.FleetManagementApi, $"Bookings/GetAllMechanics"));
        }

        public static async Task<List<proc_Bookings_BookingReasons_Customers_Select>> GetBookingsPerCustomer(int CustomerID, string startDate, string endDate)
        {
            return await RestApiHelper.GetAsync<List<proc_Bookings_BookingReasons_Customers_Select>>(new Uri(UrlHelper.Api.FleetManagementApi, $"Bookings/GetBookingsPerCustomer/{CustomerID}/{startDate}/{endDate}"));
        }

        public static async Task<proc_Bookings_BookingReasons_Customers_Select> GetBookingReasonsPerJobCard(int bookingsID)
        {
            return await RestApiHelper.GetAsync<proc_Bookings_BookingReasons_Customers_Select>(new Uri(UrlHelper.Api.FleetManagementApi, $"Bookings/GetBookingReasonsPerJobCard/{bookingsID}"));
        }

        public static async Task<proc_BookingDetails_GetByID> GetBookingDetailsByID(int BookingsID)
        {
            return await RestApiHelper.GetAsync<proc_BookingDetails_GetByID>(new Uri(UrlHelper.Api.FleetManagementApi, $"Bookings/GetBookingDetailsByID/{BookingsID}"));
        }

        public static async Task<proc_BookingDetails_GetByID> GetBookingDetailsByCustomerID(int CustomerID)
        {
            return await RestApiHelper.GetAsync<proc_BookingDetails_GetByID>(new Uri(UrlHelper.Api.FleetManagementApi, $"Bookings/GetBookingDetailsByCustomerID/{CustomerID}"));
        }

        public static async Task<bool> DeleteBooking(proc_BookingDetails_GetByID model)
        {
            return await RestApiHelper.PutAsync(new Uri(UrlHelper.Api.FleetManagementApi, $"{UrlHelper.Controller.Bookings}DeleteBooking/Update"), model);
        }

        public static async Task<proc_BookingDetails_GetByID> CheckIfBookingExist(int CustomerID, int VehicleID, string EstimatedArrivalDate)
        {
            return await RestApiHelper.GetAsync<proc_BookingDetails_GetByID>(new Uri(UrlHelper.Api.FleetManagementApi, $"Bookings/CheckIfBookingExist/{CustomerID}/{VehicleID}/{EstimatedArrivalDate}"));
        }

        public static async Task<bool> InsertDocument(DocumentRepository documentRepository,int BookingsId)
        {
            return await RestApiHelper.InsertAsync(new Uri(UrlHelper.Api.FleetManagementApi , $"Bookings/Bookings/InsertDocumentRepositoryAsync?bookingId={BookingsId}"), documentRepository);
        }

        public static async Task<List<DocumentVehicleModel>> ViewDocumentAsync(int bookingId)
        {
            return await RestApiHelper.GetAsync<List<DocumentVehicleModel>>(new Uri(UrlHelper.Api.FleetManagementApi,$"Bookings/Bookings/GetAllDocuments?bookingId={bookingId}"));
        }

        public static async Task<bool> DeleteDocumentAsync(DocumentVehicleModel documentVehicleModel)
        {
            //return true;
            return await RestApiHelper.PutAsync(new Uri(UrlHelper.Api.FleetManagementApi, $"Bookings/Bookings/DeleteDocument"), documentVehicleModel);
        }

        public static async Task<List<BookingAuditModel>> GetBookingAuditAsync(int BookingID)
        {
            return await RestApiHelper.GetAsync<List<BookingAuditModel>>(new Uri(UrlHelper.Api.FleetManagementApi, $"{UrlHelper.Controller.Bookings}BookingAudit/{BookingID}"));
        }

        public static async Task<bool> InsertPartReasons(BookingsModel model)
        {
            return await RestApiHelper.InsertAsync(new Uri(UrlHelper.Api.FleetManagementApi, $"{UrlHelper.Controller.Bookings}InsertPartReasons/Insert"), model);
        }

        public static async Task<bool> InsertPartsBookingReasonAndOutworksCommissionAsync(BookingsModel bookingsModel)
        {
            return await RestApiHelper.InsertAsync(new Uri(UrlHelper.Api.FleetManagementApi, $"Bookings/InsertPartsBookingReasonAndOutworksCommissionAsync"), bookingsModel);
        }

        public static async Task<bool> UpdatePartsBookingReasonAndOutworksCommissionAsync(BookingsModel bookingsModel)
        {
            return await RestApiHelper.PutAsync(new Uri(UrlHelper.Api.FleetManagementApi, $"Bookings/UpdatePartsBookingReasonAndOutworksCommissionAsync"), bookingsModel);
        }

        public static async Task<PartReasonViewModel> GetInventoryByBookingID(int BookingsID)
        {
            return await RestApiHelper.GetAsync<PartReasonViewModel>(new Uri(UrlHelper.Api.FleetManagementApi, $"Bookings/GetInventoryByBookingID/{BookingsID}"));
        }
    }
}
