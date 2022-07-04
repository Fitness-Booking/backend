﻿using System;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using Autofac;
using FitnessBooking.Api.Extensions;
using FitnessBooking.Core.Models;
using FitnessBooking.Core.Validators;
using FitnessBooking.Data.Models;
using FluentValidation.AspNetCore;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;

namespace FitnessBooking.Api
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        private IConfiguration Configuration { get; }
        private EnvironmentDetails _environment;

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            _environment = services.ConfigurePoco<EnvironmentDetails>(Configuration.GetSection("Environment"));

            services.DisableCachingForAllHttpCalls();
            services.AddCors(options =>
            {
                options.AddPolicy("AllowSpecificOrigin",
                    builder =>
                    {
                        builder
                            .AllowAnyOrigin()
                            .AllowAnyMethod()
                            .AllowAnyHeader();
                    });
            });
            services.AddMvc().AddFluentValidation(fv =>
            {
                fv.RegisterValidatorsFromAssemblyContaining<UserValidator>();
            });
            services.AddAntiforgery(opts => opts.Cookie.Name = "AntiForgery." + _environment.ApplicationName);
            services.AddHttpClient();

            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();

            services.AddLongRunningTasks();

            services.AddControllers();

            services.AddResponseCaching(options => { options.UseCaseSensitivePaths = true; });
            services.AddResponseCompression(options => { options.EnableForHttps = true; });
            services.AddAuthentication(x =>
            {
                x.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                x.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            }).AddJwtBearer(options =>
            {
                options.RequireHttpsMetadata = false;
                options.SaveToken = true;
                options.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidateIssuer = false,
                    ValidateAudience = false,
                    ValidateLifetime = true,
                    ValidateIssuerSigningKey = true,
                    ValidIssuer = string.Empty,
                    ValidAudience = string.Empty,
                    IssuerSigningKey =
                        new SymmetricSecurityKey(
                            Encoding.UTF8.GetBytes(Configuration["Environment:ApplicationSecret"])),
                    ClockSkew = TimeSpan.Zero
                };
                services.AddCors();
            });
            
            // Add DB Context here
            services
                .AddDbContext<FitnessBookingContext>(options => options
                    .UseLazyLoadingProxies()
                    .UseSqlServer(Configuration.GetConnectionString("SqlServer"),
                        optionsBuilder =>
                            optionsBuilder
                                .EnableRetryOnFailure(5, TimeSpan.FromSeconds(10), null)
                    )
                );
            services.AddSwaggerGen(options =>
            {
                options.ResolveConflictingActions(apiDescriptions => apiDescriptions.First());
                options.IgnoreObsoleteActions();
                options.IgnoreObsoleteProperties();
                options.CustomSchemaIds(type => type.FullName);

                options.SwaggerDoc("v1", new OpenApiInfo
                {
                    Version = "v1",
                    Title = "Fitness booking API",
                    Description = "An ASP.NET Core Web API for managing ToDo items",
                    TermsOfService = new Uri("https://example.com/terms"),
                    Contact = new OpenApiContact
                    {
                        Name = "Example Contact",
                        Url = new Uri("https://example.com/contact")
                    },
                    License = new OpenApiLicense
                    {
                        Name = "Example License",
                        Url = new Uri("https://example.com/license")
                    }
                });

                var xmlFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
                var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);
                options.IncludeXmlComments(xmlPath);
            });
        }

        public void ConfigureContainer(ContainerBuilder builder)
        {
            builder.RegisterAllServices();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseSwagger(options =>
            {
                options.SerializeAsV2 = true;
            });
            app.UseSwaggerUI(options =>
            {
                options.SwaggerEndpoint("/swagger/v1/swagger.json", "v1");
            });
            app.UseRouting();
            app.UseAuthentication();
            app.UseAuthorization();
            app.UseCors("AllowSpecificOrigin");
            app.UseResponseCaching();
            app.UseResponseCompression();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}