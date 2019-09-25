using DXBlazorDemo.Client.Services;
using DXBlazorDemo.Client.ViewModels;
using Microsoft.AspNetCore.Components.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace DXBlazorDemo.Client
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
			services.AddTransient<IFetchDataService, FetchDataService>();

			services.AddTransient<IFetchDataViewModel, FetchDataViewModel>();
			services.AddTransient<IFormViewModel, FormViewModel>();
        }

        public void Configure(IComponentsApplicationBuilder app)
        {
            app.AddComponent<App>("app");
        }
    }
}
