using Newtonsoft.Json;
using Peaky.GitHub.Webhooks.Abstractions;
using Peaky.GitHub.Webhooks.Entities;

namespace Peaky.GitHub.Webhooks.Events
{
    /// <summary>
    /// Triggered when a commit comment is created.
    /// </summary>
    public class CommitCommentEvent : GitHubEvent
    {
        public const string EventName = "commit_comment";

        public override string GetEventName() => EventName;

        /// <summary>
        /// The comment itself.
        /// </summary>
        [JsonProperty("comment")]
        public CommitComment Comment;
    }
}
