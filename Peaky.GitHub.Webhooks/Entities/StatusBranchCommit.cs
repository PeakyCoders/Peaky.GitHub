using Newtonsoft.Json;

namespace Peaky.GitHub.Webhooks.Entities
{
    public class StatusBranchCommit
    {
        [JsonProperty("sha")]
        public string SHA;

        [JsonProperty("url")]
        public string Url;
    }
}
