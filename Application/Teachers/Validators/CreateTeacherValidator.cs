using System;
using Application.Teachers.Command;
using FluentValidation;

namespace Application.Teachers.Validators;

public class CreateTeacherValidator : AbstractValidator<CreateTeacher.Command> 
{
    public CreateTeacherValidator()
    {
        RuleFor(x => x.TeacherDto.Name).NotEmpty().MinimumLength(5).MaximumLength(35);
        RuleFor(x => x.TeacherDto.Hometown).NotEmpty().MinimumLength(3).MaximumLength(20);
        RuleFor(x => x.TeacherDto.MobileNumber).NotEmpty().MinimumLength(11).MaximumLength(14);
    }
}
