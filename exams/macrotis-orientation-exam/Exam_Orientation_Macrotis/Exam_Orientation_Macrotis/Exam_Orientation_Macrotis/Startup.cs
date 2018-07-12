using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Exam_Orientation_Macrotis.Models;
using Exam_Orientation_Macrotis.Services;
using MacrotisExamApp.Repositories;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Exam_Orientation_Macrotis
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
            string connectString = @"Data Source = (localdb)\MSSQLLocalDB; Initial Catalog = MacrotisOrientationExam; Integrated Security = True;";
            services.AddDbContext<AttractionContext>(options =>
                options.UseSqlServer(connectString));
            services.AddTransient<AttractionContext>();
            services.AddTransient<AttractionRepository>();
            services.AddTransient<FilterService>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseBrowserLink();
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }

            app.UseStaticFiles();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
