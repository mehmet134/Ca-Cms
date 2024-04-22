using AutoMapper;
using Ca.Cms.Application.Features.Doctors.Commands.CreateDoctor;
using Ca.Cms.Application.Features.Doctors.Commands.UpdateDoctor;
using Ca.Cms.Application.Features.Doctors.Queries;
using Ca.Cms.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Ca.Cms.Application.Features.Doctors
{
    public class Mapping : Profile
    {
        public Mapping()
        {
            CreateMap<DoctorEntity, CreateDoctorCommand>().ReverseMap();
            CreateMap<DoctorEntity, UpdateDoctorCommand>().ReverseMap();
            CreateMap<DoctorEntity, DoctorDto>().ReverseMap();

            //CreateMap<string, DateOnly>().ConvertUsing(new DateTimeTypeConverter());
        }
    }
}
