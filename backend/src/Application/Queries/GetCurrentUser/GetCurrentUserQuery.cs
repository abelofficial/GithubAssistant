using Domain.Models;
using MediatR;

namespace Application.Queries;

public class GetCurrentUserQuery : IRequest<User>
{
    public string Username { get; set; }
}