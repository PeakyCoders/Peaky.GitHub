using Newtonsoft.Json;
using Peaky.GitHub.Webhooks.Entities;

namespace Peaky.GitHub.Webhooks.Abstractions
{
    public abstract class GitHubEvent
    {
        public abstract string GetEventName();

        [JsonProperty("sender")]
        public User Sender;

        [JsonProperty("organization")]
        public Organization Organization;

        [JsonProperty("repository")]
        public Repository Repository;
    }
}
