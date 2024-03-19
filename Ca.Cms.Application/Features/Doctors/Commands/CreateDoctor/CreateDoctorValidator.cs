using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ca.Cms.Application.Features.Doctors.Commands.CreateDoctor
{
    public class CreateDoctorValidator : AbstractValidator<CreateDoctorCommand>
    {
        public CreateDoctorValidator() 
        {
            RuleFor(x => x.Email).NotEmpty();
            RuleFor(x => x.Password).NotEmpty().Length(8,25);
            RuleFor(x => x.Phone).NotEmpty();
            RuleFor(x => x.Surname).Length(8, 25).WithMessage("Please specify a Title").MinimumLength(8);
            ;

        }

    }
}
