using System.Text.Json.Serialization;
using Domain.Models;
using MediatR;

namespace Application.Queries;

public class GetCurrentUserQuery : IRequest<User>
{
    [JsonPropertyName("username")]
    public string Username { get; set; }
}