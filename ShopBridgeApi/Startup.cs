using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using ShopBridge.Models.Models;
using ShopBridge.Repository;
using ShopBridge.Services;

namespace ShopBridgeApi
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.Configure<MyAppSettings>(Configuration.GetSection(MyAppSettings.SectionName));
            services.AddControllers();
            //Add Swagger relates setting  
            services.AddSwaggerGen(options =>
            {
                options.SwaggerDoc("v1", new Microsoft.OpenApi.Models.OpenApiInfo
                {
                    Title = "Shop Bridge application Service API",
                    Version = "v1",
                    Description = "Shop Bridge application Service API",
                });
            });
            services.AddSingleton<IInventoryService, InventoryService>();
            services.AddSingleton<IInventoryRepository, InventoryRepository>();
            services.AddOptions();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });

            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "Shop Bridge Application Service API");
            });
        }
    }
}
