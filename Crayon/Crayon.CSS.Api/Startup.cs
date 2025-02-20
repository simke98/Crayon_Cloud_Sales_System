﻿using Crayon.CSS.Api.Extensions;
using Crayon.CSS.Persistence;
using Microsoft.EntityFrameworkCore;

namespace Crayon.CSS.Api;

public class Startup
{
    public IConfiguration Configuration { get; }


    public Startup(IConfiguration configuration)
    {
        Configuration = configuration;
    }

    public void ConfigureServices(IServiceCollection services)
    {
        services.AddDbContext<CSSDBContext>(opts =>
            opts.UseSqlServer(Configuration.GetConnectionString("CLOUD_SALES_SYSTEM_DB")));

        services.AddSwaggerSettings();
        services.AddHttpClient();
        services.AddCors(options =>
        {
            options.AddPolicy("AllowAll", builder =>
            {
                builder.AllowAnyOrigin()
                       .AllowAnyMethod()
                       .AllowAnyHeader();
            });
        });

        services.AddControllers();
    }


    public void Configure(
     IApplicationBuilder app,
     IWebHostEnvironment env
 )
    {
        if (env.IsDevelopment())
        {
            app.UseDeveloperExceptionPage();
        }
        else
        {
            app.UseHsts();
        }

        app.UseHttpsRedirection();
        app.UseRouting();
        app.UseCors("AllowAll");
        app.UseEndpoints(endpoints =>
        {
            endpoints.MapControllers();
        });


        app.UseSwagger();
        app.UseSwaggerUI(c =>
        {
            c.SwaggerEndpoint("/swagger/v1/swagger.json", "Cloud Sales System API v1");
            c.DocumentTitle = "Cloud Sales System Swagger";
        });

    }
}
