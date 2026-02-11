using MediatR;
using Persistence;
using Domain;

using Microsoft.EntityFrameworkCore;

namespace Application.Teachers.Query;

public class GetAllStudent
{
    public class Query : IRequest<List<Teacher>>{}

    public class Handler(AppDbContext context) : IRequestHandler<Query, List<Teacher>>
    {
        public async Task<List<Teacher>> Handle(Query request, CancellationToken cancellationToken)
        {
            var students = await context.Teachers.ToListAsync(cancellationToken);
            return students;
        }
    }

}
