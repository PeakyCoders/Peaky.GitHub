using Newtonsoft.Json;
using Peaky.GitHub.Webhooks.Abstractions;
using Peaky.GitHub.Webhooks.Entities;

namespace Peaky.GitHub.Webhooks.Events
{
    /// <summary>
    /// Triggered when a milestone is created, closed, opened, edited, or deleted.
    /// </summary>
    public class MilestoneEvent : GitHubEvent
    {
        public const string EventName = "milestone";

        public override string GetEventName() => EventName;

        /// <summary>
        /// The action that was performed. Can be one of created, closed, opened, edited, or deleted.
        /// </summary>
        [JsonProperty("action")]
        public string Action;

        /// <summary>
        /// The milestone itself.
        /// </summary>
        [JsonProperty("milestone")]
        public Milestone Milestone;

        /// <summary>
        /// The changes to the milestone if the action was edited.
        /// </summary>
        [JsonProperty("changes")]
        public MilestoneChanges Changes;
    }
}
