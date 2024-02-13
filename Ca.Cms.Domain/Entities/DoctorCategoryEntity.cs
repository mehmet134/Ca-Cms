using Ca.Cms.Domain.Common;

namespace Ca.Cms.Domain.Entities
{
    public class DoctorCategoryEntity : BaseEntity
    {
        public string Name { get; set; }

        public List<DoctorEntity> Doctors { get; set; }
    }
}