using AdCodicem.SpecFlow.MicrosoftDependencyInjection;
using Microsoft.Extensions.DependencyInjection;
using System.Linq;
using TechTalk.SpecFlow;

namespace Tests
{
    public class Setup : IServicesConfigurator
    {
        public void ConfigureServices(IServiceCollection services)
        {
            // Without this it fails
            //var specFlowTypes = System.AppDomain.CurrentDomain.GetAssemblies()
            //    .SelectMany(assembly => assembly.GetTypes())
            //    .Where(a => System.Attribute.IsDefined(a, typeof(BindingAttribute)));

            //foreach (var type in specFlowTypes)
            //{
            //    services.AddScoped(type!);
            //}
        }
    }
}
