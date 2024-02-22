using Ca.Cms.Application.Dtos;
using Ca.Cms.Domain.Entities;
using Ca.Cms.Domain.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace Ca.Cms.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AppointmentController : ControllerBase
    {
        private readonly IAppointmentRepository _repository;

        public AppointmentController(IAppointmentRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var admins = await _repository.GetAll();
            return Ok(admins);

        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GeyByIdAdmin(int id)
        {
            var admin = await _repository.GetById(id);
            return Ok(admin);
        }
        [HttpPost]
        public async Task<IActionResult> Post(AppointmentEntity appointment)
        {
            await _repository.Create(appointment);

            return Ok(appointment.Id);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, CreateOrEditAppointmentDto appointment)
        {
            if (id == appointment.Id)
            {
                await _repository.Update(appointment);
            }
            return Ok(appointment.Id);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _departmentService.Delete(id);

            return Ok();
        }
    }
}
