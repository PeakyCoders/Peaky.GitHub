using System.Collections.Generic;
using GitHub.Webhooks.Abstractions;
using GitHub.Webhooks.Entities;
using Newtonsoft.Json;

namespace GitHub.Webhooks.Events
{
    /// <summary>
    /// Triggered when an issue is opened, edited, deleted, transferred, pinned,
    /// unpinned, closed, reopened, assigned, unassigned, labeled, unlabeled,
    /// locked, unlocked, milestoned, or demilestoned.
    /// </summary>
    public class IssuesEvent : GitHubEvent
    {
        [JsonIgnore]
        public override string EventType => "issues";

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
        public object Issue;

        /// <summary>
        /// The changes to the issue if the action was edited.
        /// </summary>
        [JsonProperty("changes")]
        public object Changes;
        
        /// <summary>
        /// The optional user who was assigned or unassigned from the issue.
        /// </summary>
        [JsonProperty("assignee")]
        public User Assignee;
        
        [JsonProperty("assignees")]
        public List<User> Assignees;
        
        /// <summary>
        /// The optional label that was added or removed from the issue.
        /// </summary>
        [JsonProperty("label")]
        public object Label;
    }
}
