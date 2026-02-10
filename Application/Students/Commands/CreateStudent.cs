using System;
using System.ComponentModel.DataAnnotations;
using Application.Students.Dtos;
using AutoMapper;
using Domain;
using FluentValidation;
using MediatR;
using Persistence;

namespace Application.Students.Commands;

public class CreateStudent
{
    public class Command : IRequest<Unit>
    {
        public required CreateStudentDto StudentDto {get; set;}
    }

    public class Handler (AppDbContext context, IMapper mapper, IValidator<Command> validator) : IRequestHandler<Command, Unit>
    {
        public async Task<Unit> Handle(Command request, CancellationToken cancellationToken)
        {
            await validator.ValidateAndThrowAsync(request, cancellationToken);

            var student = mapper.Map<Student>(request.StudentDto);

            context.Students.Add(student);

            await context.SaveChangesAsync(cancellationToken);
            
            return Unit.Value;
        }
    }

}
