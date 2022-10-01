using System.Text.Json.Serialization;

namespace Application.Contracts.Requests;

public class GetCurrentUserDto
{
    [JsonPropertyName("username")]
    public string Username { get; set; }
}