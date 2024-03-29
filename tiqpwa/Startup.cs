using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using tiqpwa.Business.Abstract;
using tiqpwa.Business.Concrete;
using tiqpwa.DataAccess.Abstract;
using tiqpwa.DataAccess.Concrete.EntityFramework;
using tiqpwa.Entities.Concrete;
using tiqpwa.ExtensionMethods;

namespace tiqpwa
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
            services.AddScoped<IKullaniciService, KullaniciManager>();
            services.AddScoped<IKullaniciDataAccessLayer, EfKullaniciDataAccessLayer>();
            services.AddScoped<IProjeService, ProjeManager>();
            services.AddScoped<IProjeDataAccessLayer, EfProjeDataAccessLayer>();
            services.AddScoped<IIsinKonusuService, IsinKonusuManager>();
            services.AddScoped<IIsinKonusuDataAccessLayer, EfIsinKonusuDataAccessLayer>();
            services.AddScoped<IIsinCinsiService, IsinCinsiManager>();
            services.AddScoped<IIsinCinsiDataAccessLayer, EfIsinCinsiDataAccessLayer>();
            services.AddControllersWithViews();
            services.AddSession(options => {
                options.IdleTimeout = TimeSpan.FromDays(7);
            });
        }

       
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseSession();
            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Giris}/{action=Index}/{id?}");
            });
        }
    }
}
