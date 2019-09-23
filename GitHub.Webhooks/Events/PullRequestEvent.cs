using GitHub.Webhooks.Abstractions;
using GitHub.Webhooks.Entities;
using Newtonsoft.Json;

namespace GitHub.Webhooks.Events
{
    /// <summary>
    /// Triggered when a pull request is assigned, unassigned, labeled, unlabeled, opened,
    /// edited, closed, reopened, synchronize, ready_for_review, locked, unlocked or when
    /// a pull request review is requested or removed.
    /// </summary>
    public class PullRequestEvent : GitHubEvent
    {
        [JsonIgnore]
        public override string EventType => "pull_request";

        /// <summary>
        /// The action that was performed. Can be one of assigned, unassigned, review_requested,
        /// review_request_removed, labeled, unlabeled, opened, edited, closed, ready_for_review,
        /// locked, unlocked, or reopened. If the action is closed and the merged key is false,
        /// the pull request was closed with unmerged commits. If the action is closed and the
        /// merged key is true, the pull request was merged. While webhooks are also triggered
        /// when a pull request is synchronized, Events API timelines don't include pull request
        /// events with the synchronize action.
        /// </summary>
        [JsonProperty("action")]
        public string Action;

        /// <summary>
        /// The pull request number.
        /// </summary>
        [JsonProperty("number")]
        public int Number;

        /// <summary>
        /// The changes to the comment if the action was edited.
        /// </summary>
        [JsonProperty("changes")]
        public Changes Changes;

        /// <summary>
        /// The pull request itself.
        /// </summary>
        [JsonProperty("pull_request")]
        public object PullRequest;
    }
}
