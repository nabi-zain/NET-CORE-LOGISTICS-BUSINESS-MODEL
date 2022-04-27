using Microsoft.Extensions.Configuration;

namespace Triton.Service.Tests
{
    public class TestHelper
    {
        private static IConfiguration GetConfig()
        {
            return new ConfigurationBuilder()
                .AddJsonFile("appsettings.json")
                .Build();
        }
    }
}
