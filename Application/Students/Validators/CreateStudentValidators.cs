using System;
using Application.Students.Commands;
using FluentValidation;

namespace Application.Students.Validators;

public class CreateStudentValidator : AbstractValidator<CreateStudent.Command>
{
    public CreateStudentValidator()
    {
        RuleFor(x => x.ActivityDto.Title).NotEmpty();
    }
}
