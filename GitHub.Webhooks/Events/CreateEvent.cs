using GitHub.Webhooks.Abstractions;
using Newtonsoft.Json;

namespace GitHub.Webhooks.Events
{
    /// <summary>
    /// Represents a created branch or tag.
    /// </summary>
    public class CreateEvent : GitHubEvent
    {
        public const string EventName = "create";

        public override string GetEventName() => EventName;

        /// <summary>
        /// The object that was created. Can be either branch or tag.
        /// </summary>
        [JsonProperty("ref_type")]
        public string RefType;

        /// <summary>
        /// The git ref.
        /// </summary>
        [JsonProperty("ref")]
        public string Ref;

        /// <summary>
        /// The name of the repository's default branch (usually master).
        /// </summary>
        [JsonProperty("master_branch")]
        public string MasterBranch;

        /// <summary>
        /// The repository's current description.
        /// </summary>
        [JsonProperty("description")]
        public string Description;
    }
}
