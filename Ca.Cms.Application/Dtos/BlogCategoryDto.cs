using AutoMapper;
using Ca.Cms.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ca.Cms.Application.Dtos
{
    public class BlogCategoryDto
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public class Mapping : Profile
        {
            public Mapping()
            {
                CreateMap<BlogCategoryEntity, BlogCategoryDto>().ReverseMap();
            }
        }
    }
}
