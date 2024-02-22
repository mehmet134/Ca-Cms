using AutoMapper;
using Ca.Cms.Domain.Entities;
using Ca.Cms.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ca.Cms.Application.Dtos
{
    public class CreateOrEditAppointmentDto
    {
        public DepartmentsEnum? CategoryId { get; set; }
        public int? DoctorId { get; set; }
        public int? PatientId { get; set; }
        public DateTime? DateTime { get; set; }
        
    }
    public class Mapping : Profile
    {
        public Mapping()
        {
            CreateMap<AppointmentEntity, CreateOrEditAppointmentDto>().ReverseMap();
        }
    }
}
