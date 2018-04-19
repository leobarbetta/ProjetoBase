using AutoMapper;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Newtonsoft.Json.Serialization;
using ProjetoBase.Persistence.Entity.Context;
using ProjetoBase.Repository.Entities;
using ProjetoBase.Repository.Interfaces;
using ProjetoBase.Service.Entities;
using ProjetoBase.Service.Interfaces;

namespace ProjetoBase
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddAutoMapper();
            services.AddMvc()
                    .AddJsonOptions(options =>
                    {
                        options.SerializerSettings.ContractResolver = new DefaultContractResolver();
                    });

            string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=ProjetoBaseCore;Integrated Security=True;user id=Teste; password=Teste;";
            services.AddDbContext<ProjetoBaseCoreDbContext>(optionBuilder =>
            {
                optionBuilder.UseSqlServer(connectionString);
            });

            services.AddTransient<DbContext, ProjetoBaseCoreDbContext>();

            services.AddTransient<ISetorService, SetorService>();

            services.AddTransient<ISetorRepository, SetorRepository>();

        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
                app.UseDeveloperExceptionPage();
            else
                app.UseExceptionHandler("/Home/Error");

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
