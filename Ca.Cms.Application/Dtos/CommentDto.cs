using AutoMapper;
using Ca.Cms.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ca.Cms.Application.Dtos
{
    public class CommentDto
    {
        public string Text { get; set; }
        public int PatientId { get; set; }
        public int BlogId { get; set; }
        public BlogEntity Blog { get; set; }

        public PatientEntity Patient { get; set; }
        public class Mapping : Profile
        {
            public Mapping()
            {
                CreateMap<CommentEntity, CommentDto>().ReverseMap();
            }
        }
    }
}
