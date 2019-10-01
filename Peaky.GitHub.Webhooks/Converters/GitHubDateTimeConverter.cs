using System;
using Newtonsoft.Json;

namespace Peaky.GitHub.Webhooks.Converters
{
    /// <summary>
    /// Since GitHub API is unreliable on which format uses to send DateTimes (Integer or String)
    /// we need a custom converter to handle the format in runtime.
    /// </summary>
    internal class GitHubDateTimeConverter : JsonConverter<DateTime?>
    {
        public override void WriteJson(JsonWriter writer, DateTime? value, JsonSerializer serializer)
        {
            writer.WriteValue(value);
        }

        public override DateTime? ReadJson(JsonReader reader, Type objectType, DateTime? existingValue, bool hasExistingValue, JsonSerializer serializer)
        {
            switch (reader.TokenType)
            {
                case JsonToken.Date:
                    return (DateTime) reader.Value;

                case JsonToken.Integer:
                    return DateTimeOffset.FromUnixTimeSeconds((long) reader.Value).UtcDateTime;

                case JsonToken.String:
                    return DateTime.Parse((string) reader.Value);

                case JsonToken.Null:
                default:
                    return null;
            }
        }
    }
}
