using Newtonsoft.Json;

namespace Peaky.GitHub.Webhooks.Entities
{
    public class ChangeFrom
    {
        [JsonProperty("from")]
        public string From;
    }
}
