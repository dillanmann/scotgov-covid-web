using HotChocolate;
using HotChocolate.AspNetCore;
using HotChocolate.Execution.Configuration;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using ScotgovCovid.Web.Types;
using ScotgovCovidWeb.DataAccess;

namespace ScotgovCovid.Web
{
    public class Startup
    {
        private readonly string CorsPolicyName = "_ScotgovCovidWebCorsPolicy";

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            var conString = ConfigurationExtensions.GetConnectionString(this.Configuration, "postgres");
            services.AddDbContext<ScotgovCovidStatsContext>(opts => opts.UseNpgsql(conString));
            services.AddGraphQL(
               SchemaBuilder.New()
               .AddQueryType<Query>()
               .Create(),
               new QueryExecutionOptions { ForceSerialExecution = true });

            if (Configuration.GetValue<bool>("EnableCors"))
            {
                services.AddCors(o => o.AddPolicy(CorsPolicyName, builder =>
                {
                    builder.AllowAnyOrigin()
                           .AllowAnyMethod()
                           .AllowAnyHeader()
                           .AllowCredentials();
                }));
            }
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseGraphQL()
               .UsePlayground();
        }
    }
}
