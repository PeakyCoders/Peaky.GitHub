using Newtonsoft.Json;

namespace GitHub.Webhooks.Abstractions
{
    public abstract class GitHubEvent
    {
        [JsonIgnore]
        public abstract string EventType { get; }

        [JsonProperty("sender")]
        public object Sender;

        [JsonProperty("organization")]
        public object Organization;

        [JsonProperty("repository")]
        public object Repository;

        //public object Installation;
    }
}
