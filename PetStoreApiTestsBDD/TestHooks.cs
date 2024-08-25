using Microsoft.Extensions.Configuration;
using System.IO;
using TechTalk.SpecFlow;

namespace PetStoreApiTests.Hooks
{
    [Binding]
    public class TestHooks
    {
        public static IConfiguration Configuration { get; private set; }

        [BeforeTestRun]
        public static void InitializeConfiguration()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);
            
            Configuration = builder.Build();
        }
    }
}
