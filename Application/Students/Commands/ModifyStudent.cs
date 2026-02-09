using System;
using Domain;
using MediatR;
using Persistence;
using Microsoft.EntityFrameworkCore;
using AutoMapper;

namespace Application.Students.Commands;

public class ModifyStudent
{
    public class Command : IRequest<Unit>
    {
        public required Student Student;
    }

    public class Handler (AppDbContext context, IMapper mapper) : IRequestHandler<Command, Unit>
    {
        public async Task<Unit> Handle(Command request, CancellationToken cancellationToken)
        {
            var student = await context.Students
                .FindAsync(request.Student.Id, cancellationToken) 
                    ?? throw new Exception("Wrong id!");
            
            mapper.Map(request.Student, student);

            await context.SaveChangesAsync(cancellationToken);
            
            return Unit.Value;
        }
    }

}
