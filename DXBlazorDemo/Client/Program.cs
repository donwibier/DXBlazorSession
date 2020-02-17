using DXBlazorDemo.Client.Services;
using DXBlazorDemo.Shared;
using DXBlazorDemo.Shared.ViewModels;
using Microsoft.AspNetCore.Blazor.Hosting;
using Microsoft.Extensions.DependencyInjection;
using System.Threading.Tasks;

namespace DXBlazorDemo.Client
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("app");
            builder.Services.AddDevExpressBlazor();

            builder.Services.AddSingleton<IFetchDataService, FetchDataService>();
            builder.Services.AddSingleton<IFormService, FormService>();

            builder.Services.AddTransient<ICounterViewModel, CounterViewModel>();
            builder.Services.AddTransient<IFetchDataViewModel, FetchDataViewModel>();
            builder.Services.AddTransient<IFormViewModel, FormViewModel>();

            await builder.Build().RunAsync();
        }
    }
}
