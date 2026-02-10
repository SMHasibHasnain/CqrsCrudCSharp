using System;
using Application.Teachers.Dtos;
using AutoMapper;
using FluentValidation;
using MediatR;
using Persistence;
using Application;
using Domain;

namespace Application.Teachers.Command;

public class CreateTeacher
{
    public class Command : IRequest<Unit>
    {
        public required CreateTeacherDto TeacherDto {get; set;}
    }

    public class Handler(AppDbContext _context, IMapper _mapper, IValidator<Command> _validator) : IRequestHandler<Command, Unit>
    {
        public async Task<Unit> Handle(Command request, CancellationToken cancellationToken)
        {
            await _validator.ValidateAndThrowAsync(request, cancellationToken);
            var teacher = _mapper.Map<Teacher>(request.TeacherDto);
            _context.Teachers.Add(teacher);
            await _context.SaveChangesAsync(cancellationToken);
            return Unit.Value;
        }
    }
}
