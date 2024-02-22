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
    public class CreateOrEditBlogDto
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }

        public BlogCategoriesEnum BlogCategoryId { get; set; }

        public class Mapping : Profile
        {
            public Mapping()
            {
                CreateMap<BlogEntity, CreateOrEditBlogDto>().ReverseMap();
            }
        }
    }
}
