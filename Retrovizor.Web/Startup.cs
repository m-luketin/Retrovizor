using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SpaServices.ReactDevelopmentServer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Serialization;
using Retrovizor.Data.Entities;
using Retrovizor.Domain.Repositories.Implementations;
using Retrovizor.Domain.Repositories.Interfaces;

namespace Retrovizor
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
            services.AddDbContext<RetrovizorContext>(options => 
                options.UseSqlServer(Configuration.GetConnectionString("RetrovizorContext")));

            services.AddScoped<IAdminRepository, AdminRepository>();
            services.AddScoped<IClassRepository, ClassRepository>();
            services.AddScoped<IDrivingSchoolRepository, DrivingSchoolRepository>();
            services.AddScoped<IEventRepository, EventRepository>();
            services.AddScoped<IExamRepository, ExamRepository>();
            services.AddScoped<IInstructorRepository, InstructorRepository>();
            services.AddScoped<ILocationRepository, LocationRepository>();
            services.AddScoped<IReviewRepository, ReviewRepository>();
            services.AddScoped<IStudentClassRepository, StudentClassRepository>();
            services.AddScoped<IStudentEventRepository, StudentEventRepository>();
            services.AddScoped<IStudentExamRepository, StudentExamRepository>();
            services.AddScoped<IStudentRepository, StudentRepository>();
            services.AddScoped<IVehicleRepository, VehicleRepository>();
            services.AddScoped<IVehicleSessionRepository, VehicleSessionRepository>();


            services.AddMvc().AddJsonOptions(options =>
            {
                options.SerializerSettings.ContractResolver = new CamelCasePropertyNamesContractResolver();
                options.SerializerSettings.Converters.Add(new StringEnumConverter());
            }).SetCompatibilityVersion(CompatibilityVersion.Version_2_2);

            // In production, the React files will be served from this directory
            services.AddSpaStaticFiles(configuration =>
            {
                configuration.RootPath = "ClientApp/build";
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if(env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseSpaStaticFiles();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller}/{action=Index}/{id?}");
            });

            app.UseSpa(spa =>
            {
                spa.Options.SourcePath = "ClientApp";

                if(env.IsDevelopment())
                {
                    spa.UseReactDevelopmentServer(npmScript: "start");
                }
            });
        }
    }
}
