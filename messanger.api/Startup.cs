using messanger.core.domain;
using messanger.core.Repoisitory;
using messanger.core.service;
using messanger.infra.domain;
using messanger.infra.Repoisitory;
using messanger.infra.service;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace messanger.api
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
            services.AddScoped<IDBContext , DbContext>();

            
            services.AddScoped<Icategory_apiRepoisitory, category_apiRepoisitory>();
            services.AddScoped<Ifrinds_apiRepoisitory, friends_apirepoisitory>();
            services.AddScoped<Ilikepost_apiRepoisitory, likepost_apirepoisitory>();
            services.AddScoped<Imessage_apiRepoisitory, message_apirepoisitory>();
            services.AddScoped<Ipost_apiRepoisitory, post_apirepoisitory>();
            services.AddScoped<Iuser_apiRepoisitory, user_apirepoisitory>();
            services.AddScoped<Ivisa_apiRepoisitory, visa_apirepoisitory>();
            services.AddScoped<Igroup_apirepoisitory, group_apirepoisitory>();
            services.AddScoped< Ilogins_apiRepoisitory ,logins_apiRepoisitory > ();
            services.AddScoped< Iroles_api_Repoisitory ,roles_api_Repoisitory > ();
            services.AddScoped<Iusergroup_apiRepoisitory, usergroup_apiRepoisitory>();
            services.AddScoped< Iservice_apiRepoisitory ,service_apirepoisitory > ();
            services.AddScoped< Isales_apirepoisitory, sales_apirepoisitory > ();
            services.AddScoped<IJwtRepository, JwtRepository>();


            services.AddScoped<Icategory_apiservice, category_apiservice>();
            services.AddScoped<Ifrinds_apiservice, friends_apiservice>();
            services.AddScoped<Ilikepost_apiservice, likepost_apiservice>();
            services.AddScoped<Imessage_apiservice, message_apiservice>();
            services.AddScoped<Ipost_apiservice, post_apiservice>();
            services.AddScoped <Iuser_apiservice, user_apiservice> ();
            services.AddScoped<Ivisa_apiservice, visa_apiservice>();
            services.AddScoped<Igroup_apiservice, group_apiservice> ();
            services.AddScoped<Ilogins_apiservice, logins_apiservice>();
            services.AddScoped< Iroles_api_service ,roles_api_service  > ();
            services.AddScoped<Iusergroup_apirervice, usergroup_apiservice>();
            services.AddScoped<Iservice_apiservice ,service_apiservice > ();
            services.AddScoped<Isales_apiservice, sales_apiservice>();
            services.AddScoped<IJwtService, JwtService>();
            services.AddAuthentication(x =>
            {
                x.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                x.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            }).AddJwtBearer(y =>
            {
                y.RequireHttpsMetadata = false;
                y.SaveToken = true;
                y.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidateIssuerSigningKey = true,
                    IssuerSigningKey = new SymmetricSecurityKey(Encoding.ASCII.GetBytes("[SECRET USED TO SIGN AND VERIFY JWT TOKENS, IT CAN BE ANY STRING]")),
                    ValidateIssuer = false,
                    ValidateAudience = false
                };
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
            app.UseAuthentication();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
