using Ca.Cms.Domain.Common;
using Ca.Cms.Domain.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ca.Cms.Domain.Entities
{
    public class BlogEntity : BaseEntity
    {
        public string Title { get; set; }
        public string Description { get; set; }

        public BlogCategoriesEnum BlogCategoryId { get; set; }




        //public string? ResimDosyaAdi { get; set; }

        //public string? ResimYolu
        //{
        //    get
        //    {
        //        if (!string.IsNullOrEmpty(ResimDosyaAdi))
        //        {
        //            return "/images/" + ResimDosyaAdi; // wwwroot klasöründeki images altındaki dosyaya göre yol belirtilir.
        //        }
        //        return null;
        //    }
        //}

        public ICollection<CommentEntity> Comments { get; set; }


    }
}
