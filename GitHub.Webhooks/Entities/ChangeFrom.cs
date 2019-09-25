using Newtonsoft.Json;

namespace GitHub.Webhooks.Entities
{
    public class ChangeFrom
    {
        [JsonProperty("from")]
        public string From;
    }
}
