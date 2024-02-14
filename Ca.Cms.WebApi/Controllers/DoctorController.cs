using Ca.Cms.Domain.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Ca.Cms.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DoctorController : ControllerBase
    {
        private readonly IDoctorRepository _repository;

        public DoctorController(IDoctorRepository repository)
        {
            _repository = repository;
        }
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var doctors = await _repository.GetAll();
            return Ok(doctors);
        }
    }
}
