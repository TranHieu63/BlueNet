using Blazored.LocalStorage;
using Blazored.Toast;
using BlueNet.Manager.Services;
using BlueNet.Services;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
 


namespace BlueNet.Manager
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("#app");
            builder.Services.AddScoped<IAuthService, AuthService>();

            //AddTransient
            builder.Services.AddTransient<IBlackListApiClient, BlackListApiClient>();
            builder.Services.AddTransient<IUserApiClient, UserApiClient>();
            builder.Services.AddTransient<IViolationApiClient, ViolationApiClient>();

            //AddBlazoredToast
            builder.Services.AddBlazoredToast();

            //AddBlazoredLocalStorage
            builder.Services.AddBlazoredLocalStorage();

            builder.Services.AddAuthorizationCore();

            builder.Services.AddScoped<AuthenticationStateProvider, ApiAuthenticationStateProvider>();

            builder.Services.AddScoped<IAuthService, AuthService>();

            builder.Services.AddScoped(sp => new HttpClient
            {
                BaseAddress = new Uri(builder.Configuration["BackendApiUrl"])
            });

            //builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("https://localhost:5001") });

            await builder.Build().RunAsync();
        }
    }
}
