using Newtonsoft.Json;
using Peaky.GitHub.Webhooks.Abstractions;
using Peaky.GitHub.Webhooks.Entities;

namespace Peaky.GitHub.Webhooks.Events
{
    /// <summary>
    /// Triggered when a user forks a repository.
    /// </summary>
    public class ForkEvent : GitHubEvent
    {
        public const string EventName = "fork";

        public override string GetEventName() => EventName;

        /// <summary>
        /// The created repository.
        /// </summary>
        [JsonProperty("forkee")]
        public Repository Forkee;
    }
}
