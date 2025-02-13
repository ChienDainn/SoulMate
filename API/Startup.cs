using System.Text;
using API.Data;
using API.Interfaces;
using API.Services;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.IdentityModel.Tokens;

public class Startup
{

    private readonly IConfiguration _config;

    public Startup(IConfiguration config)
    {
        _config = config;

    }

    public void ConfigureServices(IServiceCollection services)
    {
        services.AddScoped<ITokenService, TokenService>();
        services.AddDbContext<DataContext>(options =>
        {
            options.UseSqlite(_config.GetConnectionString("DefaultConnection"));
        });
        services.AddControllers();
        services.AddCors(options =>
    {
        options.AddPolicy("AllowAngularApp",
            builder => builder.WithOrigins("https://localhost:4200")
                              .AllowAnyMethod()
                              .AllowAnyHeader());
    });
        services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
            .AddJwtBearer(options =>
            {
                options.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidateIssuerSigningKey = true,
                    IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config["TokenKey"])),
                    ValidateIssuer = false,
                    ValidateAudience = false
                };
            });
        services.AddRazorPages();
    }

    public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
    {
        if (env.IsDevelopment())
        {
            app.UseDeveloperExceptionPage();
        }



        //app.UseStaticFiles();
        app.UseRouting();

        app.UseCors("AllowAngularApp");

        app.UseHttpsRedirection();

        app.UseAuthentication();

        app.UseAuthorization();

        app.UseEndpoints(endpoints =>
        {
            endpoints.MapControllers();
            endpoints.MapRazorPages();
        });
    }
}
