using IMDB.Recommendations.Application.ServiceRegistration;
using IMDB.Recommendations.Infrastructure;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;

namespace IMDB.Recommendations.Api
{
    public class Startup
    {
        private readonly IConfiguration _configuration;
        private const string _corsPolicy = "Permitted";

        public Startup(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        
        public void ConfigureServices(IServiceCollection services)
        {
            AddSwagger(services);
            
            services.AddApplicationServices();
            services.AddInfrastructureServices();
            
            services.AddControllers();
            services.AddCors(options =>
            {
                options.AddPolicy(_corsPolicy, builder => builder.WithOrigins("https://localhost:5001"));
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();
            app.UseRouting();
            app.UseCors(_corsPolicy);

            app.UseSwagger();
            app.UseSwaggerUI(options =>
            {
                options.SwaggerEndpoint("/swagger/v1/swagger.json", "IMDB Recommendations API");
            });

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }

        private void AddSwagger(IServiceCollection services)
        {
            services.AddSwaggerGen(options =>
            {
                options.SwaggerDoc("v1", new OpenApiInfo()
                {
                    Version = "v1",
                    Title = "IMDB Recommendations API"
                });
            });
        }
    }
}