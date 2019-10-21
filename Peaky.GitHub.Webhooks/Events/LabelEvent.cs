using Newtonsoft.Json;
using Peaky.GitHub.Webhooks.Abstractions;
using Peaky.GitHub.Webhooks.Entities;

namespace Peaky.GitHub.Webhooks.Events
{
    /// <summary>
    /// Triggered when a repository's label is created, edited, or deleted.
    /// </summary>
    public class LabelEvent : GitHubEvent
    {
        public const string EventName = "label";

        public override string GetEventName() => EventName;

        /// <summary>
        /// The action that was performed. Can be created, edited, or deleted.
        /// </summary>
        [JsonProperty("action")]
        public string Action;

        /// <summary>
        /// The label that was added.
        /// </summary>
        [JsonProperty("label")]
        public Label Label;

        /// <summary>
        /// The changes to the label if the action was edited.
        /// </summary>
        [JsonProperty("changes")]
        public Changes Changes;
    }
}
