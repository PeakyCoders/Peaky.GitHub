using Newtonsoft.Json;
using Peaky.GitHub.Webhooks.Abstractions;
using Peaky.GitHub.Webhooks.Entities;

namespace Peaky.GitHub.Webhooks.Events
{
    /// <summary>
    /// Triggered when a user accepts an invitation or is removed as a collaborator
    /// to a repository, or has their permissions changed.
    /// </summary>
    public class MemberEvent : GitHubEvent
    {
        public const string EventName = "member";

        public override string GetEventName() => EventName;

        /// <summary>
        /// The user that was added.
        /// </summary>
        [JsonProperty("member")]
        public User Member;

        /// <summary>
        /// The action that was performed. Can be one of added, deleted, or edited.
        /// </summary>
        [JsonProperty("action")]
        public string Action;

        /// <summary>
        /// The changes to the collaborator permissions if the action was edited.
        /// </summary>
        [JsonProperty("changes")]
        public Changes Changes;
    }
}
