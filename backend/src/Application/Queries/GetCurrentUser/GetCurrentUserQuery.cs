using System.Text.Json.Serialization;

namespace Application.Queries
{

    public class GetCurrentUserQuery
    {
        [JsonPropertyName("name")]
        public string? Username { get; set; }
    }
}