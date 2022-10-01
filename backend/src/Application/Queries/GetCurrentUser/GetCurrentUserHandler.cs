using Domain.Models;
using MediatR;

namespace Application.Queries;

public class GetCurrentUserHandler : IRequestHandler<GetCurrentUserQuery, User>
{
    public async Task<User> Handle(GetCurrentUserQuery request, CancellationToken cancellationToken)
    {
        return await Task.FromResult(new User
        {
            Username = request.Username,
            Email = $"@test-email.com"
        });
    }
}