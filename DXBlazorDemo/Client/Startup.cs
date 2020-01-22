using DXBlazorDemo.Client.Services;
using DXBlazorDemo.Shared;
using DXBlazorDemo.Shared.ViewModels;
using Microsoft.AspNetCore.Components.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace DXBlazorDemo.Client
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDevExpressBlazor();
            services.AddSingleton<IFetchDataService, FetchDataService>();

            services.AddTransient<ICounterViewModel, CounterViewModel>();
            services.AddTransient<IFetchDataViewModel, FetchDataViewModel>();
			services.AddTransient<IFormViewModel, FormViewModel>();
        }

        public void Configure(IComponentsApplicationBuilder app)
        {
            app.AddComponent<App>("app");
        }
    }
}
