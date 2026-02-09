using System;
using Domain;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace Application.Students.Queries;

public class GetStudentsList
{
    public class Query : IRequest<List<Student>> {}

    public class Handler(AppDbContext context) : IRequestHandler<Query, List<Student>>
    {
        public async Task<List<Student>> Handle(Query request, CancellationToken cancellationToken)
        {
            return await context.Students.ToListAsync(cancellationToken);
        }
    }
}
