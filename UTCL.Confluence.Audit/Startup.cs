using System;
using System.Text;
using Autofac;
using AutoMapper;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.IdentityModel.Tokens;
using UTCL.Confluence.Common.Cache;
using UTCL.Confluence.Common.Email;

namespace UTCL.Confluence.Audit
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        public ILifetimeScope AutofacContainer { get; private set; }
        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        [Obsolete]
        public void ConfigureServices(IServiceCollection services)
        {

            //services.AddCors(options => options.AddPolicy("ApiCorsPolicy", builder =>
            //{
            //    builder.WithOrigins("http://localhost:4200").AllowAnyMethod().AllowAnyHeader();
            //}));

            services.AddCors(c =>
            {
                c.AddPolicy(
                    "ApiCorsPolicy",
                    options => options.WithOrigins("https://utclweb.azurewebsites.net/")
                    .AllowAnyOrigin()
                    .AllowAnyMethod()
                    .AllowAnyHeader());
            });

            services.AddDistributedRedisCache(option =>
            {
                option.Configuration = Configuration.GetSection("RedisConnectionStrings").GetSection("RedisConnection").Value;
                option.InstanceName = Configuration.GetSection("RedisConnectionStrings").GetSection("InstanceName").Value;
            });
            var DBConnection = Configuration.GetSection("DBConnectionStrings").GetSection("ConnectionString").Value;
           // services.AddDbContext<utclconfluencesqldbauditdevContext>
            //  (options => options.UseSqlServer(Configuration.GetSection("DBConnectionStrings").GetSection("ConnectionString").Value));
            services.AddControllers();
            services.AddApplicationInsightsTelemetry();
            services.AddAuthentication(sharedOptions =>
            {
                sharedOptions.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;
                sharedOptions.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                sharedOptions.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;

            }).AddJwtBearer("AzureAd", options =>
            {
                options.RequireHttpsMetadata = false;
                options.SaveToken = true;
                options.TokenValidationParameters = new Microsoft.IdentityModel.Tokens.TokenValidationParameters
                {
                    ValidateIssuer = true,
                    ValidIssuer = this.Configuration["AzureAd:TenantId"],
                    ValidateAudience = true,
                    ValidAudience = this.Configuration["AzureAd:ClientId"],
                };
                options.Audience = this.Configuration["AzureAd:ClientId"];
                options.Authority = this.Configuration["AzureAd:Authority"];
            }).AddJwtBearer(options =>
            {
                options.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidateIssuer = true,
                    ValidateAudience = true,
                    ValidateLifetime = true,
                    ValidateIssuerSigningKey = true,
                    ValidIssuer = Configuration["Jwt:Issuer"],
                    ValidAudience = Configuration["Jwt:Issuer"],
                    IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(Configuration["Jwt:Key"]))
                };
            });

            services.AddAuthorization(options =>
            {
                var defaultAuthorizationPolicyBuilder = new AuthorizationPolicyBuilder(
                    JwtBearerDefaults.AuthenticationScheme,
                    "AzureAd");
                defaultAuthorizationPolicyBuilder =
                    defaultAuthorizationPolicyBuilder.RequireAuthenticatedUser();
                options.DefaultPolicy = defaultAuthorizationPolicyBuilder.Build();
            });
        }
        public void ConfigureContainer(ContainerBuilder container)
        {
            //container.RegisterModule(new KaizenRepository());
           // container.RegisterType<KaizenRepository>().As<IKaizenRepository>();
           

           // container.RegisterType<KaizenService>().As<IKaizenService>();
          

            container.RegisterType<Mapper>().As<IMapper>();
            container.RegisterType<Cache>().As<ICache>();
            container.RegisterType<Email>().As<IEmail>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        [Obsolete]
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();

            }
            else
            {
                app.UseHsts();
            }

            app.UseStaticFiles();

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthentication();

            app.UseAuthorization();

            //app.UseCors(builder =>
            //{
            //    builder.AllowAnyHeader();
            //    builder.AllowAnyMethod();
            //    builder.AllowAnyOrigin(); // For anyone access.
            //    builder.WithOrigins("http://utcl-confluence-sfc-dev.centralindia.cloudapp.azure.com:8083"); // for a specific url.
            //});
            //app.UseCors("ApiCorsPolicy");
            app.UseCors(options => options.WithOrigins("https://utclweb.azurewebsites.net/"));


            app.UseEndpoints(endpoints =>
            {
               // endpoints.MapControllerRoute("Kaizen", "{controller=Kaizen}");
                
            });

        }
    }
}
