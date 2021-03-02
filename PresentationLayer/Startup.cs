﻿
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

using Microsoft.EntityFrameworkCore;
using Context;

using DataLayer.Service;
using DataLayer.Interface;

using AplicationLayer.Service;
using AplicationLayer.Inteface;

using System;
using DTOLayer.Mapper;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;

namespace PresentationLayer
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
            services.AddControllers();

            //Aqui se añade la injeccion de dependencias
            services.AddTransient<ICasaAplication, CasaAplication>();
            services.AddTransient<IDataCasa, DataCasa>();

            services.AddTransient<IComparadorAplication, ComparadorAplication>();
            services.AddTransient<IDataComprador, DataComprador>();
            
            services.AddTransient<IContextDb, Contex>();

            
            //Conxion code First ( ConnectionStrings archivo appsetting.json )
            services.AddDbContext<Contex>(options =>
               options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));

            services.AddOptions();

            services.AddMvc();

            //Te injecta las DTO
            new Mapper();


            services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "TEst", Version = "v1" });
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                object p = app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "PresentationLayer v1"));
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
