using Newtonsoft.Json;
using Peaky.GitHub.Webhooks.Abstractions;
using Peaky.GitHub.Webhooks.Entities;

namespace Peaky.GitHub.Webhooks.Events
{
    /// <summary>
    /// Triggered when a release is published, unpublished, created, edited, deleted, or prereleased.
    /// </summary>
    public class ReleaseEvent : GitHubEvent
    {
        public const string EventName = "release";

        public override string GetEventName() => EventName;

        /// <summary>
        /// The action that was performed. Currently, can be published,
        /// unpublished, created, edited, deleted, or prereleased.
        /// </summary>
        [JsonProperty("action")]
        public string Action;

        [JsonProperty("changes")]
        public ReleaseChanges Changes;

        /// <summary>
        /// The release object.
        /// </summary>
        [JsonProperty("release")]
        public Release Release;
    }
}
