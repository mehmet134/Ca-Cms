using AutoMapper;
using Ca.Cms.Application.Features.Appointments.Commands.CreateAppointment;
using Ca.Cms.Application.Features.Appointments.Commands.UpdateAppointment;
using Ca.Cms.Application.Features.Appointments.Queries;
using Ca.Cms.Application.Features.Doctors.Commands.CreateDoctor;
using Ca.Cms.Application.Features.Doctors.Commands.UpdateDoctor;
using Ca.Cms.Application.Features.Doctors.Queries;
using Ca.Cms.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ca.Cms.Application.Features.Appointments
{
    public class Mapping : Profile
    {
        public Mapping()
        {
            CreateMap<AppointmentEntity, CreateAppointmentCommand>().ReverseMap();
            CreateMap<AppointmentEntity, UpdateAppointmentCommand>().ReverseMap();
            CreateMap<AppointmentEntity, AppointmentDto>().ReverseMap();

            //CreateMap<string, DateOnly>().ConvertUsing(new DateTimeTypeConverter());
        }
    }
}
