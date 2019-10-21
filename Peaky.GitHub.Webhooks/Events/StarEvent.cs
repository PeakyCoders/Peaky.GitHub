using System;
using Newtonsoft.Json;
using Peaky.GitHub.Webhooks.Abstractions;
using Peaky.GitHub.Webhooks.Converters;

namespace Peaky.GitHub.Webhooks.Events
{
    /// <summary>
    /// Triggered when a star is added or removed from a repository.
    /// </summary>
    public class StarEvent : GitHubEvent
    {
        public const string EventName = "star";

        public override string GetEventName() => EventName;

        /// <summary>
        /// The action performed. Can be created or deleted.
        /// </summary>
        [JsonProperty("action")]
        public string Action;

        /// <summary>
        /// The time the star was created.
        /// Will be null for the deleted action.
        /// </summary>
        [JsonProperty("starred_at")]
        [JsonConverter(typeof(GitHubDateTimeConverter))]
        public DateTime? StarredAt;
    }
}
