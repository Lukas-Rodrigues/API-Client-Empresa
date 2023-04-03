using CompanyCrudBlazor;
using CompanyCrudBlazor.Data;
using CompanyCrudBlazor.Services;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Conventions.Infrastructure;

namespace CompanyCrudBlazor
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("#app");
            builder.RootComponents.Add<HeadOutlet>("head::after");

            builder.Services.AddDbContext<AppDbContext>(options => options.UseInMemoryDatabase("CompanyDB"));
             
            builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
            builder.Services.AddScoped<ICompanyService, CompanyService>(); ;
            await builder.Build().RunAsync();
        }
    }
}