using AutoMapper;
using Ca.Cms.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ca.Cms.Application.Dtos
{
    public class CreateOrEditContactDto
    {
        public string Fullname { get; set; }
        public string Topic { get; set; }

        public string Email { get; set; }

        public long Phone { get; set; }

        public string Text { get; set; }
        public class Mapping : Profile
        {
            public Mapping()
            {
                CreateMap<ContactEntity, CreateOrEditContactDto>().ReverseMap();
            }
        }
    }
}
