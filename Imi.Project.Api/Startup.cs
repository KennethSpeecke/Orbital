using Imi.Project.Api.Core.Entities.ApplicationUsers;
using Imi.Project.Api.Core.Interfaces.Repositories.ApplicationUsers;
using Imi.Project.Api.Core.Interfaces.Repositories.Scientists;
using Imi.Project.Api.Core.Interfaces.Repositories.SpaceObjects;
using Imi.Project.Api.Core.Interfaces.Services.ApplicationUsers;
using Imi.Project.Api.Core.Interfaces.Services.ObjectsTracking;
using Imi.Project.Api.Core.Interfaces.Services.Scientists;
using Imi.Project.Api.Core.Interfaces.Services.SpaceObjects;
using Imi.Project.Api.Core.Interfaces.Services.TLEDataServices;
using Imi.Project.Api.Core.Services.ApplicationUsers;
using Imi.Project.Api.Core.Services.Scientists;
using Imi.Project.Api.Core.Services.SpaceObjects;
using Imi.Project.Api.Core.Services.TLEDataServices;
using Imi.Project.Api.Infrastructure.Data.Context;
using Imi.Project.Api.Infrastructure.Repositories.ApplicationUsers;
using Imi.Project.Api.Infrastructure.Repositories.Scientists;
using Imi.Project.Api.Infrastructure.Repositories.SpaceObjects;
using Imi.Project.Core.Services.ApplicationUsers;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using System;
using System.Text;

namespace Imi.Project.Api
{
    public class Startup
    {
        #region Constructors

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        #endregion Constructors

        #region Properties

        public IConfiguration Configuration { get; }

        #endregion Properties

        #region Methods

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            // Enable middleware to serve generated Swagger as a JSON endpoint.
            app.UseSwagger();
            // Enable middleware to serve swagger-ui (HTML, JS, CSS, etc.), specifying the Swagger
            // JSON endpoint.
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "Orbital API");
                c.RoutePrefix = string.Empty;
            });

            app.UseStaticFiles();

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();

            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("DatabaseConnection")));

            // Add a default identity to the identity services With basic role class.
            services.AddIdentity<ApplicationUser, IdentityRole>(options =>
            {
                options.SignIn.RequireConfirmedAccount = false;
                options.User.RequireUniqueEmail = true;
            })
                .AddEntityFrameworkStores<ApplicationDbContext>();

            // Register the Swagger generator, defining 1 or more Swagger documents
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "Orbital Api", Version = "v1" });
                c.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme()
                {
                    Name = "Authorization",
                    Type = SecuritySchemeType.ApiKey,
                    Scheme = "Bearer",
                    BearerFormat = "JWT",
                    In = ParameterLocation.Header,
                    Description = "Login and copy your response token. \r\n\r\n Enter 'Bearer' [space] and then your token in the text input below.\r\n\r\nExample: \"Bearer 12345abcdef\""
                });
                c.AddSecurityRequirement(new OpenApiSecurityRequirement()
                {
                    {
                        new OpenApiSecurityScheme
                        {
                            Reference = new OpenApiReference
                            {
                                Type = ReferenceType.SecurityScheme,
                                Id = "Bearer"
                            }
                        },
                        new string[] {}
                    }
                });
            });

            services.AddAuthentication(option =>
            {
                option.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                option.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            }).AddJwtBearer(jwtOptions =>
             {
                 jwtOptions.TokenValidationParameters = new TokenValidationParameters()
                 {
                     ValidateActor = true,
                     ValidateAudience = true,
                     ValidateLifetime = true,
                     ValidIssuer = Configuration["JWTConfiguration:Issuer"],
                     ValidAudience = Configuration["JWTConfiguration:Audience"],
                     IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(Configuration["JWTConfiguration:SigningKey"]))
                 };
             });

            //AutoMapper Service Config
            services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

            //IOC Container
            //Repository Config
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<IUserCommentRepository, UserCommentRepository>();
            services.AddScoped<IAstronomerRepository, AstronomerRepository>();
            services.AddScoped<IAstronautRepository, AstronautRepository>();
            services.AddScoped<INotableWorkRepository, NotableWorkRepository>();
            services.AddScoped<ISpaceCraftRepository, SpaceCraftRepository>();
            services.AddScoped<ISpaceDebrisRepository, SpaceDebrisRepository>();
            services.AddScoped<ISpacePlanetoidRepository, SpacePlanetoidRepository>();

            //Services Config
            services.AddScoped<IUserCommentService, UserCommentService>();
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IAstronomerService, AstronomerService>();
            services.AddScoped<IAstronautService, AstronautService>();
            services.AddScoped<INotableWorkService, NotableWorkService>();
            services.AddScoped<IDebrisService, DebrisService>();
            services.AddScoped<IPlanetoidCompositionService, PlanetoidCompositionService>();
            services.AddScoped<IPlanetoidService, PlanetoidService>();
            services.AddScoped<ISpaceCraftService, SpaceCraftService>();
            services.AddScoped<ISpaceObjectLocationService, TrackingService>();
            services.AddScoped<ITLEDataWebClient, TLEDataWebClient>();
            services.AddScoped<IAuthenticationService<ApplicationUser>, AuthenticationService>();
        }

        #endregion Methods
    }
}