using Imi.Project.Blazor.Models.Base;
using Imi.Project.Blazor.Models.Games.Base;
using Imi.Project.Blazor.Services.Interfaces;
using Imi.Project.Blazor.Services.Mocking;
using Imi.Project.Blazor.Services.OpenNotify;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Syncfusion.Blazor;
using System;

namespace Imi.Project.Blazor
{
    public class Startup
    {
        #region Constructors

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        #endregion Constructors

        #region Properties

        public IConfiguration Configuration { get; }

        #endregion Properties

        #region Methods

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense(Configuration.GetValue<string>("SyncfusionKey"));
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production
                // scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapBlazorHub();
                endpoints.MapFallbackToPage("/_Host");
            });
        }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddRazorPages();
            services.AddServerSideBlazor();
            services.AddScoped<ICrudService<BaseSpaceItem<Guid>>, SpaceItemService>();
            services.AddScoped<IGameService<PlanetoidsDebrisCraftsBase<Guid>>, GameService>();
            services.AddScoped<IZayraLocationService, IssLocationService>();
            services.AddSyncfusionBlazor();
        }

        #endregion Methods
    }
}