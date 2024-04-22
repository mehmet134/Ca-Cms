using Ca.Cms.Application.Features.Doctors.Commands.CreateDoctor;
using Ca.Cms.Application.Features.Doctors.Commands.DeleteDoctor;
using Ca.Cms.Application.Features.Doctors.Commands.UpdateDoctor;
using Ca.Cms.Application.Features.Doctors.Queries.GetAllDoctors;
using Ca.Cms.Application.Features.Doctors.Queries.GetDoctorById;
using Ca.Cms.Domain.Repositories;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Ca.Cms.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DoctorController : ControllerBase
    {
        private readonly IMediator _mediator;

        public DoctorController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var response = await _mediator.Send(new GetAllDoctorsQuery());
            return Ok(response);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var response = await _mediator.Send(new GetDoctorByIdQuery(id));
            return Ok(response);
        }
        [HttpPost]
        public async Task<IActionResult> Post(CreateDoctorCommand command)
        {
            var response = await _mediator.Send(command);
            return Ok(response);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, UpdateDoctorCommand command)
        {
            if (id == command.Id)
            {
                var response = await _mediator.Send(command);
                return Ok(response);
            }
            return Ok(false);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var response = await _mediator.Send(new DeleteDoctorCommand(id));
            return Ok(response);
        }
    }
}
