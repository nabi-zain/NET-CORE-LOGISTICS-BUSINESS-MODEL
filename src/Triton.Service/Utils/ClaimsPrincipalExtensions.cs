using System.Security.Claims;

namespace Triton.Service.Utils
{
    public static class ClaimsPrincipalExtensions
    {
        public static string GetUserEmail(this ClaimsPrincipal principal)
        {
            return principal.FindFirst("Email").Value;
        }

        public static int GetUserId(this ClaimsPrincipal principal)
        {
            return int.Parse(principal.FindFirst("UserID").Value);
        }

        public static string GetUserName(this ClaimsPrincipal principal)
        {
            return principal.FindFirstValue(ClaimTypes.Name);
        }

        public static string GetCustomerIds(this ClaimsPrincipal principal)
        {
            return principal.FindFirst("CustomerID").Value;
        }

        public static string GetBranchId(this ClaimsPrincipal principal)
        {
            return principal.FindFirst("BranchID").Value;
        }

        public static string GetCostCentreId(this ClaimsPrincipal principal)
        {
            return principal.FindFirst("CostCentreID").Value;
        }

        public static string GetRoleIds(this ClaimsPrincipal principal)
        {
            return principal.FindFirst("Roles").Value;
        }

        public static string GetRoleNames(this ClaimsPrincipal principal)
        {
            return principal.FindFirst("RoleClaimType").Value;
        }
    }
}
