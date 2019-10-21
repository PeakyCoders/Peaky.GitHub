using System.Collections.Generic;
using Newtonsoft.Json;
using Peaky.GitHub.Webhooks.Abstractions;
using Peaky.GitHub.Webhooks.Entities;

namespace Peaky.GitHub.Webhooks.Events
{
    /// <summary>
    /// Triggered when the status of a Git commit changes.
    /// </summary>
    public class StatusEvent : GitHubEvent
    {
        public const string EventName = "status";

        public override string GetEventName() => EventName;

        /// <summary>
        /// The Commit SHA.
        /// </summary>
        [JsonProperty("sha")]
        public string SHA;

        /// <summary>
        /// The new state. Can be pending, success, failure, or error.
        /// </summary>
        [JsonProperty("state")]
        public string State;

        /// <summary>
        /// The optional human-readable description added to the status.
        /// </summary>
        [JsonProperty("description")]
        public string Description;

        /// <summary>
        /// The optional link added to the status.
        /// </summary>
        [JsonProperty("target_url")]
        public string TargetUrl;

        /// <summary>
        /// An array of branch objects containing the status' SHA.
        /// Each branch contains the given SHA, but the SHA may or may not be the head of the branch.
        /// The array includes a maximum of 10 branches.
        /// </summary>
        [JsonProperty("branches")]
        public List<StatusBranch> Branches;
    }
}
