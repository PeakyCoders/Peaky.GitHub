using Newtonsoft.Json;
using Peaky.GitHub.Webhooks.Abstractions;
using Peaky.GitHub.Webhooks.Entities;

namespace Peaky.GitHub.Webhooks.Events
{
    /// <summary>
    /// Triggered when an issue comment is created, edited, or deleted.
    /// </summary>
    public class IssueCommentEvent : GitHubEvent
    {
        public const string EventName = "issue_comment";

        public override string GetEventName() => EventName;

        /// <summary>
        /// The action that was performed on the comment. Can be one of created, edited, or deleted.
        /// </summary>
        [JsonProperty("action")]
        public string Action;

        /// <summary>
        /// The issue the comment belongs to.
        /// </summary>
        [JsonProperty("issue")]
        public Issue Issue;

        /// <summary>
        /// The comment itself.
        /// </summary>
        [JsonProperty("comment")]
        public Comment Comment;
    }
}
