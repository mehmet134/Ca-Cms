using AutoMapper;
using Ca.Cms.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ca.Cms.Application.Dtos
{
    public class CreateOrEditPatientDto
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string Surname { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public long Phone { get; set; }
        public class Mapping : Profile
        {
            public Mapping()
            {
                CreateMap<PatientEntity, CreateOrEditPatientDto>().ReverseMap();
            }
        }
    }
}
