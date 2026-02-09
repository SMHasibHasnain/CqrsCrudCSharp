using System;
using AutoMapper;
using Domain;
using MediatR;
using Persistence;

namespace Application.Students.Commands;

public class CreateStudent
{
    public class Command : IRequest<Unit>
    {
        public required Student Student;
    }

    public class Handler (AppDbContext context) : IRequestHandler<Command, Unit>
    {
        public async Task<Unit> Handle(Command request, CancellationToken cancellationToken)
        {
            context.Students.Add(request.Student);

            await context.SaveChangesAsync(cancellationToken);
            
            return Unit.Value;
        }
    }

}
