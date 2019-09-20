using GitHub.Webhooks.Abstractions;
using Newtonsoft.Json;

namespace GitHub.Webhooks.Events
{
    /// <summary>
    /// Represents a deleted branch or tag.
    /// </summary>
    public class DeleteEvent : GitHubEvent
    {
        [JsonIgnore]
        public override string EventType => "delete";

        /// <summary>
        /// The object that was deleted. Can be branch or tag.
        /// </summary>
        [JsonProperty("ref_type")]
        public string RefType;
        
        /// <summary>
        /// The git ref.
        /// </summary>
        [JsonProperty("ref")]
        public string Ref ;
    }
}
