using Bupa.Bll;
using Bupa.Dal.Abstract;
using Bupa.Dal.Concrete.EntityFramework.Context;
using Bupa.Dal.Concrete.EntityFramework.Repository;
using Bupa.Dal.Concrete.EntityFramework.UnitOfWork;
using Bupa.Interface;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bupa.WebApi
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
            services.AddDbContext<BupaContext>();
            services.AddScoped<DbContext, BupaContext>();

            #region ServiceSection
            services.AddScoped<IOrderService, OrderManager>();
            services.AddScoped<ICustomerService, CustomerManager>();
            services.AddScoped<IPolicyService, PolicyManager>();
            services.AddScoped<IPolicyOwnerService, PolicyOwnerManager>();
            services.AddScoped<IPaymentMethodService, PaymentMethodManager>();
            services.AddScoped<IOrderDetailService, OrderDetailManager>();
            services.AddScoped<IInstallmentOptionService, InstallmentOptionManager>();
            services.AddScoped<ICardService, CardManager>();
            #endregion

            #region RepositorySection
            services.AddScoped<IOrderRepository, OrderRepository>();
            services.AddScoped<ICustomerRepository, CustomerRepository>();
            services.AddScoped<ICardRepository, CardRepository>();
            services.AddScoped<IPaymentMethodRepository, PaymentMethodRepository>();
            services.AddScoped<IPolicyOwnerRepository, PolicyOwnerRepository>();
            services.AddScoped<IPolicyRepository, PolicyRepository>();
            services.AddScoped<IInstallmentOptionRepository, InstallmentOptionRepository>();
            services.AddScoped<IOrderDetailRepository, OrderDetailRepository>();
            #endregion

            #region UnitOfWork
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            #endregion

            services.AddControllers();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "Bupa.WebApi", Version = "v1" });
            });
            services.AddCors();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseCors(options => options.WithOrigins("http://localhost:4200").AllowAnyMethod().AllowAnyHeader());
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "Bupa.WebApi v1"));
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
