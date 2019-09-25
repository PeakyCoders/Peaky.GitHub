using GitHub.Webhooks.Entities;
using Newtonsoft.Json;

namespace GitHub.Webhooks.Abstractions
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
