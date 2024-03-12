using Ca.Cms.Application.Common.Interfaces;
using Ca.Cms.Infrastructure.Authentication;
using System.Collections.Generic;

namespace Microsoft.Extensions.DependencyInjection;

public static class DependencyInjection
{
    public static IServiceCollection AddWebApiServices(this IServiceCollection services)
    {
        services.AddControllers();
        services.AddEndpointsApiExplorer();
        services.AddSwaggerGen();


        services.AddScoped<IUser,CurrentUser>();
        services.AddHttpContextAccessor();
        return services;
    }
}
