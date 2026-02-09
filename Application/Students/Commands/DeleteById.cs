using System;
using MediatR;
using Persistence;

namespace Application.Students.Commands;

public class DeleteById
{
    public class Command : IRequest<Unit>
    {
        public required string Id { get; set; }
    }

    public class Handler(AppDbContext context) : IRequestHandler<Command, Unit> 
    {
        public async Task<Unit> Handle(Command request, CancellationToken cancellationToken)
        {
            var student = await context.Students
                .FindAsync(request.Id, cancellationToken) 
                    ?? throw new Exception("Id not valid");

            context.Students.Remove(student);

            await context.SaveChangesAsync(cancellationToken);

            return Unit.Value;
        }
 
    }
}
