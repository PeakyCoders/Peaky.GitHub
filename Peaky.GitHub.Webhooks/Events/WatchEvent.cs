using Newtonsoft.Json;
using Peaky.GitHub.Webhooks.Abstractions;

namespace Peaky.GitHub.Webhooks.Events
{
    /// <summary>
    /// Triggered when someone stars a repository. This event is not related to watching a repository.
    /// See https://developer.github.com/changes/2012-09-05-watcher-api/ blog post for an explanation.
    /// The event’s actor is the user who starred a repository, and the event’s repository is the
    /// repository that was starred.
    /// </summary>
    public class WatchEvent : GitHubEvent
    {
        public const string EventName = "watch";

        public override string GetEventName() => EventName;

        /// <summary>
        /// The action that was performed. Currently, can only be started.
        /// </summary>
        [JsonProperty("action")]
        public string Action;
    }
}
