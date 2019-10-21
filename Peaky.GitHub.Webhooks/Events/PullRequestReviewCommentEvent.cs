using Newtonsoft.Json;
using Peaky.GitHub.Webhooks.Abstractions;
using Peaky.GitHub.Webhooks.Entities;

namespace Peaky.GitHub.Webhooks.Events
{
    /// <summary>
    /// Triggered when a comment on a pull request's unified diff is created, edited, or deleted (in the Files Changed tab).
    /// </summary>
    public class PullRequestReviewCommentEvent : GitHubEvent
    {
        public const string EventName = "pull_request_review_comment";

        public override string GetEventName() => EventName;

        /// <summary>
        /// The action that was performed on the comment. Can be one of created, edited, or deleted.
        /// </summary>
        [JsonProperty("action")]
        public string Action;
        
        /// <summary>
        /// The changes to the comment if the action was edited.
        /// </summary>
        [JsonProperty("changes")]
        public Changes Changes;

        /// <summary>
        /// The pull request the comment belongs to.
        /// </summary>
        [JsonProperty("pull_request")]
        public PullRequest PullRequest;

        /// <summary>
        /// The comment itself.
        /// </summary>
        [JsonProperty("comment")]
        public PullRequestReviewComment Comment;
    }
}
