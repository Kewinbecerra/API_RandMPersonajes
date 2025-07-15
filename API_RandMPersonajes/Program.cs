using API_RandMPersonajes;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

var urlLocal = "https://localhost:7137";
builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(urlLocal) });
await builder.Build().RunAsync();
