using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ChillhopStore.API.Services;
using ChillhopStore.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using MongoDB.Driver;
using WebAPI.ConfigObjects;
using WebAPI.Extensions;
using WebAPI.Services;

namespace WebAPI
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
            Auth0Configuration = Configuration.GetSection("Auth0").Get<Auth0Config>();
        }

        public Auth0Config Auth0Configuration { get; }
        public IConfiguration Configuration { get; }


        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            
            var settings = MongoClientSettings.FromConnectionString("mongodb+srv://JohnBoscoM:59MLcmta@sanbox.pregu.mongodb.net/chillhop_store?retryWrites=true&w=majority");
            services.AddAuthenticationWithAuth0(Auth0Configuration);
            services.AddSingleton<IProductRepository, ProductRepository>();
            services.AddSingleton<IUserRepository, UserRepository>();
            services.AddControllers();
            services.AddSingleton<IMongoClient>(new MongoClient(settings));
            services.AddSingleton<IMongoDBSettings, MongoDBSettings>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseAuthentication();

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
