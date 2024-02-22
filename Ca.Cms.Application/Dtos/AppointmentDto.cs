﻿using AutoMapper;
using Ca.Cms.Domain.Entities;
using Ca.Cms.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Ca.Cms.Application.Dtos
{
    public class AppointmentDto
    {
        public int Id { get; set; }
        public DepartmentsEnum CategoryId { get; set; }
        public int DoctorId { get; set; }
        public int PatientId { get; set; }
        public DateTime DateTime { get; set; }
        public class Mapping : Profile
        {
            public Mapping()
            {
                CreateMap<AppointmentEntity, AppointmentDto>().ReverseMap();
            }
        }
    }
}
