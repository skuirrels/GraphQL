using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using AutoMapper;
using Convey;
using GraphQL_EF5Core_API.DataLayer;
using GraphQL_EF5Core_API.Resolvers;
using GraphQL_EF5Core_API.Resources;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace GraphQL_EF5Core_API
{
    public class Startup
    {
        private readonly IConfiguration Configuration;

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();
            
            // services.AddControllers()
            //     .AddJsonOptions(options =>
            //     {
            //         options.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.Preserve;
            //     });
            
            // Use Docker ConnectionString Param or fallback to the connnectionstring is appsettings.json
            var connectionString = Configuration["APP_CONNECTIONSTRING"] ??
                                   Configuration.GetConnectionString("PostgresConnection");
            
            // services.AddDbContext<OrderContext>(x =>
            //     x.UseNpgsql(connectionString, m => m.MigrationsAssembly(typeof(OrderContext).Assembly.FullName)));
            
            services.AddDbContextPool<OrderContext>(o =>
                o.UseNpgsql(connectionString,m => m.MigrationsAssembly(typeof(OrderContext).Assembly.FullName)));
                

            services.AddConvey();

            services.AddAutoMapper(typeof(Startup));

            services.AddGraphQLServer()
                .AddQueryType<OrderQuery>()
                .AddMutationType<OrderMutation>();

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();
            
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
                endpoints.MapGraphQL(); 
            });
        }
    }
}