using System;
using System.IO;
using System.Linq;
using System.Reflection;
using Demo.Pubs.API.Extensions;
using Demo.Pubs.API.Options;
using Demo.Pubs.Core.Interfaces;
using Demo.Pubs.Infrastructure.DbContexts;
using Demo.Pubs.Infrastructure.Repositories;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.ApiExplorer;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json.Serialization;
using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.Swagger;

namespace Demo.Pubs.API
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
            var connectionStringsOptions = Configuration.GetSection("ConnectionStrings").Get<ConnectionStringsOptions>();

            var cosmosDbOptions = Configuration.GetSection("CosmosDb").Get<CosmosDbOptions>();
            
            var (serviceEndpoint, authKey) = connectionStringsOptions.ActiveConnectionStringOptions;
            
            var (databaseName, collectionData) = cosmosDbOptions;

            var collectionNames = collectionData.Select(c => c.Name).ToList();

            services.AddApplicationInsightsTelemetry();

            services.AddMvc().AddNewtonsoftJson(options =>
                {
                    options.SerializerSettings.ContractResolver = new CamelCasePropertyNamesContractResolver();
                });

            services.AddVersionedApiExplorer(o => o.GroupNameFormat = "'v'VVV");

            services.AddApiVersioning(options =>
            {
                options.ReportApiVersions = true;
                options.AssumeDefaultVersionWhenUnspecified = true;
            });

            services.AddControllers();

            services.AddCosmosDb(serviceEndpoint, authKey, databaseName, collectionNames);

            services.AddEntityFrameworkCosmos();

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo
                {
                    Title = "Demo Pubs + Cosms DB API", 
                    Version = "v1",
                    Description = "Fun API to interact with Azure CosmosDB using .NET Core 3 & the old Microsoft Pubs dataset."
                });
                
                var xmlFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
                var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);
                
                c.IncludeXmlComments(xmlPath);
            });

            services.AddScoped<IBookRepository, BookRepository>();

            services.AddHealthChecks();

        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, IApiVersionDescriptionProvider provider, ILoggerFactory loggerFactory)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseAppInsightsLogger(loggerFactory);
                app.UseGlobalErrorHandler();
            }

            app.UseStaticFiles();

            app.UseDefaultFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });

            app.UseSwagger();

            app.UseSwaggerUI(options =>
            {
                foreach (var description in provider.ApiVersionDescriptions)
                {
                    options.SwaggerEndpoint(
                        $"/swagger/{description.GroupName}/swagger.json",
                        description.GroupName.ToUpperInvariant());
                }
            });
        }
    }
}
