using Athlos.Application.Commands;
using Athlos.Application.Data;
using Kledex.Bus.ServiceBus.Extensions;
using Kledex.Extensions;
using Kledex.Store.EF.Extensions;
using Kledex.Store.EF.SqlServer;
using Kledex.UI.Extensions;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;

namespace Athlos
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
            services
                .AddKledex(typeof(CreateTrainingPlan))
                .AddSqlServerProvider(Configuration)
                .AddServiceBusProvider(Configuration);

            services.AddDbContext<AthlosDbContext>(options => options.UseSqlServer(Configuration.GetConnectionString("ReadModel")));

            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_3_0);
            
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo() { Title = "Athos API", Version = "v1" });
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, AthlosDbContext dbContext)
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
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "Athos API V1");
            });

            app.UseKledex().EnsureDomainDbCreated();

            dbContext.Database.EnsureCreated();
        }
    }
}
