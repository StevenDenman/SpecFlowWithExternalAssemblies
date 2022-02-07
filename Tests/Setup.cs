using AdCodicem.SpecFlow.MicrosoftDependencyInjection;
using ExternalSteps;
using Microsoft.Extensions.DependencyInjection;

namespace Tests
{
    public class Setup : IServicesConfigurator
    {
        public void ConfigureServices(IServiceCollection services)
        {
            var config = new ExternalConfig
            {
                Id = "From ConfigureServices"
            };

            services.AddSingleton(config);
        }
    }
}
