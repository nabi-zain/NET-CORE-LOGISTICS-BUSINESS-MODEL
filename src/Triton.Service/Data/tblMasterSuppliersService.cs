using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Triton.Model.Applications.Tables;
using Triton.Service.Utils;

namespace Triton.Service.Data
{
    public class tblMasterSuppliersService
    {
        public static async Task<List<tblMasterSuppliers>> GetAllAsync(string supplierName)
        {
            return await RestApiHelper.GetAsync<List<tblMasterSuppliers>>(new Uri(UrlHelper.Api.PurchaseOrderApi, $"{UrlHelper.Controller.tblMasterSuppliers}GetAllAsync?supplierName={supplierName}"));
        }

        public static async Task<tblMasterSuppliers> GetBySupplierNameAsync(string supplierName)
        {
            return await RestApiHelper.GetAsync<tblMasterSuppliers>(new Uri(UrlHelper.Api.PurchaseOrderApi, $"{UrlHelper.Controller.tblMasterSuppliers}GetBySupplierNameAsync?supplierName={supplierName}"));
        }

        public static async Task<tblMasterSuppliers> GetByIdAsync(int supplierId)
        {
            return await RestApiHelper.GetAsync<tblMasterSuppliers>(new Uri(UrlHelper.Api.PurchaseOrderApi, $"{UrlHelper.Controller.tblMasterSuppliers}GetByIdAsync?supplierId={supplierId}"));
        }
    }
}
