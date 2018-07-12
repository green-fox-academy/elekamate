using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Exam_Orientation_Old.Models;
using Exam_Orientation_Old.Repositories;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Exam_Orientation_Old
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
            services.AddMvc();
            string connectionStringToDoDB = @"Data Source = (localdb)\MSSQLLocalDB; Initial Catalog = Exam_Orientation_Old; Integrated Security = True;";
            services.AddDbContext<SpaceContext>(options =>
                options.UseSqlServer(connectionStringToDoDB));
            services.AddTransient<SpaceContext>();
            services.AddTransient<PlanetRepository>();
            services.AddTransient<SpaceShipRepository>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            app.UseStaticFiles();
            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });
            if (env.IsDevelopment())
            {
                app.UseBrowserLink();
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }
        }
    }
}
