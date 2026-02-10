using System;
using Application.Students.Commands;
using FluentValidation;

namespace Application.Students.Validators;

public class CreateStudentValidator : AbstractValidator<CreateStudent.Command>
{
    public CreateStudentValidator() {
        RuleFor(x => x.StudentDto.Name).NotEmpty().MinimumLength(6).WithMessage("Plase right a correct name!");
        RuleFor(x => x.StudentDto.Hometown).NotEmpty().MinimumLength(4).WithMessage("Dont say you are from the sun!");
    }

}
