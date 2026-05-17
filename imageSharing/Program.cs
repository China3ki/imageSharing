using imageSharing.Client.Services;
using imageSharing.Components;
using imageSharing.Entities;
using imageSharing.Services;
using imageSharing.Shared.Services;
using Majorsoft.Blazor.Extensions.BrowserStorage;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;


namespace imageSharing
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddRazorComponents()
                .AddInteractiveServerComponents()
                .AddInteractiveWebAssemblyComponents();

            // Services
            builder.Services.AddScoped<ThemeService>();
            builder.Services.AddBrowserStorage();
            builder.Services.AddScoped<SearchService>();
            builder.Services.AddScoped<HttpClient>();
            builder.Services.AddScoped<IPasswordHasher<User>, PasswordHasher<User>>();
            builder.Services.AddScoped<AccountService>();

            builder.Services.AddDbContext<ImagesharingContext>(b => b.UseNpgsql(builder.Configuration["ConnectionString"]));

            builder.Services.AddScoped<ImagesharingContext>();

            builder.Services.AddControllers();
            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseWebAssemblyDebugging();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseStatusCodePagesWithReExecute("/not-found", createScopeForStatusCodePages: true);
            app.UseHttpsRedirection();
            app.MapControllers();
            app.UseAntiforgery();

            app.MapStaticAssets();
            app.MapRazorComponents<App>()
                .AddInteractiveServerRenderMode()
                .AddInteractiveWebAssemblyRenderMode()
                .AddAdditionalAssemblies(typeof(Client._Imports).Assembly);

            app.Run();
        }
    }
}
