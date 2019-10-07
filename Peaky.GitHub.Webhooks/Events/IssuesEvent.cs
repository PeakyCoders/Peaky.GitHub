using Newtonsoft.Json;
using Peaky.GitHub.Webhooks.Abstractions;
using Peaky.GitHub.Webhooks.Entities;

namespace Peaky.GitHub.Webhooks.Events
{
    /// <summary>
    /// Triggered when an issue is opened, edited, deleted, transferred, pinned,
    /// unpinned, closed, reopened, assigned, unassigned, labeled, unlabeled,
    /// locked, unlocked, milestoned, or demilestoned.
    /// </summary>
    public class IssuesEvent : GitHubEvent
    {
        public const string EventName = "issues";

        public override string GetEventName() => EventName;

        /// <summary>
        /// The action that was performed. Can be one of opened, edited, deleted,
        /// transferred, pinned, unpinned, closed, reopened, assigned, unassigned,
        /// labeled, unlabeled, locked, unlocked, milestoned, or demilestoned.
        /// </summary>
        [JsonProperty("action")]
        public string Action;

        /// <summary>
        /// The issue itself.
        /// </summary>
        [JsonProperty("issue")]
        public Issue Issue;

        /// <summary>
        /// The changes to the issue if the action was edited.
        /// </summary>
        [JsonProperty("changes")]
        public Changes Changes;
        
        /// <summary>
        /// The optional label that was added or removed from the issue.
        /// </summary>
        [JsonProperty("label")]
        public Label Label;
    }
}
