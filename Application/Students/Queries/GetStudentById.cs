using System;
using Domain;
using MediatR;
using Persistence;

namespace Application.Students.Queries;

public class GetStudentById
{
    public class Query : IRequest<Student>
    {
        public required string Id { get; set; }
    
    }

    public class Handler(AppDbContext context) : IRequestHandler<Query, Student>
    {
        public async Task<Student> Handle(Query request, CancellationToken cancellationToken)
        {
            var student = await context.Students.FindAsync(request.Id);
            return student!;
        }
    }
}


