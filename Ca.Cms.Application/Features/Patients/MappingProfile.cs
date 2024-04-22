using AutoMapper;
using Ca.Cms.Application.Features.Patients.Commands.CreatePatient;
using Ca.Cms.Application.Features.Patients.Commands.UpdatePatient;
using Ca.Cms.Application.Features.Patients.Queries;
using Ca.Cms.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Ca.Cms.Application.Features.Patients
{
    public class Mapping : Profile
    {
        public Mapping()
        {
            CreateMap<PatientEntity, CreatePatientCommand>().ReverseMap();
            CreateMap<PatientEntity, UpdatePatientCommand>().ReverseMap();
            CreateMap<PatientEntity, PatientDto>();
            //CreateMap<string, DateOnly>().ConvertUsing(new DateTimeTypeConverter());
        }
    }
}
