using Ca.Cms.Application.Common.Interfaces;
using Ca.Cms.Application.Dtos;
using Ca.Cms.Application.Services;
using Ca.Cms.Application.Services.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using static Ca.Cms.Application.Dtos.AppointmentDto;

namespace Microsoft.Extensions.DependencyInjection;

public static class DependencyInjection
{
    public static IServiceCollection AddApplicationServices(this IServiceCollection services)
    {
        //services.AddTransient<IPatientService, PatientService>();
        services.AddTransient<IAppointmentService, AppointmentService>();
        services.AddTransient<IContactService, ContactService>();

        var assembly = Assembly.GetExecutingAssembly();
        services.AddAutoMapper(assembly);
        //services.AddAutoMapper(typeof(Mapping));

        return services;
    }
}
