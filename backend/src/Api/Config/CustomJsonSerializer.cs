using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Serialization;

namespace Api.Config;
public class CustomJsonSerializer : Amazon.Lambda.Serialization.Json.JsonSerializer
{
    [Obsolete]
    public CustomJsonSerializer()
        : base(
            // Step 1: Customize the serializer settings
            CustomizeSerializerSettings,
            // Step 2: Use Pascal Case
            new CamelCaseNamingStrategy()
            )
    {

    }

    [Obsolete]
    private static void CustomizeSerializerSettings(JsonSerializerSettings settings)
    {
        settings.Converters = new List<JsonConverter>
        {
            new StringEnumConverter()
            {
                CamelCaseText = false
            },
        };
        settings.DateTimeZoneHandling = DateTimeZoneHandling.Utc;
    }
}