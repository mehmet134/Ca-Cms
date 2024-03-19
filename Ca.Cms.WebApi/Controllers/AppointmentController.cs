using Ca.Cms.Application.Features.Appointments.Commands.CreateAppointment;
using Ca.Cms.Application.Features.Appointments.Commands.DeleteAppointment;
using Ca.Cms.Application.Features.Appointments.Commands.UpdateAppointment;
using Ca.Cms.Application.Features.Appointments.Queries.GetAllAppointments;
using Ca.Cms.Application.Features.Appointments.Queries.GetAppointmentById;
using Ca.Cms.Application.Features.Doctors.Commands.CreateDoctor;
using Ca.Cms.Application.Features.Doctors.Commands.DeleteDoctor;
using Ca.Cms.Application.Features.Doctors.Commands.UpdateDoctor;
using Ca.Cms.Application.Features.Doctors.Queries.GetAllDoctors;
using Ca.Cms.Application.Features.Doctors.Queries.GetDoctorById;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Ca.Cms.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AppointmentController : ControllerBase
    {
        private readonly IMediator _mediator;

        public AppointmentController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var response = await _mediator.Send(new GetAllAppointmentsQuery());
            return Ok(response);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var response = await _mediator.Send(new GetAppointmentByIdQuery(id));
            return Ok(response);
        }
        [HttpPost]
        public async Task<IActionResult> Post(CreateAppointmentCommand command)
        {
            var response = await _mediator.Send(command);
            return Ok(response);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, UpdateAppointmentCommand command)
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
            var response = await _mediator.Send(new DeleteAppointmentCommand(id));
            return Ok(response);
        }
    }
}
