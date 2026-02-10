using System;
using MediatR;
using Persistence;
using Domain

namespace Application.Teachers.Query;

public class GetAllStudent
{
    public class Query : IRequest<Teacher>{}

    public class Handler(AppDbContext context) : IRequestHandler<Query, Teacher>
    {
        public Task<Teacher> Handle(Query request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }

}
