using Ca.Cms.Application.Common.Interfaces;
using Ca.Cms.Infrastructure.Authentication;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using System.Collections.Generic;
using System.Text;

namespace Microsoft.Extensions.DependencyInjection;

public static class DependencyInjection
{
    public static IServiceCollection AddWebApiServices(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddControllers();
        services.AddEndpointsApiExplorer();
        services.AddSwaggerGen();


        services.AddScoped<IUser,CurrentUser>();
        services.AddHttpContextAccessor();
        services.AddScoped<JwtAccountService>();
        //services
        //    .AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
        //    .AddJwtBearer(JwtBearerDefaults.AuthenticationScheme, options =>
        //    {
        //        var signingKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(configuration["Authentication:Jwt:SigningKey"]));
        //        options.TokenValidationParameters = new TokenValidationParameters
        //        {
        //            //ValidateIssuer = true,
        //            //ValidateAudience = true,
        //            //ValidateLifetime = true,
        //            ValidateIssuerSigningKey = true,
        //            ValidIssuer = configuration["Authentication:Jwt:Issuer"],
        //            ValidAudience = configuration["Authentication:Jwt:Audience"],
        //            IssuerSigningKey = signingKey,
        //        };
        //    });
        return services;
    }
}
