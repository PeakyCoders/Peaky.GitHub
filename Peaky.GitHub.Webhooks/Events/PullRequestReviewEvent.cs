using Newtonsoft.Json;
using Peaky.GitHub.Webhooks.Abstractions;
using Peaky.GitHub.Webhooks.Entities;

namespace Peaky.GitHub.Webhooks.Events
{
    /// <summary>
    /// Triggered when a pull request review is submitted into a non-pending state,
    /// the body is edited, or the review is dismissed.
    /// </summary>
    public class PullRequestReviewEvent : GitHubEvent
    {
        public const string EventName = "pull_request_review";

        public override string GetEventName() => EventName;

        /// <summary>
        /// The action that was performed. Can be submitted, edited, or dismissed.
        /// </summary>
        [JsonProperty("action")]
        public string Action;

        /// <summary>
        /// The pull request the review pertains to.
        /// </summary>
        [JsonProperty("pull_request")]
        public PullRequest PullRequest;

        /// <summary>
        /// The review that was affected.
        /// </summary>
        [JsonProperty("review")]
        public PullRequestReview Review;

        /// <summary>
        /// The previous version of the body if the action was edited.
        /// </summary>
        [JsonProperty("changes")]
        public Changes Changes;
    }
}
