using GitHub.Webhooks.Abstractions;
using Newtonsoft.Json;

namespace GitHub.Webhooks.Events
{
    /// <summary>
    /// Represents a deleted branch or tag.
    /// </summary>
    public class DeleteEvent : GitHubEvent
    {
        public const string EventName = "delete";

        public override string GetEventName() => EventName;

        /// <summary>
        /// The object that was deleted. Can be branch or tag.
        /// </summary>
        [JsonProperty("ref_type")]
        public string RefType;
        
        /// <summary>
        /// The git ref.
        /// </summary>
        [JsonProperty("ref")]
        public string Ref;
    }
}
